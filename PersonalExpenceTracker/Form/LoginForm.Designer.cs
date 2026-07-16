using System.Windows.Forms;

namespace PersonalExpenseTracker
{
    partial class LoginForm : Form
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.panelBody = new System.Windows.Forms.Panel();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblRegister = new System.Windows.Forms.Label();
            this.lnkRegister = new System.Windows.Forms.LinkLabel();
            this.lblError = new System.Windows.Forms.Label();

            this.panelTop.SuspendLayout();
            this.panelBody.SuspendLayout();
            this.SuspendLayout();

            // panelTop
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(75, 0, 130);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Height = 100;
            this.panelTop.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblTitle, this.lblSubtitle });

            // lblTitle
            this.lblTitle.Text = "💰  Personal Expense Tracker";
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16f, System.Drawing.FontStyle.Bold);
            this.lblTitle.AutoSize = false;
            this.lblTitle.Size = new System.Drawing.Size(400, 40);
            this.lblTitle.Location = new System.Drawing.Point(30, 15);

            // lblSubtitle
            this.lblSubtitle.Text = "Sign in to manage your expenses";
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(220, 180, 255);
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10f);
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Location = new System.Drawing.Point(32, 58);

            // panelBody
            this.panelBody.BackColor = System.Drawing.Color.White;
            this.panelBody.Location = new System.Drawing.Point(0, 100);
            this.panelBody.Size = new System.Drawing.Size(420, 310);
            this.panelBody.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblUsername, this.txtUsername,
                this.lblPassword, this.txtPassword,
                this.btnLogin, this.lblError,
                this.lblRegister, this.lnkRegister });

            // lblUsername
            this.lblUsername.Text = "USERNAME";
            this.lblUsername.Location = new System.Drawing.Point(30, 30);
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 8f, System.Drawing.FontStyle.Bold);
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(75, 0, 130);

            // txtUsername
            this.txtUsername.Location = new System.Drawing.Point(30, 50);
            this.txtUsername.Size = new System.Drawing.Size(350, 36);
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 12f);
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(245, 240, 255);

            // lblPassword
            this.lblPassword.Text = "PASSWORD";
            this.lblPassword.Location = new System.Drawing.Point(30, 105);
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 8f, System.Drawing.FontStyle.Bold);
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(75, 0, 130);

            // txtPassword
            this.txtPassword.Location = new System.Drawing.Point(30, 125);
            this.txtPassword.Size = new System.Drawing.Size(350, 36);
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 12f);
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(245, 240, 255);
            this.txtPassword.PasswordChar = '●';

            // lblError
            this.lblError.Text = "";
            this.lblError.Location = new System.Drawing.Point(30, 175);
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Segoe UI", 9f);
            this.lblError.ForeColor = System.Drawing.Color.Red;

            // btnLogin
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.Location = new System.Drawing.Point(30, 195);
            this.btnLogin.Size = new System.Drawing.Size(350, 42);
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(75, 0, 130);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 11f, System.Drawing.FontStyle.Bold);
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);

            // lblRegister
            this.lblRegister.Text = "Don't have an account?";
            this.lblRegister.Location = new System.Drawing.Point(30, 255);
            this.lblRegister.AutoSize = true;
            this.lblRegister.Font = new System.Drawing.Font("Segoe UI", 9f);
            this.lblRegister.ForeColor = System.Drawing.Color.Gray;

            // lnkRegister
            this.lnkRegister.Text = "Register here";
            this.lnkRegister.Location = new System.Drawing.Point(210, 255);
            this.lnkRegister.AutoSize = true;
            this.lnkRegister.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold);
            this.lnkRegister.LinkColor = System.Drawing.Color.FromArgb(75, 0, 130);
            this.lnkRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkRegister_LinkClicked);

            // LoginForm
            this.Text = "Login — Personal Expense Tracker";
            this.Size = new System.Drawing.Size(436, 450);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BackColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.panelTop, this.panelBody });

            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelBody.ResumeLayout(false);
            this.panelBody.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblRegister;
        private System.Windows.Forms.LinkLabel lnkRegister;
    }
}