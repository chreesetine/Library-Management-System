namespace LibrarySystem.FORMS
{
    partial class ViewLibrarian
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
            this.Panel_viewL = new System.Windows.Forms.Panel();
            this.DTG_viewL = new System.Windows.Forms.DataGridView();
            this.label_x_button = new System.Windows.Forms.Label();
            this.Panel_viewLib = new System.Windows.Forms.Panel();
            this.label_title_dashboard = new System.Windows.Forms.Label();
            this.pictureBox_books_viewLib = new System.Windows.Forms.PictureBox();
            this.Lbl_librarian = new System.Windows.Forms.Label();
            this.Btn_back_trans = new System.Windows.Forms.Button();
            this.Panel_viewL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTG_viewL)).BeginInit();
            this.Panel_viewLib.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_books_viewLib)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_viewL
            // 
            this.Panel_viewL.BackColor = System.Drawing.Color.Bisque;
            this.Panel_viewL.Controls.Add(this.DTG_viewL);
            this.Panel_viewL.Controls.Add(this.label_x_button);
            this.Panel_viewL.Controls.Add(this.Panel_viewLib);
            this.Panel_viewL.Location = new System.Drawing.Point(0, 0);
            this.Panel_viewL.Name = "Panel_viewL";
            this.Panel_viewL.Size = new System.Drawing.Size(616, 383);
            this.Panel_viewL.TabIndex = 0;
            // 
            // DTG_viewL
            // 
            this.DTG_viewL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTG_viewL.Location = new System.Drawing.Point(50, 107);
            this.DTG_viewL.Name = "DTG_viewL";
            this.DTG_viewL.Size = new System.Drawing.Size(506, 264);
            this.DTG_viewL.TabIndex = 8;
            // 
            // label_x_button
            // 
            this.label_x_button.AutoSize = true;
            this.label_x_button.BackColor = System.Drawing.Color.Transparent;
            this.label_x_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_x_button.ForeColor = System.Drawing.Color.Maroon;
            this.label_x_button.Location = new System.Drawing.Point(592, 0);
            this.label_x_button.Name = "label_x_button";
            this.label_x_button.Size = new System.Drawing.Size(24, 24);
            this.label_x_button.TabIndex = 6;
            this.label_x_button.Text = "X";
            this.label_x_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_x_button.Click += new System.EventHandler(this.label_x_button_Click);
            // 
            // Panel_viewLib
            // 
            this.Panel_viewLib.BackColor = System.Drawing.Color.Tan;
            this.Panel_viewLib.Controls.Add(this.label_title_dashboard);
            this.Panel_viewLib.Controls.Add(this.pictureBox_books_viewLib);
            this.Panel_viewLib.Controls.Add(this.Lbl_librarian);
            this.Panel_viewLib.Controls.Add(this.Btn_back_trans);
            this.Panel_viewLib.Location = new System.Drawing.Point(0, 0);
            this.Panel_viewLib.Name = "Panel_viewLib";
            this.Panel_viewLib.Size = new System.Drawing.Size(616, 100);
            this.Panel_viewLib.TabIndex = 7;
            // 
            // label_title_dashboard
            // 
            this.label_title_dashboard.BackColor = System.Drawing.Color.Transparent;
            this.label_title_dashboard.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title_dashboard.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_title_dashboard.Location = new System.Drawing.Point(246, 12);
            this.label_title_dashboard.Name = "label_title_dashboard";
            this.label_title_dashboard.Size = new System.Drawing.Size(180, 42);
            this.label_title_dashboard.TabIndex = 17;
            this.label_title_dashboard.Text = "MegaBox Library";
            this.label_title_dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox_books_viewLib
            // 
            this.pictureBox_books_viewLib.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_books_viewLib.Location = new System.Drawing.Point(195, 10);
            this.pictureBox_books_viewLib.Name = "pictureBox_books_viewLib";
            this.pictureBox_books_viewLib.Size = new System.Drawing.Size(48, 48);
            this.pictureBox_books_viewLib.TabIndex = 16;
            this.pictureBox_books_viewLib.TabStop = false;
            // 
            // Lbl_librarian
            // 
            this.Lbl_librarian.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_librarian.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_librarian.Location = new System.Drawing.Point(189, 60);
            this.Lbl_librarian.Name = "Lbl_librarian";
            this.Lbl_librarian.Size = new System.Drawing.Size(273, 39);
            this.Lbl_librarian.TabIndex = 15;
            this.Lbl_librarian.Text = "View Librarians";
            // 
            // Btn_back_trans
            // 
            this.Btn_back_trans.BackColor = System.Drawing.Color.White;
            this.Btn_back_trans.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_back_trans.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_back_trans.Location = new System.Drawing.Point(7, 8);
            this.Btn_back_trans.Name = "Btn_back_trans";
            this.Btn_back_trans.Size = new System.Drawing.Size(75, 23);
            this.Btn_back_trans.TabIndex = 8;
            this.Btn_back_trans.Text = "Back";
            this.Btn_back_trans.UseVisualStyleBackColor = false;
            this.Btn_back_trans.Click += new System.EventHandler(this.Btn_back_trans_Click);
            // 
            // ViewLibrarian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 383);
            this.Controls.Add(this.Panel_viewL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewLibrarian";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewLibrarian";
            this.Load += new System.EventHandler(this.ViewLibrarian_Load);
            this.Panel_viewL.ResumeLayout(false);
            this.Panel_viewL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTG_viewL)).EndInit();
            this.Panel_viewLib.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_books_viewLib)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_viewL;
        private System.Windows.Forms.Label label_x_button;
        private System.Windows.Forms.Panel Panel_viewLib;
        private System.Windows.Forms.Button Btn_back_trans;
        private System.Windows.Forms.Label Lbl_librarian;
        private System.Windows.Forms.Label label_title_dashboard;
        private System.Windows.Forms.PictureBox pictureBox_books_viewLib;
        private System.Windows.Forms.DataGridView DTG_viewL;
    }
}