using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using MySqlX.XDevAPI.Relational;
using Org.BouncyCastle.Asn1.CryptoPro;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Infrastructure.Interception;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;

namespace OT1_R4
{
    public partial class Frm_services : Form
    {


        BindingSource servicesBS = new BindingSource();

        List<Services> serviceList = new List<Services>();

        AreasDAO areasDAO = new AreasDAO();

        List<Area> areaList = new List<Area>();

        public void Load_areas()
        {
            //Loads all the areas into the combobox from the database

            AreasDAO areaDAO = new AreasDAO();

            List<Area> areas = areasDAO.GetAllAreas();

            // link datasource areas to combobox
            cmb_location.DataSource = areas;
            cmb_location.DisplayMember = "Name";
            cmb_location.ValueMember = "ID";
               
        }

        public Frm_services()
        {
            InitializeComponent();
            Load_areas();
            toolTip1.SetToolTip(tb_name, "Anna palvelun nimi, max 45 merkkiä");
            toolTip1.SetToolTip(tb_description, "Anna kuvaus max 255 merkkiä");
            toolTip1.SetToolTip(tb_price, "Anna hinta");
            toolTip1.SetToolTip(cmb_location, "Valitse alue listalta");
            toolTip1.SetToolTip(btn_close, "Sulkee sovelluksen");
            toolTip1.SetToolTip(btn_add, "Lisää alue tästä napista," + Environment.NewLine + "syötä ensin tiedot tekstikenttiin");
            toolTip1.SetToolTip(btn_delete, "Poista valittu palvelu");
            toolTip1.SetToolTip(btn_panel3_modify, "Muokkaa valittua palvelua");
            toolTip1.SetToolTip(btn_search, "Hae palvelua");
            toolTip1.SetToolTip(tb_search, "Hae palvelun nimellä");
            toolTip1.SetToolTip(bt_clear, "Tyhjennä lomake");
        }



        // create function where you can load all data and show it in datagridview, can be done for every table!
        public void loadDataServices()
        {
             //Loads all the services into the datagridview from the database

             ServicesDAO servicesDAO = new ServicesDAO();

             servicesBS.DataSource = servicesDAO.GetAllServices();

             dgv_service.DataSource = servicesBS;
            //Loads all the services into the datagridview from the database  

        } // loadservices

        // Clear textboxes

        private void ClearData()
        {
            tb_name.Text = "";
            tb_price.Text = "";
            tb_description.Text = "";
            lbl_ID.Text = "";
            Load_areas();
            cmb_location.SelectedIndex = -1;

        }
        // function for adding new services to database propably working (needs to create test data to database)

        private void Frm_services_Load(object sender, EventArgs e)
        {
            loadDataServices();
        }
       

        // get areaname to combobox sijainti
        public void getAreaName(int alue_ID)
        {

            AreasDAO areaDAO = new AreasDAO();

            areaList = areaDAO.GetAllAreas();

            for (int i = 0; i < areaList.Count; i++)
            {
                if (areaList[i].ID == alue_ID)
                {
                    cmb_location.Text = areaList[i].Name;
                }
            }
        }
        

        private int getServiceID(int rowIndex)
        {
            return Convert.ToInt32(dgv_service.Rows[rowIndex].Cells[0].Value);
            
        }
        private int getAreaID(int rowIndex)
        {
            return Convert.ToInt32(dgv_service.Rows[rowIndex].Cells[1].Value);
        }



        private int rowIndex;
        // choose service to modify by clicking and show it in textboxes
        private void dgv_service_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && dgv_service.Rows[e.RowIndex].Cells[2].Value != null)
            {
                rowIndex = e.RowIndex;
                // State(rowIndex);
                tb_name.Text = dgv_service.Rows[e.RowIndex].Cells[2].Value.ToString();
                tb_description.Text = dgv_service.Rows[e.RowIndex].Cells[3].Value.ToString();
                tb_price.Text = dgv_service.Rows[e.RowIndex].Cells[4].Value.ToString();
                tb_Alv.Text = dgv_service.Rows[e.RowIndex].Cells[5].Value.ToString();
                int alueID = Convert.ToInt32(dgv_service.SelectedRows[0].Cells["alue_ID"].Value);
                lbl_ID.Text = dgv_service.Rows[e.RowIndex].Cells[0].Value.ToString();
                // get areaname in cmb_location combobox
                getAreaName(alueID);

                checkInput();
            }
                
        }

        private void btn_panel3_modify_Click(object sender, EventArgs e)
        {

             if (dgv_service.SelectedRows.Count > 0)

                {
                bool inputValid = checkInput(); // Check if input is valid
                if (inputValid) // Check if row is selected
                 {
                    int rowIndex = dgv_service.SelectedRows[0].Index; // Get the index of the selected row
                    int selectedLocationID = areaList[cmb_location.SelectedIndex].ID;
                    int serviceID = getServiceID(rowIndex);

                    Services service = new Services
                    {
                        palvelu_ID = serviceID,
                        alue_ID = selectedLocationID,
                        nimi = tb_name.Text,
                        kuvaus = tb_description.Text,
                        hinta = Double.Parse(tb_price.Text),
                        alv = Double.Parse(tb_Alv.Text),
                    };

                    ServicesDAO servicesDAO = new ServicesDAO();
                    int newRows = servicesDAO.UpdateService(service); // Update the service

                    if (newRows >= 1)
                    {
                        ClearData();
                        loadDataServices();
                        MessageBox.Show("Muokkaus onnistui!");
                    }
                    else
                    {
                        MessageBox.Show("Muokkaus epäonnistui!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    ClearData();
                }
                else
                {
                    MessageBox.Show("Täytä kaikki tiedot!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Valitse rivi muokattavaksi", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btn_add_Click_1(object sender, EventArgs e)
        {
            tb_name.Text = tb_name.Text.Trim();
            checkInput();
            bool inputValid = checkInput();
            if (inputValid)
            {

                int locationID = (int)cmb_location.SelectedValue;

                Services service = new Services
                {
                    alue_ID = locationID,
                    nimi = tb_name.Text,
                    kuvaus = tb_description.Text,
                    hinta = Double.Parse(tb_price.Text),
                    alv = 23,
                };

                ServicesDAO servicesDAO = new ServicesDAO();


                //Adding the new Service, returns how many rows were affected (should be 1 if successfully added)
                int newRows = servicesDAO.AddService(service);

                if (newRows >= 1)
                {
                    //Clear the input fields
                    ClearData();
                    loadDataServices(); //Reload Services into datagridview
                    MessageBox.Show("Lisäys onnistui!", "Palvelu lisätty", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Lisäys epäonnistui!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                // Show message box indicating that all conditions must be met
                MessageBox.Show("Täytä kaikki kentät", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (dgv_service.SelectedRows.Count > 0)
            {
                bool inputValid = checkInput();
                if (inputValid)
                {
                    try
                    {
                        int selectedLocationID = getAreaID(rowIndex);
                        int selectedRowIndex = dgv_service.SelectedCells[0].RowIndex; // Hae valitun solun rivin indeksi
                        int ID = Convert.ToInt32(dgv_service.Rows[selectedRowIndex].Cells["palvelu_ID"].Value); // Hae palvelu_ID-arvo valitulta riviltä ja solulta nimellä "palvelu_ID"

                        Services service = new Services
                        {
                            palvelu_ID = ID,
                            alue_ID = selectedLocationID,
                            nimi = tb_name.Text,
                            kuvaus = tb_description.Text,
                            hinta = Double.Parse(tb_price.Text),
                            alv = Double.Parse(tb_Alv.Text),
                        };
                        DialogResult dialogresult = MessageBox.Show("Haluatko varmasti poistaa palvelun", "vahvista poisto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        
                        if (dialogresult == DialogResult.Yes)
                        {
                            ServicesDAO servicesDAO = new ServicesDAO();

                            //Adding the new Service, returns how many rows were affected (should be 1 if successfully deleted)
                            int newRows = servicesDAO.DeleteService(service);

                            if (newRows > 0)
                            {
                                //Clear the input fields
                                ClearData();
                                loadDataServices(); //Reload Services into datagridview
                                MessageBox.Show("Poisto onnistui!");
                            }
                            else
                            {
                                MessageBox.Show("Poisto epäonnistui!");
                            }
                        }
                            

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Virhe", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Tarkista syötteet!");
                }
            }
            else
            {
                MessageBox.Show("Valitse ensin palvelu!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void tb_price_Leave(object sender, EventArgs e)
        {
            double value;

            // Replace any dots with commas in textbox3 text
            tb_price.Text = tb_price.Text.Replace(".", ",");

            // Try to parse textbox3 text as double, and round to 2 decimal places
            if (!double.TryParse(tb_price.Text, out value))
            {
                // Set background color to light yellow
                tb_price.BackColor = Color.LightYellow;
            }
            else
            {
                // Round value to 2 decimal places
                value = Math.Round(value, 2);

                // Set textbox3 text to the rounded value
                tb_price.Text = value.ToString();

                // Set background color to default
                tb_price.BackColor = SystemColors.Window;

                // Hide tooltip
                toolTip1.Hide(tb_price);
            }
        }

        private void ResetInputFields()
        {
            tb_description.BackColor = SystemColors.Window;
            cmb_location.BackColor = SystemColors.Window;
            tb_name.BackColor = SystemColors.Window;
            tb_price.BackColor = SystemColors.Window;

            toolTip1.Hide(tb_description);
            toolTip1.Hide(cmb_location);
            toolTip1.Hide(tb_name);
            toolTip1.Hide(tb_price);

        }

        public bool checkInput()
        {
            bool result = true;            
            
            
            if (tb_description.Text == "" || tb_description.Text.Length > 255)
            {
                result = false;
                tb_description.BackColor = Color.LightYellow;
                toolTip1.Show("Anna kuvaus, max 255 merkkiä.", tb_description, tb_name.Width, 0);
            }
            // input check for location
            if (cmb_location.SelectedItem == null)
            {
                result = false;
                cmb_location.BackColor = Color.LightYellow;
                toolTip1.Show("Valitse alue listalta", cmb_location, cmb_location.Width, 0);
            }
            // check for tb_name
            if (tb_name.Text == "" || !Regex.IsMatch(tb_name.Text, @"^[a-zA-Z0-9\s\u00C0-\u00FF]+$"))
            {
                result = false;
                tb_name.BackColor = Color.LightYellow;
                toolTip1.Show("Vain kirjaimet ja numerot sallittu.", tb_name, tb_name.Width, 0);
            }
            if (!double.TryParse(tb_price.Text, out double price))
            {
                result = false;
                tb_price.BackColor = Color.LightYellow;
                toolTip1.Show("Anna hinta numeroina", tb_price, tb_name.Width, 0);
            }

            if (result)
            {
                ResetInputFields();
            }

            return result;
           
        }

        

        private void bt_clear_Click(object sender, EventArgs e)
        {
            ClearData();
            ResetInputFields();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            {
                string searchTerm = tb_search.Text.Trim(); // Get the search term from the text box
                ServicesDAO servicesDAO = new ServicesDAO();

                if (!string.IsNullOrEmpty(searchTerm)) // Check if search term is not empty
                {
                    // Call the search service method and pass in the search term
                    List<Services> searchResults = servicesDAO.GetServicesByName(searchTerm);

                    if (searchResults.Count > 0) // Check if there are any search results
                    {
                        dgv_service.DataSource = searchResults; // Set the search results as the data source for the DataGridView
                        dgv_service.ClearSelection(); // Clear any previous row selections
                    }
                    else
                    {
                        MessageBox.Show("Ei hakutuloksia."); // Display message if no results found
                    }
                }
                else
                {
                    loadDataServices(); // Load all services into the DataGridView
                }
            }
            
        }

        private void tb_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            // check if character is letter or digit or whitespace
            
               
                    if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                    {
                        e.Handled = true;
                    }

                    if (tb_name.Text.Length >= 40 && e.KeyChar != (char)Keys.Back)
                    {
                        e.Handled = true;
                    }
                


            
        }
        // check if charcter is number or , or . backspace
        private void tb_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            {
                if (MessageBox.Show("Haluatko varmasti sulkea ohjelman?", "Sulje ohjelma", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
           this.Close();
        }
    }
}


