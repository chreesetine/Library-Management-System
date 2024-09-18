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
    public partial class Transaction_Form : Form
    {
        public Transaction_Form()
        {
            InitializeComponent();
        }

        private void Btn_back_trans_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_load_trans_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=libsys");
            con.Open();
            dataGridView_transaction.DataSource = null;
            MySqlDataAdapter adapt = new MySqlDataAdapter("Select * from transaction", con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            dataGridView_transaction.DataSource = dt;
            con.Close();
        }

        private void btn_add_trans_Click(object sender, EventArgs e) // for add in transaction
        {
            //transaction_no, title, sname, date_borrowed, status, date_returned, due_date, penalty, received_by, book_id
            if (Txtbx_transNum.Text != "" && Txtbx_title.Text != "" && Txtbx_sname.Text != "" && Label_DB_trans.Text != "" && Txtbx_status.Text !="" && Txtbx_dateR_trans.Text != "" && Txtbx_dueD.Text != "" && Txtbx_penalty.Text != "" && Txtbx_receivedB.Text != "" && Txtbx_book_id.Text !="")
            {
                string transaction_no = Txtbx_transNum.Text;
                string title = Txtbx_title.Text;
                string sname = Txtbx_sname.Text;
                string student_id = Txtbx_studID.Text;
                string date_borrowed = Label_DB_trans.Text;
                string status = Txtbx_status.Text;
                string date_returned = Txtbx_dateR_trans.Text;
                string due_date = Txtbx_dueD.Text;
                string penalty = Txtbx_penalty.Text;
                string received_by = Txtbx_receivedB.Text;
                string book_id = Txtbx_book_id.Text;

                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = "server=localhost;port=3306;username=root;password=;database=libsys";
                con.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;

                //transaction_no, title, sname, date_borrowed, status, date_returned, due_date, penalty, received_by, book_id
                cmd.CommandText = "INSERT INTO `transaction`(`transaction_no`, `title`, `sname`,`student_id`, `date_borrowed`, `status`, `date_returned`, `due_date`, `penalty`, `received_by`, `book_id`) VALUES (@trans_num,@title,@sname,@student_id, @date_b,@status,@date_r,@due_date,@penalty,@received_by,@book_id)";
                //cmd.Parameters.AddWithValue("@student_id", (Txtbx_studID_studInfo.Text));
                cmd.Parameters.AddWithValue("@trans_num", (Txtbx_transNum.Text));
                cmd.Parameters.AddWithValue("@title", (Txtbx_title.Text));
                cmd.Parameters.AddWithValue("@sname", (Txtbx_sname.Text));
                cmd.Parameters.AddWithValue("@student_id", (Txtbx_studID.Text));
                cmd.Parameters.AddWithValue("@date_b", (Label_DB_trans.Text));
                cmd.Parameters.AddWithValue("@status", (Txtbx_status.Text));
                cmd.Parameters.AddWithValue("@date_r", (Txtbx_dateR_trans.Text));
                cmd.Parameters.AddWithValue("@due_date", (Txtbx_dueD.Text));
                cmd.Parameters.AddWithValue("@penalty", (Txtbx_penalty.Text));
                cmd.Parameters.AddWithValue("@received_by", (Txtbx_receivedB.Text));
                cmd.Parameters.AddWithValue("@book_id", (Txtbx_book_id.Text));
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data Saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
                MessageBox.Show("Please fill the empty fields.", "Suggest", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_edit_trans_Click(object sender, EventArgs e) // for edit in transaction
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "server=localhost;port=3306;username=root;password=;database=libsys";
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;

            try
            { //@trans_num','@book_title','@sname', '@student_id', '@date_b','@status','@date_r','@due_date','@penalty','@received_by','@book_id
                cmd.CommandText = "UPDATE `transaction` SET `transaction_no`=@trans_num, `title` =@title, `sname`=@sname, `student_id`=@student_id, `date_borrowed`=@date_b, `status`=@status, `date_returned`=@date_r, `due_date`=@due_date, `penalty`=@penalty, `received_by`=@received_by, `book_id`=@book_id WHERE `transaction_no`=@trans_num";
      
                cmd.Parameters.AddWithValue("@trans_num", (Txtbx_transNum.Text));
                cmd.Parameters.AddWithValue("@title", (Txtbx_title.Text));
                cmd.Parameters.AddWithValue("@sname", (Txtbx_sname.Text));
                cmd.Parameters.AddWithValue("@student_id", (Txtbx_studID.Text));
                cmd.Parameters.AddWithValue("@date_b", (Label_DB_trans.Text));
                cmd.Parameters.AddWithValue("@status", (Txtbx_status.Text));
                cmd.Parameters.AddWithValue("@date_r", (Txtbx_dateR_trans.Text));
                cmd.Parameters.AddWithValue("@due_date", (Txtbx_dueD.Text));
                cmd.Parameters.AddWithValue("@penalty", (Txtbx_penalty.Text));
                cmd.Parameters.AddWithValue("@received_by", (Txtbx_receivedB.Text));
                cmd.Parameters.AddWithValue("@book_id", (Txtbx_book_id.Text));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Updated!");
                Txtbx_transNum.Clear();
                Txtbx_title.Clear();
                Txtbx_sname.Clear();
                Txtbx_studID.Clear();
                Label_DB_trans.Text = String.Empty;
                Txtbx_status.Clear();
                Txtbx_dateR_trans.Clear();
                Txtbx_dueD.Clear();
                Txtbx_penalty.Clear();
                Txtbx_receivedB.Clear();
                Txtbx_book_id.Clear();
            } catch (Exception)
            {
                throw; //ayaw gumana, pero gagana ka rin //dito may error palagi may duplication ng primary key
            }
            con.Close();
        }

        private void Btn_delete_trans_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "server=localhost;port=3306;username=root;password=;database=libsys";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            con.Open();

            try
            {
                //@trans_num','@book_title','@sname','@date_b','@status','@date_r','@due_date','@penalty','@received_by','@book_id
                cmd = con.CreateCommand();
                cmd.CommandText = "DELETE FROM `transaction` WHERE `transaction_no`= @trans_num";
                cmd.Parameters.AddWithValue("@trans_num", (Txtbx_transNum.Text));
                cmd.Parameters.AddWithValue("@title", (Txtbx_title.Text));
                cmd.Parameters.AddWithValue("@sname", (Txtbx_sname.Text));
                cmd.Parameters.AddWithValue("@student_id", (Txtbx_studID.Text));
                cmd.Parameters.AddWithValue("@date_b", (Label_DB_trans.Text));
                cmd.Parameters.AddWithValue("@status", (Txtbx_status.Text));
                cmd.Parameters.AddWithValue("@date_r", (Txtbx_dateR_trans.Text));
                cmd.Parameters.AddWithValue("@due_date", (Txtbx_dueD.Text));
                cmd.Parameters.AddWithValue("@penalty", (Txtbx_penalty.Text));
                cmd.Parameters.AddWithValue("@received_by", (Txtbx_receivedB.Text));
                cmd.Parameters.AddWithValue("@book_id", (Txtbx_book_id.Text));
                cmd.ExecuteNonQuery();

                MessageBox.Show("Successfully Deleted!");
                Txtbx_transNum.Focus();
                Txtbx_title.Clear();
                Txtbx_sname.Clear();
                Txtbx_studID.Clear();
                Label_DB_trans.Text = String.Empty;
                Txtbx_status.Clear();
                Txtbx_dateR_trans.Clear();
                Txtbx_dueD.Clear();
                Txtbx_penalty.Clear();
                Txtbx_receivedB.Clear();
                Txtbx_book_id.Clear();
            } catch (Exception) 
            {

            }
            con.Close();
        }

        private void Txtbx_transNum_TextChanged(object sender, EventArgs e) //may reader
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "server=localhost;port=3306;username=root;password=;database=libsys";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "SELECT `transaction_no`,`title`,`sname`, `student_id`, `date_borrowed`, `status`, `date_returned`, `due_date`, `penalty`, `received_by`, `book_id` FROM `transaction` WHERE `transaction_no`=@trans_num";
            cmd.Parameters.AddWithValue("@trans_num", (Txtbx_transNum.Text));
            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read()) // reader
            { 
                Txtbx_transNum.Text = reader["transaction_no"].ToString();
                Txtbx_title.Text = reader["title"].ToString();
                Txtbx_sname.Text = reader["sname"].ToString();
                Txtbx_studID.Text = reader["student_id"].ToString();
                Label_DB_trans.Text = reader["date_borrowed"].ToString();
                Txtbx_status.Text = reader["status"].ToString();
                Txtbx_dateR_trans.Text = reader["date_returned"].ToString();
                Txtbx_dueD.Text = reader["due_date"].ToString();
                Txtbx_penalty.Text = reader["penalty"].ToString();
                Txtbx_receivedB.Text = reader["received_by"].ToString();
                Txtbx_book_id.Text = reader["book_id"].ToString();
            }
            con.Close();
        }

        private void Button_clear_trans_Click(object sender, EventArgs e)
        {
            foreach (var control in Panel_main_trans.Controls)
            {
                if (control.GetType() == typeof(TextBox))
                {
                    TextBox textbox = (TextBox)control;
                    textbox.Text = "";
                    Label_DB_trans.Text = textbox.Text;
                }
            }
        }

        private void Label_DB_trans_MouseHover(object sender, EventArgs e) // date borrowed
        {
            Label_DB_trans.Text = DateTime.Now.ToString("MMM dd yyyy");
            Label_DB_trans.Focus();
        }

        private void Transaction_Form_Load(object sender, EventArgs e)
        {
            pictureBox_books_trans.Image = Image.FromFile("../../IMAGES/shelf_icon.png");

            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "server=localhost;port=3306;username=root;password=;database=libsys";
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;

            try
            {
                con.CreateCommand();
                cmd.CommandText = "SELECT * FROM transaction";
                MySqlDataAdapter adapt = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                dataGridView_transaction.DataSource = dt;
            }

            catch (Exception)
            {
                throw;
            }
        }

        private void label_x_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
