using System;
using System.Windows.Forms;
using PersonalExpenseTracker.Data;

namespace PersonalExpenseTracker
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string confirm = txtConfirm.Text.Trim();
            string email = txtEmail.Text.Trim();
            string phone = txtPhone.Text.Trim();

            // Validate
            if (string.IsNullOrWhiteSpace(username))
            {
                lblError.Text = "Please enter a username!";
                return;
            }
            if (username.Length < 3)
            {
                lblError.Text = "Username must be at least 3 characters!";
                return;
            }
            if (string.IsNullOrWhiteSpace(password))
            {
                lblError.Text = "Please enter a password!";
                return;
            }
            if (password.Length < 6)
            {
                lblError.Text = "Password must be at least 6 characters!";
                return;
            }
            if (password != confirm)
            {
                lblError.Text = "Passwords do not match!";
                return;
            }
            if (DatabaseHelper.UsernameExists(username))
            {
                lblError.Text = "Username already taken — try another!";
                return;
            }

            bool success = DatabaseHelper.RegisterUser(
                username, password, email, phone);

            if (success)
            {
                MessageBox.Show(
                    "Account created successfully!\nYou can now log in.",
                    "Welcome!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                lblError.Text = "Registration failed — please try again!";
            }
        }
    }
}