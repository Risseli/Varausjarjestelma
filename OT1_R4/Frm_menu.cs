using System;
using System.Linq;
using System.Windows.Forms;

namespace OT1_R4
{
    public partial class Frm_menu : Form
    {
        public Frm_menu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btn_areas_cottages_Click(object sender, EventArgs e)
        {
            Frm_cottages form2Instance = Application.OpenForms.OfType<Frm_cottages>().FirstOrDefault();
            if (form2Instance == null)
            {
                form2Instance = new Frm_cottages();
                form2Instance.Show();
            }
            else
            {
                form2Instance.BringToFront();
            }
        }


        private void btn_services_Click(object sender, EventArgs e)
        {
            Frm_services form3Instance = Application.OpenForms.OfType<Frm_services>().FirstOrDefault();
            if (form3Instance == null)
            {
                form3Instance = new Frm_services();
                form3Instance.Show();
            }
            else
            {
                form3Instance.BringToFront();
            }
        }

        private void btn_reservations_Click(object sender, EventArgs e)
        {
            Frm_reservations form4Instance = Application.OpenForms.OfType<Frm_reservations>().FirstOrDefault();
            if (form4Instance == null)
            {
                form4Instance = new Frm_reservations();
                form4Instance.Show();
            }
            else
            {
                form4Instance.BringToFront();
            }
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

        private void btn_appexit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Haluatko varmasti sulkea ohjelman?", "Sulje ohjelma", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_billing_Click(object sender, EventArgs e)
        {
            Frm_billing form6Instance = Application.OpenForms.OfType<Frm_billing>().FirstOrDefault();
            if (form6Instance == null)
            {
                form6Instance = new Frm_billing();
                form6Instance.Show();
            }
            else
            {
                form6Instance.BringToFront();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_reports form7Instance = Application.OpenForms.OfType<Frm_reports>().FirstOrDefault();
            if (form7Instance == null)
            {
                form7Instance = new Frm_reports();
                form7Instance.Show();
            }
            else
            {
                form7Instance.BringToFront();
            }
        }
    }
}
