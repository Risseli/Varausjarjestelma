using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using TextBox = System.Windows.Forms.TextBox;

namespace OT1_R4
{
    public partial class Frm_areas : Form
    {
        List<Area> areaList = new List<Area>();

        public Frm_areas()
        {
            InitializeComponent();
        }

        private void Frm_areas_Load(object sender, EventArgs e)
        {
            Load_areas();
        }

        private void Load_areas()
        {
            //Loads all the areas into the listbox from the database
            lb_area.Items.Clear();

            AreasDAO areaDAO = new AreasDAO();

            areaList = areaDAO.GetAllAreas();

            for (int i = 0; i < areaList.Count; i++)
            {
                lb_area.Items.Add(areaList[i].Name);
            }
        }

        private void Frm_areas_SizeChanged(object sender, EventArgs e)
        {
            //Title positioning
            lbl_title.Location = new Point(pnl_top.Width / 2 - lbl_title.Width / 2, pnl_top.Height / 2 - lbl_title.Height / 2);

            //button back positioning
            btn_back.Location = new Point(pnl_bottom.Width / 2 - btn_back.Width / 2, pnl_bottom.Height / 2 - btn_back.Height / 2);
        }

        private void btn_add_area_Click(object sender, EventArgs e)
        {
            //Adds an area to the database
            AreasDAO areaDAO = new AreasDAO();

            if (tb_add_area.Text.Trim().Length != 0) //tb_add_area cant be empty
            {
                int match = 0;

                //Checking to see if an area like that already exists
                for (int i = 0; i < lb_area.Items.Count; i++)
                {
                    if (tb_add_area.Text.Trim().ToLower().Equals(lb_area.Items[i].ToString().ToLower()))
                    {
                        match++;
                        toolTip1.ToolTipTitle = "Alue on jo olemassa!";
                        toolTip1.Show("Alueelle pitää antaa uniikki nimi!", tb_add_area, 0, tb_add_area.Height, 5000);
                    }
                }

                if (match == 0) //add the area, if no dublicates
                {
                    //Adding the new area, returns how many rows were affecter (should be 1 if succesfully added)
                    int newRows = areaDAO.AddArea(tb_add_area.Text.Trim());

                    if (newRows >= 1)
                    {
                        //MessageBox.Show("Lisäys onnistui!");
                        tb_add_area.Text = "";
                        Load_areas(); //Reload areas into ListBox
                    }
                    else
                    {
                        MessageBox.Show("Lisäys epäonnistui!", "Virhe!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                toolTip1.ToolTipTitle = "Tekstikenttä tyhjä!";
                toolTip1.Show("Alueelle pitää antaa nimi!", tb_add_area, 0, tb_add_area.Height, 5000);
            }
        }

        private void btn_rename_area_Click(object sender, EventArgs e)
        {
            AreasDAO areaDAO = new AreasDAO();

            //Checking that an area has been selected
            if (lb_area.SelectedIndex == -1)
            {
                toolTip1.ToolTipTitle = "Aluetta ei ole valittu!";
                toolTip1.Show("Valitse alue jonka haluat nimetä uudelleen!", lb_area, 0, lb_area.Height, 5000);
            }
            else if (tb_add_area.Text.Trim().Length != 0) //tb_add_area cant be empty
            {
                int match = 0;

                //Checking to see if an area like that already exists
                for (int i = 0; i < lb_area.Items.Count; i++)
                {
                    if (tb_add_area.Text.Trim().ToLower().Equals(lb_area.Items[i].ToString().ToLower()) &&
                        !tb_add_area.Text.Trim().ToLower().Equals(lb_area.SelectedItem.ToString().ToLower()))
                    {
                        match++;
                        toolTip1.ToolTipTitle = "Alue on jo olemassa!";
                        toolTip1.Show("Alueelle pitää antaa uniikki nimi!", tb_add_area, 0, tb_add_area.Height, 5000);
                    }
                }

                if (match == 0) //add the area, if no dublicates
                {
                    //Updating the area name, returns how many rows were affecter (should be 1 if succesfully updated)
                    int newRows = areaDAO.RenameArea(tb_add_area.Text.Trim(), lb_area.SelectedItem.ToString());

                    if (newRows >= 1)
                    {
                        //MessageBox.Show("Uudelleen nimeäminen onnistui!");
                        tb_add_area.Text = "";
                        Load_areas(); //Reload areas into ListBox
                    }
                    else
                    {
                        MessageBox.Show("Uudelleen nimeäminen epäonnistui!", "Virhe!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                toolTip1.ToolTipTitle = "Tekstikenttä tyhjä!";
                toolTip1.Show("Alueelle pitää antaa nimi.", tb_add_area, 0, tb_add_area.Height, 5000);
            }
        }

        private void btn_delete_area_Click(object sender, EventArgs e)
        {
            //Checking that an area has been selected
            if (lb_area.SelectedIndex == -1)
            {
                toolTip1.ToolTipTitle = "Aluetta ei ole valittu!";
                toolTip1.Show("Valitse alue, jonka haluat poistaa!", lb_area, 0, lb_area.Height, 5000);
            }
            else
            {
                if (MessageBox.Show("Haluatko varmasti poistaa alueen " + lb_area.SelectedItem.ToString() + "?", "Varoitus!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    AreasDAO areaDAO = new AreasDAO();

                    //Getting the area ID
                    int area_id = -1;
                    string area = lb_area.SelectedItem.ToString();

                    for (int i = 0; i < areaList.Count; i++)
                    {
                        if (area.Equals(areaList[i].Name))
                        {
                            area_id = areaList[i].ID;
                        }
                    }

                    if (area_id == -1)
                    {
                        //If for some reason the area_id isn't found, issue error and stop the adding process
                        MessageBox.Show("Alueen määrittelyssä tapahtui virhe!", "Virhe!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }


                    //int rowsDeleted = areaDAO.DeleteArea(lb_area.SelectedItem.ToString());
                    int rowsDeleted = areaDAO.DeleteArea(area_id);



                    if (rowsDeleted >= 1)
                    {
                        //MessageBox.Show("Poisto onnistui!");
                        tb_add_area.Text = "";
                        Load_areas(); //Reload areas into ListBox
                    }
                    else
                    {
                        MessageBox.Show("Poisto epäonnistui!", "Virhe!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lb_area_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Every time we select an item it's information is brought to the input fields
            if (lb_area.SelectedIndex != -1)
            {
                for (int i = 0; i < areaList.Count; i++)
                {
                    if (lb_area.SelectedItem.Equals(areaList[i].Name))
                    {
                        lbl_id.Text = "ID: " + areaList[i].ID.ToString();
                        tb_add_area.Text = areaList[i].Name;
                    }
                }
            }
        }

        private void tb_add_area_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Limiting the amount of characters to 40
            TextBox tb = sender as TextBox;
            if (tb.Text.Length >= 40 && e.KeyChar != '\b')
            {
                e.Handled = true;

                toolTip1.ToolTipTitle = "Liian pitkä nimi!";
                toolTip1.Show("Alueen nimen maksimi pituus on 40.", (TextBox)sender, 0, ((TextBox)sender).Height, 5000);
            }
        }
    }
}
