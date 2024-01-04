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

namespace OT1_R4
{
    public partial class Frm_searchreservations : Form
    {
        BindingSource reservationBindingSource = new BindingSource();

        public Frm_searchreservations()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            ReservationsDAO reservationsDAO = new ReservationsDAO();

            // connect the list to the dgv
            reservationBindingSource.DataSource = reservationsDAO.getReservations();
            dgv_search.DataSource = reservationBindingSource;
        }
    }
}
