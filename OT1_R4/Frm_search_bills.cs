﻿using System;
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
    public partial class Frm_search_bills : Form
    {
        public string LastSearch { get; set; }

        public List<Bill> ReturnList { get; set; }

        public Frm_search_bills(string searchString)
        {
            InitializeComponent();

            LastSearch = searchString;
            tb_email.Text = LastSearch;
        }

        private void Frm_search_bills_Load(object sender, EventArgs e)
        {
            //Positioning the title in the middle
            lbl_title.Location = new Point(pnl_top.Width / 2 - lbl_title.Width / 2, pnl_top.Height / 2 - lbl_title.Height / 2);
            btn_back.Location = new Point(pnl_bottom.Width / 2 - btn_back.Width / 2, pnl_bottom.Height / 2 - btn_back.Height / 2);
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            LastSearch = tb_email.Text;

            Close();
        }

        private void btn_search_all_Click(object sender, EventArgs e)
        {
            LastSearch = tb_email.Text;

            BillsDAO billsDAO = new BillsDAO();

            ReturnList = billsDAO.GetAllBills();
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            LastSearch = tb_email.Text;

            BillsDAO billsDAO = new BillsDAO();

            ReturnList = billsDAO.SearchBills(tb_email.Text);
            this.DialogResult = DialogResult.OK;
            Close();
        }

    }
}
