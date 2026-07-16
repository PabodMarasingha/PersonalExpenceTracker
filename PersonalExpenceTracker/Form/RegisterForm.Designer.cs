using System.Windows.Forms;

namespace PersonalExpenseTracker
{
    partial class RegisterForm : Form
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
            this.lblConfirm = new System.Windows.Forms.Label();
            this.txtConfirm = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();

            this.panelTop.SuspendLayout();
            this.panelBody.SuspendLayout();
            this.SuspendLayout();

            // panelTop
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(75, 0, 130);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Height = 90;
            this.panelTop.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblTitle, this.lblSubtitle });

            // lblTitle
            this.lblTitle.Text = "📝  Create an Account";
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 15f, System.Drawing.FontStyle.Bold);
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(25, 12);

            // lblSubtitle
            this.lblSubtitle.Text = "Fill in your details to get started";
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(220, 180, 255);
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9f);
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Location = new System.Drawing.Point(27, 52);

            // panelBody
            this.panelBody.BackColor = System.Drawing.Color.White;
            this.panelBody.Location = new System.Drawing.Point(0, 90);
            this.panelBody.Size = new System.Drawing.Size(420, 460);
            this.panelBody.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblUsername, this.txtUsername,
                this.lblPassword, this.txtPassword,
                this.lblConfirm,  this.txtConfirm,
                this.lblEmail,    this.txtEmail,
                this.lblPhone,    this.txtPhone,
                this.btnRegister, this.lblError });

            // lblUsername
            this.lblUsername.Text = "USERNAME";
            this.lblUsername.Location = new System.Drawing.Point(30, 20);
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 8f, System.Drawing.FontStyle.Bold);
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(75, 0, 130);

            // txtUsername
            this.txtUsername.Location = new System.Drawing.Point(30, 38);
            this.txtUsername.Size = new System.Drawing.Size(350, 32);
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 11f);
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(245, 240, 255);

            // lblPassword
            this.lblPassword.Text = "PASSWORD";
            this.lblPassword.Location = new System.Drawing.Point(30, 85);
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 8f, System.Drawing.FontStyle.Bold);
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(75, 0, 130);

            // txtPassword
            this.txtPassword.Location = new System.Drawing.Point(30, 103);
            this.txtPassword.Size = new System.Drawing.Size(350, 32);
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 11f);
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(245, 240, 255);
            this.txtPassword.PasswordChar = '●';

            // lblConfirm
            this.lblConfirm.Text = "CONFIRM PASSWORD";
            this.lblConfirm.Location = new System.Drawing.Point(30, 150);
            this.lblConfirm.AutoSize = true;
            this.lblConfirm.Font = new System.Drawing.Font("Segoe UI", 8f, System.Drawing.FontStyle.Bold);
            this.lblConfirm.ForeColor = System.Drawing.Color.FromArgb(75, 0, 130);

            // txtConfirm
            this.txtConfirm.Location = new System.Drawing.Point(30, 168);
            this.txtConfirm.Size = new System.Drawing.Size(350, 32);
            this.txtConfirm.Font = new System.Drawing.Font("Segoe UI", 11f);
            this.txtConfirm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConfirm.BackColor = System.Drawing.Color.FromArgb(245, 240, 255);
            this.txtConfirm.PasswordChar = '●';

            // lblEmail
            this.lblEmail.Text = "EMAIL ADDRESS";
            this.lblEmail.Location = new System.Drawing.Point(30, 215);
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 8f, System.Drawing.FontStyle.Bold);
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(75, 0, 130);

            // txtEmail
            this.txtEmail.Location = new System.Drawing.Point(30, 233);
            this.txtEmail.Size = new System.Drawing.Size(350, 32);
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 11f);
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(245, 240, 255);

            // lblPhone
            this.lblPhone.Text = "PHONE NUMBER";
            this.lblPhone.Location = new System.Drawing.Point(30, 280);
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 8f, System.Drawing.FontStyle.Bold);
            this.lblPhone.ForeColor = System.Drawing.Color.FromArgb(75, 0, 130);

            // txtPhone
            this.txtPhone.Location = new System.Drawing.Point(30, 298);
            this.txtPhone.Size = new System.Drawing.Size(350, 32);
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 11f);
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone.BackColor = System.Drawing.Color.FromArgb(245, 240, 255);

            // lblError
            this.lblError.Text = "";
            this.lblError.Location = new System.Drawing.Point(30, 345);
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Segoe UI", 9f);
            this.lblError.ForeColor = System.Drawing.Color.Red;

            // btnRegister
            this.btnRegister.Text = "CREATE ACCOUNT";
            this.btnRegister.Location = new System.Drawing.Point(30, 365);
            this.btnRegister.Size = new System.Drawing.Size(350, 42);
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(75, 0, 130);
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI", 11f, System.Drawing.FontStyle.Bold);
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);

            // RegisterForm
            this.Text = "Register — Personal Expense Tracker";
            this.Size = new System.Drawing.Size(436, 590);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
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
        private System.Windows.Forms.Label lblConfirm;
        private System.Windows.Forms.TextBox txtConfirm;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblError;
    }
}