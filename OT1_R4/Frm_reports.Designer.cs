namespace OT1_R4
{
    partial class Frm_reports
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
            this.cmb_areas_reservations = new System.Windows.Forms.ComboBox();
            this.lbl_reservations = new System.Windows.Forms.Label();
            this.lbl_services = new System.Windows.Forms.Label();
            this.panel_left = new System.Windows.Forms.Panel();
            this.gb_services = new System.Windows.Forms.GroupBox();
            this.btn_search_services = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_services_endTime = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_services_startTime = new System.Windows.Forms.DateTimePicker();
            this.cmb_areas_services = new System.Windows.Forms.ComboBox();
            this.gb_reservations = new System.Windows.Forms.GroupBox();
            this.btn_search_reservations = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_reservations_endTime = new System.Windows.Forms.DateTimePicker();
            this.dtp_reservations_startTime = new System.Windows.Forms.DateTimePicker();
            this.panel_up = new System.Windows.Forms.Panel();
            this.lbl_newbies = new System.Windows.Forms.Label();
            this.dgv_reservations = new System.Windows.Forms.DataGridView();
            this.dgv_services = new System.Windows.Forms.DataGridView();
            this.panel_right = new System.Windows.Forms.Panel();
            this.btn_print_services = new System.Windows.Forms.Button();
            this.btn_print_reservations = new System.Windows.Forms.Button();
            this.panel_bottom = new System.Windows.Forms.Panel();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.panel_left.SuspendLayout();
            this.gb_services.SuspendLayout();
            this.gb_reservations.SuspendLayout();
            this.panel_up.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reservations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_services)).BeginInit();
            this.panel_right.SuspendLayout();
            this.panel_bottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmb_areas_reservations
            // 
            this.cmb_areas_reservations.FormattingEnabled = true;
            this.cmb_areas_reservations.Location = new System.Drawing.Point(134, 62);
            this.cmb_areas_reservations.Name = "cmb_areas_reservations";
            this.cmb_areas_reservations.Size = new System.Drawing.Size(121, 28);
            this.cmb_areas_reservations.TabIndex = 0;
            // 
            // lbl_reservations
            // 
            this.lbl_reservations.AutoSize = true;
            this.lbl_reservations.Location = new System.Drawing.Point(58, 62);
            this.lbl_reservations.Name = "lbl_reservations";
            this.lbl_reservations.Size = new System.Drawing.Size(45, 20);
            this.lbl_reservations.TabIndex = 1;
            this.lbl_reservations.Text = "Alue:";
            // 
            // lbl_services
            // 
            this.lbl_services.AutoSize = true;
            this.lbl_services.Location = new System.Drawing.Point(32, 122);
            this.lbl_services.Name = "lbl_services";
            this.lbl_services.Size = new System.Drawing.Size(77, 20);
            this.lbl_services.TabIndex = 3;
            this.lbl_services.Text = "Alku pvm:";
            // 
            // panel_left
            // 
            this.panel_left.Controls.Add(this.gb_services);
            this.panel_left.Controls.Add(this.gb_reservations);
            this.panel_left.Location = new System.Drawing.Point(2, 75);
            this.panel_left.Name = "panel_left";
            this.panel_left.Size = new System.Drawing.Size(372, 672);
            this.panel_left.TabIndex = 4;
            // 
            // gb_services
            // 
            this.gb_services.Controls.Add(this.btn_search_services);
            this.gb_services.Controls.Add(this.label1);
            this.gb_services.Controls.Add(this.label2);
            this.gb_services.Controls.Add(this.dtp_services_endTime);
            this.gb_services.Controls.Add(this.label4);
            this.gb_services.Controls.Add(this.dtp_services_startTime);
            this.gb_services.Controls.Add(this.cmb_areas_services);
            this.gb_services.Location = new System.Drawing.Point(3, 331);
            this.gb_services.Name = "gb_services";
            this.gb_services.Size = new System.Drawing.Size(366, 338);
            this.gb_services.TabIndex = 9;
            this.gb_services.TabStop = false;
            this.gb_services.Text = "Palvelut";
            // 
            // btn_search_services
            // 
            this.btn_search_services.Location = new System.Drawing.Point(134, 229);
            this.btn_search_services.Name = "btn_search_services";
            this.btn_search_services.Size = new System.Drawing.Size(110, 43);
            this.btn_search_services.TabIndex = 8;
            this.btn_search_services.Text = "Hae";
            this.btn_search_services.UseVisualStyleBackColor = true;
            this.btn_search_services.Click += new System.EventHandler(this.btn_search_services_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Loppu pvm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Alue:";
            // 
            // dtp_services_endTime
            // 
            this.dtp_services_endTime.Location = new System.Drawing.Point(134, 183);
            this.dtp_services_endTime.Name = "dtp_services_endTime";
            this.dtp_services_endTime.Size = new System.Drawing.Size(222, 26);
            this.dtp_services_endTime.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Alku pvm:";
            // 
            // dtp_services_startTime
            // 
            this.dtp_services_startTime.Location = new System.Drawing.Point(134, 125);
            this.dtp_services_startTime.Name = "dtp_services_startTime";
            this.dtp_services_startTime.Size = new System.Drawing.Size(222, 26);
            this.dtp_services_startTime.TabIndex = 6;
            // 
            // cmb_areas_services
            // 
            this.cmb_areas_services.FormattingEnabled = true;
            this.cmb_areas_services.Location = new System.Drawing.Point(134, 62);
            this.cmb_areas_services.Name = "cmb_areas_services";
            this.cmb_areas_services.Size = new System.Drawing.Size(121, 28);
            this.cmb_areas_services.TabIndex = 5;
            // 
            // gb_reservations
            // 
            this.gb_reservations.Controls.Add(this.btn_search_reservations);
            this.gb_reservations.Controls.Add(this.label3);
            this.gb_reservations.Controls.Add(this.dtp_reservations_endTime);
            this.gb_reservations.Controls.Add(this.dtp_reservations_startTime);
            this.gb_reservations.Controls.Add(this.cmb_areas_reservations);
            this.gb_reservations.Controls.Add(this.lbl_reservations);
            this.gb_reservations.Controls.Add(this.lbl_services);
            this.gb_reservations.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_reservations.Location = new System.Drawing.Point(3, 17);
            this.gb_reservations.Name = "gb_reservations";
            this.gb_reservations.Size = new System.Drawing.Size(366, 308);
            this.gb_reservations.TabIndex = 8;
            this.gb_reservations.TabStop = false;
            this.gb_reservations.Text = "Varaukset";
            // 
            // btn_search_reservations
            // 
            this.btn_search_reservations.Location = new System.Drawing.Point(134, 228);
            this.btn_search_reservations.Name = "btn_search_reservations";
            this.btn_search_reservations.Size = new System.Drawing.Size(110, 43);
            this.btn_search_reservations.TabIndex = 3;
            this.btn_search_reservations.Text = "Hae";
            this.btn_search_reservations.UseVisualStyleBackColor = true;
            this.btn_search_reservations.Click += new System.EventHandler(this.btn_search_reservations_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Loppu pvm:";
            // 
            // dtp_reservations_endTime
            // 
            this.dtp_reservations_endTime.Location = new System.Drawing.Point(134, 177);
            this.dtp_reservations_endTime.Name = "dtp_reservations_endTime";
            this.dtp_reservations_endTime.Size = new System.Drawing.Size(222, 26);
            this.dtp_reservations_endTime.TabIndex = 2;
            // 
            // dtp_reservations_startTime
            // 
            this.dtp_reservations_startTime.Location = new System.Drawing.Point(134, 118);
            this.dtp_reservations_startTime.Name = "dtp_reservations_startTime";
            this.dtp_reservations_startTime.Size = new System.Drawing.Size(222, 26);
            this.dtp_reservations_startTime.TabIndex = 1;
            // 
            // panel_up
            // 
            this.panel_up.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel_up.Controls.Add(this.lbl_newbies);
            this.panel_up.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_up.Location = new System.Drawing.Point(0, 0);
            this.panel_up.Name = "panel_up";
            this.panel_up.Size = new System.Drawing.Size(1486, 78);
            this.panel_up.TabIndex = 5;
            // 
            // lbl_newbies
            // 
            this.lbl_newbies.AutoSize = true;
            this.lbl_newbies.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_newbies.Location = new System.Drawing.Point(1198, 11);
            this.lbl_newbies.Name = "lbl_newbies";
            this.lbl_newbies.Size = new System.Drawing.Size(259, 37);
            this.lbl_newbies.TabIndex = 0;
            this.lbl_newbies.Text = "Village Newbies";
            // 
            // dgv_reservations
            // 
            this.dgv_reservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_reservations.Location = new System.Drawing.Point(3, 49);
            this.dgv_reservations.Name = "dgv_reservations";
            this.dgv_reservations.RowHeadersWidth = 62;
            this.dgv_reservations.RowTemplate.Height = 28;
            this.dgv_reservations.Size = new System.Drawing.Size(1096, 288);
            this.dgv_reservations.TabIndex = 6;
            // 
            // dgv_services
            // 
            this.dgv_services.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_services.Location = new System.Drawing.Point(3, 392);
            this.dgv_services.Name = "dgv_services";
            this.dgv_services.RowHeadersWidth = 62;
            this.dgv_services.RowTemplate.Height = 28;
            this.dgv_services.Size = new System.Drawing.Size(1102, 280);
            this.dgv_services.TabIndex = 7;
            // 
            // panel_right
            // 
            this.panel_right.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel_right.Controls.Add(this.btn_print_services);
            this.panel_right.Controls.Add(this.dgv_services);
            this.panel_right.Controls.Add(this.btn_print_reservations);
            this.panel_right.Controls.Add(this.dgv_reservations);
            this.panel_right.Location = new System.Drawing.Point(380, 82);
            this.panel_right.Name = "panel_right";
            this.panel_right.Size = new System.Drawing.Size(1106, 666);
            this.panel_right.TabIndex = 7;
            // 
            // btn_print_services
            // 
            this.btn_print_services.Location = new System.Drawing.Point(14, 345);
            this.btn_print_services.Name = "btn_print_services";
            this.btn_print_services.Size = new System.Drawing.Size(174, 42);
            this.btn_print_services.TabIndex = 10;
            this.btn_print_services.Text = "Tulosta palvelut";
            this.btn_print_services.UseVisualStyleBackColor = true;
            this.btn_print_services.Click += new System.EventHandler(this.btn_print_services_Click);
            // 
            // btn_print_reservations
            // 
            this.btn_print_reservations.Location = new System.Drawing.Point(14, 3);
            this.btn_print_reservations.Name = "btn_print_reservations";
            this.btn_print_reservations.Size = new System.Drawing.Size(174, 42);
            this.btn_print_reservations.TabIndex = 9;
            this.btn_print_reservations.Text = "Tulosta varaukset";
            this.btn_print_reservations.UseVisualStyleBackColor = true;
            this.btn_print_reservations.Click += new System.EventHandler(this.btn_print_reservations_Click);
            // 
            // panel_bottom
            // 
            this.panel_bottom.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel_bottom.Controls.Add(this.btn_back);
            this.panel_bottom.Controls.Add(this.btn_close);
            this.panel_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_bottom.Location = new System.Drawing.Point(0, 750);
            this.panel_bottom.Name = "panel_bottom";
            this.panel_bottom.Size = new System.Drawing.Size(1486, 78);
            this.panel_bottom.TabIndex = 8;
            // 
            // btn_back
            // 
            this.btn_back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_back.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(1267, 13);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(213, 49);
            this.btn_back.TabIndex = 18;
            this.btn_back.Text = "Palaa";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.Location = new System.Drawing.Point(7, 13);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(213, 49);
            this.btn_close.TabIndex = 17;
            this.btn_close.Text = "Sulje Ohjelma";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // Frm_reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1486, 828);
            this.Controls.Add(this.panel_bottom);
            this.Controls.Add(this.panel_right);
            this.Controls.Add(this.panel_up);
            this.Controls.Add(this.panel_left);
            this.HelpButton = true;
            this.Name = "Frm_reports";
            this.Text = "Raportointi";
            this.panel_left.ResumeLayout(false);
            this.gb_services.ResumeLayout(false);
            this.gb_services.PerformLayout();
            this.gb_reservations.ResumeLayout(false);
            this.gb_reservations.PerformLayout();
            this.panel_up.ResumeLayout(false);
            this.panel_up.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reservations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_services)).EndInit();
            this.panel_right.ResumeLayout(false);
            this.panel_bottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_areas_reservations;
        private System.Windows.Forms.Label lbl_reservations;
        private System.Windows.Forms.Label lbl_services;
        private System.Windows.Forms.Panel panel_left;
        private System.Windows.Forms.GroupBox gb_services;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_services_endTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_services_startTime;
        private System.Windows.Forms.ComboBox cmb_areas_services;
        private System.Windows.Forms.GroupBox gb_reservations;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp_reservations_endTime;
        private System.Windows.Forms.DateTimePicker dtp_reservations_startTime;
        private System.Windows.Forms.Panel panel_up;
        private System.Windows.Forms.DataGridView dgv_reservations;
        private System.Windows.Forms.DataGridView dgv_services;
        private System.Windows.Forms.Label lbl_newbies;
        private System.Windows.Forms.Panel panel_right;
        private System.Windows.Forms.Panel panel_bottom;
        private System.Windows.Forms.Button btn_search_services;
        private System.Windows.Forms.Button btn_search_reservations;
        private System.Windows.Forms.Button btn_print_services;
        private System.Windows.Forms.Button btn_print_reservations;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_back;
    }
}