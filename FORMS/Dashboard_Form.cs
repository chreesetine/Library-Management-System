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
    public partial class Dashboard_Form : Form
    {
        public Dashboard_Form()
        {
            InitializeComponent();
        }


        private void Dashboard_Form_Load(object sender, EventArgs e)
        {
            // Display the app logo image
            pictureBox_book_dshbrd.Image = Image.FromFile("../../IMAGES/shelf_icon.png");
            pictureBox_books_dshbrd2.Image = Image.FromFile("../../IMAGES/shelf_icon.png");

            // The menu images
            button_books.Image = Image.FromFile("../../IMAGES/books_icon.png");
            button_studInfo.Image = Image.FromFile("../../IMAGES/account_icon.png");
            button_trans.Image = Image.FromFile("../../IMAGES/transaction_icon.png");
            reports_settings.Image = Image.FromFile("../../IMAGES/reports_icon.png");

            // Pictures of books
            Pctrbx1.Image = Image.FromFile("../../IMAGES/Christine.jpg");
            Pctrbx2.Image = Image.FromFile("../../IMAGES/LittleWomen.jpg");
            Pctrbx3.Image = Image.FromFile("../../IMAGES/Inferno.jpg");
            Pctrbx4.Image = Image.FromFile("../../IMAGES/NoliMeTangere.jpg");
            Pctrbx5.Image = Image.FromFile("../../IMAGES/DOAWK.jpg");
            Pctrbx6.Image = Image.FromFile("../../IMAGES/hp_SorcererStone.jpg");
            Pctrbx7.Image = Image.FromFile("../../IMAGES/Mathematics.jpg");
            Pctrbx8.Image = Image.FromFile("../../IMAGES/Flipped.jpg");
            Pctrbx9.Image = Image.FromFile("../../IMAGES/AliceInWonderland.jpg");
            Pctrbx10.Image = Image.FromFile("../../IMAGES/GulliversTravel.jpg");


            // show the login form
            Login_Form lgf = new Login_Form(this);
            lgf.Show();
        }

        private void Dashboard_Form_Shown(object sender, EventArgs e)
        {
            this.Enabled = false;

            // show the login form
            Login_Form lgf = new Login_Form(this);
            lgf.Show();
        }

        private void button_books_Click(object sender, EventArgs e)
        {
            // show the book form
            ManageBookForm managebk = new ManageBookForm();
            managebk.Show();
        }

        private void button_studInfo_Click(object sender, EventArgs e)
        {
            // show the student information form
            StudentInfo studF = new StudentInfo();
            studF.Show();
        }

        private void button_trans_Click(object sender, EventArgs e)
        {
            Transaction_Form transaction = new Transaction_Form();
            transaction.Show();
        }

        private void reports_settings_Click(object sender, EventArgs e)
        {
            Reports rprts = new Reports();
            rprts.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Pctrbx_user.Image = Image.FromFile("../../IMAGES/user_icon.png");
            Users_Form users = new Users_Form();
            users.Show();
        }

        private void label_x_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
