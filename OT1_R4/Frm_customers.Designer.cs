namespace OT1_R4
{
    partial class Frm_customers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Button btnEdit;
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLast = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.btnCommit = new System.Windows.Forms.Button();
            this.pnl_top = new System.Windows.Forms.Panel();
            this.lbl_logo = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.dgv_customer = new System.Windows.Forms.DataGridView();
            this.toolTipCustomer = new System.Windows.Forms.ToolTip(this.components);
            this.btnPoista = new System.Windows.Forms.Button();
            this.pnl_bottom = new System.Windows.Forms.Panel();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.pnl_buttons = new System.Windows.Forms.Panel();
            this.pnl_input = new System.Windows.Forms.Panel();
            this.cb_post = new System.Windows.Forms.ComboBox();
            this.btn_update = new System.Windows.Forms.Button();
            btnEdit = new System.Windows.Forms.Button();
            this.pnl_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_customer)).BeginInit();
            this.pnl_bottom.SuspendLayout();
            this.pnl_buttons.SuspendLayout();
            this.pnl_input.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            btnEdit.BackColor = System.Drawing.SystemColors.ButtonFace;
            btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnEdit.Location = new System.Drawing.Point(50, 96);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new System.Drawing.Size(123, 37);
            btnEdit.TabIndex = 19;
            btnEdit.Text = "Muokkaus";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Postinumero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nimi";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(168, 60);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(198, 20);
            this.txtName.TabIndex = 8;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Sukunimi";
            // 
            // txtLast
            // 
            this.txtLast.Location = new System.Drawing.Point(168, 106);
            this.txtLast.Name = "txtLast";
            this.txtLast.Size = new System.Drawing.Size(198, 20);
            this.txtLast.TabIndex = 10;
            this.txtLast.TextChanged += new System.EventHandler(this.txtLast_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Sähköposti";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(168, 152);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(198, 20);
            this.txtEmail.TabIndex = 12;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Puhelinnumero";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(168, 198);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(198, 20);
            this.txtNumber.TabIndex = 14;
            this.txtNumber.TextChanged += new System.EventHandler(this.txtNumber_TextChanged);
            this.txtNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumber_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Osoite";
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(168, 244);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(198, 20);
            this.txtStreet.TabIndex = 16;
            this.txtStreet.TextChanged += new System.EventHandler(this.txtStreet_TextChanged);
            // 
            // btnCommit
            // 
            this.btnCommit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCommit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCommit.Location = new System.Drawing.Point(48, 11);
            this.btnCommit.Name = "btnCommit";
            this.btnCommit.Size = new System.Drawing.Size(125, 69);
            this.btnCommit.TabIndex = 20;
            this.btnCommit.Text = "Lisää";
            this.btnCommit.UseVisualStyleBackColor = false;
            this.btnCommit.Click += new System.EventHandler(this.btnCommit_Click);
            // 
            // pnl_top
            // 
            this.pnl_top.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnl_top.Controls.Add(this.lbl_logo);
            this.pnl_top.Controls.Add(this.lbl_title);
            this.pnl_top.Controls.Add(this.flowLayoutPanel1);
            this.pnl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_top.Location = new System.Drawing.Point(0, 0);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(1223, 50);
            this.pnl_top.TabIndex = 21;
            // 
            // lbl_logo
            // 
            this.lbl_logo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_logo.AutoSize = true;
            this.lbl_logo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_logo.Location = new System.Drawing.Point(1016, 9);
            this.lbl_logo.Name = "lbl_logo";
            this.lbl_logo.Size = new System.Drawing.Size(204, 29);
            this.lbl_logo.TabIndex = 3;
            this.lbl_logo.Text = "Village Newbies";
            // 
            // lbl_title
            // 
            this.lbl_title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(12, 9);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(124, 29);
            this.lbl_title.TabIndex = 2;
            this.lbl_title.Text = "Asiakkaat";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(-17, 329);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(699, 84);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // dgv_customer
            // 
            this.dgv_customer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_customer.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_customer.Location = new System.Drawing.Point(620, 55);
            this.dgv_customer.Name = "dgv_customer";
            this.dgv_customer.RowHeadersWidth = 51;
            this.dgv_customer.Size = new System.Drawing.Size(592, 564);
            this.dgv_customer.TabIndex = 22;
            // 
            // toolTipCustomer
            // 
            this.toolTipCustomer.IsBalloon = true;
            // 
            // btnPoista
            // 
            this.btnPoista.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPoista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPoista.Location = new System.Drawing.Point(50, 150);
            this.btnPoista.Name = "btnPoista";
            this.btnPoista.Size = new System.Drawing.Size(123, 40);
            this.btnPoista.TabIndex = 26;
            this.btnPoista.Text = "Poista";
            this.btnPoista.UseVisualStyleBackColor = false;
            this.btnPoista.Click += new System.EventHandler(this.btnPoista_Click);
            // 
            // pnl_bottom
            // 
            this.pnl_bottom.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnl_bottom.Controls.Add(this.btn_back);
            this.pnl_bottom.Controls.Add(this.btn_close);
            this.pnl_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_bottom.Location = new System.Drawing.Point(0, 496);
            this.pnl_bottom.Name = "pnl_bottom";
            this.pnl_bottom.Size = new System.Drawing.Size(1223, 50);
            this.pnl_bottom.TabIndex = 27;
            // 
            // btn_back
            // 
            this.btn_back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_back.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(1070, 7);
            this.btn_back.Margin = new System.Windows.Forms.Padding(2);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(142, 32);
            this.btn_back.TabIndex = 15;
            this.btn_back.Text = "Palaa";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_close.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.Location = new System.Drawing.Point(11, 7);
            this.btn_close.Margin = new System.Windows.Forms.Padding(2);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(142, 32);
            this.btn_close.TabIndex = 16;
            this.btn_close.Text = "Sulje Ohjelma";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // pnl_buttons
            // 
            this.pnl_buttons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnl_buttons.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnl_buttons.Controls.Add(this.btn_update);
            this.pnl_buttons.Controls.Add(this.btnPoista);
            this.pnl_buttons.Controls.Add(this.btnCommit);
            this.pnl_buttons.Controls.Add(btnEdit);
            this.pnl_buttons.Location = new System.Drawing.Point(11, 58);
            this.pnl_buttons.Name = "pnl_buttons";
            this.pnl_buttons.Size = new System.Drawing.Size(213, 431);
            this.pnl_buttons.TabIndex = 28;
            // 
            // pnl_input
            // 
            this.pnl_input.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnl_input.Controls.Add(this.cb_post);
            this.pnl_input.Controls.Add(this.txtLast);
            this.pnl_input.Controls.Add(this.label1);
            this.pnl_input.Controls.Add(this.txtName);
            this.pnl_input.Controls.Add(this.label2);
            this.pnl_input.Controls.Add(this.label3);
            this.pnl_input.Controls.Add(this.txtEmail);
            this.pnl_input.Controls.Add(this.label4);
            this.pnl_input.Controls.Add(this.label6);
            this.pnl_input.Controls.Add(this.txtNumber);
            this.pnl_input.Controls.Add(this.txtStreet);
            this.pnl_input.Controls.Add(this.label5);
            this.pnl_input.Location = new System.Drawing.Point(234, 56);
            this.pnl_input.Name = "pnl_input";
            this.pnl_input.Size = new System.Drawing.Size(380, 434);
            this.pnl_input.TabIndex = 29;
            // 
            // cb_post
            // 
            this.cb_post.FormattingEnabled = true;
            this.cb_post.Location = new System.Drawing.Point(168, 12);
            this.cb_post.Name = "cb_post";
            this.cb_post.Size = new System.Drawing.Size(198, 21);
            this.cb_post.TabIndex = 26;
            this.cb_post.SelectedIndexChanged += new System.EventHandler(this.cb_post_SelectedIndexChanged);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(6, 377);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(204, 40);
            this.btn_update.TabIndex = 27;
            this.btn_update.Text = "Päivitä";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // Frm_customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1223, 546);
            this.Controls.Add(this.pnl_input);
            this.Controls.Add(this.pnl_buttons);
            this.Controls.Add(this.pnl_bottom);
            this.Controls.Add(this.dgv_customer);
            this.Controls.Add(this.pnl_top);
            this.Name = "Frm_customers";
            this.Text = "Asiakkaiden hallinta";
            this.Load += new System.EventHandler(this.Frm_customers_Load);
            this.pnl_top.ResumeLayout(false);
            this.pnl_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_customer)).EndInit();
            this.pnl_bottom.ResumeLayout(false);
            this.pnl_buttons.ResumeLayout(false);
            this.pnl_input.ResumeLayout(false);
            this.pnl_input.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLast;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.Button btnCommit;
        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridView dgv_customer;
        private System.Windows.Forms.Label lbl_logo;
        private System.Windows.Forms.ToolTip toolTipCustomer;
        private System.Windows.Forms.Button btnPoista;
        private System.Windows.Forms.Panel pnl_bottom;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Panel pnl_buttons;
        private System.Windows.Forms.Panel pnl_input;
        private System.Windows.Forms.ComboBox cb_post;
        private System.Windows.Forms.Button btn_update;
    }
}