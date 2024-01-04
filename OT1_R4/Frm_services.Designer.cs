using System.Data;

namespace OT1_R4
{
    partial class Frm_services
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
            this.dgv_service = new System.Windows.Forms.DataGridView();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_delete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.tb_price = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_location = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_description = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_clear = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.tb_Alv = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_panel3_modify = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.dataSet1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_return = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_service)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_service
            // 
            this.dgv_service.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_service.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_service.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dgv_service.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_service.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgv_service.Location = new System.Drawing.Point(887, 63);
            this.dgv_service.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_service.Name = "dgv_service";
            this.dgv_service.RowHeadersWidth = 62;
            this.dgv_service.RowTemplate.Height = 28;
            this.dgv_service.Size = new System.Drawing.Size(849, 631);
            this.dgv_service.TabIndex = 2;
            this.dgv_service.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_service_RowHeaderMouseClick);
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(151, 327);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(179, 92);
            this.btn_delete.TabIndex = 8;
            this.btn_delete.Text = "Poista ";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 491);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Hae palvelua nimellä";
            // 
            // tb_search
            // 
            this.tb_search.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_search.Location = new System.Drawing.Point(33, 524);
            this.tb_search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(248, 30);
            this.tb_search.TabIndex = 9;
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(303, 522);
            this.btn_search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(109, 34);
            this.btn_search.TabIndex = 10;
            this.btn_search.Text = "Hae ";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // tb_price
            // 
            this.tb_price.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_price.Location = new System.Drawing.Point(125, 186);
            this.tb_price.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_price.Name = "tb_price";
            this.tb_price.Size = new System.Drawing.Size(271, 30);
            this.tb_price.TabIndex = 1;
            this.tb_price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_price_KeyPress);
            this.tb_price.Leave += new System.EventHandler(this.tb_price_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "Hinta";
            // 
            // cmb_location
            // 
            this.cmb_location.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_location.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_location.FormattingEnabled = true;
            this.cmb_location.ItemHeight = 23;
            this.cmb_location.Location = new System.Drawing.Point(125, 337);
            this.cmb_location.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmb_location.Name = "cmb_location";
            this.cmb_location.Size = new System.Drawing.Size(271, 31);
            this.cmb_location.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 340);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 23);
            this.label5.TabIndex = 13;
            this.label5.Text = "Sijainti";
            // 
            // tb_description
            // 
            this.tb_description.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_description.Location = new System.Drawing.Point(125, 415);
            this.tb_description.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_description.Multiline = true;
            this.tb_description.Name = "tb_description";
            this.tb_description.Size = new System.Drawing.Size(271, 144);
            this.tb_description.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Menu;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.bt_clear);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lbl_ID);
            this.panel1.Controls.Add(this.tb_description);
            this.panel1.Controls.Add(this.tb_Alv);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.tb_price);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tb_name);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.cmb_location);
            this.panel1.Location = new System.Drawing.Point(4, 63);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(438, 632);
            this.panel1.TabIndex = 17;
            // 
            // bt_clear
            // 
            this.bt_clear.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_clear.Location = new System.Drawing.Point(125, 577);
            this.bt_clear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bt_clear.Name = "bt_clear";
            this.bt_clear.Size = new System.Drawing.Size(129, 38);
            this.bt_clear.TabIndex = 5;
            this.bt_clear.Text = "Tyhjennä lomake";
            this.bt_clear.UseVisualStyleBackColor = true;
            this.bt_clear.Click += new System.EventHandler(this.bt_clear_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 23);
            this.label6.TabIndex = 24;
            this.label6.Text = "Palvelu ID";
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID.Location = new System.Drawing.Point(121, 38);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(19, 23);
            this.lbl_ID.TabIndex = 23;
            this.lbl_ID.Text = "0";
            // 
            // tb_Alv
            // 
            this.tb_Alv.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Alv.Location = new System.Drawing.Point(125, 262);
            this.tb_Alv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_Alv.Name = "tb_Alv";
            this.tb_Alv.ReadOnly = true;
            this.tb_Alv.Size = new System.Drawing.Size(271, 30);
            this.tb_Alv.TabIndex = 21;
            this.tb_Alv.Text = "23";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(29, 263);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 23);
            this.label10.TabIndex = 22;
            this.label10.Text = "Alv";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 415);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Kuvaus";
            // 
            // tb_name
            // 
            this.tb_name.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_name.Location = new System.Drawing.Point(125, 110);
            this.tb_name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(271, 30);
            this.tb_name.TabIndex = 0;
            this.tb_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_name_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(29, 112);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 23);
            this.label11.TabIndex = 22;
            this.label11.Text = "Nimi";
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(151, 100);
            this.btn_add.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(179, 92);
            this.btn_add.TabIndex = 6;
            this.btn_add.Text = "Lisää";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click_1);
            // 
            // btn_panel3_modify
            // 
            this.btn_panel3_modify.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_panel3_modify.Location = new System.Drawing.Point(151, 213);
            this.btn_panel3_modify.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_panel3_modify.Name = "btn_panel3_modify";
            this.btn_panel3_modify.Size = new System.Drawing.Size(179, 92);
            this.btn_panel3_modify.TabIndex = 7;
            this.btn_panel3_modify.Text = "Muokkaa";
            this.btn_panel3_modify.UseVisualStyleBackColor = true;
            this.btn_panel3_modify.Click += new System.EventHandler(this.btn_panel3_modify_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(25, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 29);
            this.label9.TabIndex = 20;
            this.label9.Text = "Palvelut";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1761, 62);
            this.panel2.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1404, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "Village Newbies";
            // 
            // btn_close
            // 
            this.btn_close.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_close.BackColor = System.Drawing.SystemColors.Menu;
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.Location = new System.Drawing.Point(12, 2);
            this.btn_close.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(183, 54);
            this.btn_close.TabIndex = 11;
            this.btn_close.Text = "Sulje Ohjelma";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.btn_close);
            this.panel3.Controls.Add(this.btn_return);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 700);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1761, 63);
            this.panel3.TabIndex = 19;
            // 
            // btn_return
            // 
            this.btn_return.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_return.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_return.Location = new System.Drawing.Point(1566, 2);
            this.btn_return.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(183, 54);
            this.btn_return.TabIndex = 12;
            this.btn_return.Text = "Palaa";
            this.btn_return.UseVisualStyleBackColor = true;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Menu;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.btn_add);
            this.panel4.Controls.Add(this.btn_search);
            this.panel4.Controls.Add(this.tb_search);
            this.panel4.Controls.Add(this.btn_delete);
            this.panel4.Controls.Add(this.btn_panel3_modify);
            this.panel4.Location = new System.Drawing.Point(447, 63);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(434, 632);
            this.panel4.TabIndex = 20;
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // Frm_services
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1761, 763);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgv_service);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Frm_services";
            this.Text = "Palvelut";
            this.Load += new System.EventHandler(this.Frm_services_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_service)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_service;
        private DataSet dataSet1;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox tb_price;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_location;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_description;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_Alv;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_panel3_modify;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.BindingSource dataSet1BindingSource1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.Button bt_clear;
        private System.Windows.Forms.Button btn_return;
        private System.Windows.Forms.Button btn_close;
    }
}