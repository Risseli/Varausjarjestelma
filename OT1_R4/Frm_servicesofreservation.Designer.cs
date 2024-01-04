namespace OT1_R4
{
    partial class Frm_servicesofreservation
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
            this.lbl_servicesofreservation = new System.Windows.Forms.Label();
            this.lbl_logo = new System.Windows.Forms.Label();
            this.panel_down = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_appexit = new System.Windows.Forms.Button();
            this.panel_left = new System.Windows.Forms.Panel();
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.dgv_servicesofreservation = new System.Windows.Forms.DataGridView();
            this.tb_amount = new System.Windows.Forms.TextBox();
            this.lbl_amount = new System.Windows.Forms.Label();
            this.btn_clear_inputs = new System.Windows.Forms.Button();
            this.lbl_area = new System.Windows.Forms.Label();
            this.lbl_service = new System.Windows.Forms.Label();
            this.cb_area = new System.Windows.Forms.ComboBox();
            this.cb_services = new System.Windows.Forms.ComboBox();
            this.lbl_reservationcb = new System.Windows.Forms.Label();
            this.cb_reservations = new System.Windows.Forms.ComboBox();
            this.lbl_reservation_id = new System.Windows.Forms.Label();
            this.lbl_service_id = new System.Windows.Forms.Label();
            this.lbl_reservation_id_result = new System.Windows.Forms.Label();
            this.lbl_service_id_result = new System.Windows.Forms.Label();
            this.panel_up.SuspendLayout();
            this.panel_down.SuspendLayout();
            this.panel_left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_servicesofreservation)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_up
            // 
            this.panel_up.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_up.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel_up.Controls.Add(this.lbl_servicesofreservation);
            this.panel_up.Controls.Add(this.lbl_logo);
            this.panel_up.Location = new System.Drawing.Point(0, 0);
            this.panel_up.Name = "panel_up";
            this.panel_up.Size = new System.Drawing.Size(1079, 79);
            this.panel_up.TabIndex = 0;
            // 
            // lbl_servicesofreservation
            // 
            this.lbl_servicesofreservation.AutoSize = true;
            this.lbl_servicesofreservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_servicesofreservation.Location = new System.Drawing.Point(35, 26);
            this.lbl_servicesofreservation.Name = "lbl_servicesofreservation";
            this.lbl_servicesofreservation.Size = new System.Drawing.Size(287, 36);
            this.lbl_servicesofreservation.TabIndex = 2;
            this.lbl_servicesofreservation.Text = "Varauksen palvelut";
            // 
            // lbl_logo
            // 
            this.lbl_logo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_logo.AutoSize = true;
            this.lbl_logo.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_logo.Location = new System.Drawing.Point(657, 20);
            this.lbl_logo.Name = "lbl_logo";
            this.lbl_logo.Size = new System.Drawing.Size(360, 42);
            this.lbl_logo.TabIndex = 6;
            this.lbl_logo.Text = "Village Newbies Oy";
            // 
            // panel_down
            // 
            this.panel_down.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_down.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel_down.Controls.Add(this.btn_close);
            this.panel_down.Controls.Add(this.btn_appexit);
            this.panel_down.Location = new System.Drawing.Point(0, 581);
            this.panel_down.Name = "panel_down";
            this.panel_down.Size = new System.Drawing.Size(1079, 79);
            this.panel_down.TabIndex = 1;
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.Location = new System.Drawing.Point(865, 29);
            this.btn_close.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(189, 39);
            this.btn_close.TabIndex = 18;
            this.btn_close.Text = "Palaa";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_appexit
            // 
            this.btn_appexit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_appexit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_appexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_appexit.Location = new System.Drawing.Point(41, 29);
            this.btn_appexit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_appexit.Name = "btn_appexit";
            this.btn_appexit.Size = new System.Drawing.Size(189, 39);
            this.btn_appexit.TabIndex = 19;
            this.btn_appexit.Text = "Sulje Ohjelma";
            this.btn_appexit.UseVisualStyleBackColor = false;
            this.btn_appexit.Click += new System.EventHandler(this.btn_appexit_Click);
            // 
            // panel_left
            // 
            this.panel_left.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel_left.Controls.Add(this.btn_new);
            this.panel_left.Controls.Add(this.btn_search);
            this.panel_left.Controls.Add(this.btn_edit);
            this.panel_left.Controls.Add(this.btn_delete);
            this.panel_left.Location = new System.Drawing.Point(12, 85);
            this.panel_left.Name = "panel_left";
            this.panel_left.Size = new System.Drawing.Size(244, 483);
            this.panel_left.TabIndex = 2;
            // 
            // btn_new
            // 
            this.btn_new.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_new.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new.Location = new System.Drawing.Point(29, 80);
            this.btn_new.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(189, 39);
            this.btn_new.TabIndex = 10;
            this.btn_new.Text = "Luo uusi";
            this.btn_new.UseVisualStyleBackColor = false;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(29, 22);
            this.btn_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(189, 39);
            this.btn_search.TabIndex = 9;
            this.btn_search.Text = "Hae kaikki";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.Location = new System.Drawing.Point(29, 138);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(189, 39);
            this.btn_edit.TabIndex = 11;
            this.btn_edit.Text = "Muokkaa varausta";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(29, 196);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(189, 39);
            this.btn_delete.TabIndex = 12;
            this.btn_delete.Text = "Poista";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // dgv_servicesofreservation
            // 
            this.dgv_servicesofreservation.AllowUserToAddRows = false;
            this.dgv_servicesofreservation.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_servicesofreservation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_servicesofreservation.Location = new System.Drawing.Point(593, 85);
            this.dgv_servicesofreservation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_servicesofreservation.Name = "dgv_servicesofreservation";
            this.dgv_servicesofreservation.RowHeadersWidth = 51;
            this.dgv_servicesofreservation.RowTemplate.Height = 24;
            this.dgv_servicesofreservation.Size = new System.Drawing.Size(480, 455);
            this.dgv_servicesofreservation.TabIndex = 20;
            this.dgv_servicesofreservation.SelectionChanged += new System.EventHandler(this.dvg_servicesofreservation_SelectionChanged);
            // 
            // tb_amount
            // 
            this.tb_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_amount.Location = new System.Drawing.Point(408, 254);
            this.tb_amount.Name = "tb_amount";
            this.tb_amount.Size = new System.Drawing.Size(157, 30);
            this.tb_amount.TabIndex = 16;
            this.tb_amount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_amount_KeyPress);
            // 
            // lbl_amount
            // 
            this.lbl_amount.AutoSize = true;
            this.lbl_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_amount.Location = new System.Drawing.Point(274, 254);
            this.lbl_amount.Name = "lbl_amount";
            this.lbl_amount.Size = new System.Drawing.Size(116, 25);
            this.lbl_amount.TabIndex = 8;
            this.lbl_amount.Text = "Lukumäärä:";
            // 
            // btn_clear_inputs
            // 
            this.btn_clear_inputs.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_clear_inputs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear_inputs.Location = new System.Drawing.Point(279, 512);
            this.btn_clear_inputs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_clear_inputs.Name = "btn_clear_inputs";
            this.btn_clear_inputs.Size = new System.Drawing.Size(168, 39);
            this.btn_clear_inputs.TabIndex = 17;
            this.btn_clear_inputs.Text = "Tyhjennä kentät";
            this.btn_clear_inputs.UseVisualStyleBackColor = false;
            this.btn_clear_inputs.Click += new System.EventHandler(this.btn_clear_inputs_Click);
            // 
            // lbl_area
            // 
            this.lbl_area.AutoSize = true;
            this.lbl_area.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_area.Location = new System.Drawing.Point(274, 107);
            this.lbl_area.Name = "lbl_area";
            this.lbl_area.Size = new System.Drawing.Size(58, 25);
            this.lbl_area.TabIndex = 23;
            this.lbl_area.Text = "Alue:";
            // 
            // lbl_service
            // 
            this.lbl_service.AutoSize = true;
            this.lbl_service.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_service.Location = new System.Drawing.Point(274, 152);
            this.lbl_service.Name = "lbl_service";
            this.lbl_service.Size = new System.Drawing.Size(82, 25);
            this.lbl_service.TabIndex = 24;
            this.lbl_service.Text = "Palvelu:";
            // 
            // cb_area
            // 
            this.cb_area.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_area.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_area.FormattingEnabled = true;
            this.cb_area.Location = new System.Drawing.Point(408, 107);
            this.cb_area.Name = "cb_area";
            this.cb_area.Size = new System.Drawing.Size(157, 33);
            this.cb_area.TabIndex = 13;
            this.cb_area.SelectedIndexChanged += new System.EventHandler(this.cb_area_SelectedIndexChanged);
            // 
            // cb_services
            // 
            this.cb_services.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_services.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_services.FormattingEnabled = true;
            this.cb_services.Location = new System.Drawing.Point(408, 152);
            this.cb_services.Name = "cb_services";
            this.cb_services.Size = new System.Drawing.Size(157, 33);
            this.cb_services.TabIndex = 14;
            // 
            // lbl_reservationcb
            // 
            this.lbl_reservationcb.AutoSize = true;
            this.lbl_reservationcb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_reservationcb.Location = new System.Drawing.Point(274, 198);
            this.lbl_reservationcb.Name = "lbl_reservationcb";
            this.lbl_reservationcb.Size = new System.Drawing.Size(81, 25);
            this.lbl_reservationcb.TabIndex = 27;
            this.lbl_reservationcb.Text = "Varaus:";
            // 
            // cb_reservations
            // 
            this.cb_reservations.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_reservations.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_reservations.FormattingEnabled = true;
            this.cb_reservations.Location = new System.Drawing.Point(408, 198);
            this.cb_reservations.Name = "cb_reservations";
            this.cb_reservations.Size = new System.Drawing.Size(157, 33);
            this.cb_reservations.TabIndex = 15;
            // 
            // lbl_reservation_id
            // 
            this.lbl_reservation_id.AutoSize = true;
            this.lbl_reservation_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_reservation_id.Location = new System.Drawing.Point(275, 319);
            this.lbl_reservation_id.Name = "lbl_reservation_id";
            this.lbl_reservation_id.Size = new System.Drawing.Size(105, 25);
            this.lbl_reservation_id.TabIndex = 29;
            this.lbl_reservation_id.Text = "Varaus ID:";
            // 
            // lbl_service_id
            // 
            this.lbl_service_id.AutoSize = true;
            this.lbl_service_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_service_id.Location = new System.Drawing.Point(275, 357);
            this.lbl_service_id.Name = "lbl_service_id";
            this.lbl_service_id.Size = new System.Drawing.Size(106, 25);
            this.lbl_service_id.TabIndex = 30;
            this.lbl_service_id.Text = "Palvelu ID:";
            // 
            // lbl_reservation_id_result
            // 
            this.lbl_reservation_id_result.AutoSize = true;
            this.lbl_reservation_id_result.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_reservation_id_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_reservation_id_result.Location = new System.Drawing.Point(387, 319);
            this.lbl_reservation_id_result.Name = "lbl_reservation_id_result";
            this.lbl_reservation_id_result.Size = new System.Drawing.Size(0, 25);
            this.lbl_reservation_id_result.TabIndex = 31;
            // 
            // lbl_service_id_result
            // 
            this.lbl_service_id_result.AutoSize = true;
            this.lbl_service_id_result.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_service_id_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_service_id_result.Location = new System.Drawing.Point(387, 357);
            this.lbl_service_id_result.Name = "lbl_service_id_result";
            this.lbl_service_id_result.Size = new System.Drawing.Size(0, 25);
            this.lbl_service_id_result.TabIndex = 32;
            // 
            // Frm_servicesofreservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 660);
            this.Controls.Add(this.lbl_service_id_result);
            this.Controls.Add(this.lbl_reservation_id_result);
            this.Controls.Add(this.lbl_service_id);
            this.Controls.Add(this.lbl_reservation_id);
            this.Controls.Add(this.cb_reservations);
            this.Controls.Add(this.lbl_reservationcb);
            this.Controls.Add(this.cb_services);
            this.Controls.Add(this.cb_area);
            this.Controls.Add(this.lbl_service);
            this.Controls.Add(this.lbl_area);
            this.Controls.Add(this.btn_clear_inputs);
            this.Controls.Add(this.lbl_amount);
            this.Controls.Add(this.tb_amount);
            this.Controls.Add(this.dgv_servicesofreservation);
            this.Controls.Add(this.panel_left);
            this.Controls.Add(this.panel_down);
            this.Controls.Add(this.panel_up);
            this.Name = "Frm_servicesofreservation";
            this.Text = "Varauksen palvelut";
            this.panel_up.ResumeLayout(false);
            this.panel_up.PerformLayout();
            this.panel_down.ResumeLayout(false);
            this.panel_left.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_servicesofreservation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_up;
        private System.Windows.Forms.Panel panel_down;
        private System.Windows.Forms.Label lbl_servicesofreservation;
        private System.Windows.Forms.Label lbl_logo;
        private System.Windows.Forms.Panel panel_left;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.DataGridView dgv_servicesofreservation;
        private System.Windows.Forms.Button btn_appexit;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.TextBox tb_amount;
        private System.Windows.Forms.Label lbl_amount;
        private System.Windows.Forms.Button btn_clear_inputs;
        private System.Windows.Forms.Label lbl_area;
        private System.Windows.Forms.Label lbl_service;
        private System.Windows.Forms.ComboBox cb_area;
        private System.Windows.Forms.ComboBox cb_services;
        private System.Windows.Forms.Label lbl_reservationcb;
        private System.Windows.Forms.ComboBox cb_reservations;
        private System.Windows.Forms.Label lbl_reservation_id;
        private System.Windows.Forms.Label lbl_service_id;
        private System.Windows.Forms.Label lbl_reservation_id_result;
        private System.Windows.Forms.Label lbl_service_id_result;
    }
}