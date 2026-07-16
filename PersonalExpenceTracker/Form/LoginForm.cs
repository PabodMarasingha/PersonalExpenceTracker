using System;
using System.Windows.Forms;
using PersonalExpenseTracker.Data;
using PersonalExpenseTracker.Models;

namespace PersonalExpenseTracker
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password))
            {
                lblError.Text = "Please enter username and password!";
                return;
            }

            User user = DatabaseHelper.LoginUser(username, password);

            if (user != null)
            {
                Session.CurrentUser = user;
                MainForm main = new MainForm();
                this.Hide();
                main.ShowDialog();
                this.Close();
            }
            else
            {
                lblError.Text = "Invalid username or password!";
                txtPassword.Clear();
            }
        }

        private void lnkRegister_LinkClicked(object sender,
            LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm register = new RegisterForm();
            register.ShowDialog();
        }
    }
}