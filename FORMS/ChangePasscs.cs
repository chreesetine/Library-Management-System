using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace LibrarySystem.FORMS
{
    public partial class ChangePass : Form
    {
        public ChangePass()
        {
            InitializeComponent();
        }

        private void Btn_back_reps_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_update_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "server=localhost;port=3306;username=root;password=;database=libsys";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            con.Open();

            try
            {
                MySqlCommand ChangePass = new MySqlCommand("SELECT library_id FROM app_users WHERE library_id = '" + (Txtbx_libID.Text) + "'" + "AND password = '" + (Txtbx_oldP.Text) + "'", con);
                MySqlDataAdapter adapter = new MySqlDataAdapter(ChangePass);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    cmd = con.CreateCommand();
                    MySqlCommand Password = new MySqlCommand("UPDATE app_users set password = '" + Txtbx_newP.Text + "'" + "where password = '" + (Txtbx_oldP.Text) + "'", con);
                    Password.ExecuteNonQuery();
                    con.Close();
                    Txtbx_newP.Clear();
                    MessageBox.Show("Password Change");
                }
            }
            catch (Exception)
            {
                
            }
            } //update closing bracket

        private void label_x_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChangePass_Load(object sender, EventArgs e)
        {
            pictureBox_books_changeLib.Image = Image.FromFile("../../IMAGES/shelf_icon.png");
        }
    }
    }

