using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem.FORMS
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void label_x_button_MouseEnter_1(object sender, EventArgs e)
        {
            label_x_button.ForeColor = Color.Black;
        }

        private void label_x_button_MouseLeave(object sender, EventArgs e)
        {
            label_x_button.ForeColor = Color.White;
        }

        private void label_x_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Form_Load_1(object sender, EventArgs e)
        {
            pictureBox_books.Image = Image.FromFile("../../IMAGES/shelf_icon.png"); // App logo image
        }

        // manipulate the dashboard from the login form
        private Dashboard_Form dashF = null;
        public Login_Form(Dashboard_Form SourceForm)
        {
            dashF = SourceForm as Dashboard_Form;
            InitializeComponent();
        }

        // the login button
        private void button_login_Click_1(object sender, EventArgs e)
        {

            DATABASE.DB db = new DATABASE.DB();

            //int library_id = Convert.ToInt32(this.lbl_login_id.Text);
            string library_id = txtbx_login_id.Text;
            string password = txtbx_login_password.Text;

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `app_users` WHERE `library_id` =@lid AND `password` =@pass", db.getConnection());

            command.Parameters.Add("@lid", MySqlDbType.VarChar).Value = library_id;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            // checks if this user exists or not
            if (table.Rows.Count > 0) // if exist
            {
                dashF.Enabled = true;
                this.Close();
            }

            else // if user does not exist
            {
                // check if the library id is empty
                if (library_id.Trim().Equals(""))
                {
                    MessageBox.Show("Enter your Library ID to login", "Empty Library ID", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                // check if the password is empty
                else if (password.Trim().Equals(""))
                {
                    MessageBox.Show("Enter your password to login", "Empty password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // if this data doesn't exist
                else
                {
                    MessageBox.Show("Wrong Library ID or Password", "Wrong data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
