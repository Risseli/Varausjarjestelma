using System;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace OT1_R4
{
    public partial class Frm_customers_edit : Form
    {
        BindingSource customerBS = new BindingSource();
        List<Post> PostList = new List<Post>();
        public Frm_customers_edit()
        {

            InitializeComponent();
            LoadCustomer();
            LoadPost();
            dgv_customer_edit.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btnCommit_Click(object sender, EventArgs e)
        {
            string email = txtEmailEdit.Text;
            CustomerDAO customerDAO = new CustomerDAO();
            customerBS.DataSource = customerDAO.GetCustomerByEmail(email);
            dgv_customer_edit.DataSource = customerBS;

            if (dgv_customer_edit.RowCount == 1)
            {
                MessageBox.Show("Ei ole asiakasta tällä sähköpostilla", "Tarkista oikein kirjoitus", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

  

        }
        private void LoadCustomer()
        {
            CustomerDAO customerDAO = new CustomerDAO();
            customerBS.DataSource = customerDAO.GetAllCustomer();
            dgv_customer_edit.DataSource = customerBS;
        }
        private void LoadPost()
        {
            PostDAO postDAO = new PostDAO();
            List<Post> posts = postDAO.GetAllPost();

            cb_post.DataSource = posts;
            cb_post.DisplayMember = "FullPost";
            cb_post.ValueMember = "Postn";

        }
        private bool CheckTextBoxesNotEmpty(params (TextBox textBox, string name)[] textBoxes)
        {
            foreach (var (textBox, name) in textBoxes)
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    string message = $"\"{name}\" is empty";
                    MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            return true;
        }
        private Customer CreateCustomer()
        {


            Customer cus = new Customer
            {

                PostNum = cb_post.SelectedValue.ToString().Substring(0, 5),
                Name = txtNameEdit.Text,
                LastName = txtLastEdit.Text,
                Address = txtStreetEdit.Text,
                Email = txtEmail_Edit.Text,
                Number = txtNumberEdit.Text

            };

            return cus;
        }

        private void dgv_customer_edit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_customer_edit.Rows[e.RowIndex];
                txtEmail_Edit.Text = row.Cells["Email"].Value.ToString();
                txtLastEdit.Text = row.Cells["LastName"].Value.ToString();
                txtNameEdit.Text = row.Cells["Name"].Value.ToString();
                txtNumberEdit.Text = row.Cells["Number"].Value.ToString();
                cb_post.Text = row.Cells["PostNum"].Value.ToString();
                txtStreetEdit.Text = row.Cells["Address"].Value.ToString();
                lblID.Text = row.Cells["ID"].Value.ToString();


            }
        }
        private void ClearAllTextBoxes()
        {
            txtEmail_Edit.Text = "";
            txtLastEdit.Text = "";
            txtNameEdit.Text = "";
            txtNumberEdit.Text = "";
            txtStreetEdit.Text = "";

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            CheckTextBoxesNotEmpty();
            int id = int.Parse(lblID.Text);
            
            
            if(CheckTextBoxesNotEmpty()==true)
            {
                Customer cus = CreateCustomer();
                if (cus != null)
                {
                    cus.ID = id;

                    CustomerDAO customerDAO = new CustomerDAO();


                    int newRows = customerDAO.EditCustomer(cus);

                    if (newRows >= 1)
                    {


                        LoadCustomer();
                        dgv_customer_edit.ClearSelection();
                        MessageBox.Show("Muokkaus onnistui!", "Onnistui!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ClearAllTextBoxes();
                    }
                }
                else
                {
                    MessageBox.Show("Muokkaus epäonnistui!", "Virhe!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtNameEdit_TextChanged(object sender, EventArgs e)
        {
            if (txtNameEdit.Text.Length >= 20)
            {
                txtNameEdit.Text = txtNameEdit.Text.Substring(0, 20);
                toolTipCustomerEdit.SetToolTip(txtNameEdit, "Vain 20 merkin pituinen nimi on sallittu.");
            }
            else
            {
                toolTipCustomerEdit.SetToolTip(txtNameEdit, "");
            }
        }

        private void txtLastEdit_TextChanged(object sender, EventArgs e)
        {
            if (txtLastEdit.Text.Length >= 40)
            {
                txtLastEdit.Text = txtLastEdit.Text.Substring(0, 40);
                toolTipCustomerEdit.SetToolTip(txtLastEdit, "Vain 40 merkin pituinen sukunimi on sallittu.");
            }
            else
            {
                toolTipCustomerEdit.SetToolTip(txtLastEdit, "");
            }
        }

        private void txtEmail_Edit_TextChanged(object sender, EventArgs e)
        {
            string email = txtEmailEdit.Text.Trim();

            if (email.Length >= 50)
            {
                txtEmailEdit.Text = email.Substring(0, 50);
                toolTipCustomerEdit.SetToolTip(txtEmailEdit, "Vain 50 merkin pituinen sähköpostiosoite on sallittu.");
                txtEmail_Edit.Focus();
            }
            else if (!IsValidEmail(email))
            {
                toolTipCustomerEdit.SetToolTip(txtEmailEdit, "Virheellinen sähköpostiosoite.");
                txtEmail_Edit.Focus();
            }
            else
            {
                toolTipCustomerEdit.SetToolTip(txtEmailEdit, "");
            }
        }

        private bool IsValidEmail(string email)
        {
            const string pattern = @"^(?:[^\s@]+@[^\s@]+\.[^\s@]+)?$";
            return Regex.IsMatch(email, pattern);
        }
        private void txtNumberEdit_TextChanged(object sender, EventArgs e)
        {
            if (txtNumberEdit.Text.Length >= 15)
            {
                txtNumberEdit.Text = txtNumberEdit.Text.Substring(0, 15);
                toolTipCustomerEdit.SetToolTip(txtNumberEdit, "Vain 15 numeron pituinen puhelinnumero on sallittu.");
            }
            else
            {
                toolTipCustomerEdit.SetToolTip(txtNumberEdit, "");
            }
        }

        private void txtStreetEdit_TextChanged(object sender, EventArgs e)
        {
            if (txtStreetEdit.Text.Length >= 40)
            {
                txtStreetEdit.Text = txtStreetEdit.Text.Substring(0, 40);
                toolTipCustomerEdit.SetToolTip(txtStreetEdit, "Vain 40 merkin pituinen katuosoite on sallittu.");
            }
            else
            {
                toolTipCustomerEdit.SetToolTip(txtStreetEdit, "");
            }
        }

        private void txtPostEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void txtNumberEdit_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtEmail_Edit_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string email = txtEmail_Edit.Text.Trim();

            if (!IsValidEmail(email))
            {
                toolTipCustomerEdit.SetToolTip(txtEmail_Edit, "Virheellinen sähköpostiosoite.");
                txtEmail_Edit.Focus();
                txtEmail_Edit.SelectAll();
                e.Cancel = true;
            }
            else
            {
                toolTipCustomerEdit.SetToolTip(txtEmail_Edit, "");
            }
        }
    }
}


