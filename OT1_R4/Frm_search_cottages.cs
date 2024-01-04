using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace OT1_R4
{
    public partial class Frm_search_cottages : Form
    {
        List<Area> areaList = new List<Area>();

        public List<Cottage> ReturnList { get; set; }
        public List<string> SearchInputs { get; set; }

        public Frm_search_cottages(List<string> csi)
        {
            InitializeComponent();

            LoadAreas();

            SearchInputs = csi;
            tb_name.Text = SearchInputs[0];
            cmb_area.Text = SearchInputs[1];
            nud_price_max.Text = SearchInputs[2];
            nud_headcount.Text = SearchInputs[3];
            tb_equipment.Text = SearchInputs[4];
        }

        private void Frm_search_cottages_Load(object sender, EventArgs e)
        {
            //Positioning the title in the middle
            lbl_title.Location = new Point(pnl_top.Width / 2 - lbl_title.Width / 2, pnl_top.Height / 2 - lbl_title.Height / 2);
            btn_back.Location = new Point(pnl_bottom.Width / 2 - btn_back.Width / 2, pnl_bottom.Height / 2 - btn_back.Height / 2);
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

        private void tb_equipment_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Limiting the amount of characters to 100
            TextBox tb = sender as TextBox;
            if (tb.Text.Length >= 100 && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }


        private void btn_clear_inputs_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }


        private void ClearInputs()
        {
            cmb_area.SelectedItem = null;
            tb_name.Text = "";
            nud_price_max.Value = 0;
            nud_headcount.Value = 0;
            tb_equipment.Text = "";
        }

        private void StoreInputs()
        {
            SearchInputs.Clear();
            SearchInputs.Add(tb_name.Text);
            SearchInputs.Add(cmb_area.Text);
            SearchInputs.Add(nud_price_max.Value.ToString());
            SearchInputs.Add(nud_headcount.Value.ToString());
            SearchInputs.Add(tb_equipment.Text);
        }

        private void LoadAreas()
        {
            //Loads all the areas into the combobox from the database
            String previousSelection = cmb_area.Text;

            cmb_area.Items.Clear();

            AreasDAO areaDAO = new AreasDAO();

            areaList = areaDAO.GetAllAreas();

            cmb_area.Items.Add("");

            for (int i = 0; i < areaList.Count; i++)
            {
                cmb_area.Items.Add(areaList[i].Name);

                if (previousSelection.Equals(areaList[i].Name))
                {
                    cmb_area.SelectedIndex = i;
                }
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            StoreInputs();

            Close();
        }

        private void btn_search_all_Click(object sender, EventArgs e)
        {
            StoreInputs();

            CottagesDAO cottagesDAO = new CottagesDAO();
            ReturnList = cottagesDAO.GetAllCottages();

            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            StoreInputs();

            CottagesDAO cottagesDAO = new CottagesDAO();

            //Doing a search based on the given inputs
            ReturnList = cottagesDAO.SearchCottages(tb_name.Text, cmb_area.Text, (int)nud_price_max.Value, (int)nud_headcount.Value, tb_equipment.Text);

            this.DialogResult = DialogResult.OK;
            Close();
        }
    }
}
