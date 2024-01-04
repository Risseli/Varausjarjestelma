namespace OT1_R4
{
    partial class Frm_cottages
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
            this.cmb_area = new System.Windows.Forms.ComboBox();
            this.tb_postcode = new System.Windows.Forms.TextBox();
            this.tb_address = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_price = new System.Windows.Forms.TextBox();
            this.tb_description = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_equipment = new System.Windows.Forms.TextBox();
            this.nud_headcount = new System.Windows.Forms.NumericUpDown();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dgv_cottages = new System.Windows.Forms.DataGridView();
            this.btn_add_cottage = new System.Windows.Forms.Button();
            this.btn_areas = new System.Windows.Forms.Button();
            this.pnl_top = new System.Windows.Forms.Panel();
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_logo = new System.Windows.Forms.Label();
            this.pnl_bottom = new System.Windows.Forms.Panel();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.pnl_input = new System.Windows.Forms.Panel();
            this.btn_clear_inputs = new System.Windows.Forms.Button();
            this.lbl_cottage_ID = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pnl_buttons = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_delete_cottage = new System.Windows.Forms.Button();
            this.btn_edit_cottage = new System.Windows.Forms.Button();
            this.btn_search_cottage = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nud_headcount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cottages)).BeginInit();
            this.pnl_top.SuspendLayout();
            this.pnl_bottom.SuspendLayout();
            this.pnl_input.SuspendLayout();
            this.pnl_buttons.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmb_area
            // 
            this.cmb_area.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_area.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_area.FormattingEnabled = true;
            this.cmb_area.Items.AddRange(new object[] {
            "Joensuu",
            "Kuopio",
            "Oulu",
            "Sotkamo"});
            this.cmb_area.Location = new System.Drawing.Point(132, 51);
            this.cmb_area.Name = "cmb_area";
            this.cmb_area.Size = new System.Drawing.Size(206, 28);
            this.cmb_area.Sorted = true;
            this.cmb_area.TabIndex = 7;
            // 
            // tb_postcode
            // 
            this.tb_postcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_postcode.Location = new System.Drawing.Point(132, 139);
            this.tb_postcode.Name = "tb_postcode";
            this.tb_postcode.Size = new System.Drawing.Size(206, 26);
            this.tb_postcode.TabIndex = 9;
            this.tb_postcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_postcode_KeyPress);
            // 
            // tb_address
            // 
            this.tb_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_address.Location = new System.Drawing.Point(132, 182);
            this.tb_address.Name = "tb_address";
            this.tb_address.Size = new System.Drawing.Size(206, 26);
            this.tb_address.TabIndex = 10;
            this.tb_address.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_address_KeyPress);
            // 
            // tb_name
            // 
            this.tb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_name.Location = new System.Drawing.Point(132, 98);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(206, 26);
            this.tb_name.TabIndex = 8;
            this.tb_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_name_KeyPress);
            // 
            // tb_price
            // 
            this.tb_price.BackColor = System.Drawing.SystemColors.Window;
            this.tb_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_price.Location = new System.Drawing.Point(132, 226);
            this.tb_price.Name = "tb_price";
            this.tb_price.Size = new System.Drawing.Size(105, 26);
            this.tb_price.TabIndex = 11;
            this.tb_price.Text = "0.00";
            this.tb_price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_price_KeyPress);
            this.tb_price.Leave += new System.EventHandler(this.tb_price_Leave);
            // 
            // tb_description
            // 
            this.tb_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_description.Location = new System.Drawing.Point(132, 315);
            this.tb_description.Multiline = true;
            this.tb_description.Name = "tb_description";
            this.tb_description.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_description.Size = new System.Drawing.Size(227, 100);
            this.tb_description.TabIndex = 13;
            this.tb_description.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_description_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Postinumero";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alue";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nimi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Katuosoite";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Henkilömäärä";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Hinta";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 315);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Kuvaus";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 438);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Varustelu";
            // 
            // tb_equipment
            // 
            this.tb_equipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_equipment.Location = new System.Drawing.Point(132, 438);
            this.tb_equipment.Multiline = true;
            this.tb_equipment.Name = "tb_equipment";
            this.tb_equipment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_equipment.Size = new System.Drawing.Size(227, 97);
            this.tb_equipment.TabIndex = 14;
            this.tb_equipment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_equipment_KeyPress);
            // 
            // nud_headcount
            // 
            this.nud_headcount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_headcount.Location = new System.Drawing.Point(132, 269);
            this.nud_headcount.Name = "nud_headcount";
            this.nud_headcount.Size = new System.Drawing.Size(105, 26);
            this.nud_headcount.TabIndex = 12;
            // 
            // dgv_cottages
            // 
            this.dgv_cottages.AllowUserToAddRows = false;
            this.dgv_cottages.AllowUserToDeleteRows = false;
            this.dgv_cottages.AllowUserToResizeRows = false;
            this.dgv_cottages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_cottages.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_cottages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cottages.Location = new System.Drawing.Point(619, 56);
            this.dgv_cottages.MultiSelect = false;
            this.dgv_cottages.Name = "dgv_cottages";
            this.dgv_cottages.ReadOnly = true;
            this.dgv_cottages.RowHeadersVisible = false;
            this.dgv_cottages.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_cottages.Size = new System.Drawing.Size(592, 564);
            this.dgv_cottages.StandardTab = true;
            this.dgv_cottages.TabIndex = 21;
            this.dgv_cottages.TabStop = false;
            this.dgv_cottages.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_cottages_CellClick);
            this.dgv_cottages.SelectionChanged += new System.EventHandler(this.dgv_cottages_SelectionChanged);
            // 
            // btn_add_cottage
            // 
            this.btn_add_cottage.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_add_cottage.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_add_cottage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_cottage.Location = new System.Drawing.Point(35, 142);
            this.btn_add_cottage.Name = "btn_add_cottage";
            this.btn_add_cottage.Size = new System.Drawing.Size(127, 38);
            this.btn_add_cottage.TabIndex = 2;
            this.btn_add_cottage.Text = "Lisää";
            this.btn_add_cottage.UseVisualStyleBackColor = false;
            this.btn_add_cottage.Click += new System.EventHandler(this.btn_add_cottage_Click);
            // 
            // btn_areas
            // 
            this.btn_areas.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_areas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_areas.Location = new System.Drawing.Point(35, 364);
            this.btn_areas.Name = "btn_areas";
            this.btn_areas.Size = new System.Drawing.Size(127, 51);
            this.btn_areas.TabIndex = 5;
            this.btn_areas.Text = "Muokkaa alueita";
            this.btn_areas.UseVisualStyleBackColor = false;
            this.btn_areas.Click += new System.EventHandler(this.btn_areas_Click);
            // 
            // pnl_top
            // 
            this.pnl_top.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnl_top.Controls.Add(this.lbl_title);
            this.pnl_top.Controls.Add(this.lbl_logo);
            this.pnl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_top.Location = new System.Drawing.Point(0, 0);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(1223, 50);
            this.pnl_top.TabIndex = 24;
            // 
            // lbl_title
            // 
            this.lbl_title.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(448, 9);
            this.lbl_title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(202, 29);
            this.lbl_title.TabIndex = 7;
            this.lbl_title.Text = "Mökkien hallinta";
            // 
            // lbl_logo
            // 
            this.lbl_logo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_logo.AutoSize = true;
            this.lbl_logo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_logo.Location = new System.Drawing.Point(968, 9);
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
            this.pnl_bottom.Location = new System.Drawing.Point(0, 626);
            this.pnl_bottom.Name = "pnl_bottom";
            this.pnl_bottom.Size = new System.Drawing.Size(1223, 50);
            this.pnl_bottom.TabIndex = 0;
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
            // pnl_input
            // 
            this.pnl_input.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnl_input.Controls.Add(this.btn_clear_inputs);
            this.pnl_input.Controls.Add(this.lbl_cottage_ID);
            this.pnl_input.Controls.Add(this.label11);
            this.pnl_input.Controls.Add(this.tb_description);
            this.pnl_input.Controls.Add(this.cmb_area);
            this.pnl_input.Controls.Add(this.tb_postcode);
            this.pnl_input.Controls.Add(this.tb_address);
            this.pnl_input.Controls.Add(this.tb_name);
            this.pnl_input.Controls.Add(this.tb_price);
            this.pnl_input.Controls.Add(this.label7);
            this.pnl_input.Controls.Add(this.label1);
            this.pnl_input.Controls.Add(this.label8);
            this.pnl_input.Controls.Add(this.label4);
            this.pnl_input.Controls.Add(this.tb_equipment);
            this.pnl_input.Controls.Add(this.label2);
            this.pnl_input.Controls.Add(this.label6);
            this.pnl_input.Controls.Add(this.label5);
            this.pnl_input.Controls.Add(this.nud_headcount);
            this.pnl_input.Controls.Add(this.label3);
            this.pnl_input.Location = new System.Drawing.Point(233, 56);
            this.pnl_input.Name = "pnl_input";
            this.pnl_input.Size = new System.Drawing.Size(380, 564);
            this.pnl_input.TabIndex = 25;
            // 
            // btn_clear_inputs
            // 
            this.btn_clear_inputs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear_inputs.Location = new System.Drawing.Point(195, 10);
            this.btn_clear_inputs.Name = "btn_clear_inputs";
            this.btn_clear_inputs.Size = new System.Drawing.Size(143, 26);
            this.btn_clear_inputs.TabIndex = 6;
            this.btn_clear_inputs.Text = "Tyhjennä kentät";
            this.btn_clear_inputs.UseVisualStyleBackColor = true;
            this.btn_clear_inputs.Click += new System.EventHandler(this.btn_clear_inputs_Click);
            // 
            // lbl_cottage_ID
            // 
            this.lbl_cottage_ID.AutoSize = true;
            this.lbl_cottage_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cottage_ID.Location = new System.Drawing.Point(128, 10);
            this.lbl_cottage_ID.Name = "lbl_cottage_ID";
            this.lbl_cottage_ID.Size = new System.Drawing.Size(14, 20);
            this.lbl_cottage_ID.TabIndex = 16;
            this.lbl_cottage_ID.Text = "-";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 20);
            this.label11.TabIndex = 15;
            this.label11.Text = "Mökki ID";
            // 
            // pnl_buttons
            // 
            this.pnl_buttons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnl_buttons.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnl_buttons.Controls.Add(this.label10);
            this.pnl_buttons.Controls.Add(this.btn_delete_cottage);
            this.pnl_buttons.Controls.Add(this.btn_edit_cottage);
            this.pnl_buttons.Controls.Add(this.btn_search_cottage);
            this.pnl_buttons.Controls.Add(this.btn_areas);
            this.pnl_buttons.Controls.Add(this.label9);
            this.pnl_buttons.Controls.Add(this.btn_add_cottage);
            this.pnl_buttons.Location = new System.Drawing.Point(11, 56);
            this.pnl_buttons.Name = "pnl_buttons";
            this.pnl_buttons.Size = new System.Drawing.Size(213, 564);
            this.pnl_buttons.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(13, 324);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 24);
            this.label10.TabIndex = 27;
            this.label10.Text = "Alue";
            // 
            // btn_delete_cottage
            // 
            this.btn_delete_cottage.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_delete_cottage.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_delete_cottage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete_cottage.Location = new System.Drawing.Point(35, 262);
            this.btn_delete_cottage.Name = "btn_delete_cottage";
            this.btn_delete_cottage.Size = new System.Drawing.Size(127, 38);
            this.btn_delete_cottage.TabIndex = 4;
            this.btn_delete_cottage.Text = "Poista";
            this.btn_delete_cottage.UseVisualStyleBackColor = false;
            this.btn_delete_cottage.Click += new System.EventHandler(this.btn_delete_cottage_Click);
            // 
            // btn_edit_cottage
            // 
            this.btn_edit_cottage.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_edit_cottage.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_edit_cottage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit_cottage.Location = new System.Drawing.Point(35, 202);
            this.btn_edit_cottage.Name = "btn_edit_cottage";
            this.btn_edit_cottage.Size = new System.Drawing.Size(127, 38);
            this.btn_edit_cottage.TabIndex = 3;
            this.btn_edit_cottage.Text = "Muokkaa";
            this.btn_edit_cottage.UseVisualStyleBackColor = false;
            this.btn_edit_cottage.Click += new System.EventHandler(this.btn_edit_cottage_Click);
            // 
            // btn_search_cottage
            // 
            this.btn_search_cottage.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_search_cottage.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_search_cottage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search_cottage.Location = new System.Drawing.Point(35, 83);
            this.btn_search_cottage.Name = "btn_search_cottage";
            this.btn_search_cottage.Size = new System.Drawing.Size(127, 38);
            this.btn_search_cottage.TabIndex = 1;
            this.btn_search_cottage.Text = "Hae";
            this.btn_search_cottage.UseVisualStyleBackColor = false;
            this.btn_search_cottage.Click += new System.EventHandler(this.btn_search_cottage_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 24);
            this.label9.TabIndex = 23;
            this.label9.Text = "Mökki";
            // 
            // Frm_cottages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 676);
            this.Controls.Add(this.pnl_buttons);
            this.Controls.Add(this.pnl_input);
            this.Controls.Add(this.pnl_bottom);
            this.Controls.Add(this.pnl_top);
            this.Controls.Add(this.dgv_cottages);
            this.Name = "Frm_cottages";
            this.Text = "Mökkien hallinta";
            this.Load += new System.EventHandler(this.Frm_areas_cottages_Load);
            this.SizeChanged += new System.EventHandler(this.Frm_areas_cottages_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.nud_headcount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cottages)).EndInit();
            this.pnl_top.ResumeLayout(false);
            this.pnl_top.PerformLayout();
            this.pnl_bottom.ResumeLayout(false);
            this.pnl_input.ResumeLayout(false);
            this.pnl_input.PerformLayout();
            this.pnl_buttons.ResumeLayout(false);
            this.pnl_buttons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cmb_area;
        private System.Windows.Forms.TextBox tb_postcode;
        private System.Windows.Forms.TextBox tb_address;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_price;
        private System.Windows.Forms.TextBox tb_description;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_equipment;
        private System.Windows.Forms.NumericUpDown nud_headcount;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridView dgv_cottages;
        private System.Windows.Forms.Button btn_add_cottage;
        private System.Windows.Forms.Button btn_areas;
        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.Panel pnl_bottom;
        private System.Windows.Forms.Panel pnl_input;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label lbl_logo;
        private System.Windows.Forms.Panel pnl_buttons;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_delete_cottage;
        private System.Windows.Forms.Button btn_edit_cottage;
        private System.Windows.Forms.Button btn_search_cottage;
        private System.Windows.Forms.Label lbl_cottage_ID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_clear_inputs;
    }
}