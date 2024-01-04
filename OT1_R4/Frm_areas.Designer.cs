namespace OT1_R4
{
    partial class Frm_areas
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnl_bottom = new System.Windows.Forms.Panel();
            this.btn_back = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.lb_area = new System.Windows.Forms.ListBox();
            this.btn_add_area = new System.Windows.Forms.Button();
            this.btn_rename_area = new System.Windows.Forms.Button();
            this.tb_add_area = new System.Windows.Forms.TextBox();
            this.btn_delete_area = new System.Windows.Forms.Button();
            this.lbl_id = new System.Windows.Forms.Label();
            this.pnl_inputs = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pnl_top.SuspendLayout();
            this.pnl_bottom.SuspendLayout();
            this.pnl_inputs.SuspendLayout();
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
            this.pnl_top.Size = new System.Drawing.Size(423, 50);
            this.pnl_top.TabIndex = 0;
            // 
            // lbl_title
            // 
            this.lbl_title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(147, 9);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(87, 29);
            this.lbl_title.TabIndex = 2;
            this.lbl_title.Text = "Alueet";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(-17, 329);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(699, 84);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // pnl_bottom
            // 
            this.pnl_bottom.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnl_bottom.Controls.Add(this.btn_back);
            this.pnl_bottom.Controls.Add(this.flowLayoutPanel2);
            this.pnl_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_bottom.Location = new System.Drawing.Point(0, 332);
            this.pnl_bottom.Name = "pnl_bottom";
            this.pnl_bottom.Size = new System.Drawing.Size(423, 50);
            this.pnl_bottom.TabIndex = 1;
            // 
            // btn_back
            // 
            this.btn_back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_back.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(152, 9);
            this.btn_back.Margin = new System.Windows.Forms.Padding(2);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(103, 30);
            this.btn_back.TabIndex = 5;
            this.btn_back.Text = "Palaa";
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
            // lb_area
            // 
            this.lb_area.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_area.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_area.FormattingEnabled = true;
            this.lb_area.ItemHeight = 20;
            this.lb_area.Location = new System.Drawing.Point(12, 57);
            this.lb_area.Name = "lb_area";
            this.lb_area.Size = new System.Drawing.Size(211, 224);
            this.lb_area.Sorted = true;
            this.lb_area.TabIndex = 4;
            this.lb_area.TabStop = false;
            this.lb_area.SelectedIndexChanged += new System.EventHandler(this.lb_area_SelectedIndexChanged);
            // 
            // btn_add_area
            // 
            this.btn_add_area.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_area.Location = new System.Drawing.Point(14, 105);
            this.btn_add_area.Name = "btn_add_area";
            this.btn_add_area.Size = new System.Drawing.Size(165, 30);
            this.btn_add_area.TabIndex = 2;
            this.btn_add_area.Text = "Lisää alue";
            this.btn_add_area.UseVisualStyleBackColor = true;
            this.btn_add_area.Click += new System.EventHandler(this.btn_add_area_Click);
            // 
            // btn_rename_area
            // 
            this.btn_rename_area.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rename_area.Location = new System.Drawing.Point(14, 153);
            this.btn_rename_area.Name = "btn_rename_area";
            this.btn_rename_area.Size = new System.Drawing.Size(165, 30);
            this.btn_rename_area.TabIndex = 3;
            this.btn_rename_area.Text = "Nimeä uudelleen";
            this.btn_rename_area.UseVisualStyleBackColor = true;
            this.btn_rename_area.Click += new System.EventHandler(this.btn_rename_area_Click);
            // 
            // tb_add_area
            // 
            this.tb_add_area.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_add_area.Location = new System.Drawing.Point(14, 47);
            this.tb_add_area.MaxLength = 40;
            this.tb_add_area.Name = "tb_add_area";
            this.tb_add_area.Size = new System.Drawing.Size(165, 23);
            this.tb_add_area.TabIndex = 1;
            this.tb_add_area.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_add_area_KeyPress);
            // 
            // btn_delete_area
            // 
            this.btn_delete_area.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete_area.Location = new System.Drawing.Point(14, 201);
            this.btn_delete_area.Name = "btn_delete_area";
            this.btn_delete_area.Size = new System.Drawing.Size(165, 30);
            this.btn_delete_area.TabIndex = 4;
            this.btn_delete_area.Text = "Poista alue";
            this.btn_delete_area.UseVisualStyleBackColor = true;
            this.btn_delete_area.Click += new System.EventHandler(this.btn_delete_area_Click);
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Location = new System.Drawing.Point(11, 17);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(30, 16);
            this.lbl_id.TabIndex = 24;
            this.lbl_id.Text = "ID: ";
            // 
            // pnl_inputs
            // 
            this.pnl_inputs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_inputs.BackColor = System.Drawing.SystemColors.Control;
            this.pnl_inputs.Controls.Add(this.btn_add_area);
            this.pnl_inputs.Controls.Add(this.lbl_id);
            this.pnl_inputs.Controls.Add(this.btn_rename_area);
            this.pnl_inputs.Controls.Add(this.btn_delete_area);
            this.pnl_inputs.Controls.Add(this.tb_add_area);
            this.pnl_inputs.Location = new System.Drawing.Point(232, 50);
            this.pnl_inputs.Name = "pnl_inputs";
            this.pnl_inputs.Size = new System.Drawing.Size(191, 282);
            this.pnl_inputs.TabIndex = 25;
            // 
            // Frm_areas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 382);
            this.Controls.Add(this.pnl_inputs);
            this.Controls.Add(this.lb_area);
            this.Controls.Add(this.pnl_bottom);
            this.Controls.Add(this.pnl_top);
            this.MinimumSize = new System.Drawing.Size(439, 421);
            this.Name = "Frm_areas";
            this.Text = "Alueiden hallinta";
            this.Load += new System.EventHandler(this.Frm_areas_Load);
            this.SizeChanged += new System.EventHandler(this.Frm_areas_SizeChanged);
            this.pnl_top.ResumeLayout(false);
            this.pnl_top.PerformLayout();
            this.pnl_bottom.ResumeLayout(false);
            this.pnl_inputs.ResumeLayout(false);
            this.pnl_inputs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel pnl_bottom;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.ListBox lb_area;
        private System.Windows.Forms.Button btn_add_area;
        private System.Windows.Forms.Button btn_rename_area;
        private System.Windows.Forms.TextBox tb_add_area;
        private System.Windows.Forms.Button btn_delete_area;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Panel pnl_inputs;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}