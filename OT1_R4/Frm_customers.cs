using System;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace OT1_R4
{
    public partial class Frm_customers : Form
    {
        BindingSource customerBS = new BindingSource();
        BindingSource postBS = new BindingSource();
        List<Post> PostList = new List<Post>();

        int selectedCustomerID = -1;

        public Frm_customers()
        {
            
           
            InitializeComponent();
            LoadPost();
            LoadCustomer();
            dgv_customer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        




        }
        private void LoadPost()
        {
            PostDAO postDAO = new PostDAO();
            List<Post> posts = postDAO.GetAllPost();

            cb_post.DataSource = posts;
            cb_post.DisplayMember = "FullPost";
            cb_post.ValueMember = "Postn";
            

         

        }


        private void Frm_customers_Load(object sender, EventArgs e)
        {
            
            lbl_title.Location = new Point(pnl_top.Width / 2 - lbl_title.Width / 2, pnl_top.Height / 2 - lbl_title.Height / 2);

        }
        private void ClearTextBoxes()
        {
            txtEmail.Text = "";
            txtLast.Text = "";
            txtName.Text="";
            txtNumber.Text = "";
            txtStreet.Text = "";
          
        }
        private bool AreRequiredTextboxesEmpty()
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtLast.Text) ||
                string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtNumber.Text) ||
                string.IsNullOrWhiteSpace(txtStreet.Text))
            {
                return true;
            }

            return false;
        }


        private Customer CreateCustomer()
        {


            Customer cus = new Customer
            {

                PostNum = cb_post.SelectedValue.ToString().Substring(0,5),
                Name = txtName.Text,
                LastName = txtLast.Text,
                Address = txtStreet.Text,
                Email = txtEmail.Text,
                Number = txtNumber.Text

            };

            return cus;
        }

        private void btnCommit_Click(object sender, EventArgs e)
        {

            if (AreRequiredTextboxesEmpty())
            {
                MessageBox.Show("Täytä kaikki tiedot!");
                return;
            }
            else
            {
                Customer cus = CreateCustomer();
                if (cus != null)
                {
                    CustomerDAO customerDAO = new CustomerDAO();
                    int newRows = customerDAO.AddCustomer(cus);

                    if (newRows >= 1)
                    {
                        ClearTextBoxes();
                        LoadCustomer();
                        MessageBox.Show("Lisäys onnistui");
                    }
                    else
                    {
                        MessageBox.Show("Lisäys epäonnistui");
                    }
                }
            }

            

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            bool isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Frm_customers_edit")
                {
                    isopen = true;
                    f.BringToFront();
                    break;
                }
            }
            if (isopen == false)
            {
                Form muokkaus = new Frm_customers_edit();
                muokkaus.Show();
            }

        }
        private void LoadCustomer()
        {
            CustomerDAO customerDAO = new CustomerDAO();
            customerBS.DataSource = customerDAO.GetAllCustomer();
            dgv_customer.DataSource = customerBS;
        }
        private void btnPoista_Click(object sender, EventArgs e)
        {
            int selectedPersonID = Convert.ToInt32(dgv_customer.SelectedRows[0].Cells["ID"].Value);

            CustomerDAO customerDAO = new CustomerDAO();
            int removedRows = customerDAO.DeleteCustomer(selectedPersonID);





            if (removedRows > 0)
            {
                LoadCustomer();
                MessageBox.Show("Poisto onnistui.");
                dgv_customer.ClearSelection();
            }
            else
            {
                MessageBox.Show("Poisto epäonnistui!", "Virhe!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (txtName.Text.Length >= 20)
            {
                txtName.Text = txtName.Text.Substring(0, 20);
                toolTipCustomer.SetToolTip(txtName, "Vain 20 merkin pituinen nimi on sallittu.");
            }
            else
            {
                toolTipCustomer.SetToolTip(txtName, "");
            }
        }

        private void txtLast_TextChanged(object sender, EventArgs e)
        {
            if (txtLast.Text.Length >= 40)
            {
                txtLast.Text = txtLast.Text.Substring(0, 40);
                toolTipCustomer.SetToolTip(txtLast, "Vain 40 merkin pituinen sukunimi on sallittu.");
            }
            else
            {
                toolTipCustomer.SetToolTip(txtLast, "");
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();

            if (email.Length >= 50)
            {
                txtEmail.Text = email.Substring(0, 50);
                toolTipCustomer.SetToolTip(txtEmail, "Vain 50 merkin pituinen sähköpostiosoite on sallittu.");
                txtEmail.Select(txtEmail.Text.Length, 0);
                txtEmail.Focus();
            }
            else if (!IsValidEmail(email))
            {
                toolTipCustomer.SetToolTip(txtEmail, "Virheellinen sähköpostiosoite.");
                txtEmail.Focus();
                txtEmail.Select(txtEmail.Text.Length, 0);
            }
            else
            {
                toolTipCustomer.SetToolTip(txtEmail, "");
            }
        }

        private bool IsValidEmail(string email)
        {
            const string pattern = @"^(?:[^\s@]+@[^\s@]+\.[^\s@]+)?$";
            return Regex.IsMatch(email, pattern);
        }

        private void txtNumber_TextChanged(object sender, EventArgs e)
        {
            if (txtNumber.Text.Length >= 15)
            {
                txtNumber.Text = txtNumber.Text.Substring(0, 15);
                toolTipCustomer.SetToolTip(txtNumber, "Vain 15 numeron pituinen puhelinnumero on sallittu.");
            }
            else
            {
                toolTipCustomer.SetToolTip(txtNumber, "");
            }
        }

        private void txtStreet_TextChanged(object sender, EventArgs e)
        {
            if (txtStreet.Text.Length >= 40)
            {
                txtStreet.Text = txtStreet.Text.Substring(0, 40);
                toolTipCustomer.SetToolTip(txtStreet, "Vain 40 merkin pituinen katuosoite on sallittu.");
            }
            else
            {
                toolTipCustomer.SetToolTip(txtStreet, "");
            }
        }

        private void txtPost_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void txtNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
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

        private void cb_post_SelectedIndexChanged(object sender, EventArgs e)
        {
           // LoadPost();
        }

        private void txtEmail_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string email = txtEmail.Text.Trim();

            if (!IsValidEmail(email))
            {
                toolTipCustomer.SetToolTip(txtEmail, "Virheellinen sähköpostiosoite.");
                txtEmail.Focus();
                txtEmail.SelectAll();
                e.Cancel = true;
            }
            else
            {
                toolTipCustomer.SetToolTip(txtEmail, "");
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            LoadCustomer();
        }
    }
}
