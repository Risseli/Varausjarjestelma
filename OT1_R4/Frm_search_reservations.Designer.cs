namespace OT1_R4
{
    partial class Frm_search_reservations
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
            this.pnl_top = new System.Windows.Forms.Panel();
            this.lbl_title = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.pnl_input = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_search_all = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.pnl_bottom = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnl_top.SuspendLayout();
            this.pnl_input.SuspendLayout();
            this.pnl_bottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_top
            // 
            this.pnl_top.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnl_top.Controls.Add(this.lbl_title);
            this.pnl_top.Controls.Add(this.flowLayoutPanel1);
            this.pnl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_top.Location = new System.Drawing.Point(0, 0);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(394, 50);
            this.pnl_top.TabIndex = 28;
            // 
            // lbl_title
            // 
            this.lbl_title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(90, 9);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(204, 29);
            this.lbl_title.TabIndex = 2;
            this.lbl_title.Text = "Varauksien haku";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(-17, 329);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(699, 84);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // tb_email
            // 
            this.tb_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_email.Location = new System.Drawing.Point(107, 36);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(236, 26);
            this.tb_email.TabIndex = 2;
            // 
            // pnl_input
            // 
            this.pnl_input.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_input.Controls.Add(this.label1);
            this.pnl_input.Controls.Add(this.btn_search_all);
            this.pnl_input.Controls.Add(this.btn_search);
            this.pnl_input.Controls.Add(this.tb_email);
            this.pnl_input.Controls.Add(this.label3);
            this.pnl_input.Location = new System.Drawing.Point(12, 56);
            this.pnl_input.Name = "pnl_input";
            this.pnl_input.Size = new System.Drawing.Size(370, 196);
            this.pnl_input.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "sähköposti";
            // 
            // btn_search_all
            // 
            this.btn_search_all.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_search_all.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_search_all.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search_all.Location = new System.Drawing.Point(105, 150);
            this.btn_search_all.Margin = new System.Windows.Forms.Padding(2);
            this.btn_search_all.Name = "btn_search_all";
            this.btn_search_all.Size = new System.Drawing.Size(217, 30);
            this.btn_search_all.TabIndex = 7;
            this.btn_search_all.Text = "Hae kaikki varaukset";
            this.btn_search_all.UseVisualStyleBackColor = false;
            this.btn_search_all.Click += new System.EventHandler(this.btn_search_all_Click);
            // 
            // btn_search
            // 
            this.btn_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_search.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(105, 107);
            this.btn_search.Margin = new System.Windows.Forms.Padding(2);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(217, 30);
            this.btn_search.TabIndex = 8;
            this.btn_search.Text = "Hae asiakkaan varaukset";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Asiakkaan";
            // 
            // btn_back
            // 
            this.btn_back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_back.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(107, 9);
            this.btn_back.Margin = new System.Windows.Forms.Padding(2);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(166, 30);
            this.btn_back.TabIndex = 9;
            this.btn_back.Text = "Peruuta";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // pnl_bottom
            // 
            this.pnl_bottom.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnl_bottom.Controls.Add(this.btn_back);
            this.pnl_bottom.Controls.Add(this.flowLayoutPanel2);
            this.pnl_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_bottom.Location = new System.Drawing.Point(0, 258);
            this.pnl_bottom.Name = "pnl_bottom";
            this.pnl_bottom.Size = new System.Drawing.Size(394, 50);
            this.pnl_bottom.TabIndex = 29;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Location = new System.Drawing.Point(-17, 329);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(699, 84);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // Frm_search_reservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 308);
            this.Controls.Add(this.pnl_top);
            this.Controls.Add(this.pnl_input);
            this.Controls.Add(this.pnl_bottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Frm_search_reservations";
            this.Text = "Varauksien haku";
            this.Load += new System.EventHandler(this.Frm_search_reservations_Load);
            this.pnl_top.ResumeLayout(false);
            this.pnl_top.PerformLayout();
            this.pnl_input.ResumeLayout(false);
            this.pnl_input.PerformLayout();
            this.pnl_bottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Panel pnl_input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_search_all;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Panel pnl_bottom;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
    }
}