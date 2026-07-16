using System.Windows.Forms;

namespace PersonalExpenseTracker
{
    partial class Dashboard : Form
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
            this.lblMonth = new System.Windows.Forms.Label();
            this.panelTotal = new System.Windows.Forms.Panel();
            this.lblTotalHead = new System.Windows.Forms.Label();
            this.lblTotalVal = new System.Windows.Forms.Label();
            this.lblBreakdown = new System.Windows.Forms.Label();
            this.dgvSummary = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();

            this.panelTop.SuspendLayout();
            this.panelBody.SuspendLayout();
            this.panelTotal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSummary)).BeginInit();
            this.SuspendLayout();

            // panelTop
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(15, 20, 40);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Height = 75;
            this.panelTop.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblTitle, this.lblSubtitle });

            // lblTitle
            this.lblTitle.Text = "📊  Spending Dashboard";
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14f, System.Drawing.FontStyle.Bold);
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(20, 10);

            // lblSubtitle
            this.lblSubtitle.Text = "Your monthly spending summary";
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(120, 160, 210);
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9f);
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Location = new System.Drawing.Point(22, 44);

            // panelBody
            this.panelBody.BackColor = System.Drawing.Color.FromArgb(18, 24, 45);
            this.panelBody.Location = new System.Drawing.Point(0, 75);
            this.panelBody.Size = new System.Drawing.Size(480, 380);
            this.panelBody.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblMonth, this.panelTotal,
                this.lblBreakdown, this.dgvSummary });

            // lblMonth
            this.lblMonth.Text = "";
            this.lblMonth.Location = new System.Drawing.Point(25, 18);
            this.lblMonth.AutoSize = true;
            this.lblMonth.Font = new System.Drawing.Font("Segoe UI", 11f, System.Drawing.FontStyle.Bold);
            this.lblMonth.ForeColor = System.Drawing.Color.FromArgb(100, 180, 255);

            // panelTotal
            this.panelTotal.BackColor = System.Drawing.Color.FromArgb(25, 35, 65);
            this.panelTotal.Location = new System.Drawing.Point(25, 50);
            this.panelTotal.Size = new System.Drawing.Size(420, 80);
            this.panelTotal.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblTotalHead, this.lblTotalVal });

            // lblTotalHead
            this.lblTotalHead.Text = "TOTAL SPENT THIS MONTH";
            this.lblTotalHead.Location = new System.Drawing.Point(20, 12);
            this.lblTotalHead.AutoSize = true;
            this.lblTotalHead.Font = new System.Drawing.Font("Segoe UI", 8f, System.Drawing.FontStyle.Bold);
            this.lblTotalHead.ForeColor = System.Drawing.Color.FromArgb(100, 160, 230);

            // lblTotalVal
            this.lblTotalVal.Text = "LKR 0.00";
            this.lblTotalVal.Location = new System.Drawing.Point(18, 32);
            this.lblTotalVal.AutoSize = true;
            this.lblTotalVal.Font = new System.Drawing.Font("Segoe UI", 22f, System.Drawing.FontStyle.Bold);
            this.lblTotalVal.ForeColor = System.Drawing.Color.White;

            // lblBreakdown
            this.lblBreakdown.Text = "SPENDING BY CATEGORY";
            this.lblBreakdown.Location = new System.Drawing.Point(25, 148);
            this.lblBreakdown.AutoSize = true;
            this.lblBreakdown.Font = new System.Drawing.Font("Segoe UI", 8f, System.Drawing.FontStyle.Bold);
            this.lblBreakdown.ForeColor = System.Drawing.Color.FromArgb(100, 160, 230);

            // dgvSummary
            this.dgvSummary.Location = new System.Drawing.Point(25, 170);
            this.dgvSummary.Size = new System.Drawing.Size(420, 190);
            this.dgvSummary.AllowUserToAddRows = false;
            this.dgvSummary.ReadOnly = true;
            this.dgvSummary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSummary.BackgroundColor = System.Drawing.Color.FromArgb(18, 24, 45);
            this.dgvSummary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSummary.RowHeadersVisible = false;
            this.dgvSummary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSummary.MultiSelect = false;
            this.dgvSummary.GridColor = System.Drawing.Color.FromArgb(35, 45, 75);
            this.dgvSummary.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(18, 24, 45);
            this.dgvSummary.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(200, 220, 255);
            this.dgvSummary.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(30, 90, 180);
            this.dgvSummary.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvSummary.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.5f);

            // btnClose
            this.btnClose.Text = "✖  Close";
            this.btnClose.Location = new System.Drawing.Point(25, 14);
            this.btnClose.Size = new System.Drawing.Size(150, 38);
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(140, 30, 30);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10f, System.Drawing.FontStyle.Bold);
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            // Dashboard Form
            this.Text = "Dashboard";
            this.Size = new System.Drawing.Size(496, 580);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.BackColor = System.Drawing.Color.FromArgb(15, 20, 40);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.panelTop, this.panelBody,
                new System.Windows.Forms.Panel {
                    Dock      = System.Windows.Forms.DockStyle.Bottom,
                    Height    = 65,
                    BackColor = System.Drawing.Color.FromArgb(15, 20, 40),
                    Controls  = { this.btnClose }
                }
            });

            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelTotal.ResumeLayout(false);
            this.panelTotal.PerformLayout();
            this.panelBody.ResumeLayout(false);
            this.panelBody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSummary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Panel panelTotal;
        private System.Windows.Forms.Label lblTotalHead;
        private System.Windows.Forms.Label lblTotalVal;
        private System.Windows.Forms.Label lblBreakdown;
        private System.Windows.Forms.DataGridView dgvSummary;
        private System.Windows.Forms.Button btnClose;
    }
}