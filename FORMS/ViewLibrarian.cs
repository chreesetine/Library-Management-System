using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem.FORMS
{
    public partial class ViewLibrarian : Form
    {
        public ViewLibrarian()
        {
            InitializeComponent();
        }

        private void label_x_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_back_trans_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ViewLibrarian_Load(object sender, EventArgs e)
        {
            pictureBox_books_viewLib.Image = Image.FromFile("../../IMAGES/shelf_icon.png");

            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "server=localhost;port=3306;username=root;password=;database=libsys";
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;

            try
            {
                con.CreateCommand();
                cmd.CommandText = "SELECT id, fname, lname, library_id, user_type FROM app_users";
                MySqlDataAdapter adapt = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                DTG_viewL.DataSource = dt;
            }

            catch (Exception)
            {
                throw;
            }
        }
    }
}
