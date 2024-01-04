using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace OT1_R4
{
    public partial class Frm_cottages : Form
    {

        BindingSource cottagesBS = new BindingSource();
        
        List<Area> areaList = new List<Area>();

        //CottageSearchInputs csi = new CottageSearchInputs();

        List<string> csi = new List<string>() { "", "", "", "", ""};

        int selectedCottageID = -1;

        public Frm_cottages()
        {
            InitializeComponent();

            LoadAreas();
            LoadCottages();

        }
        private void Frm_areas_cottages_SizeChanged(object sender, EventArgs e)
        {
            //Keeping the title in the middle
            lbl_title.Location = new Point(pnl_top.Width / 2 - lbl_title.Width / 2, pnl_top.Height / 2 - lbl_title.Height / 2);
        }

        private void Frm_areas_cottages_Load(object sender, EventArgs e)
        {
            //Positioning the title in the middle
            lbl_title.Location = new Point(pnl_top.Width / 2 - lbl_title.Width / 2, pnl_top.Height / 2 - lbl_title.Height / 2);
        }

        private void tb_postcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Limiting the amount of characters to 5
            if (tb_postcode.Text.Length >= 5 && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
            //Only allowing numbers
            if (!Char.IsNumber(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void tb_address_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Limiting the amount of characters to 45
            if (tb_address.Text.Length >= 45 && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void tb_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Limiting the amount of characters to 45
            TextBox tb = sender as TextBox;
            if (tb.Text.Length >= 45 && e.KeyChar != '\b')
            {
                e.Handled = true;
            }

            
        }

        private void tb_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            //limiting the amount of characters to 11
            if (tb_price.Text.Length >= 11 && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
            //only allowing numbers
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        private void tb_description_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Limiting the amount of characters to 150
            TextBox tb = sender as TextBox;
            if (tb.Text.Length >= 150 && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void tb_equipment_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Limiting the amount of characters to 100
            TextBox tb = sender as TextBox;
            if (tb.Text.Length >= 100 && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void tb_price_Leave(object sender, EventArgs e)
        {
            //Replace , with .
            string text = tb_price.Text.Replace(",",".");

            //Making sure the text ends with a decimal and two digits
            if (text.IndexOf(".") == -1)
            {
                //Adding a 0 if no input is given
                if (text.Length == 0) text += "0";
                text += ".00";
            }
            else if (text.IndexOf(".") == text.Length - 1)
            {
                if (text.IndexOf(".") == 0) text = "0.";
                text += "00";
            }
            else if (text.IndexOf(".") == text.Length - 2)
            {
                text += "0";
            }
            else if (text.IndexOf(".") == 0)
            {
                text = "0" + text;
            }

            //Round to 2 decimals and check it isn't more than 99999999.99
            double.TryParse(text.Replace(".", ","), out double value);
            if (value > 99999999.99)
            {
                text = "0.00";
                toolTip1.ToolTipTitle = "Virheellinen syöte!";
                toolTip1.Show("Liian suuri hinta.", (TextBox)sender, 0, 26, 5000);
            }
            else
            {
                text = value.ToString("F2"); //Rounds to 2 decimals
                text = text.Replace(",", ".");
            }

            //Check that the text is given in 00000000.00 format
            Regex rg = new Regex(@"^[0-9]{1,8}\.[0-9]{2}$");
            Match m = rg.Match(text);

            if (m.Success)
            {
                //tb_price.BackColor = Color.LightGreen;
            }
            else
            {
                tb_price.BackColor = Color.LemonChiffon;

                //A way to give a notification
                toolTip1.ToolTipTitle = "Virheellinen syöte!";
                toolTip1.Show("Pitää antaa hinta muodossa \"0000.00\".", (TextBox)sender, 0, 26, 5000);
            }
            tb_price.Text = text;

        }

        private void LoadAreas()
        {
            //Loads all the areas into the combobox from the database
            String previousSelection = cmb_area.Text;

            cmb_area.Items.Clear();

            AreasDAO areaDAO = new AreasDAO();

            areaList = areaDAO.GetAllAreas();

            for (int i = 0; i < areaList.Count; i++)
            {
                cmb_area.Items.Add(areaList[i].Name);
                
                if (previousSelection.Equals(areaList[i].Name))
                {
                    cmb_area.SelectedIndex = i;
                }
            }
        }

        private void LoadCottages()
        {
            //Loads all the cottages into the datagridview from the database
            CottagesDAO cottagesDAO = new CottagesDAO();

            cottagesBS.DataSource = cottagesDAO.GetAllCottages();

            dgv_cottages.DataSource = cottagesBS;
        }

        private void ClearInputs()
        {
            selectedCottageID = -1;
            lbl_cottage_ID.Text = "-";

            cmb_area.SelectedItem = null;
            tb_postcode.Text = "";
            tb_name.Text = "";
            tb_address.Text = "";
            tb_price.Text = "0.00";
            tb_description.Text = "";
            nud_headcount.Value = 0;
            tb_equipment.Text = "";
        }

        //Checks that all the input fiels are filled out, returns true or false
        private bool CheckInputs()
        {
            CottagesDAO cottagesDAO = new CottagesDAO();
            bool ret = false;
            if (cmb_area.SelectedIndex == -1)
            {
                //Error, need to have an area
                toolTip1.ToolTipTitle = "Aluetta ei ole valittu!";
                toolTip1.Show("Valitse mökin alue!", cmb_area, 0, cmb_area.Height, 5000);
            }
            else if (tb_name.Text.Trim().Length == 0)
            {
                //Error, need to have a name
                toolTip1.ToolTipTitle = "Tekstikenttä tyhjä!";
                toolTip1.Show("Anna mökille nimi!", tb_name, 0, tb_name.Height, 5000);
            }
            else if (tb_postcode.Text.Trim().Length == 0)
            {
                //Error, need to have a postcode
                toolTip1.ToolTipTitle = "Tekstikenttä tyhjä!";
                toolTip1.Show("Anna mökille postinumero!", tb_postcode, 0, tb_postcode.Height, 5000);
            }
            else if (cottagesDAO.CheckPostcode(tb_postcode.Text.Trim()) != 1)
            {
                toolTip1.ToolTipTitle = "Virheellinen postiosoite!";
                toolTip1.Show("Antamasi postinumero ei ole kelvollinen!", tb_postcode, 0, tb_postcode.Height, 5000);
            }
            else if (tb_address.Text.Trim().Length == 0)
            {
                //Error, need to have a postcode
                toolTip1.ToolTipTitle = "Tekstikenttä tyhjä!";
                toolTip1.Show("Anna mökille katuosoite!", tb_address, 0, tb_address.Height, 5000);
            }
            else if (double.Parse(tb_price.Text.Replace(".", ",")) == 0)
            {
                //Error, need to have a price
                toolTip1.ToolTipTitle = "Hinta nolla!";
                toolTip1.Show("Anna mökille hinta!", tb_price, 0, tb_price.Height, 5000);
            }
            else if (nud_headcount.Value == 0)
            {
                //Error, need to have a price
                toolTip1.ToolTipTitle = "Henkilömäärä nolla!";
                toolTip1.Show("Anna mökille henkilömäärä!", nud_headcount, 0, nud_headcount.Height, 5000);
            }
            else if (tb_description.Text.Trim().Length == 0)
            {
                //Error, need to have a description
                toolTip1.ToolTipTitle = "Tekstikenttä tyhjä!";
                toolTip1.Show("Anna mökille kuvaus!", tb_description, 0, tb_description.Height, 5000);
            }
            else if (tb_equipment.Text.Trim().Length == 0)
            {
                //Error, need to have a description
                toolTip1.ToolTipTitle = "Tekstikenttä tyhjä!";
                toolTip1.Show("Anna mökille varustelu!", tb_equipment, 0, tb_equipment.Height, 5000);
            }
            else
            {
                ret = true;
            }
            return ret;
        }
        
        //Checks that all the inputs are correct for editing, returns true or false
        private bool CheckEditInputs()
        {
            bool ret = false;
            if (CheckInputs())
            {
                if (selectedCottageID <= 0)
                {
                    //Error, need to select the cottage to edit
                    toolTip1.ToolTipTitle = "Mökkiä ei ole valittu!";
                    toolTip1.Show("Valitse mökki listasta, jota haluat muokata!", btn_edit_cottage, 0, btn_edit_cottage.Height, 5000);
                }
                else
                {
                    ret = true;
                }
            }

            return ret;
        }

        //Takes the inputs from the input fields and creates a cottage based on them. Returns null if the area ID cant be found
        private Cottage CreateCottage()
        {
            //Getting the area ID
            int area_id = GetAreaID(cmb_area.SelectedItem.ToString());

            if (area_id == -1)
            {
                //If for some reason the area_id isn't found, issue error and stop the creating process
                MessageBox.Show("Alueen määrittelyssä tapahtui virhe!", "Virhe!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            Cottage cot = new Cottage
            {
                Area_ID = area_id,
                PostNum = tb_postcode.Text,
                Name = tb_name.Text,
                Address = tb_address.Text,
                Price = tb_price.Text,
                Description = tb_description.Text,
                Headcount = (int)nud_headcount.Value,
                Equipment = tb_equipment.Text,
            };

            return cot;
        }

        //Checks through the areaList to find a matching name, returns the id. Returns -1 if not found
        private int GetAreaID(string name)
        {
            int area_id = -1;

            for (int i = 0; i < areaList.Count; i++)
            {
                if (name.Equals(areaList[i].Name))
                {
                    area_id = areaList[i].ID;
                }
            }

            return area_id;
        }

        //Adds a new cottage to the database
        private void btn_add_cottage_Click(object sender, EventArgs e)
        {
            if (CheckInputs())
            {
                //Creating the cottage that will be added to the database
                Cottage cot = CreateCottage();

                if (cot != null)
                {
                    CottagesDAO cottagesDAO = new CottagesDAO();

                    //Adding the new cottage, returns how many rows were affecter (should be 1 if succesfully added)
                    int newRows = cottagesDAO.AddCottage(cot);

                    if (newRows >= 1)
                    {
                        //Clear the input fields
                        ClearInputs();

                        LoadCottages(); //Reload cottages into datagridview
                        MessageBox.Show("Lisäys onnistui!", "Onnistui!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Lisäys epäonnistui!", "Virhe!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btn_areas_Click(object sender, EventArgs e)
        {
            Frm_areas frm_areas = new Frm_areas();

            frm_areas.ShowDialog();
            LoadAreas();
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

        //Cheking what row of the dgv_cotteges is selected and storing the id value
        private void dgv_cottages_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //DataGridView dgv = sender as DataGridView;

            ////get the row nubmer clicked
            //int rowClicked = dgv.CurrentRow.Index;

            ////MessageBox.Show("Painoit riviä " + rowClicked);

            ////Taking the ID of the selected cottage, has to be higher than 0
            //if ((int)dgv.Rows[rowClicked].Cells[0].Value > 0)
            //{
            //    selectedCottageID = (int)dgv.Rows[rowClicked].Cells[0].Value;

            //    //Filling the input fields with selected data

            //    lbl_cottage_ID.Text = selectedCottageID.ToString();

            //    string selectedArea = "";
            //    for (int i = 0; i < areaList.Count; i++)
            //    {
            //        if (areaList[i].ID == (int)dgv.Rows[rowClicked].Cells[1].Value)
            //        {
            //            selectedArea = areaList[i].Name;
            //        }
            //    }
            //    cmb_area.SelectedItem = selectedArea;

            //    tb_postcode.Text = dgv.Rows[rowClicked].Cells[2].Value.ToString();
            //    tb_name.Text = dgv.Rows[rowClicked].Cells[3].Value.ToString();
            //    tb_address.Text = dgv.Rows[rowClicked].Cells[4].Value.ToString();
            //    tb_price.Text = dgv.Rows[rowClicked].Cells[5].Value.ToString().Replace(",", ".");
            //    tb_description.Text = dgv.Rows[rowClicked].Cells[6].Value.ToString();
            //    nud_headcount.Value = (int)dgv.Rows[rowClicked].Cells[7].Value;
            //    tb_equipment.Text = dgv.Rows[rowClicked].Cells[8].Value.ToString();

            //}
        }

        private void btn_edit_cottage_Click(object sender, EventArgs e)
        {
            if (CheckEditInputs())
            {
                Cottage cot = CreateCottage();

                if (cot != null)
                {
                    cot.ID = selectedCottageID;

                    CottagesDAO cottagesDAO = new CottagesDAO();

                    //Adding the new cottage, returns how many rows were affecter (should be 1 if succesfully added)
                    int newRows = cottagesDAO.EditCottage(cot);

                    if (newRows >= 1)
                    {
                        //Clear the input fields
                        ClearInputs();

                        LoadCottages(); //Reload cottages into datagridview
                        MessageBox.Show("Muokkaus onnistui!", "Onnistui!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Muokkaus epäonnistui!", "Virhe!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btn_clear_inputs_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private void btn_delete_cottage_Click(object sender, EventArgs e)
        {
            if (selectedCottageID == -1)
            {
                toolTip1.ToolTipTitle = "Mökkiä ei ole valittu!";
                toolTip1.Show("Valitse mökki listasta, jonka haluat poistaa!", btn_delete_cottage, 0, btn_delete_cottage.Height, 5000);
            }
            else
            {
                if (MessageBox.Show("Haluatko varmasti poistaa mökin " + tb_name.Text + "?", "Varoitus!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    CottagesDAO cottagesDAO = new CottagesDAO();
                    int removedRows = cottagesDAO.DeleteCottage(selectedCottageID);

                    if (removedRows > 0)
                    {
                        ClearInputs();
                        LoadCottages();
                        //MessageBox.Show("Poisto onnistui.");
                    }
                    else
                    {
                        MessageBox.Show("Poisto epäonnistui!", "Virhe!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btn_search_cottage_Click(object sender, EventArgs e)
        {
            using (Frm_search_cottages frm_search = new Frm_search_cottages(csi))
            {
                if (frm_search.ShowDialog() == DialogResult.OK)
                {
                    cottagesBS.DataSource = frm_search.ReturnList;

                    dgv_cottages.DataSource = null;

                    dgv_cottages.DataSource = cottagesBS;
                }

                csi = frm_search.SearchInputs;
            }
        }

        //Cheking what row of the dgv_cotteges is selected and storing the id value
        private void dgv_cottages_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = sender as DataGridView;

            //get the row nubmer clicked
            int rowSelected = dgv.CurrentRow != null ? dgv.CurrentRow.Index : -1;

            //MessageBox.Show("Painoit riviä " + rowClicked);

            //Taking the ID of the selected cottage, has to be higher than 0
            if (rowSelected >= 0)
            {
                selectedCottageID = (int)dgv.Rows[rowSelected].Cells[0].Value;

                //Filling the input fields with selected data

                lbl_cottage_ID.Text = selectedCottageID.ToString();

                string selectedArea = "";
                for (int i = 0; i < areaList.Count; i++)
                {
                    if (areaList[i].ID == (int)dgv.Rows[rowSelected].Cells[1].Value)
                    {
                        selectedArea = areaList[i].Name;
                    }
                }
                cmb_area.SelectedItem = selectedArea;

                tb_postcode.Text = dgv.Rows[rowSelected].Cells[2].Value.ToString();
                tb_name.Text = dgv.Rows[rowSelected].Cells[3].Value.ToString();
                tb_address.Text = dgv.Rows[rowSelected].Cells[4].Value.ToString();
                tb_price.Text = dgv.Rows[rowSelected].Cells[5].Value.ToString().Replace(",", ".");
                tb_description.Text = dgv.Rows[rowSelected].Cells[6].Value.ToString();
                nud_headcount.Value = (int)dgv.Rows[rowSelected].Cells[7].Value;
                tb_equipment.Text = dgv.Rows[rowSelected].Cells[8].Value.ToString();

            }
        }
    }
}
