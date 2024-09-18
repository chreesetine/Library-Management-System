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
using static System.Collections.Specialized.BitVector32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using TextBox = System.Windows.Forms.TextBox;

namespace LibrarySystem.FORMS
{
    public partial class StudentInfo : Form
    {
        public StudentInfo()
        {
            InitializeComponent();
        }

        private void btn_back_studentInfoPanel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StudentInfo_Load(object sender, EventArgs e) 
        {
            MySqlConnection con = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=libsys");
            con.Open();
            dataGridView_studentInfo.DataSource = null;
            MySqlDataAdapter adapt = new MySqlDataAdapter("Select * from student_info", con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            dataGridView_studentInfo.DataSource = dt;
            con.Close();

            pictureBox_books_dshbrd2.Image = Image.FromFile("../../IMAGES/shelf_icon.png");
        }

        private void Btn_add_StudInfo_Click(object sender, EventArgs e)
        {
            Panel_StudentInfo.BringToFront();
            //stud id, name, course, year, section, contact number, status
            if (Txtbx_studID_studInfo.Text != "" && Txtbx_name_studInfo.Text != "" && Txtbx_course_studInfo.Text != "" && Txtbx_year_studInfo.Text != "" && Txtbx_section_studInfo.Text != "" && Txtbx_conNum_studInfo.Text != "")
            {
                string student_id = Txtbx_studID_studInfo.Text;
                string sname = Txtbx_name_studInfo.Text;
                string course = Txtbx_course_studInfo.Text;
                string year = Txtbx_year_studInfo.Text;
                string section= Txtbx_section_studInfo.Text;
                string contact_no = Txtbx_conNum_studInfo.Text;

                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = "server=localhost;port=3306;username=root;password=;database=libsys";
                con.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;

                //stud id, name, course, year, section, contact number, book_id
                cmd.CommandText = "INSERT INTO `student_info`(`student_id`,`sname`,`course`,`year`,`section`,`contact_no`) VALUES (@student_id,@sname,@course,@year,@section,@con_num)";
                cmd.Parameters.AddWithValue("@student_id", (Txtbx_studID_studInfo.Text));
                cmd.Parameters.AddWithValue("@sname", (Txtbx_name_studInfo.Text));
                cmd.Parameters.AddWithValue("@course", (Txtbx_course_studInfo.Text));
                cmd.Parameters.AddWithValue("@year", (Txtbx_year_studInfo.Text));
                cmd.Parameters.AddWithValue("@section", (Txtbx_section_studInfo.Text));
                cmd.Parameters.AddWithValue("@con_num", (Txtbx_conNum_studInfo.Text));
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data Saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please fill the empty fields.", "Suggest", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Btn_load_studentInfo_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=libsys");
            con.Open();
            dataGridView_studentInfo.DataSource = null;
            MySqlDataAdapter adapt = new MySqlDataAdapter("Select * from student_info", con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            dataGridView_studentInfo.DataSource = dt;
            con.Close();
        }

        private void Btn_edit_StudInfo_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=libsys");
            con.Open();
            dataGridView_studentInfo.DataSource = null;
            MySqlDataAdapter adapt = new MySqlDataAdapter("Select * from student_info", con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            dataGridView_studentInfo.DataSource = dt;
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            try
            {
                cmd.CommandText = "UPDATE `student_info` SET `student_id`= @stud_id,`sname`= @sname,`course`= @course,`year`= @year,`section`= @section,`contact_no`= @con_num WHERE `student_id`= @stud_id";
                cmd.Parameters.AddWithValue("@stud_id", (Txtbx_studID_studInfo.Text));
                cmd.Parameters.AddWithValue("@sname", (Txtbx_name_studInfo.Text));
                cmd.Parameters.AddWithValue("@course", (Txtbx_course_studInfo.Text));
                cmd.Parameters.AddWithValue("@year", (Txtbx_year_studInfo.Text));
                cmd.Parameters.AddWithValue("@section", (Txtbx_section_studInfo.Text));
                cmd.Parameters.AddWithValue("@con_num", (Txtbx_conNum_studInfo.Text));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Updated!");
                Txtbx_studID_studInfo.Focus();
                Txtbx_name_studInfo.Clear();
                Txtbx_course_studInfo.Clear();
                Txtbx_year_studInfo.Clear();
                Txtbx_section_studInfo.Clear();
                Txtbx_conNum_studInfo.Clear();
            }
            catch (Exception)
            {
                throw;
            }
            con.Close();
        }

        private void Txtbx_studID_studInfo_TextChanged(object sender, EventArgs e) // may reader
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "server=localhost;port=3306;username=root;password=;database=libsys";
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "SELECT `student_id`, `sname`, `course`, `year`, `section`, `contact_no` FROM `student_info` WHERE `student_id`=@stud_id";
            cmd.Parameters.AddWithValue("@stud_id", (Txtbx_studID_studInfo.Text));
            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                //stud id, name, course, year, section, contact number, status
                Txtbx_studID_studInfo.Text = reader["student_id"].ToString();
                Txtbx_name_studInfo.Text = reader["sname"].ToString();
                Txtbx_course_studInfo.Text = reader["course"].ToString();
                Txtbx_year_studInfo.Text = reader["year"].ToString();
                Txtbx_section_studInfo.Text = reader["section"].ToString();
                Txtbx_conNum_studInfo.Text = reader["contact_no"].ToString();

            }
            con.Close();
        }

        private void Btn_delete_StudInfo_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "server=localhost;port=3306;username=root;password=;database=libsys";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            con.Open();

            try
            {
                //stud id, fullname, course, year, section, contact number
                cmd = con.CreateCommand();
                cmd.CommandText = "DELETE FROM `student_info` WHERE `student_id`= @stud_id";
                cmd.Parameters.AddWithValue("stud_id", (Txtbx_studID_studInfo.Text));
                cmd.Parameters.AddWithValue("@sname", (Txtbx_name_studInfo.Text));
                cmd.Parameters.AddWithValue("course", (Txtbx_course_studInfo.Text));
                cmd.Parameters.AddWithValue("@year", (Txtbx_year_studInfo.Text));
                cmd.Parameters.AddWithValue("@section", (Txtbx_section_studInfo.Text));
                cmd.Parameters.AddWithValue("@con_num", (Txtbx_conNum_studInfo.Text));
                cmd.ExecuteNonQuery();

                MessageBox.Show("Successfully Deleted!");
                Txtbx_studID_studInfo.Focus();
                Txtbx_name_studInfo.Clear();
                Txtbx_course_studInfo.Clear();
                Txtbx_year_studInfo.Clear();
                Txtbx_section_studInfo.Clear();
                Txtbx_conNum_studInfo.Clear();
            }
            catch (Exception)
            {

            }
            con.Close();
        }

        private void Button_clear_studInfo_Click(object sender, EventArgs e) // not yet working properly
        {
            foreach (var control in Panel_studInfo.Controls)
            {
                if (control.GetType() == typeof(TextBox))
                {
                    TextBox textbox = (TextBox)control;
                    textbox.Text = "";
                }
            }
        }

        private void label_x_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
