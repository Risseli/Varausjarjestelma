namespace OT1_R4
{
    partial class Frm_searchreservation
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
            this.lbl_searchres = new System.Windows.Forms.Label();
            this.lbl_logo = new System.Windows.Forms.Label();
            this.panel_down = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.dgv_searchres = new System.Windows.Forms.DataGridView();
            this.panel_up.SuspendLayout();
            this.panel_down.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_searchres)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_up
            // 
            this.panel_up.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel_up.Controls.Add(this.lbl_searchres);
            this.panel_up.Controls.Add(this.lbl_logo);
            this.panel_up.Location = new System.Drawing.Point(0, 1);
            this.panel_up.Name = "panel_up";
            this.panel_up.Size = new System.Drawing.Size(1060, 76);
            this.panel_up.TabIndex = 0;
            // 
            // lbl_searchres
            // 
            this.lbl_searchres.AutoSize = true;
            this.lbl_searchres.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_searchres.Location = new System.Drawing.Point(47, 20);
            this.lbl_searchres.Name = "lbl_searchres";
            this.lbl_searchres.Size = new System.Drawing.Size(208, 32);
            this.lbl_searchres.TabIndex = 7;
            this.lbl_searchres.Text = "Hae varauksia";
            // 
            // lbl_logo
            // 
            this.lbl_logo.AutoSize = true;
            this.lbl_logo.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_logo.Location = new System.Drawing.Point(669, 20);
            this.lbl_logo.Name = "lbl_logo";
            this.lbl_logo.Size = new System.Drawing.Size(360, 42);
            this.lbl_logo.TabIndex = 6;
            this.lbl_logo.Text = "Village Newbies Oy";
            // 
            // panel_down
            // 
            this.panel_down.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel_down.Controls.Add(this.btn_close);
            this.panel_down.Location = new System.Drawing.Point(0, 545);
            this.panel_down.Name = "panel_down";
            this.panel_down.Size = new System.Drawing.Size(1060, 76);
            this.panel_down.TabIndex = 1;
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.Location = new System.Drawing.Point(12, 16);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(189, 40);
            this.btn_close.TabIndex = 10;
            this.btn_close.Text = "Palaa";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(20, 93);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(181, 31);
            this.btn_search.TabIndex = 2;
            this.btn_search.Text = "Hae varaukset";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // dgv_searchres
            // 
            this.dgv_searchres.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_searchres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_searchres.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgv_searchres.Location = new System.Drawing.Point(270, 93);
            this.dgv_searchres.Name = "dgv_searchres";
            this.dgv_searchres.RowHeadersWidth = 51;
            this.dgv_searchres.RowTemplate.Height = 24;
            this.dgv_searchres.Size = new System.Drawing.Size(759, 430);
            this.dgv_searchres.TabIndex = 3;
            // 
            // Frm_searchreservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 622);
            this.Controls.Add(this.dgv_searchres);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.panel_down);
            this.Controls.Add(this.panel_up);
            this.Name = "Frm_searchreservation";
            this.Text = "Frm_searchreservationscs";
            this.panel_up.ResumeLayout(false);
            this.panel_up.PerformLayout();
            this.panel_down.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_searchres)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_up;
        private System.Windows.Forms.Panel panel_down;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label lbl_logo;
        private System.Windows.Forms.Label lbl_searchres;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.DataGridView dgv_searchres;
    }
}