namespace OT1_R4
{
    partial class Frm_search_cottages
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
            this.pnl_bottom = new System.Windows.Forms.Panel();
            this.btn_back = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_search = new System.Windows.Forms.Button();
            this.pnl_top = new System.Windows.Forms.Panel();
            this.lbl_title = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnl_input = new System.Windows.Forms.Panel();
            this.btn_search_all = new System.Windows.Forms.Button();
            this.btn_clear_inputs = new System.Windows.Forms.Button();
            this.nud_price_max = new System.Windows.Forms.NumericUpDown();
            this.cmb_area = new System.Windows.Forms.ComboBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_equipment = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nud_headcount = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.pnl_bottom.SuspendLayout();
            this.pnl_top.SuspendLayout();
            this.pnl_input.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_price_max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_headcount)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_bottom
            // 
            this.pnl_bottom.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnl_bottom.Controls.Add(this.btn_back);
            this.pnl_bottom.Controls.Add(this.flowLayoutPanel2);
            this.pnl_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_bottom.Location = new System.Drawing.Point(0, 467);
            this.pnl_bottom.Name = "pnl_bottom";
            this.pnl_bottom.Size = new System.Drawing.Size(405, 50);
            this.pnl_bottom.TabIndex = 3;
            // 
            // btn_back
            // 
            this.btn_back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_back.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(119, 9);
            this.btn_back.Margin = new System.Windows.Forms.Padding(2);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(166, 30);
            this.btn_back.TabIndex = 9;
            this.btn_back.Text = "Peruuta";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Location = new System.Drawing.Point(-17, 329);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(699, 84);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // btn_search
            // 
            this.btn_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_search.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(200, 350);
            this.btn_search.Margin = new System.Windows.Forms.Padding(2);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(143, 30);
            this.btn_search.TabIndex = 8;
            this.btn_search.Text = "Hae kriteereillä";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // pnl_top
            // 
            this.pnl_top.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnl_top.Controls.Add(this.lbl_title);
            this.pnl_top.Controls.Add(this.flowLayoutPanel1);
            this.pnl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_top.Location = new System.Drawing.Point(0, 0);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(405, 50);
            this.pnl_top.TabIndex = 2;
            // 
            // lbl_title
            // 
            this.lbl_title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(112, 9);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(173, 29);
            this.lbl_title.TabIndex = 2;
            this.lbl_title.Text = "Mökkien haku";
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
            this.pnl_input.Controls.Add(this.btn_search_all);
            this.pnl_input.Controls.Add(this.btn_clear_inputs);
            this.pnl_input.Controls.Add(this.btn_search);
            this.pnl_input.Controls.Add(this.nud_price_max);
            this.pnl_input.Controls.Add(this.cmb_area);
            this.pnl_input.Controls.Add(this.tb_name);
            this.pnl_input.Controls.Add(this.label1);
            this.pnl_input.Controls.Add(this.label8);
            this.pnl_input.Controls.Add(this.tb_equipment);
            this.pnl_input.Controls.Add(this.label6);
            this.pnl_input.Controls.Add(this.label5);
            this.pnl_input.Controls.Add(this.nud_headcount);
            this.pnl_input.Controls.Add(this.label3);
            this.pnl_input.Location = new System.Drawing.Point(12, 56);
            this.pnl_input.Name = "pnl_input";
            this.pnl_input.Size = new System.Drawing.Size(381, 405);
            this.pnl_input.TabIndex = 26;
            // 
            // btn_search_all
            // 
            this.btn_search_all.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_search_all.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_search_all.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search_all.Location = new System.Drawing.Point(20, 350);
            this.btn_search_all.Margin = new System.Windows.Forms.Padding(2);
            this.btn_search_all.Name = "btn_search_all";
            this.btn_search_all.Size = new System.Drawing.Size(143, 30);
            this.btn_search_all.TabIndex = 7;
            this.btn_search_all.Text = "Hae kaikki";
            this.btn_search_all.UseVisualStyleBackColor = false;
            this.btn_search_all.Click += new System.EventHandler(this.btn_search_all_Click);
            // 
            // btn_clear_inputs
            // 
            this.btn_clear_inputs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear_inputs.Location = new System.Drawing.Point(221, 12);
            this.btn_clear_inputs.Name = "btn_clear_inputs";
            this.btn_clear_inputs.Size = new System.Drawing.Size(143, 26);
            this.btn_clear_inputs.TabIndex = 1;
            this.btn_clear_inputs.Text = "Tyhjennä kentät";
            this.btn_clear_inputs.UseVisualStyleBackColor = true;
            this.btn_clear_inputs.Click += new System.EventHandler(this.btn_clear_inputs_Click);
            // 
            // nud_price_max
            // 
            this.nud_price_max.Cursor = System.Windows.Forms.Cursors.Default;
            this.nud_price_max.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_price_max.InterceptArrowKeys = false;
            this.nud_price_max.Location = new System.Drawing.Point(184, 140);
            this.nud_price_max.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nud_price_max.Name = "nud_price_max";
            this.nud_price_max.Size = new System.Drawing.Size(105, 26);
            this.nud_price_max.TabIndex = 4;
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
            this.cmb_area.Location = new System.Drawing.Point(137, 93);
            this.cmb_area.Name = "cmb_area";
            this.cmb_area.Size = new System.Drawing.Size(206, 28);
            this.cmb_area.Sorted = true;
            this.cmb_area.TabIndex = 3;
            // 
            // tb_name
            // 
            this.tb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_name.Location = new System.Drawing.Point(137, 53);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(206, 26);
            this.tb_name.TabIndex = 2;
            this.tb_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_name_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alue";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 234);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Varustelu";
            // 
            // tb_equipment
            // 
            this.tb_equipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_equipment.Location = new System.Drawing.Point(137, 234);
            this.tb_equipment.Multiline = true;
            this.tb_equipment.Name = "tb_equipment";
            this.tb_equipment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_equipment.Size = new System.Drawing.Size(227, 79);
            this.tb_equipment.TabIndex = 6;
            this.tb_equipment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_equipment_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Hinta (Max)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Henkilömäärä (Min)";
            // 
            // nud_headcount
            // 
            this.nud_headcount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_headcount.Location = new System.Drawing.Point(184, 186);
            this.nud_headcount.Name = "nud_headcount";
            this.nud_headcount.Size = new System.Drawing.Size(105, 26);
            this.nud_headcount.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nimi";
            // 
            // Frm_search_cottages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 517);
            this.Controls.Add(this.pnl_input);
            this.Controls.Add(this.pnl_bottom);
            this.Controls.Add(this.pnl_top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Frm_search_cottages";
            this.Text = "Mökkien haku";
            this.Load += new System.EventHandler(this.Frm_search_cottages_Load);
            this.pnl_bottom.ResumeLayout(false);
            this.pnl_top.ResumeLayout(false);
            this.pnl_top.PerformLayout();
            this.pnl_input.ResumeLayout(false);
            this.pnl_input.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_price_max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_headcount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_bottom;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel pnl_input;
        private System.Windows.Forms.Button btn_clear_inputs;
        private System.Windows.Forms.ComboBox cmb_area;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_equipment;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nud_headcount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nud_price_max;
        private System.Windows.Forms.Button btn_search_all;
        private System.Windows.Forms.Button btn_back;
    }
}