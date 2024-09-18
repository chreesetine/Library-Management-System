namespace LibrarySystem.FORMS
{
    partial class Login_Form
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
            this.Login = new System.Windows.Forms.Panel();
            this.pictureBox_books = new System.Windows.Forms.PictureBox();
            this.button_login = new System.Windows.Forms.Button();
            this.label_x_button = new System.Windows.Forms.Label();
            this.txtbx_login_password = new System.Windows.Forms.TextBox();
            this.lbl_login_password = new System.Windows.Forms.Label();
            this.txtbx_login_id = new System.Windows.Forms.TextBox();
            this.lbl_login_id = new System.Windows.Forms.Label();
            this.lbl_LMS = new System.Windows.Forms.Label();
            this.Login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_books)).BeginInit();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.Color.DarkSalmon;
            this.Login.Controls.Add(this.pictureBox_books);
            this.Login.Controls.Add(this.button_login);
            this.Login.Controls.Add(this.label_x_button);
            this.Login.Controls.Add(this.txtbx_login_password);
            this.Login.Controls.Add(this.lbl_login_password);
            this.Login.Controls.Add(this.txtbx_login_id);
            this.Login.Controls.Add(this.lbl_login_id);
            this.Login.Controls.Add(this.lbl_LMS);
            this.Login.Location = new System.Drawing.Point(0, 0);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(562, 370);
            this.Login.TabIndex = 0;
            // 
            // pictureBox_books
            // 
            this.pictureBox_books.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_books.Location = new System.Drawing.Point(46, 36);
            this.pictureBox_books.Name = "pictureBox_books";
            this.pictureBox_books.Size = new System.Drawing.Size(48, 48);
            this.pictureBox_books.TabIndex = 7;
            this.pictureBox_books.TabStop = false;
            // 
            // button_login
            // 
            this.button_login.BackColor = System.Drawing.Color.IndianRed;
            this.button_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_login.ForeColor = System.Drawing.Color.Black;
            this.button_login.Location = new System.Drawing.Point(258, 276);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(81, 34);
            this.button_login.TabIndex = 6;
            this.button_login.Text = "Login";
            this.button_login.UseVisualStyleBackColor = false;
            this.button_login.Click += new System.EventHandler(this.button_login_Click_1);
            // 
            // label_x_button
            // 
            this.label_x_button.AutoSize = true;
            this.label_x_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_x_button.ForeColor = System.Drawing.Color.Maroon;
            this.label_x_button.Location = new System.Drawing.Point(535, 1);
            this.label_x_button.Name = "label_x_button";
            this.label_x_button.Size = new System.Drawing.Size(24, 24);
            this.label_x_button.TabIndex = 5;
            this.label_x_button.Text = "X";
            this.label_x_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_x_button.Click += new System.EventHandler(this.label_x_button_Click);
            this.label_x_button.MouseEnter += new System.EventHandler(this.label_x_button_MouseEnter_1);
            this.label_x_button.MouseLeave += new System.EventHandler(this.label_x_button_MouseLeave);
            // 
            // txtbx_login_password
            // 
            this.txtbx_login_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbx_login_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbx_login_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_login_password.Location = new System.Drawing.Point(211, 213);
            this.txtbx_login_password.MaxLength = 10;
            this.txtbx_login_password.Name = "txtbx_login_password";
            this.txtbx_login_password.PasswordChar = '*';
            this.txtbx_login_password.Size = new System.Drawing.Size(246, 31);
            this.txtbx_login_password.TabIndex = 7;
            this.txtbx_login_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtbx_login_password.UseSystemPasswordChar = true;
            // 
            // lbl_login_password
            // 
            this.lbl_login_password.AutoSize = true;
            this.lbl_login_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login_password.Location = new System.Drawing.Point(73, 216);
            this.lbl_login_password.Name = "lbl_login_password";
            this.lbl_login_password.Size = new System.Drawing.Size(121, 25);
            this.lbl_login_password.TabIndex = 3;
            this.lbl_login_password.Text = "Password:";
            // 
            // txtbx_login_id
            // 
            this.txtbx_login_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbx_login_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_login_id.Location = new System.Drawing.Point(210, 146);
            this.txtbx_login_id.Multiline = true;
            this.txtbx_login_id.Name = "txtbx_login_id";
            this.txtbx_login_id.Size = new System.Drawing.Size(246, 29);
            this.txtbx_login_id.TabIndex = 2;
            this.txtbx_login_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_login_id
            // 
            this.lbl_login_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login_id.Location = new System.Drawing.Point(73, 147);
            this.lbl_login_id.Name = "lbl_login_id";
            this.lbl_login_id.Size = new System.Drawing.Size(130, 29);
            this.lbl_login_id.TabIndex = 1;
            this.lbl_login_id.Text = "Library ID: ";
            // 
            // lbl_LMS
            // 
            this.lbl_LMS.AutoSize = true;
            this.lbl_LMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LMS.Location = new System.Drawing.Point(100, 44);
            this.lbl_LMS.Name = "lbl_LMS";
            this.lbl_LMS.Size = new System.Drawing.Size(413, 33);
            this.lbl_LMS.TabIndex = 0;
            this.lbl_LMS.Text = "Library Management System";
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 365);
            this.Controls.Add(this.Login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login_Form";
            this.Load += new System.EventHandler(this.Login_Form_Load_1);
            this.Login.ResumeLayout(false);
            this.Login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_books)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Login;
        private System.Windows.Forms.Label lbl_LMS;
        private System.Windows.Forms.TextBox txtbx_login_id;
        private System.Windows.Forms.Label lbl_login_id;
        private System.Windows.Forms.TextBox txtbx_login_password;
        private System.Windows.Forms.Label lbl_login_password;
        private System.Windows.Forms.Label label_x_button;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.PictureBox pictureBox_books;
    }
}