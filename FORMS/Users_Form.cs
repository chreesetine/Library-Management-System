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
    public partial class Users_Form : Form
    {
        public Users_Form()
        {
            InitializeComponent();
        }

        private void label_x_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_back_users_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_viewLib_Click(object sender, EventArgs e)
        {
            ViewLibrarian vl = new ViewLibrarian();
            vl.Show();
        }

        private void Btn_logout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to logout?", "Exit message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Button_changePass_Click(object sender, EventArgs e)
        {
            ChangePass CP = new ChangePass();
            CP.Show();
        }
    }
}
