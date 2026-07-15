using System.Windows.Forms;

namespace PersonalExpenseTracker
{
    partial class SplashScreen : Form
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
            this.panelMain = new System.Windows.Forms.Panel();
            this.lblAppName = new System.Windows.Forms.Label();
            this.lblTagline = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblLoading = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer();

            this.panelMain.SuspendLayout();
            this.SuspendLayout();

            // panelMain
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(75, 0, 130);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblAppName, this.lblTagline, this.lblVersion,
                this.lblLoading, this.progressBar, this.lblCopyright });

            // lblAppName
            this.lblAppName.Text = "💰 Personal Expense Tracker";
            this.lblAppName.ForeColor = System.Drawing.Color.White;
            this.lblAppName.Font = new System.Drawing.Font("Segoe UI", 26f, System.Drawing.FontStyle.Bold);
            this.lblAppName.AutoSize = false;
            this.lblAppName.Size = new System.Drawing.Size(500, 50);
            this.lblAppName.Location = new System.Drawing.Point(50, 120);
            this.lblAppName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblTagline
            this.lblTagline.Text = "Track • Manage • Save";
            this.lblTagline.ForeColor = System.Drawing.Color.FromArgb(220, 180, 255);
            this.lblTagline.Font = new System.Drawing.Font("Segoe UI", 13f, System.Drawing.FontStyle.Italic);
            this.lblTagline.AutoSize = false;
            this.lblTagline.Size = new System.Drawing.Size(500, 35);
            this.lblTagline.Location = new System.Drawing.Point(50, 175);
            this.lblTagline.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblVersion
            this.lblVersion.Text = "Version 1.0";
            this.lblVersion.ForeColor = System.Drawing.Color.FromArgb(180, 140, 220);
            this.lblVersion.Font = new System.Drawing.Font("Segoe UI", 9f);
            this.lblVersion.AutoSize = false;
            this.lblVersion.Size = new System.Drawing.Size(500, 25);
            this.lblVersion.Location = new System.Drawing.Point(50, 215);
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // progressBar
            this.progressBar.Location = new System.Drawing.Point(80, 300);
            this.progressBar.Size = new System.Drawing.Size(440, 8);
            this.progressBar.Maximum = 100;
            this.progressBar.Value = 0;
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.ForeColor = System.Drawing.Color.FromArgb(200, 150, 255);
            this.progressBar.BackColor = System.Drawing.Color.FromArgb(50, 0, 100);

            // lblLoading
            this.lblLoading.Text = "Loading...";
            this.lblLoading.ForeColor = System.Drawing.Color.FromArgb(200, 170, 240);
            this.lblLoading.Font = new System.Drawing.Font("Segoe UI", 9f);
            this.lblLoading.AutoSize = false;
            this.lblLoading.Size = new System.Drawing.Size(500, 25);
            this.lblLoading.Location = new System.Drawing.Point(50, 318);
            this.lblLoading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblCopyright
            this.lblCopyright.Text = "© 2025 Chethisha Pabod — BCI Negombo";
            this.lblCopyright.ForeColor = System.Drawing.Color.FromArgb(150, 100, 200);
            this.lblCopyright.Font = new System.Drawing.Font("Segoe UI", 8f);
            this.lblCopyright.AutoSize = false;
            this.lblCopyright.Size = new System.Drawing.Size(500, 25);
            this.lblCopyright.Location = new System.Drawing.Point(50, 370);
            this.lblCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // timer1
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);

            // SplashScreen
            this.Text = "Loading...";
            this.Size = new System.Drawing.Size(600, 420);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.BackColor = System.Drawing.Color.FromArgb(75, 0, 130);
            this.Controls.Add(this.panelMain);

            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.Label lblTagline;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblLoading;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.Timer timer1;
    }
}