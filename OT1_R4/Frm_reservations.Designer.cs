namespace OT1_R4
{
    partial class Frm_reservations
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
            this.panel_up = new System.Windows.Forms.Panel();
            this.lbl_reservation_control = new System.Windows.Forms.Label();
            this.lbl_logo = new System.Windows.Forms.Label();
            this.panel_down = new System.Windows.Forms.Panel();
            this.btn_appexit = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.panel_left = new System.Windows.Forms.Panel();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.btn_servicemenu = new System.Windows.Forms.Button();
            this.btn_newrsv = new System.Windows.Forms.Button();
            this.btn_deletersv = new System.Windows.Forms.Button();
            this.btn_searchrsv = new System.Windows.Forms.Button();
            this.lbl_reservations = new System.Windows.Forms.Label();
            this.dgv_reservations = new System.Windows.Forms.DataGridView();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_startdate = new System.Windows.Forms.Label();
            this.lbl_enddate = new System.Windows.Forms.Label();
            this.lbl_area = new System.Windows.Forms.Label();
            this.lbl_cottages = new System.Windows.Forms.Label();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.dtp_startdate = new System.Windows.Forms.DateTimePicker();
            this.dtp_enddate = new System.Windows.Forms.DateTimePicker();
            this.cb_area = new System.Windows.Forms.ComboBox();
            this.cb_cottages = new System.Windows.Forms.ComboBox();
            this.btn_search_email = new System.Windows.Forms.Button();
            this.lbl_customer = new System.Windows.Forms.Label();
            this.cb_customers = new System.Windows.Forms.ComboBox();
            this.btn_customers = new System.Windows.Forms.Button();
            this.btn_clear_inputs = new System.Windows.Forms.Button();
            this.lbl_res_ID = new System.Windows.Forms.Label();
            this.lbl_ID_result = new System.Windows.Forms.Label();
            this.lbl_customer_id = new System.Windows.Forms.Label();
            this.lbl_cottage_id = new System.Windows.Forms.Label();
            this.lbl_cottage_id_result = new System.Windows.Forms.Label();
            this.lbl_customer_id_result = new System.Windows.Forms.Label();
            this.panel_up.SuspendLayout();
            this.panel_down.SuspendLayout();
            this.panel_left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reservations)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_up
            // 
            this.panel_up.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_up.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_up.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel_up.Controls.Add(this.lbl_reservation_control);
            this.panel_up.Controls.Add(this.lbl_logo);
            this.panel_up.Location = new System.Drawing.Point(0, 0);
            this.panel_up.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_up.Name = "panel_up";
            this.panel_up.Size = new System.Drawing.Size(1609, 62);
            this.panel_up.TabIndex = 0;
            // 
            // lbl_reservation_control
            // 
            this.lbl_reservation_control.AutoSize = true;
            this.lbl_reservation_control.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_reservation_control.Location = new System.Drawing.Point(54, 8);
            this.lbl_reservation_control.Name = "lbl_reservation_control";
            this.lbl_reservation_control.Size = new System.Drawing.Size(323, 40);
            this.lbl_reservation_control.TabIndex = 6;
            this.lbl_reservation_control.Text = "Varausten hallinta";
            // 
            // lbl_logo
            // 
            this.lbl_logo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_logo.AutoSize = true;
            this.lbl_logo.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_logo.Location = new System.Drawing.Point(1138, 0);
            this.lbl_logo.Name = "lbl_logo";
            this.lbl_logo.Size = new System.Drawing.Size(431, 52);
            this.lbl_logo.TabIndex = 5;
            this.lbl_logo.Text = "Village Newbies Oy";
            // 
            // panel_down
            // 
            this.panel_down.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_down.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_down.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel_down.Controls.Add(this.btn_appexit);
            this.panel_down.Controls.Add(this.btn_close);
            this.panel_down.Location = new System.Drawing.Point(0, 788);
            this.panel_down.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_down.Name = "panel_down";
            this.panel_down.Size = new System.Drawing.Size(1609, 82);
            this.panel_down.TabIndex = 1;
            // 
            // btn_appexit
            // 
            this.btn_appexit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_appexit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_appexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_appexit.Location = new System.Drawing.Point(3, 31);
            this.btn_appexit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_appexit.Name = "btn_appexit";
            this.btn_appexit.Size = new System.Drawing.Size(213, 49);
            this.btn_appexit.TabIndex = 19;
            this.btn_appexit.Text = "Sulje Ohjelma";
            this.btn_appexit.UseVisualStyleBackColor = false;
            this.btn_appexit.Click += new System.EventHandler(this.btn_appexit_Click);
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.Location = new System.Drawing.Point(1397, 31);
            this.btn_close.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(213, 49);
            this.btn_close.TabIndex = 18;
            this.btn_close.Text = "Palaa";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // panel_left
            // 
            this.panel_left.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel_left.Controls.Add(this.monthCalendar1);
            this.panel_left.Controls.Add(this.btn_servicemenu);
            this.panel_left.Controls.Add(this.btn_newrsv);
            this.panel_left.Controls.Add(this.btn_deletersv);
            this.panel_left.Controls.Add(this.btn_searchrsv);
            this.panel_left.Controls.Add(this.lbl_reservations);
            this.panel_left.Location = new System.Drawing.Point(0, 71);
            this.panel_left.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_left.Name = "panel_left";
            this.panel_left.Size = new System.Drawing.Size(305, 692);
            this.panel_left.TabIndex = 2;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.monthCalendar1.Location = new System.Drawing.Point(33, 400);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.monthCalendar1.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 35;
            // 
            // btn_servicemenu
            // 
            this.btn_servicemenu.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_servicemenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_servicemenu.Location = new System.Drawing.Point(50, 242);
            this.btn_servicemenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_servicemenu.Name = "btn_servicemenu";
            this.btn_servicemenu.Size = new System.Drawing.Size(213, 49);
            this.btn_servicemenu.TabIndex = 7;
            this.btn_servicemenu.Text = "Muokkaa";
            this.btn_servicemenu.UseVisualStyleBackColor = false;
            this.btn_servicemenu.Click += new System.EventHandler(this.btn_servicemenu_Click);
            // 
            // btn_newrsv
            // 
            this.btn_newrsv.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_newrsv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_newrsv.Location = new System.Drawing.Point(50, 172);
            this.btn_newrsv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_newrsv.Name = "btn_newrsv";
            this.btn_newrsv.Size = new System.Drawing.Size(213, 49);
            this.btn_newrsv.TabIndex = 6;
            this.btn_newrsv.Text = "Luo uusi";
            this.btn_newrsv.UseVisualStyleBackColor = false;
            this.btn_newrsv.Click += new System.EventHandler(this.btn_newrsv_Click);
            // 
            // btn_deletersv
            // 
            this.btn_deletersv.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_deletersv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deletersv.Location = new System.Drawing.Point(50, 318);
            this.btn_deletersv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_deletersv.Name = "btn_deletersv";
            this.btn_deletersv.Size = new System.Drawing.Size(213, 49);
            this.btn_deletersv.TabIndex = 8;
            this.btn_deletersv.Text = "Poista";
            this.btn_deletersv.UseVisualStyleBackColor = false;
            this.btn_deletersv.Click += new System.EventHandler(this.btn_deletersv_Click);
            // 
            // btn_searchrsv
            // 
            this.btn_searchrsv.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_searchrsv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_searchrsv.Location = new System.Drawing.Point(50, 100);
            this.btn_searchrsv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_searchrsv.Name = "btn_searchrsv";
            this.btn_searchrsv.Size = new System.Drawing.Size(213, 49);
            this.btn_searchrsv.TabIndex = 5;
            this.btn_searchrsv.Text = "Hae";
            this.btn_searchrsv.UseVisualStyleBackColor = false;
            this.btn_searchrsv.Click += new System.EventHandler(this.btn_searchrsv_Click);
            // 
            // lbl_reservations
            // 
            this.lbl_reservations.AutoSize = true;
            this.lbl_reservations.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_reservations.Location = new System.Drawing.Point(69, 19);
            this.lbl_reservations.Name = "lbl_reservations";
            this.lbl_reservations.Size = new System.Drawing.Size(174, 38);
            this.lbl_reservations.TabIndex = 4;
            this.lbl_reservations.Text = "Varaukset";
            // 
            // dgv_reservations
            // 
            this.dgv_reservations.AllowUserToAddRows = false;
            this.dgv_reservations.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_reservations.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_reservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_reservations.Location = new System.Drawing.Point(783, 71);
            this.dgv_reservations.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_reservations.Name = "dgv_reservations";
            this.dgv_reservations.RowHeadersWidth = 51;
            this.dgv_reservations.RowTemplate.Height = 24;
            this.dgv_reservations.Size = new System.Drawing.Size(811, 692);
            this.dgv_reservations.TabIndex = 20;
            this.dgv_reservations.SelectionChanged += new System.EventHandler(this.dvg_reservations_SelectionChanged);
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.Location = new System.Drawing.Point(324, 92);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(195, 29);
            this.lbl_email.TabIndex = 4;
            this.lbl_email.Text = "Anna sähköposti:";
            // 
            // lbl_startdate
            // 
            this.lbl_startdate.AutoSize = true;
            this.lbl_startdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_startdate.Location = new System.Drawing.Point(330, 205);
            this.lbl_startdate.Name = "lbl_startdate";
            this.lbl_startdate.Size = new System.Drawing.Size(129, 29);
            this.lbl_startdate.TabIndex = 5;
            this.lbl_startdate.Text = "Alkaa pvm:";
            // 
            // lbl_enddate
            // 
            this.lbl_enddate.AutoSize = true;
            this.lbl_enddate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_enddate.Location = new System.Drawing.Point(330, 258);
            this.lbl_enddate.Name = "lbl_enddate";
            this.lbl_enddate.Size = new System.Drawing.Size(146, 29);
            this.lbl_enddate.TabIndex = 6;
            this.lbl_enddate.Text = "Päättyy pvm:";
            // 
            // lbl_area
            // 
            this.lbl_area.AutoSize = true;
            this.lbl_area.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_area.Location = new System.Drawing.Point(330, 342);
            this.lbl_area.Name = "lbl_area";
            this.lbl_area.Size = new System.Drawing.Size(143, 29);
            this.lbl_area.TabIndex = 7;
            this.lbl_area.Text = "Valitse alue:";
            // 
            // lbl_cottages
            // 
            this.lbl_cottages.AutoSize = true;
            this.lbl_cottages.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cottages.Location = new System.Drawing.Point(330, 400);
            this.lbl_cottages.Name = "lbl_cottages";
            this.lbl_cottages.Size = new System.Drawing.Size(161, 29);
            this.lbl_cottages.TabIndex = 8;
            this.lbl_cottages.Text = "Valitse mökki:";
            // 
            // tb_search
            // 
            this.tb_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_search.Location = new System.Drawing.Point(543, 94);
            this.tb_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(223, 31);
            this.tb_search.TabIndex = 9;
            this.tb_search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_search_KeyPress);
            // 
            // dtp_startdate
            // 
            this.dtp_startdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_startdate.Location = new System.Drawing.Point(543, 202);
            this.dtp_startdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp_startdate.MaxDate = new System.DateTime(2025, 12, 31, 0, 0, 0, 0);
            this.dtp_startdate.MinDate = new System.DateTime(2021, 9, 1, 0, 0, 0, 0);
            this.dtp_startdate.Name = "dtp_startdate";
            this.dtp_startdate.Size = new System.Drawing.Size(201, 31);
            this.dtp_startdate.TabIndex = 11;
            this.dtp_startdate.Value = new System.DateTime(2023, 5, 2, 0, 0, 0, 0);
            // 
            // dtp_enddate
            // 
            this.dtp_enddate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_enddate.Location = new System.Drawing.Point(543, 255);
            this.dtp_enddate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp_enddate.MaxDate = new System.DateTime(2025, 12, 31, 0, 0, 0, 0);
            this.dtp_enddate.MinDate = new System.DateTime(2021, 10, 1, 0, 0, 0, 0);
            this.dtp_enddate.Name = "dtp_enddate";
            this.dtp_enddate.Size = new System.Drawing.Size(201, 31);
            this.dtp_enddate.TabIndex = 12;
            this.dtp_enddate.Value = new System.DateTime(2023, 5, 2, 0, 0, 0, 0);
            // 
            // cb_area
            // 
            this.cb_area.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_area.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_area.FormattingEnabled = true;
            this.cb_area.Location = new System.Drawing.Point(543, 342);
            this.cb_area.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_area.Name = "cb_area";
            this.cb_area.Size = new System.Drawing.Size(201, 33);
            this.cb_area.TabIndex = 13;
            // 
            // cb_cottages
            // 
            this.cb_cottages.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_cottages.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_cottages.FormattingEnabled = true;
            this.cb_cottages.Location = new System.Drawing.Point(543, 401);
            this.cb_cottages.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_cottages.Name = "cb_cottages";
            this.cb_cottages.Size = new System.Drawing.Size(201, 33);
            this.cb_cottages.TabIndex = 14;
            this.cb_cottages.SelectedIndexChanged += new System.EventHandler(this.cb_cottagesSelectedIndexChanged);
            // 
            // btn_search_email
            // 
            this.btn_search_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search_email.Location = new System.Drawing.Point(543, 135);
            this.btn_search_email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_search_email.Name = "btn_search_email";
            this.btn_search_email.Size = new System.Drawing.Size(224, 48);
            this.btn_search_email.TabIndex = 10;
            this.btn_search_email.Text = "Hae sähköpostilla";
            this.btn_search_email.UseVisualStyleBackColor = true;
            this.btn_search_email.Click += new System.EventHandler(this.btn_search_email_Click);
            // 
            // lbl_customer
            // 
            this.lbl_customer.AutoSize = true;
            this.lbl_customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_customer.Location = new System.Drawing.Point(330, 469);
            this.lbl_customer.Name = "lbl_customer";
            this.lbl_customer.Size = new System.Drawing.Size(178, 29);
            this.lbl_customer.TabIndex = 19;
            this.lbl_customer.Text = "Valitse asiakas:";
            // 
            // cb_customers
            // 
            this.cb_customers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_customers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_customers.FormattingEnabled = true;
            this.cb_customers.Location = new System.Drawing.Point(543, 471);
            this.cb_customers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_customers.Name = "cb_customers";
            this.cb_customers.Size = new System.Drawing.Size(201, 33);
            this.cb_customers.TabIndex = 15;
            // 
            // btn_customers
            // 
            this.btn_customers.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_customers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_customers.Location = new System.Drawing.Point(543, 715);
            this.btn_customers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_customers.Name = "btn_customers";
            this.btn_customers.Size = new System.Drawing.Size(186, 49);
            this.btn_customers.TabIndex = 17;
            this.btn_customers.Text = "Uusi asiakas";
            this.btn_customers.UseVisualStyleBackColor = false;
            this.btn_customers.Click += new System.EventHandler(this.btn_customers_Click_1);
            // 
            // btn_clear_inputs
            // 
            this.btn_clear_inputs.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_clear_inputs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear_inputs.Location = new System.Drawing.Point(335, 715);
            this.btn_clear_inputs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_clear_inputs.Name = "btn_clear_inputs";
            this.btn_clear_inputs.Size = new System.Drawing.Size(189, 49);
            this.btn_clear_inputs.TabIndex = 16;
            this.btn_clear_inputs.Text = "Tyhjennä kentät";
            this.btn_clear_inputs.UseVisualStyleBackColor = false;
            this.btn_clear_inputs.Click += new System.EventHandler(this.btn_clear_inputs_Click);
            // 
            // lbl_res_ID
            // 
            this.lbl_res_ID.AutoSize = true;
            this.lbl_res_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_res_ID.Location = new System.Drawing.Point(330, 535);
            this.lbl_res_ID.Name = "lbl_res_ID";
            this.lbl_res_ID.Size = new System.Drawing.Size(122, 29);
            this.lbl_res_ID.TabIndex = 29;
            this.lbl_res_ID.Text = "Varaus ID:";
            // 
            // lbl_ID_result
            // 
            this.lbl_ID_result.AutoSize = true;
            this.lbl_ID_result.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_ID_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID_result.Location = new System.Drawing.Point(454, 535);
            this.lbl_ID_result.Name = "lbl_ID_result";
            this.lbl_ID_result.Size = new System.Drawing.Size(0, 29);
            this.lbl_ID_result.TabIndex = 30;
            // 
            // lbl_customer_id
            // 
            this.lbl_customer_id.AutoSize = true;
            this.lbl_customer_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_customer_id.Location = new System.Drawing.Point(330, 620);
            this.lbl_customer_id.Name = "lbl_customer_id";
            this.lbl_customer_id.Size = new System.Drawing.Size(131, 29);
            this.lbl_customer_id.TabIndex = 31;
            this.lbl_customer_id.Text = "Asiakas ID:";
            // 
            // lbl_cottage_id
            // 
            this.lbl_cottage_id.AutoSize = true;
            this.lbl_cottage_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cottage_id.Location = new System.Drawing.Point(330, 578);
            this.lbl_cottage_id.Name = "lbl_cottage_id";
            this.lbl_cottage_id.Size = new System.Drawing.Size(112, 29);
            this.lbl_cottage_id.TabIndex = 32;
            this.lbl_cottage_id.Text = "Mökki ID:";
            // 
            // lbl_cottage_id_result
            // 
            this.lbl_cottage_id_result.AutoSize = true;
            this.lbl_cottage_id_result.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_cottage_id_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cottage_id_result.Location = new System.Drawing.Point(454, 578);
            this.lbl_cottage_id_result.Name = "lbl_cottage_id_result";
            this.lbl_cottage_id_result.Size = new System.Drawing.Size(0, 29);
            this.lbl_cottage_id_result.TabIndex = 33;
            // 
            // lbl_customer_id_result
            // 
            this.lbl_customer_id_result.AutoSize = true;
            this.lbl_customer_id_result.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_customer_id_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_customer_id_result.Location = new System.Drawing.Point(454, 620);
            this.lbl_customer_id_result.Name = "lbl_customer_id_result";
            this.lbl_customer_id_result.Size = new System.Drawing.Size(0, 29);
            this.lbl_customer_id_result.TabIndex = 34;
            // 
            // Frm_reservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1609, 871);
            this.Controls.Add(this.lbl_customer_id_result);
            this.Controls.Add(this.lbl_cottage_id_result);
            this.Controls.Add(this.lbl_cottage_id);
            this.Controls.Add(this.lbl_customer_id);
            this.Controls.Add(this.lbl_ID_result);
            this.Controls.Add(this.lbl_res_ID);
            this.Controls.Add(this.btn_clear_inputs);
            this.Controls.Add(this.btn_customers);
            this.Controls.Add(this.cb_customers);
            this.Controls.Add(this.lbl_customer);
            this.Controls.Add(this.btn_search_email);
            this.Controls.Add(this.cb_cottages);
            this.Controls.Add(this.cb_area);
            this.Controls.Add(this.dtp_enddate);
            this.Controls.Add(this.dtp_startdate);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.lbl_cottages);
            this.Controls.Add(this.lbl_area);
            this.Controls.Add(this.lbl_enddate);
            this.Controls.Add(this.lbl_startdate);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.dgv_reservations);
            this.Controls.Add(this.panel_left);
            this.Controls.Add(this.panel_down);
            this.Controls.Add(this.panel_up);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Frm_reservations";
            this.Text = "Varausten hallinta";
            this.Load += new System.EventHandler(this.Frm_reservations_Load);
            this.panel_up.ResumeLayout(false);
            this.panel_up.PerformLayout();
            this.panel_down.ResumeLayout(false);
            this.panel_left.ResumeLayout(false);
            this.panel_left.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reservations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_up;
        private System.Windows.Forms.Panel panel_down;
        private System.Windows.Forms.Panel panel_left;
        private System.Windows.Forms.DataGridView dgv_reservations;
        private System.Windows.Forms.Label lbl_logo;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_newrsv;
        private System.Windows.Forms.Button btn_deletersv;
        private System.Windows.Forms.Button btn_searchrsv;
        private System.Windows.Forms.Label lbl_reservations;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_startdate;
        private System.Windows.Forms.Label lbl_enddate;
        private System.Windows.Forms.Label lbl_area;
        private System.Windows.Forms.Label lbl_cottages;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.DateTimePicker dtp_startdate;
        private System.Windows.Forms.DateTimePicker dtp_enddate;
        private System.Windows.Forms.ComboBox cb_area;
        private System.Windows.Forms.ComboBox cb_cottages;
        private System.Windows.Forms.Button btn_appexit;
        private System.Windows.Forms.Label lbl_reservation_control;
        private System.Windows.Forms.Button btn_search_email;
        private System.Windows.Forms.Label lbl_customer;
        private System.Windows.Forms.ComboBox cb_customers;
        private System.Windows.Forms.Button btn_customers;
        private System.Windows.Forms.Button btn_clear_inputs;
        private System.Windows.Forms.Label lbl_res_ID;
        private System.Windows.Forms.Label lbl_ID_result;
        private System.Windows.Forms.Label lbl_customer_id;
        private System.Windows.Forms.Label lbl_cottage_id;
        private System.Windows.Forms.Label lbl_cottage_id_result;
        private System.Windows.Forms.Label lbl_customer_id_result;
        private System.Windows.Forms.Button btn_servicemenu;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}