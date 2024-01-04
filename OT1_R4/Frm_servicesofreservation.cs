using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OT1_R4
{
    public partial class Frm_servicesofreservation : Form
    {

        BindingSource servicesofreservationBindingSource = new BindingSource();


        private int selectedReservationID = -1;
        private int selectedServiceID = -1;

        public Frm_servicesofreservation()
        {
            InitializeComponent();
            LoadAreas();
            LoadServicesOfReservation();
        }


        private void LoadAreas()
        {
            string connectionString = "server=127.0.0.1;port=3307;database=vn;uid=root;pwd=Ruutti;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            //Populate the Area ComboBox
            string query = "SELECT nimi FROM alue";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cb_area.Items.Add(reader.GetString(0));
            }
            reader.Close();

            cb_area.SelectedIndexChanged += new EventHandler(cb_area_SelectedIndexChanged);
            connection.Close();
        }

   

        private void cb_area_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connectionString = "server=127.0.0.1;port=3307;database=vn;uid=root;pwd=Ruutti;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            //Retrieve selected Area name
            string selectedArea = cb_area.SelectedItem.ToString();

            //Populate the Reservations ComboBox with the reservations available in the selected Area
            string reservationQuery = "SELECT varaus.varaus_id FROM varaus " +
                                      "INNER JOIN mokki ON varaus.mokki_mokki_id = mokki.mokki_id " +
                                      "INNER JOIN alue ON mokki.alue_id = alue.alue_id " +
                                      "WHERE alue.nimi = @selectedArea";

            MySqlCommand reservationCmd = new MySqlCommand(reservationQuery, connection);
            reservationCmd.Parameters.AddWithValue("@selectedArea", selectedArea);

            DataTable reservationTable = new DataTable();
            MySqlDataAdapter reservationAdapter = new MySqlDataAdapter(reservationCmd);
            reservationAdapter.Fill(reservationTable);

            cb_reservations.DisplayMember = "varaus_id";
            cb_reservations.ValueMember = "varaus_id";
            cb_reservations.DataSource = reservationTable;

            //Populate the Service ComboBox with the services available in the selected Area
            string serviceQuery = "SELECT palvelu.palvelu_id, palvelu.nimi FROM palvelu " +
                                  "INNER JOIN alue ON palvelu.alue_id = alue.alue_id " +
                                  "WHERE alue.nimi = @selectedArea";

            MySqlCommand serviceCmd = new MySqlCommand(serviceQuery, connection);
            serviceCmd.Parameters.AddWithValue("@selectedArea", selectedArea);

            DataTable serviceTable = new DataTable();
            MySqlDataAdapter serviceAdapter = new MySqlDataAdapter(serviceCmd);
            serviceAdapter.Fill(serviceTable);

            cb_services.DisplayMember = "nimi";
            cb_services.ValueMember = "palvelu_id";
            cb_services.DataSource = serviceTable;

            connection.Close();
        }


        private void dvg_servicesofreservation_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            string connectionString = "server=127.0.0.1;port=3307;database=vn;uid=root;pwd=Ruutti;";


            // get the row number clicked
            int rowClicked = dgv.CurrentRow.Index;

            // Taking the ID of the selected service of reservation, has to be higher than 0
            if ((int)dgv.Rows[rowClicked].Cells[0].Value > 0)
            {
                selectedReservationID = (int)dgv.Rows[rowClicked].Cells[0].Value;
                selectedServiceID = (int)dgv.Rows[rowClicked].Cells[1].Value;

                // get the area for the selected reservation
                string areaQuery = "SELECT alue.nimi FROM mokki " +
                                   "INNER JOIN alue ON mokki.alue_id = alue.alue_id " +
                                   "INNER JOIN varaus ON mokki.mokki_id = varaus.mokki_mokki_id " +
                                   "WHERE varaus.varaus_id = @selectedReservationID";

                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();

                MySqlCommand areaCmd = new MySqlCommand(areaQuery, connection);
                areaCmd.Parameters.AddWithValue("@selectedReservationID", selectedReservationID);

                string areaName = areaCmd.ExecuteScalar().ToString();

                // update the area combo box selection
                cb_area.SelectedItem = areaName;


                // Filling the input fields with selected data
                tb_amount.Text = dgv.Rows[rowClicked].Cells[2].Value.ToString();

                lbl_reservation_id_result.Text = dgv.Rows[rowClicked].Cells[0].Value.ToString();
                lbl_service_id_result.Text = dgv.Rows[rowClicked].Cells[1].Value.ToString();
                cb_reservations.SelectedIndex = -1;
                cb_services.SelectedIndex = -1;


                connection.Close();
            }

        }





        private void btn_search_Click(object sender, EventArgs e)
        {
            
                ServicesOfReservationDAO servicesofreservationDAO = new ServicesOfReservationDAO();
                // connect the list to the dgv
                servicesofreservationBindingSource.DataSource = servicesofreservationDAO.GetAllServiceOfReservation();
                dgv_servicesofreservation.DataSource = servicesofreservationBindingSource;
            
        }




        private void LoadServicesOfReservation()
        {
            ServicesOfReservationDAO servicesofreservationDAO = new ServicesOfReservationDAO();
            // connect the list to the dgv
            servicesofreservationBindingSource.DataSource = servicesofreservationDAO.GetAllServiceOfReservation();
            dgv_servicesofreservation.DataSource = servicesofreservationBindingSource;
        }

        private void btn_appexit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Haluatko varmasti sulkea ohjelman?", "Sulje ohjelma", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_clear_inputs_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private void ClearInputs()
        {

            tb_amount.Text = string.Empty;
            cb_area.SelectedIndex = 0;
            cb_reservations.SelectedIndex = -1;
            cb_services.SelectedIndex = -1;
            lbl_reservation_id_result.Text = string.Empty;
            lbl_service_id_result.Text = string.Empty;


        }


        private void tb_amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Limiting the amount of characters to 2
            if (tb_amount.Text.Length >= 2 && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
            //Only allowing numbers
            if (!Char.IsNumber(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }


        private void btn_new_Click(object sender, EventArgs e)
        {
            if (cb_reservations.SelectedIndex != -1 || cb_services.SelectedIndex != -1 || tb_amount.Text != string.Empty)
            {
                // add new service of reservation to database
                ServicesOfReservation servicesofreservation = new ServicesOfReservation
                {
                    Varaus_ID = Convert.ToInt32(cb_reservations.SelectedValue),
                    Palvelu_ID = Convert.ToInt32(cb_services.SelectedValue),
                    Lkm = Int32.Parse(tb_amount.Text),

                };

                ServicesOfReservationDAO servicesofreservationDAO = new ServicesOfReservationDAO();
                int result = servicesofreservationDAO.AddNewServiceOfReservation(servicesofreservation);
                MessageBox.Show(result + " new row(s) inserted");
                if (result >= 1)
                {

                    ClearInputs();
                    LoadServicesOfReservation();
                    MessageBox.Show("Lisäys onnistui!", "Onnistui!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Lisäys epäonnistui! Tarkasta onko tiedot syötetty oikein", "Virhe!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            else
            {
                MessageBox.Show("Lisäys epäonnistui! Tarkasta onko tiedot syötetty oikein", "Virhe!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }





        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (selectedReservationID == -1)
            {
                MessageBox.Show("Valitse varaus listasta, jonka haluat poistaa!", "Varausta ei ole valittu!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (MessageBox.Show("Haluatko varmasti poistaa palvelun varaukselta:" + cb_reservations.Text + "?", "Varoitus!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    ServicesOfReservationDAO servicesofreservationDAO = new ServicesOfReservationDAO();

                    try
                    {
                        servicesofreservationDAO.DeleteServiceOfReservation(selectedReservationID, selectedServiceID);
                        ClearInputs();
                        LoadServicesOfReservation();
                        MessageBox.Show("Poisto onnistui.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Poisto epäonnistui! Virhe: " + ex.Message, "Virhe!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }



        private ServicesOfReservation CreateServicesOfReservation()
        {

           
            ServicesOfReservation servicesofreservation = new ServicesOfReservation
            {


                Varaus_ID = Int32.Parse(lbl_reservation_id_result.Text),
                Palvelu_ID = Int32.Parse(lbl_service_id_result.Text),
                Lkm = Int32.Parse(tb_amount.Text),

            };
            return servicesofreservation;
        }


        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (selectedReservationID == -1)
            {
                MessageBox.Show("Valitse varaus listasta, jota haluat muokata!", "Varausta ei ole valittu!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {

                ServicesOfReservation servicesofreservation = CreateServicesOfReservation();

                if (servicesofreservation != null)
                {
                    servicesofreservation.Varaus_ID = selectedReservationID;

                    ServicesOfReservationDAO servicesofreservationDAO = new ServicesOfReservationDAO();

                    //Adding the new service of reservation
                    int newRows = servicesofreservationDAO.EditServiceOfReservation(servicesofreservation);

                    if (newRows >= 1)
                    {

                        ClearInputs();
                        LoadServicesOfReservation();
                        MessageBox.Show("Muokkaus onnistui!", "Onnistui!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Muokkaus epäonnistui!", "Virhe!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
