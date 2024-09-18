namespace LibrarySystem.FORMS
{
    partial class Users_Form
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
            this.Pnl_users = new System.Windows.Forms.Panel();
            this.Btn_logout = new System.Windows.Forms.Button();
            this.Panel_up_trans = new System.Windows.Forms.Panel();
            this.label_x_button = new System.Windows.Forms.Label();
            this.label_title_dashboard = new System.Windows.Forms.Label();
            this.pictureBox_books_users = new System.Windows.Forms.PictureBox();
            this.Btn_back_users = new System.Windows.Forms.Button();
            this.Lbl_Users = new System.Windows.Forms.Label();
            this.Btn_viewLib = new System.Windows.Forms.Button();
            this.Button_changePass = new System.Windows.Forms.Button();
            this.Pnl_users.SuspendLayout();
            this.Panel_up_trans.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_books_users)).BeginInit();
            this.SuspendLayout();
            // 
            // Pnl_users
            // 
            this.Pnl_users.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Pnl_users.Controls.Add(this.Button_changePass);
            this.Pnl_users.Controls.Add(this.Btn_logout);
            this.Pnl_users.Controls.Add(this.Panel_up_trans);
            this.Pnl_users.Controls.Add(this.Btn_viewLib);
            this.Pnl_users.Location = new System.Drawing.Point(1, 1);
            this.Pnl_users.Name = "Pnl_users";
            this.Pnl_users.Size = new System.Drawing.Size(1044, 448);
            this.Pnl_users.TabIndex = 0;
            // 
            // Btn_logout
            // 
            this.Btn_logout.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_logout.Location = new System.Drawing.Point(268, 299);
            this.Btn_logout.Name = "Btn_logout";
            this.Btn_logout.Size = new System.Drawing.Size(97, 68);
            this.Btn_logout.TabIndex = 3;
            this.Btn_logout.Text = "Logout";
            this.Btn_logout.UseVisualStyleBackColor = false;
            this.Btn_logout.Click += new System.EventHandler(this.Btn_logout_Click);
            // 
            // Panel_up_trans
            // 
            this.Panel_up_trans.BackColor = System.Drawing.Color.MediumAquamarine;
            this.Panel_up_trans.Controls.Add(this.label_x_button);
            this.Panel_up_trans.Controls.Add(this.label_title_dashboard);
            this.Panel_up_trans.Controls.Add(this.pictureBox_books_users);
            this.Panel_up_trans.Controls.Add(this.Btn_back_users);
            this.Panel_up_trans.Controls.Add(this.Lbl_Users);
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
            this.label_x_button.Location = new System.Drawing.Point(602, 3);
            this.label_x_button.Name = "label_x_button";
            this.label_x_button.Size = new System.Drawing.Size(24, 24);
            this.label_x_button.TabIndex = 15;
            this.label_x_button.Text = "X";
            this.label_x_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_x_button.Click += new System.EventHandler(this.label_x_button_Click);
            // 
            // label_title_dashboard
            // 
            this.label_title_dashboard.BackColor = System.Drawing.Color.Transparent;
            this.label_title_dashboard.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title_dashboard.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_title_dashboard.Location = new System.Drawing.Point(236, 4);
            this.label_title_dashboard.Name = "label_title_dashboard";
            this.label_title_dashboard.Size = new System.Drawing.Size(180, 42);
            this.label_title_dashboard.TabIndex = 13;
            this.label_title_dashboard.Text = "MegaBox Library";
            this.label_title_dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox_books_users
            // 
            this.pictureBox_books_users.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_books_users.Location = new System.Drawing.Point(180, 2);
            this.pictureBox_books_users.Name = "pictureBox_books_users";
            this.pictureBox_books_users.Size = new System.Drawing.Size(48, 48);
            this.pictureBox_books_users.TabIndex = 12;
            this.pictureBox_books_users.TabStop = false;
            // 
            // Btn_back_users
            // 
            this.Btn_back_users.BackColor = System.Drawing.Color.White;
            this.Btn_back_users.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_back_users.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_back_users.Location = new System.Drawing.Point(25, 21);
            this.Btn_back_users.Name = "Btn_back_users";
            this.Btn_back_users.Size = new System.Drawing.Size(75, 23);
            this.Btn_back_users.TabIndex = 0;
            this.Btn_back_users.Text = "Back";
            this.Btn_back_users.UseVisualStyleBackColor = false;
            this.Btn_back_users.Click += new System.EventHandler(this.Btn_back_users_Click);
            // 
            // Lbl_Users
            // 
            this.Lbl_Users.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Users.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Users.Location = new System.Drawing.Point(267, 40);
            this.Lbl_Users.Name = "Lbl_Users";
            this.Lbl_Users.Size = new System.Drawing.Size(114, 39);
            this.Lbl_Users.TabIndex = 14;
            this.Lbl_Users.Text = "Users";
            // 
            // Btn_viewLib
            // 
            this.Btn_viewLib.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_viewLib.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_viewLib.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_viewLib.Location = new System.Drawing.Point(239, 154);
            this.Btn_viewLib.Name = "Btn_viewLib";
            this.Btn_viewLib.Size = new System.Drawing.Size(149, 68);
            this.Btn_viewLib.TabIndex = 0;
            this.Btn_viewLib.Text = "View Librarian";
            this.Btn_viewLib.UseVisualStyleBackColor = false;
            this.Btn_viewLib.Click += new System.EventHandler(this.Btn_viewLib_Click);
            // 
            // Button_changePass
            // 
            this.Button_changePass.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button_changePass.Cursor = System.Windows.Forms.Cursors.Default;
            this.Button_changePass.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_changePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_changePass.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Button_changePass.Location = new System.Drawing.Point(239, 228);
            this.Button_changePass.Name = "Button_changePass";
            this.Button_changePass.Size = new System.Drawing.Size(149, 65);
            this.Button_changePass.TabIndex = 10;
            this.Button_changePass.Text = "Change Password";
            this.Button_changePass.UseVisualStyleBackColor = false;
            this.Button_changePass.Click += new System.EventHandler(this.Button_changePass_Click);
            // 
            // Users_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 450);
            this.Controls.Add(this.Pnl_users);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Users_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Users_Form";
            this.Pnl_users.ResumeLayout(false);
            this.Panel_up_trans.ResumeLayout(false);
            this.Panel_up_trans.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_books_users)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_users;
        private System.Windows.Forms.Button Btn_viewLib;
        private System.Windows.Forms.Panel Panel_up_trans;
        private System.Windows.Forms.Label label_title_dashboard;
        private System.Windows.Forms.PictureBox pictureBox_books_users;
        private System.Windows.Forms.Button Btn_back_users;
        private System.Windows.Forms.Label Lbl_Users;
        private System.Windows.Forms.Button Btn_logout;
        private System.Windows.Forms.Label label_x_button;
        private System.Windows.Forms.Button Button_changePass;
    }
}