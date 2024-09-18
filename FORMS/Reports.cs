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
using System.Configuration;

namespace LibrarySystem.FORMS
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            pictureBox_books_reps.Image = Image.FromFile("../../IMAGES/shelf_icon.png");

            string mainconn = ConfigurationManager.ConnectionStrings["mysqlconnection"].ConnectionString;
            MySqlConnection con = new MySqlConnection(mainconn);
            //string sqlquery = "SELECT student_id, sname, title, genre, date_borrowed, due_date, penalty, status FROM student_info t1 INNER JOIN books t2 ON t1.book_id = t2.book_id INNER JOIN transaction t3 ON t1.student_id = t3.student_id";
            string sqlquery = "SELECT student_info.student_id, student_info.sname, books.book_id, books.title, books.genre, transaction.date_borrowed, transaction.due_date, transaction.penalty, transaction.status FROM student_info, books, transaction WHERE transaction.book_id = books.book_id AND student_info.student_id = transaction.student_id ORDER BY student_info.student_id";
            con.Open();
            MySqlCommand cmd = new MySqlCommand(sqlquery, con);
            MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            DTG_reports.DataSource = dt;
            con.Close();
        }

        private void Btn_back_trans_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label_x_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
