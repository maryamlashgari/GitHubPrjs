using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;

namespace BasetPajooh
{
    public partial class frmLogin : Form
    {
        public static bool trustUser = false;
        int LoginErrorCount = 0;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Models.DataBaseContext OdbContext = null;
            try
            {
                OdbContext = new Models.DataBaseContext();
                Models.User Ouser = new Models.User();
                var model = OdbContext.Users.Where(E => (E.UserName == tbxUserName.Text.Trim()
                                                        && E.Password == tbxPassword.Text.Trim())).ToList();
                if (model.Count > 0)
                {
                    trustUser = true;
                    this.Close();
                }
                else
                {
                    LoginErrorCount++;
                    MessageBox.Show("نام کاربری یا کلمه عبور شما اشتباه است ");
                    if (LoginErrorCount == 3)// اگر کاربر سه بار نام کاربری و کلمه عبور را اشتباه وارد کرد برنامه بسته شود
                    {
                        this.Close();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tbxPassword_MouseHover(object sender, EventArgs e)
        {
            tbxPassword.PasswordChar = '\0';
        }

        private void tbxPassword_MouseLeave(object sender, EventArgs e)
        {
            tbxPassword.PasswordChar = '*';
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!trustUser)
                Application.Exit();
        }
    }
}
