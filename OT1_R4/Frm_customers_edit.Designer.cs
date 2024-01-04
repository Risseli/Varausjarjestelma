
namespace OT1_R4
{
    partial class Frm_customers_edit
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
            this.label6 = new System.Windows.Forms.Label();
            this.txtStreetEdit = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNumberEdit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmailEdit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLastEdit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNameEdit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCommit = new System.Windows.Forms.Button();
            this.dgv_customer_edit = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmail_Edit = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.toolTipCustomerEdit = new System.Windows.Forms.ToolTip(this.components);
            this.pnl_top = new System.Windows.Forms.Panel();
            this.lbl_title = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnl_input = new System.Windows.Forms.Panel();
            this.cb_post = new System.Windows.Forms.ComboBox();
            this.btn_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_customer_edit)).BeginInit();
            this.pnl_top.SuspendLayout();
            this.pnl_input.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 29;
            this.label6.Text = "Osoite";
            // 
            // txtStreetEdit
            // 
            this.txtStreetEdit.Location = new System.Drawing.Point(142, 209);
            this.txtStreetEdit.Name = "txtStreetEdit";
            this.txtStreetEdit.Size = new System.Drawing.Size(239, 20);
            this.txtStreetEdit.TabIndex = 28;
            this.txtStreetEdit.TextChanged += new System.EventHandler(this.txtStreetEdit_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "Puhelinnumero";
            // 
            // txtNumberEdit
            // 
            this.txtNumberEdit.Location = new System.Drawing.Point(142, 163);
            this.txtNumberEdit.Name = "txtNumberEdit";
            this.txtNumberEdit.Size = new System.Drawing.Size(239, 20);
            this.txtNumberEdit.TabIndex = 26;
            this.txtNumberEdit.TextChanged += new System.EventHandler(this.txtNumberEdit_TextChanged);
            this.txtNumberEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumberEdit_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(135, 347);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Sähköposti haku:";
            // 
            // txtEmailEdit
            // 
            this.txtEmailEdit.Location = new System.Drawing.Point(139, 370);
            this.txtEmailEdit.Name = "txtEmailEdit";
            this.txtEmailEdit.Size = new System.Drawing.Size(239, 20);
            this.txtEmailEdit.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Sukunimi";
            // 
            // txtLastEdit
            // 
            this.txtLastEdit.Location = new System.Drawing.Point(142, 117);
            this.txtLastEdit.Name = "txtLastEdit";
            this.txtLastEdit.Size = new System.Drawing.Size(239, 20);
            this.txtLastEdit.TabIndex = 22;
            this.txtLastEdit.TextChanged += new System.EventHandler(this.txtLastEdit_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Nimi";
            // 
            // txtNameEdit
            // 
            this.txtNameEdit.Location = new System.Drawing.Point(142, 71);
            this.txtNameEdit.Name = "txtNameEdit";
            this.txtNameEdit.Size = new System.Drawing.Size(239, 20);
            this.txtNameEdit.TabIndex = 20;
            this.txtNameEdit.TextChanged += new System.EventHandler(this.txtNameEdit_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Postinumero";
            // 
            // btnCommit
            // 
            this.btnCommit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCommit.Location = new System.Drawing.Point(206, 303);
            this.btnCommit.Name = "btnCommit";
            this.btnCommit.Size = new System.Drawing.Size(172, 41);
            this.btnCommit.TabIndex = 30;
            this.btnCommit.Text = "Hae";
            this.btnCommit.UseVisualStyleBackColor = true;
            this.btnCommit.Click += new System.EventHandler(this.btnCommit_Click);
            // 
            // dgv_customer_edit
            // 
            this.dgv_customer_edit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_customer_edit.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_customer_edit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_customer_edit.Location = new System.Drawing.Point(0, 456);
            this.dgv_customer_edit.Name = "dgv_customer_edit";
            this.dgv_customer_edit.RowHeadersWidth = 51;
            this.dgv_customer_edit.Size = new System.Drawing.Size(417, 195);
            this.dgv_customer_edit.TabIndex = 31;
            this.dgv_customer_edit.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_customer_edit_CellClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 20);
            this.label7.TabIndex = 33;
            this.label7.Text = "Sähköposti";
            // 
            // txtEmail_Edit
            // 
            this.txtEmail_Edit.Location = new System.Drawing.Point(142, 255);
            this.txtEmail_Edit.Name = "txtEmail_Edit";
            this.txtEmail_Edit.Size = new System.Drawing.Size(239, 20);
            this.txtEmail_Edit.TabIndex = 32;
            this.txtEmail_Edit.TextChanged += new System.EventHandler(this.txtEmail_Edit_TextChanged);
            this.txtEmail_Edit.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Edit_Validating);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(7, 303);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(172, 41);
            this.btnUpdate.TabIndex = 34;
            this.btnUpdate.Text = "Tallenna";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 362);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 20);
            this.label8.TabIndex = 35;
            this.label8.Text = "ID:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(42, 362);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(19, 20);
            this.lblID.TabIndex = 36;
            this.lblID.Text = "0";
            // 
            // toolTipCustomerEdit
            // 
            this.toolTipCustomerEdit.IsBalloon = true;
            // 
            // pnl_top
            // 
            this.pnl_top.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnl_top.Controls.Add(this.lbl_title);
            this.pnl_top.Controls.Add(this.flowLayoutPanel1);
            this.pnl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_top.Location = new System.Drawing.Point(0, 0);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(417, 47);
            this.pnl_top.TabIndex = 37;
            // 
            // lbl_title
            // 
            this.lbl_title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(62, 7);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(314, 29);
            this.lbl_title.TabIndex = 2;
            this.lbl_title.Text = "Asiakastietojen muokkaus";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(-17, 329);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(699, 84);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // pnl_input
            // 
            this.pnl_input.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_input.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pnl_input.Controls.Add(this.cb_post);
            this.pnl_input.Controls.Add(this.label2);
            this.pnl_input.Controls.Add(this.btnUpdate);
            this.pnl_input.Controls.Add(this.lblID);
            this.pnl_input.Controls.Add(this.label1);
            this.pnl_input.Controls.Add(this.btnCommit);
            this.pnl_input.Controls.Add(this.label4);
            this.pnl_input.Controls.Add(this.label8);
            this.pnl_input.Controls.Add(this.txtEmailEdit);
            this.pnl_input.Controls.Add(this.txtNameEdit);
            this.pnl_input.Controls.Add(this.txtLastEdit);
            this.pnl_input.Controls.Add(this.label7);
            this.pnl_input.Controls.Add(this.label3);
            this.pnl_input.Controls.Add(this.txtEmail_Edit);
            this.pnl_input.Controls.Add(this.txtNumberEdit);
            this.pnl_input.Controls.Add(this.label5);
            this.pnl_input.Controls.Add(this.txtStreetEdit);
            this.pnl_input.Controls.Add(this.label6);
            this.pnl_input.Location = new System.Drawing.Point(12, 53);
            this.pnl_input.Name = "pnl_input";
            this.pnl_input.Size = new System.Drawing.Size(393, 398);
            this.pnl_input.TabIndex = 38;
            // 
            // cb_post
            // 
            this.cb_post.FormattingEnabled = true;
            this.cb_post.Location = new System.Drawing.Point(142, 27);
            this.cb_post.Name = "cb_post";
            this.cb_post.Size = new System.Drawing.Size(100, 21);
            this.cb_post.TabIndex = 37;
            // 
            // btn_back
            // 
            this.btn_back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_back.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(263, 661);
            this.btn_back.Margin = new System.Windows.Forms.Padding(2);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(142, 32);
            this.btn_back.TabIndex = 39;
            this.btn_back.Text = "Palaa";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // Frm_customers_edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(417, 704);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.pnl_input);
            this.Controls.Add(this.pnl_top);
            this.Controls.Add(this.dgv_customer_edit);
            this.Name = "Frm_customers_edit";
            this.Text = "Asiakastietojen muokkaus";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_customer_edit)).EndInit();
            this.pnl_top.ResumeLayout(false);
            this.pnl_top.PerformLayout();
            this.pnl_input.ResumeLayout(false);
            this.pnl_input.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtStreetEdit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNumberEdit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmailEdit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLastEdit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNameEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCommit;
        private System.Windows.Forms.DataGridView dgv_customer_edit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEmail_Edit;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.ToolTip toolTipCustomerEdit;
        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel pnl_input;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.ComboBox cb_post;
    }
}