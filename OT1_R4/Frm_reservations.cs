using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OT1_R4
{
    public partial class Frm_reservations : Form
    {

        BindingSource reservationBindingSource = new BindingSource();

        List<Area> areaList = new List<Area>();
        List<Cottage> cottageList = new List<Cottage>();
        List<Customer> customerList = new List<Customer>();
        List<Reservation> reservationList = new List<Reservation>();


        

        int selectedReservationID = -1;


        public Frm_reservations()
        {
            InitializeComponent();
            LoadAreas();
            LoadCustomers();
            
        }



        private void Frm_reservations_Load(object sender, EventArgs e)
        {
            //loadReservations();
            ClearInputs();

        }

    



        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loadReservations()
        {
            ReservationsDAO reservationsDAO = new ReservationsDAO();
            // connect the list to the dgv
            reservationBindingSource.DataSource = reservationsDAO.getReservations();
            dgv_reservations.DataSource = reservationBindingSource;
        }



        private void btn_appexit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Haluatko varmasti sulkea ohjelman?", "Sulje ohjelma", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }




        private void btn_searchrsv_Click(object sender, EventArgs e)
        {
            ReservationsDAO reservationsDAO = new ReservationsDAO();
            // connect the list to the dgv
            reservationBindingSource.DataSource = reservationsDAO.getReservations();
            dgv_reservations.DataSource = reservationBindingSource;

        }



        private void btn_search_email_Click(object sender, EventArgs e)
        {
            ReservationsDAO reservationsDAO = new ReservationsDAO();
            // connect the list to dgv
            reservationBindingSource.DataSource = reservationsDAO.searchReservations(tb_search.Text);
            dgv_reservations.DataSource = reservationBindingSource;
        }



        private void btn_customers_Click(object sender, EventArgs e)
        {
            Frm_customers form5Instance = Application.OpenForms.OfType<Frm_customers>().FirstOrDefault();
            if (form5Instance == null)
            {
                form5Instance = new Frm_customers();
                form5Instance.Show();
            }
            else
            {
                form5Instance.BringToFront();
            }
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







        // monthcalendar that shows reserved dates of certain cottage at bolded letters
        private List<DateTime> GetReservedDates(int cottageId)
        {
            List<DateTime> reservedDates = new List<DateTime>();

            string connectionString = "server=127.0.0.1;port=3307;database=vn;uid=root;pwd=Ruutti;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            string query = "SELECT varattu_alkupvm, varattu_loppupvm FROM varaus WHERE mokki_mokki_id = @cottageId";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@cottageId", cottageId);

            DataTable dataTable = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            adapter.Fill(dataTable);

            foreach (DataRow row in dataTable.Rows)
            {
                DateTime startDate = (DateTime)row["varattu_alkupvm"];
                DateTime endDate = (DateTime)row["varattu_loppupvm"];

                // Add all dates between start and end dates to the list of reserved dates
                for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
                {
                    reservedDates.Add(date);
                }
            }

            connection.Close();

            return reservedDates;
        }

        private void cb_cottagesSelectedIndexChanged(object sender, EventArgs e)
        {

            int cottageId = Convert.ToInt32(cb_cottages.SelectedValue);
            List<DateTime> reservedDates = GetReservedDates(cottageId);
            monthCalendar1.RemoveAllBoldedDates();
            monthCalendar1.UpdateBoldedDates();

            foreach (DateTime date in reservedDates)
            {
                monthCalendar1.AddBoldedDate(date);

            }
            monthCalendar1.UpdateBoldedDates();

        }


        private void cb_area_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connectionString = "server=127.0.0.1;port=3307;database=vn;uid=root;pwd=Ruutti;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            //Retrieve selected Area name
            string selectedArea = cb_area.SelectedItem.ToString();


            //Populate the Cottage ComboBox with the cottages available in the selected Area
            string cottageQuery = "SELECT mokki_id, mokkinimi FROM mokki " +
                      "INNER JOIN alue ON mokki.alue_id = alue.alue_id " +
                      "WHERE alue.nimi = @selectedArea";
            MySqlCommand cottageCmd = new MySqlCommand(cottageQuery, connection);
            cottageCmd.Parameters.AddWithValue("@selectedArea", selectedArea);

            DataTable cottageTable = new DataTable();
            MySqlDataAdapter cottageAdapter = new MySqlDataAdapter(cottageCmd);
            cottageAdapter.Fill(cottageTable);
            cb_cottages.DisplayMember = "mokkinimi";
            cb_cottages.ValueMember = "mokki_id";
            cb_cottages.DataSource = cottageTable; 

            connection.Close();

        }



        private void LoadCustomers()
        {
            //Loads all customers into combobox
            String previousSelection = cb_customers.Text;

            cb_customers.Items.Clear();

            CustomerDAO customerDAO = new CustomerDAO();

            customerList = customerDAO.GetAllCustomer();
            
            cb_customers.DataSource = customerList;

            cb_customers.DisplayMember = "FullName";
            cb_customers.ValueMember = "ID";

        }



        private void ClearInputs()
        {
            //cb_area.SelectedItem = null;
            cb_cottages.SelectedItem = null;
            cb_customers.SelectedItem = null;
            dtp_startdate.Value = DateTime.Now;
            dtp_enddate.Value = DateTime.Now;
            dgv_reservations.ClearSelection();
            tb_search.Text = "";
            lbl_ID_result.Text = "";
            lbl_cottage_id_result.Text = "";
            lbl_customer_id_result.Text = "";
         
        }

        private void btn_customers_Click_1(object sender, EventArgs e)
        {
            Frm_customers form5Instance = Application.OpenForms.OfType<Frm_customers>().FirstOrDefault();
            if (form5Instance == null)
            {
                form5Instance = new Frm_customers();
                form5Instance.Show();
            }
            else
            {
                form5Instance.BringToFront();
            }
        }

        private void btn_clear_inputs_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private void btn_newrsv_Click(object sender, EventArgs e)
        {

            // add new reservation to database
            Reservation reservation = new Reservation
            {
                Asiakas_ID = Convert.ToInt32(cb_customers.SelectedValue),
                Mokki_ID = Convert.ToInt32(cb_cottages.SelectedValue),
                Varaus_pvm = DateTime.Now,
                Varauksen_alku_pvm = dtp_startdate.Value,
                Varauksen_loppu_pvm = dtp_enddate.Value,
                Vahvistus_pvm = dtp_startdate.Value.AddDays(-1)
            };

            ReservationsDAO reservationsDAO = new ReservationsDAO();
            int result = reservationsDAO.addOneReservation(reservation);
            MessageBox.Show(result + " new row(s) inserted");
            if (result >= 1)
            {

                ClearInputs();
                loadReservations();
                MessageBox.Show("Lisäys onnistui!", "Onnistui!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lisäys epäonnistui! Tarkasta onko tiedot syötetty oikein", "Virhe!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }




        private void btn_deletersv_Click(object sender, EventArgs e)
        {

            if(selectedReservationID == -1)
            {
                MessageBox.Show("Poisto epäonnistui, valitse varaus listalta", "Virhe!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if (MessageBox.Show("Haluatko varmasti poistaa varauksen, ID:" + lbl_ID_result.Text + "?", "Varoitus!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    ReservationsDAO reservationsDAO = new ReservationsDAO();
                    int removedRows = reservationsDAO.deleteReservation(selectedReservationID);

                    if (removedRows > 0)
                    {
                        ClearInputs();
                        loadReservations();
                        MessageBox.Show("Poisto onnistui.");
                    }
                    else
                    {
                        MessageBox.Show("Poisto epäonnistui!", "Virhe!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }




        //Checking what row of the dgv_reservations is selected and storing the id value
        private void dvg_reservations_SelectionChanged(object sender, EventArgs e)
        {
            
            DataGridView dgv = sender as DataGridView;

            if (dgv.CurrentRow.Index == null)
            {
                MessageBox.Show("Ei löydy sähköpostia! Tarkista syöte.", "Virhe!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                //get the row number clicked
                int rowClicked = dgv.CurrentRow.Index;

                //Taking the ID of the selected cottage, has to be higher than 0
                if ((int)dgv.Rows[rowClicked].Cells[0].Value > 0)
                {
                    selectedReservationID = (int)dgv.Rows[rowClicked].Cells[0].Value;

                    //Filling the input fields with selected data

                    lbl_ID_result.Text = selectedReservationID.ToString();
                    lbl_customer_id_result.Text = dgv.Rows[rowClicked].Cells[1].Value.ToString();
                    lbl_cottage_id_result.Text = dgv.Rows[rowClicked].Cells[2].Value.ToString();

                    DataGridViewCell selectedCell = dgv.Rows[rowClicked].Cells[5];
                    if (selectedCell.Value is DateTime selectedDateTime)
                    {
                        dtp_startdate.Value = selectedDateTime;
                    }

                    DataGridViewCell selectedCell1 = dgv.Rows[rowClicked].Cells[6];
                    if (selectedCell1.Value is DateTime selectedDateTime1)
                    {
                        dtp_enddate.Value = selectedDateTime1;
                    }


                }
            }
        }

        

        private void btn_servicemenu_Click(object sender, EventArgs e)
        {
            Form frm_servicesofreservation = new Frm_servicesofreservation();
            frm_servicesofreservation.ShowDialog();
        }


        private void tb_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            dgv_reservations.ClearSelection();


            //Limiting the amount of characters to 45
            if (tb_search.Text.Length >= 25 && e.KeyChar != '\b')
            {
                e.Handled = true;
            }

        }

    }
}