using Google.Protobuf.WellKnownTypes;
using iTextSharp.text;
using iTextSharp.text.pdf;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Font = System.Drawing.Font;

namespace OT1_R4
{
    public partial class Frm_reports : Form
    {
        String conString = "datasource=localhost; port=3307; username=root;password=Ruutti; database=vn;";

        AreasDAO areasDAO = new AreasDAO();
        public Frm_reports()
        {
            InitializeComponent();
            Load_areasToReservations();
            LoadAreasToServises();  
        }

        // get all areas to comboboxes 
        public void Load_areasToReservations()
        {
            //Loads all the areas into the combobox from the database

            AreasDAO areaDAO = new AreasDAO();

            List<Area> areas = areasDAO.GetAllAreas();

            // link datasource to areas_reservations combobox
            cmb_areas_reservations.DataSource = areas;
            cmb_areas_reservations.DisplayMember = "Name";
            cmb_areas_reservations.ValueMember = "ID";

        }

        public void LoadAreasToServises()
        {
            AreasDAO areaDAO = new AreasDAO();

            List<Area> areas = areasDAO.GetAllAreas();
            // link datasource to areas_servces combobox
            cmb_areas_services.DataSource = areas;
            cmb_areas_services.DisplayMember = "Name";
            cmb_areas_services.ValueMember = "ID";
        }

        private void btn_search_reservations_Click(object sender, EventArgs e)
        {
            // check if starttime is bigger than endtime
            if (dtp_reservations_startTime.Value < dtp_reservations_endTime.Value)
            {
                MySqlConnection connection = new MySqlConnection(conString);
                MySqlCommand command = new MySqlCommand("SELECT alue_id, varaus_id as 'Varaus ID', asiakas_id as 'Asiakas ID', " +
                "mokki_id as 'Mokki ID', mokkinimi as 'Mokin nimi', katuosoite as 'Katuosoite', hinta as 'Hinta', kuvaus as 'Kuvaus', " +
                "henkilomaara as 'Henkilomaara', varustelu as 'Varustelu', varattu_pvm as 'Varattu',varattu_alkupvm as 'Aloitus pvm', varattu_loppupvm as 'Varattu loppupvm', vahvistus_pvm as 'Vahvistus pvm' " +
                "FROM vn.varaus v JOIN vn.mokki m ON v.mokki_mokki_id = m.mokki_id " +
                "WHERE ((v.varattu_alkupvm >= @starttime AND v.varattu_alkupvm <= @endtime) " +
                "OR (v.varattu_alkupvm < @starttime AND v.varattu_loppupvm > @endtime)) " +
                "AND m.alue_id = @area", connection);

                command.Parameters.AddWithValue("@area", cmb_areas_reservations.SelectedValue.ToString());
                command.Parameters.AddWithValue("@starttime", dtp_reservations_startTime.Value);
                command.Parameters.AddWithValue("@endtime", dtp_reservations_endTime.Value);

                try
                {
                    connection.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dgv_reservations.DataSource = table;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Tietokantavirhe" + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                finally
                {
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Loppupäivämäärän on oltava alkuäivämäärää suurempi!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
                        

        }



        private void btn_print_reservations_Click(object sender, EventArgs e)
        {

            // Tarkista, että taulukossa on dataa
            if (dgv_reservations.Rows.Count == 0)
            {
                MessageBox.Show("Taulukossa ei ole dataa.", "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Luo PDF-tiedosto
            MemoryStream stream = new MemoryStream();
            Document pdfDoc = new Document(PageSize.A4.Rotate()); // Muutetaan sivun koko vaakasuunnaksi
            PdfWriter pdfWriter = PdfWriter.GetInstance(pdfDoc, stream);
            pdfDoc.Open();



            // Lisää taulukko PDF-tiedostoon
            try
            {
                // Raportin otsikko
                string dateRange = $"{dtp_reservations_startTime.Value.ToString("dd.MM.yyyy")} - {dtp_reservations_endTime.Value.ToString("dd.MM.yyyy")}";
                Paragraph title = new Paragraph($"Raportti varauksista ajalla: {dateRange}");
                title.Alignment = Element.ALIGN_CENTER;

                pdfDoc.Add(title);
                pdfDoc.Add(new Chunk("\n")); // Tyhjä rivi raportin otsikon ja taulukon välissä

                PdfPTable pdfTable = new PdfPTable(dgv_reservations.Columns.Count);
                pdfTable.WidthPercentage = 100;
                foreach (DataGridViewColumn column in dgv_reservations.Columns)
                {
                    
                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                    pdfTable.AddCell(cell);
                }
                foreach (DataGridViewRow row in dgv_reservations.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value != null)
                        {
                            if (cell.Value is DateTime date)
                            {
                                pdfTable.AddCell(date.ToShortDateString());
                            }
                            else
                            {
                                pdfTable.AddCell(cell.Value.ToString());
                            }
                        }
                        else
                        {
                            pdfTable.AddCell("");
                        }
                    }
                }
                pdfDoc.Add(pdfTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tapahtui virhe taulukon luomisessa: " + ex.Message, "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pdfDoc.Close();
                stream.Close();
                return;
            }

            // Sulje PDF-tiedosto
            pdfDoc.Close();

            // Avaa PDF-tiedosto oletusohjelmassa
            byte[] bytes = stream.ToArray();
            stream.Close();
            var fileStream = new FileStream(Path.GetTempFileName() + ".pdf", FileMode.Create, FileAccess.Write);
            fileStream.Write(bytes, 0, bytes.Length);
            fileStream.Close();
            Process.Start(fileStream.Name);
        }


        private void btn_search_services_Click(object sender, EventArgs e)
        {

            MySqlConnection connection = new MySqlConnection(conString);

           MySqlCommand command = new MySqlCommand("SELECT nimi as 'Nimi',kuvaus as 'Kuvaus', lkm, asiakas_id as 'Asiakas ID', alue_id as 'Alue ID', hinta as 'Hinta', varattu_alkupvm as 'Palvelun alkupvm', varattu_loppupvm FROM palvelu JOIN varauksen_palvelut " +
                "ON palvelu.palvelu_ID = varauksen_palvelut.palvelu_ID JOIN varaus " +
                "ON varauksen_palvelut.varaus_ID = varaus.varaus_ID " +
                "WHERE ((varaus.varattu_alkupvm >= @starttime AND varaus.varattu_alkupvm <= @endtime)" +
                "or varaus.varattu_loppupvm >= @endtime and varaus.varattu_alkupvm < @starttime) AND varauksen_palvelut.varaus_ID = varaus.varaus_id AND alue_id IN (SELECT alue_id FROM palvelu WHERE alue_id = @area)", connection);
            command.Parameters.AddWithValue("@area", cmb_areas_services.SelectedValue.ToString());
            //command.Parameters.AddWithValue("@area", Convert.ToInt32(cmb_areas_services.SelectedValue));
            command.Parameters.AddWithValue("@starttime", dtp_services_startTime.Value);
            command.Parameters.AddWithValue("@endtime", dtp_services_endTime.Value);

            if (dtp_services_startTime.Value < dtp_services_endTime.Value)
            {
                try
                {

                    connection.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable table2 = new DataTable();
                    adapter.Fill(table2);
                    dgv_services.DataSource = table2;
                }

               
            
                catch (Exception ex)
                {
                    MessageBox.Show("Tietokantavirhe" + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                finally
                {
                    connection.Close();
                }
            }
                else
                {
                    MessageBox.Show("Loppupäivämäärän on oltava alkuäivämäärää suurempi!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

        }

        private void btn_print_services_Click(object sender, EventArgs e)
        {
            // Tarkista, että taulukossa on dataa
            if (dgv_services.Rows.Count == 0)
            {
                MessageBox.Show("Taulukossa ei ole dataa.", "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Luo PDF-tiedosto
            MemoryStream stream = new MemoryStream();
            Document pdfDoc = new Document(PageSize.A4);
            PdfWriter pdfWriter = PdfWriter.GetInstance(pdfDoc, stream);
            pdfDoc.Open();

            // Lisää taulukko PDF-tiedostoon
            try
            {
                // Raportin otsikko
                string dateRange = $"{dtp_services_startTime.Value.ToString("dd.MM.yyyy")} - {dtp_services_endTime.Value.ToString("dd.MM.yyyy")}";
                Paragraph title = new Paragraph($"Raportti palveluista ajalla: {dateRange}");
                title.Alignment = Element.ALIGN_CENTER;

                pdfDoc.Add(title);
                pdfDoc.Add(new Chunk("\n")); // Tyhjä rivi raportin otsikon ja taulukon välissä

                PdfPTable pdfTable = new PdfPTable(dgv_services.Columns.Count);
                pdfTable.WidthPercentage = 100;
                foreach (DataGridViewColumn column in dgv_services.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                    pdfTable.AddCell(cell);
                }
                foreach (DataGridViewRow row in dgv_services.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value != null)
                        {
                            if (cell.Value is DateTime date)
                            {
                                pdfTable.AddCell(date.ToShortDateString());
                            }
                            else
                            {
                                pdfTable.AddCell(cell.Value.ToString());
                            }
                        }
                        else
                        {
                            pdfTable.AddCell("");
                        }
                    }
                }
                pdfDoc.Add(pdfTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tapahtui virhe taulukon luomisessa: " + ex.Message, "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pdfDoc.Close();
                stream.Close();
                return;
            }

            // Sulje PDF-tiedosto
            pdfDoc.Close();

            // Avaa PDF-tiedosto oletusohjelmassa
            byte[] bytes = stream.ToArray();
            stream.Close();
            var fileStream = new FileStream(Path.GetTempFileName() + ".pdf", FileMode.Create, FileAccess.Write);
            fileStream.Write(bytes, 0, bytes.Length);
            fileStream.Close();
            Process.Start(fileStream.Name);

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Haluatko varmasti sulkea ohjelman?", "Sulje ohjelma", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
    
}
