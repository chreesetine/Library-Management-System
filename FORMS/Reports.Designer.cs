namespace LibrarySystem.FORMS
{
    partial class Reports
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
            this.Panel_up_trans = new System.Windows.Forms.Panel();
            this.label_x_button = new System.Windows.Forms.Label();
            this.label_title_dashboard = new System.Windows.Forms.Label();
            this.pictureBox_books_reps = new System.Windows.Forms.PictureBox();
            this.Btn_back_reps = new System.Windows.Forms.Button();
            this.Lbl_reports = new System.Windows.Forms.Label();
            this.Pnl_pink = new System.Windows.Forms.Panel();
            this.DTG_reports = new System.Windows.Forms.DataGridView();
            this.Panel_up_trans.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_books_reps)).BeginInit();
            this.Pnl_pink.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTG_reports)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_up_trans
            // 
            this.Panel_up_trans.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Panel_up_trans.Controls.Add(this.label_x_button);
            this.Panel_up_trans.Controls.Add(this.label_title_dashboard);
            this.Panel_up_trans.Controls.Add(this.pictureBox_books_reps);
            this.Panel_up_trans.Controls.Add(this.Btn_back_reps);
            this.Panel_up_trans.Controls.Add(this.Lbl_reports);
            this.Panel_up_trans.Location = new System.Drawing.Point(0, 0);
            this.Panel_up_trans.Name = "Panel_up_trans";
            this.Panel_up_trans.Size = new System.Drawing.Size(1044, 83);
            this.Panel_up_trans.TabIndex = 2;
            // 
            // label_x_button
            // 
            this.label_x_button.AutoSize = true;
            this.label_x_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_x_button.ForeColor = System.Drawing.Color.Maroon;
            this.label_x_button.Location = new System.Drawing.Point(1017, 2);
            this.label_x_button.Name = "label_x_button";
            this.label_x_button.Size = new System.Drawing.Size(24, 24);
            this.label_x_button.TabIndex = 6;
            this.label_x_button.Text = "X";
            this.label_x_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_x_button.Click += new System.EventHandler(this.label_x_button_Click);
            // 
            // label_title_dashboard
            // 
            this.label_title_dashboard.BackColor = System.Drawing.Color.Transparent;
            this.label_title_dashboard.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title_dashboard.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_title_dashboard.Location = new System.Drawing.Point(482, 3);
            this.label_title_dashboard.Name = "label_title_dashboard";
            this.label_title_dashboard.Size = new System.Drawing.Size(180, 42);
            this.label_title_dashboard.TabIndex = 13;
            this.label_title_dashboard.Text = "MegaBox Library";
            this.label_title_dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox_books_reps
            // 
            this.pictureBox_books_reps.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_books_reps.Location = new System.Drawing.Point(431, 2);
            this.pictureBox_books_reps.Name = "pictureBox_books_reps";
            this.pictureBox_books_reps.Size = new System.Drawing.Size(48, 48);
            this.pictureBox_books_reps.TabIndex = 12;
            this.pictureBox_books_reps.TabStop = false;
            // 
            // Btn_back_reps
            // 
            this.Btn_back_reps.BackColor = System.Drawing.Color.White;
            this.Btn_back_reps.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_back_reps.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_back_reps.Location = new System.Drawing.Point(25, 21);
            this.Btn_back_reps.Name = "Btn_back_reps";
            this.Btn_back_reps.Size = new System.Drawing.Size(75, 23);
            this.Btn_back_reps.TabIndex = 0;
            this.Btn_back_reps.Text = "Back";
            this.Btn_back_reps.UseVisualStyleBackColor = false;
            this.Btn_back_reps.Click += new System.EventHandler(this.Btn_back_trans_Click);
            // 
            // Lbl_reports
            // 
            this.Lbl_reports.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_reports.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_reports.Location = new System.Drawing.Point(496, 39);
            this.Lbl_reports.Name = "Lbl_reports";
            this.Lbl_reports.Size = new System.Drawing.Size(153, 39);
            this.Lbl_reports.TabIndex = 14;
            this.Lbl_reports.Text = "Reports";
            // 
            // Pnl_pink
            // 
            this.Pnl_pink.BackColor = System.Drawing.Color.LightCoral;
            this.Pnl_pink.Controls.Add(this.DTG_reports);
            this.Pnl_pink.Location = new System.Drawing.Point(0, 80);
            this.Pnl_pink.Name = "Pnl_pink";
            this.Pnl_pink.Size = new System.Drawing.Size(1044, 384);
            this.Pnl_pink.TabIndex = 5;
            // 
            // DTG_reports
            // 
            this.DTG_reports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTG_reports.Location = new System.Drawing.Point(47, 9);
            this.DTG_reports.Name = "DTG_reports";
            this.DTG_reports.Size = new System.Drawing.Size(943, 349);
            this.DTG_reports.TabIndex = 8;
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 450);
            this.Controls.Add(this.Panel_up_trans);
            this.Controls.Add(this.Pnl_pink);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.Reports_Load);
            this.Panel_up_trans.ResumeLayout(false);
            this.Panel_up_trans.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_books_reps)).EndInit();
            this.Pnl_pink.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DTG_reports)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Panel_up_trans;
        private System.Windows.Forms.Label label_title_dashboard;
        private System.Windows.Forms.PictureBox pictureBox_books_reps;
        private System.Windows.Forms.Button Btn_back_reps;
        private System.Windows.Forms.Label Lbl_reports;
        private System.Windows.Forms.Panel Pnl_pink;
        private System.Windows.Forms.DataGridView DTG_reports;
        private System.Windows.Forms.Label label_x_button;
    }
}