using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LibrarySystem.FORMS
{
    public partial class ManageBookForm : Form
    {
        public ManageBookForm()
        {
            InitializeComponent();
        }

        CLASSES.Books book = new CLASSES.Books(); // call the class of books

        private void ManageBookForm_Load(object sender, EventArgs e)
        {
            pictureBox_books_dshbrd2.Image = Image.FromFile("../../IMAGES/shelf_icon.png"); // App logo image
            pictureBox_books1.Image = Image.FromFile("../../IMAGES/shelf_icon.png");

            // The menu images
            Button_Add.Image = Image.FromFile("../../IMAGES/add_icon.png");
            Button_Edit.Image = Image.FromFile("../../IMAGES/edit_icon.png");
            Button_Delete.Image = Image.FromFile("../../IMAGES/trash_icon.png");
            pictureBox_search.Image = Image.FromFile("../../IMAGES/search_icon.png");

            panel_add.BringToFront(); // panel add (pink), panel edit (gray)

            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "server=localhost;port=3306;username=root;password=;database=libsys";
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;

            try //add
            {
                con.CreateCommand();
                cmd.CommandText = "Select * from books";
                MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adap.Fill(ds);
                dataGridView_addPanel.DataSource = ds.Tables[0].DefaultView;
                dataGridView_editPanel.DataSource = ds.Tables[0].DefaultView;
                dataGridView_deletePanel.DataSource = ds.Tables[0].DefaultView;
            }
            catch (Exception)
            {
                throw;
            }
        }

        // add button to add a new book
        private void Button_Add_Click(object sender, EventArgs e)
        {
            panel_add.BringToFront();
            // int id = Convert.ToInt32(Txtbx_book_id.Text);
            if (Txtbx_book_id.Text != "" && Txtbx_title.Text != "" && Txtbx_isbn.Text != "" && Txtbx_author.Text != "" && Combobox_genre_addPanel.Text != "" && Txtbx_quantity.Text != "" && Label_DR_addPanel.Text != "") 
            {
                string book_id = Txtbx_book_id.Text; 
                string title = Txtbx_title.Text;
                string isbn = Txtbx_isbn.Text;
                string author = Txtbx_author.Text;
                string genre = Combobox_genre_addPanel.Text;
                string quantity = Txtbx_quantity.Text;
                string date_returned = Label_DR_addPanel.Text;

                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = "server=localhost;port=3306;username=root;password=;database=libsys";
                con.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "INSERT INTO `books`(`book_id`, `title`, `isbn`, `author`, `genre`, `quantity`, `date_returned`) VALUES (@book_id,@title,@isbn,@author,@genre,@quantity,@date_returned)";
                cmd.Parameters.AddWithValue("@book_id", (Txtbx_book_id.Text));
                cmd.Parameters.AddWithValue("@title", (Txtbx_title.Text));
                cmd.Parameters.AddWithValue("isbn", (Txtbx_isbn.Text));
                cmd.Parameters.AddWithValue("@author", (Txtbx_author.Text));
                cmd.Parameters.AddWithValue("@genre", (Combobox_genre_addPanel.Text));
                cmd.Parameters.AddWithValue("@quantity", (Txtbx_quantity.Text));
                cmd.Parameters.AddWithValue("@date_returned", (Label_DR_addPanel.Text));
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data Saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please fill the empty fields.", "Suggest", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        } 

        // button to clear fields in add panel
        private void btn_ClearFields_Click(object sender, EventArgs e)
        {
            foreach(var control in panel_add.Controls)
            {
                if(control.GetType() == typeof(TextBox))
                {
                    TextBox textbox = (TextBox)control;
                    textbox.Text = "";
                    Combobox_genre_addPanel.Text = textbox.Text;
                    Label_DR_addPanel.Text = textbox.Text;
                }
            } 
        }

        // edit button to edit a book
        private void Button_Edit_Click(object sender, EventArgs e)
        {
            panel_edit.BringToFront();
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "server=localhost;port=3306;username=root;password=;database=libsys";
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;

            try//1439582637
            {
                cmd.CommandText = "UPDATE `books` SET `book_id`=@book_id, `title`=@title, `isbn`=@isbn, `author`=@author, `genre`=@genre, `quantity`=@quantity, `date_returned`=@date_returned WHERE `book_id`=@book_id";
                cmd.Parameters.AddWithValue("@book_id", (Txtbx_bookID_edit.Text));
                cmd.Parameters.AddWithValue("@title", (Txtbx_title_edit.Text));
                cmd.Parameters.AddWithValue("isbn", (Txtbx_isbn_edit.Text));
                cmd.Parameters.AddWithValue("@author", (Txtbx_author_edit.Text));
                cmd.Parameters.AddWithValue("@genre", (Combobox_genre_addPanel.Text));
                cmd.Parameters.AddWithValue("@quantity", (Txtbx_quantity_edit.Text));
                cmd.Parameters.AddWithValue("@date_returned", (Label_DR_addPanel.Text));
                cmd.ExecuteNonQuery();
                con.Close();
                //MessageBox.Show("Successfully Updated!");
                Txtbx_bookID_edit.Focus();
                Txtbx_title_edit.Clear();
                Txtbx_isbn_edit.Clear();
                Txtbx_author_edit.Clear();
                Combobox_genre_addPanel.Text = String.Empty;
                Txtbx_quantity_edit.Clear();
                Label_DR_addPanel.Text = String.Empty;
            } catch (Exception)
            {
                throw;
            } 
        }

        private void Txtbx_bookID_edit_TextChanged(object sender, EventArgs e) 
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "server=localhost;port=3306;username=root;password=;database=libsys";
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con; 

            cmd.CommandText = "SELECT `book_id`,`title`, `isbn`, `author`, `genre`, `quantity`, `date_returned` FROM `books` WHERE `book_id`=@book_id";
            cmd.Parameters.AddWithValue("@book_id", (Txtbx_bookID_edit.Text)); 
            MySqlDataReader reader = cmd.ExecuteReader(); 

            if (reader.Read())
            {
                Txtbx_title_edit.Text = reader["title"].ToString();
                Txtbx_isbn_edit.Text = reader["isbn"].ToString();
                Txtbx_author_edit.Text = reader["author"].ToString();
                Combobox_genre_addPanel.Text = reader["genre"].ToString();
                Txtbx_quantity_edit.Text = reader["quantity"].ToString();
                Label_DR_editPanel.Text = reader["date_returned"].ToString();
            }
            con.Close();
        }

        // button to clear fields in edit
        private void Button_Clear_edit_Click(object sender, EventArgs e)
        {
            foreach (var control in panel_edit.Controls)
            {
                if (control.GetType() == typeof(TextBox))
                {
                    TextBox textbox = (TextBox)control;
                    textbox.Text = "";
                    Combobox_genre_editPanel.Text = textbox.Text;
                    Label_DR_editPanel.Text = textbox.Text;
                }
            }
        }

        private void Btn_update_edit_Click_1(object sender, EventArgs e)
        {
            panel_edit.BringToFront();
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "server=localhost;port=3306;username=root;password=;database=libsys";
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;

            try
            {
                cmd.CommandText = "UPDATE `books` SET `book_id`=@book_id, `title`=@title, `isbn`=@isbn, `author`=@author, `genre`=@genre, `quantity`=@quantity, `date_returned`=@date_returned WHERE `book_id`=@book_id";
                cmd.Parameters.AddWithValue("@book_id", (Txtbx_bookID_edit.Text));
                cmd.Parameters.AddWithValue("@title", (Txtbx_title_edit.Text));
                cmd.Parameters.AddWithValue("isbn", (Txtbx_isbn_edit.Text));
                cmd.Parameters.AddWithValue("@author", (Txtbx_author_edit.Text));
                cmd.Parameters.AddWithValue("@genre", (Combobox_genre_addPanel.Text));
                cmd.Parameters.AddWithValue("@quantity", (Txtbx_quantity_edit.Text));
                cmd.Parameters.AddWithValue("@date_returned", (Label_DR_editPanel.Text));
                cmd.ExecuteNonQuery();
               
                MessageBox.Show("Successfully Updated!");
                Txtbx_bookID_edit.Focus();
                Txtbx_title_edit.Clear();
                Txtbx_isbn_edit.Clear();
                Txtbx_author_edit.Clear();
                Combobox_genre_addPanel.Text = String.Empty; 
                Txtbx_quantity_edit.Clear();
                Label_DR_editPanel.Text = String.Empty;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void Label_DR_addPanel_MouseHover(object sender, EventArgs e)
        {
            Label_DR_addPanel.Text = DateTime.Now.ToString("MMM dd yyyy");
            Label_DR_addPanel.Focus();
        }

        private void BackButton_books_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Load_addPanel_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "server=localhost;port=3306;username=root;password=;database=libsys";
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;

            dataGridView_addPanel.DataSource = null;
            MySqlDataAdapter adapt = new MySqlDataAdapter("Select * from books",con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            dataGridView_addPanel.DataSource = dt;
            con.Close();
        }

        private void Btn_Load_editPanel_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "server=localhost;port=3306;username=root;password=;database=libsys";
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;

            dataGridView_editPanel.DataSource = null;
            MySqlDataAdapter adapt = new MySqlDataAdapter("Select * from books", con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            dataGridView_editPanel.DataSource = dt;
            con.Close();
        }

        private void Button_Delete_Click(object sender, EventArgs e) // delete button in side panel
        {
            panel_delete.BringToFront();
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "server=localhost;port=3306;username=root;password=;database=libsys";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            con.Open();
        }

        private void btn_delete_deletePanel_Click(object sender, EventArgs e) // main delete function
        {
            panel_delete.BringToFront();
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "server=localhost;port=3306;username=root;password=;database=libsys";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            con.Open();

            try
            {
                cmd = con.CreateCommand();
                cmd.CommandText = "DELETE FROM `books` WHERE `book_id`= @book_id";
                cmd.Parameters.AddWithValue("@book_id", (Txtbx_bookID_delete.Text));
                cmd.Parameters.AddWithValue("@title", (Txtbx_title_delete.Text));
                cmd.Parameters.AddWithValue("isbn", (Txtbx_isbn_delete.Text));
                cmd.Parameters.AddWithValue("@author", (Txtbx_author_delete.Text));
                cmd.Parameters.AddWithValue("@genre", (ComboBx_genre_delete.Text));
                cmd.Parameters.AddWithValue("@quantity", (Txtbx_quantity_delete.Text));
                cmd.Parameters.AddWithValue("@date_returned", (Label_DR_deletePanel.Text));
                cmd.ExecuteNonQuery();

                MessageBox.Show("Successfully Deleted!");
                Txtbx_bookID_delete.Focus();
                Txtbx_title_delete.Clear();
                Txtbx_isbn_delete.Clear();
                Txtbx_author_delete.Clear();
                ComboBx_genre_delete.Text = String.Empty; 
                Txtbx_quantity_delete.Clear();
                Label_DR_deletePanel.Text = String.Empty;
            }
            catch (Exception)
            {
              
            }
            con.Close();
        }

        private void btn_load_delete_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=libsys");
            con.Open();
            dataGridView_deletePanel.DataSource = null;
            MySqlDataAdapter adapt = new MySqlDataAdapter("Select * from books", con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            dataGridView_deletePanel.DataSource = dt;
            con.Close();
        }

        // button to clear fields in delete panel
        private void btn_clearFields_delete_Click(object sender, EventArgs e)
        {
            foreach (var control in panel_delete.Controls)
            {
                if (control.GetType() == typeof(TextBox))
                {
                    TextBox textbox = (TextBox)control;
                    textbox.Text = "";
                    ComboBx_genre_delete.Text = textbox.Text;
                    Label_DR_deletePanel.Text = textbox.Text;
                }
            }
        }

        private void Label_DR_editPanel_MouseHover(object sender, EventArgs e) //date received in edit panel
        {
            Label_DR_editPanel.Text = DateTime.Now.ToString("MMM dd yyyy");
            Label_DR_editPanel.Focus();
        }

        private void textBox_searchBar_TextChanged(object sender, EventArgs e) // for search bar in textbox
        {
            if(textBox_searchBar.Text != "")
            {
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = "server=localhost;port=3306;username=root;password=;database=libsys";
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "SELECT * FROM `books` WHERE `title` =@title";
                cmd.Parameters.AddWithValue("@title", textBox_searchBar.Text);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView_addPanel.DataSource = ds.Tables[0];
                dataGridView_editPanel.DataSource = ds.Tables[0];
                dataGridView_deletePanel.DataSource = ds.Tables[0];
            }
            else
            {
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = "server=localhost;port=3306;username=root;password=;database=libsys";
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "SELECT * FROM `books` WHERE `book_id`=@book_id";
                cmd.Parameters.AddWithValue("@book_id", textBox_searchBar.Text);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView_addPanel.DataSource = ds.Tables[0];
                dataGridView_editPanel.DataSource = ds.Tables[0];
                dataGridView_deletePanel.DataSource = ds.Tables[0];
            }
        }

        private void button_search_Click(object sender, EventArgs e) // search button to search a book
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "server=localhost;port=3306;username=root;password=;database=libsys";

            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM `books` WHERE `book_id`=@book_id";
                cmd.Parameters.AddWithValue("@book_id", textBox_searchBar.Text);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView_addPanel.DataSource = ds.Tables[0].DefaultView; 
                Txtbx_book_id.Text = Convert.ToString(ds.Tables[0].Rows[0][0]);
                Txtbx_title.Text = Convert.ToString(ds.Tables[0].Rows[0][1]);
                Txtbx_isbn.Text = Convert.ToString(ds.Tables[0].Rows[0][2]);
                Txtbx_author.Text = Convert.ToString(ds.Tables[0].Rows[0][3]);
                Combobox_genre_addPanel.Text = Convert.ToString(ds.Tables[0].Rows[0][4]);
                Txtbx_quantity.Text  = Convert.ToString(ds.Tables[0].Rows[0][5]);
                Label_DR_addPanel.Text = Convert.ToString(ds.Tables[0].Rows[0][6]);

                dataGridView_editPanel.DataSource = ds.Tables[0].DefaultView;
                Txtbx_bookID_edit.Text = Convert.ToString(ds.Tables[0].Rows[0][0]);
                Txtbx_title_edit.Text = Convert.ToString(ds.Tables[0].Rows[0][1]);
                Txtbx_isbn_edit.Text = Convert.ToString(ds.Tables[0].Rows[0][2]);
                Txtbx_author_edit.Text = Convert.ToString(ds.Tables[0].Rows[0][3]);
                Combobox_genre_editPanel.Text = Convert.ToString(ds.Tables[0].Rows[0][4]);
                Txtbx_quantity_edit.Text = Convert.ToString(ds.Tables[0].Rows[0][5]);
                Label_DR_editPanel.Text = Convert.ToString(ds.Tables[0].Rows[0][6]);

                dataGridView_deletePanel.DataSource = ds.Tables[0].DefaultView;
                Txtbx_bookID_delete.Text = Convert.ToString(ds.Tables[0].Rows[0][0]);
                Txtbx_title_delete.Text = Convert.ToString(ds.Tables[0].Rows[0][1]);
                Txtbx_isbn_delete.Text = Convert.ToString(ds.Tables[0].Rows[0][2]);
                Txtbx_author_delete.Text = Convert.ToString(ds.Tables[0].Rows[0][3]);
                ComboBx_genre_delete.Text = Convert.ToString(ds.Tables[0].Rows[0][4]);
                Txtbx_quantity_delete.Text = Convert.ToString(ds.Tables[0].Rows[0][5]);
                Label_DR_deletePanel.Text = Convert.ToString(ds.Tables[0].Rows[0][6]); 
            } catch (Exception)
            {

            }
        }

        private void label_x_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
