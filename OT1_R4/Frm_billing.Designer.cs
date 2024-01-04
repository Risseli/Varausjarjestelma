namespace OT1_R4
{
    partial class Frm_billing
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
            this.pnl_top = new System.Windows.Forms.Panel();
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_logo = new System.Windows.Forms.Label();
            this.pnl_bottom = new System.Windows.Forms.Panel();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.dgv_bills = new System.Windows.Forms.DataGridView();
            this.pnl_buttons = new System.Windows.Forms.Panel();
            this.btn_search_reservations = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_paper_bill = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_delete_bill = new System.Windows.Forms.Button();
            this.btn_edit_bill = new System.Windows.Forms.Button();
            this.btn_search_bill = new System.Windows.Forms.Button();
            this.btn_email_bill = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_add_bill = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_reservations = new System.Windows.Forms.DataGridView();
            this.sfd_bill = new System.Windows.Forms.SaveFileDialog();
            this.pnl_top.SuspendLayout();
            this.pnl_bottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bills)).BeginInit();
            this.pnl_buttons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reservations)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_top
            // 
            this.pnl_top.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnl_top.Controls.Add(this.lbl_title);
            this.pnl_top.Controls.Add(this.lbl_logo);
            this.pnl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_top.Location = new System.Drawing.Point(0, 0);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(994, 50);
            this.pnl_top.TabIndex = 25;
            // 
            // lbl_title
            // 
            this.lbl_title.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(354, 9);
            this.lbl_title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(88, 29);
            this.lbl_title.TabIndex = 7;
            this.lbl_title.Text = "Laskut";
            // 
            // lbl_logo
            // 
            this.lbl_logo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_logo.AutoSize = true;
            this.lbl_logo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_logo.Location = new System.Drawing.Point(739, 9);
            this.lbl_logo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_logo.Name = "lbl_logo";
            this.lbl_logo.Size = new System.Drawing.Size(243, 29);
            this.lbl_logo.TabIndex = 6;
            this.lbl_logo.Text = "Village Newbies Oy";
            // 
            // pnl_bottom
            // 
            this.pnl_bottom.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnl_bottom.Controls.Add(this.btn_back);
            this.pnl_bottom.Controls.Add(this.btn_close);
            this.pnl_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_bottom.Location = new System.Drawing.Point(0, 652);
            this.pnl_bottom.Name = "pnl_bottom";
            this.pnl_bottom.Size = new System.Drawing.Size(994, 50);
            this.pnl_bottom.TabIndex = 26;
            // 
            // btn_back
            // 
            this.btn_back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_back.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(841, 7);
            this.btn_back.Margin = new System.Windows.Forms.Padding(2);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(142, 32);
            this.btn_back.TabIndex = 8;
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
            this.btn_close.TabIndex = 9;
            this.btn_close.Text = "Sulje Ohjelma";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // dgv_bills
            // 
            this.dgv_bills.AllowUserToAddRows = false;
            this.dgv_bills.AllowUserToDeleteRows = false;
            this.dgv_bills.AllowUserToResizeRows = false;
            this.dgv_bills.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_bills.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_bills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_bills.Location = new System.Drawing.Point(239, 399);
            this.dgv_bills.MultiSelect = false;
            this.dgv_bills.Name = "dgv_bills";
            this.dgv_bills.ReadOnly = true;
            this.dgv_bills.RowHeadersVisible = false;
            this.dgv_bills.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_bills.Size = new System.Drawing.Size(744, 240);
            this.dgv_bills.StandardTab = true;
            this.dgv_bills.TabIndex = 27;
            this.dgv_bills.TabStop = false;
            this.dgv_bills.SelectionChanged += new System.EventHandler(this.dgv_bills_SelectionChanged);
            // 
            // pnl_buttons
            // 
            this.pnl_buttons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnl_buttons.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnl_buttons.Controls.Add(this.btn_search_reservations);
            this.pnl_buttons.Controls.Add(this.label3);
            this.pnl_buttons.Controls.Add(this.btn_paper_bill);
            this.pnl_buttons.Controls.Add(this.label10);
            this.pnl_buttons.Controls.Add(this.btn_delete_bill);
            this.pnl_buttons.Controls.Add(this.btn_edit_bill);
            this.pnl_buttons.Controls.Add(this.btn_search_bill);
            this.pnl_buttons.Controls.Add(this.btn_email_bill);
            this.pnl_buttons.Controls.Add(this.label9);
            this.pnl_buttons.Controls.Add(this.btn_add_bill);
            this.pnl_buttons.Location = new System.Drawing.Point(11, 56);
            this.pnl_buttons.Name = "pnl_buttons";
            this.pnl_buttons.Size = new System.Drawing.Size(192, 590);
            this.pnl_buttons.TabIndex = 28;
            // 
            // btn_search_reservations
            // 
            this.btn_search_reservations.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_search_reservations.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_search_reservations.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search_reservations.Location = new System.Drawing.Point(35, 53);
            this.btn_search_reservations.Name = "btn_search_reservations";
            this.btn_search_reservations.Size = new System.Drawing.Size(127, 51);
            this.btn_search_reservations.TabIndex = 1;
            this.btn_search_reservations.Text = "Hae varauksia";
            this.btn_search_reservations.UseVisualStyleBackColor = false;
            this.btn_search_reservations.Click += new System.EventHandler(this.btn_search_reservations_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 24);
            this.label3.TabIndex = 29;
            this.label3.Text = "Varaukset";
            // 
            // btn_paper_bill
            // 
            this.btn_paper_bill.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_paper_bill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_paper_bill.Location = new System.Drawing.Point(35, 509);
            this.btn_paper_bill.Name = "btn_paper_bill";
            this.btn_paper_bill.Size = new System.Drawing.Size(127, 51);
            this.btn_paper_bill.TabIndex = 7;
            this.btn_paper_bill.Text = "Paperilasku";
            this.btn_paper_bill.UseVisualStyleBackColor = false;
            this.btn_paper_bill.Click += new System.EventHandler(this.btn_paper_bill_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(13, 416);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 24);
            this.label10.TabIndex = 27;
            this.label10.Text = "Tulosta lasku";
            // 
            // btn_delete_bill
            // 
            this.btn_delete_bill.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_delete_bill.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_delete_bill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete_bill.Location = new System.Drawing.Point(35, 348);
            this.btn_delete_bill.Name = "btn_delete_bill";
            this.btn_delete_bill.Size = new System.Drawing.Size(127, 38);
            this.btn_delete_bill.TabIndex = 5;
            this.btn_delete_bill.Text = "Poista";
            this.btn_delete_bill.UseVisualStyleBackColor = false;
            this.btn_delete_bill.Click += new System.EventHandler(this.btn_delete_bill_Click);
            // 
            // btn_edit_bill
            // 
            this.btn_edit_bill.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_edit_bill.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_edit_bill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit_bill.Location = new System.Drawing.Point(35, 278);
            this.btn_edit_bill.Name = "btn_edit_bill";
            this.btn_edit_bill.Size = new System.Drawing.Size(127, 54);
            this.btn_edit_bill.TabIndex = 4;
            this.btn_edit_bill.Text = "Maksettu /   Ei maksettu";
            this.btn_edit_bill.UseVisualStyleBackColor = false;
            this.btn_edit_bill.Click += new System.EventHandler(this.btn_edit_bill_Click);
            // 
            // btn_search_bill
            // 
            this.btn_search_bill.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_search_bill.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_search_bill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search_bill.Location = new System.Drawing.Point(35, 169);
            this.btn_search_bill.Name = "btn_search_bill";
            this.btn_search_bill.Size = new System.Drawing.Size(127, 38);
            this.btn_search_bill.TabIndex = 2;
            this.btn_search_bill.Text = "Hae laskuja";
            this.btn_search_bill.UseVisualStyleBackColor = false;
            this.btn_search_bill.Click += new System.EventHandler(this.btn_search_bill_Click);
            // 
            // btn_email_bill
            // 
            this.btn_email_bill.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_email_bill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_email_bill.Location = new System.Drawing.Point(35, 452);
            this.btn_email_bill.Name = "btn_email_bill";
            this.btn_email_bill.Size = new System.Drawing.Size(127, 51);
            this.btn_email_bill.TabIndex = 6;
            this.btn_email_bill.Text = "Sähköposti- lasku";
            this.btn_email_bill.UseVisualStyleBackColor = false;
            this.btn_email_bill.Click += new System.EventHandler(this.btn_email_bill_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 131);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 24);
            this.label9.TabIndex = 23;
            this.label9.Text = "Lasku";
            // 
            // btn_add_bill
            // 
            this.btn_add_bill.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_add_bill.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_add_bill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_bill.Location = new System.Drawing.Point(35, 224);
            this.btn_add_bill.Name = "btn_add_bill";
            this.btn_add_bill.Size = new System.Drawing.Size(127, 38);
            this.btn_add_bill.TabIndex = 3;
            this.btn_add_bill.Text = "Luo lasku";
            this.btn_add_bill.UseVisualStyleBackColor = false;
            this.btn_add_bill.Click += new System.EventHandler(this.btn_add_bill_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(235, 359);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 24);
            this.label1.TabIndex = 28;
            this.label1.Text = "Laskut";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(235, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 24);
            this.label2.TabIndex = 30;
            this.label2.Text = "Varaukset";
            // 
            // dgv_reservations
            // 
            this.dgv_reservations.AllowUserToAddRows = false;
            this.dgv_reservations.AllowUserToDeleteRows = false;
            this.dgv_reservations.AllowUserToResizeRows = false;
            this.dgv_reservations.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_reservations.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_reservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_reservations.Location = new System.Drawing.Point(239, 85);
            this.dgv_reservations.MultiSelect = false;
            this.dgv_reservations.Name = "dgv_reservations";
            this.dgv_reservations.ReadOnly = true;
            this.dgv_reservations.RowHeadersVisible = false;
            this.dgv_reservations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_reservations.Size = new System.Drawing.Size(744, 258);
            this.dgv_reservations.StandardTab = true;
            this.dgv_reservations.TabIndex = 29;
            this.dgv_reservations.TabStop = false;
            this.dgv_reservations.SelectionChanged += new System.EventHandler(this.dgv_reservations_SelectionChanged);
            // 
            // sfd_bill
            // 
            this.sfd_bill.DefaultExt = "pdf";
            // 
            // Frm_billing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 702);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_reservations);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnl_buttons);
            this.Controls.Add(this.dgv_bills);
            this.Controls.Add(this.pnl_bottom);
            this.Controls.Add(this.pnl_top);
            this.MinimumSize = new System.Drawing.Size(1010, 740);
            this.Name = "Frm_billing";
            this.Text = "Laskujen hallinta";
            this.pnl_top.ResumeLayout(false);
            this.pnl_top.PerformLayout();
            this.pnl_bottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bills)).EndInit();
            this.pnl_buttons.ResumeLayout(false);
            this.pnl_buttons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reservations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_logo;
        private System.Windows.Forms.Panel pnl_bottom;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.DataGridView dgv_bills;
        private System.Windows.Forms.Panel pnl_buttons;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_delete_bill;
        private System.Windows.Forms.Button btn_edit_bill;
        private System.Windows.Forms.Button btn_search_bill;
        private System.Windows.Forms.Button btn_email_bill;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_add_bill;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_reservations;
        private System.Windows.Forms.Button btn_paper_bill;
        private System.Windows.Forms.Button btn_search_reservations;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.SaveFileDialog sfd_bill;
    }
}