using System.Windows.Forms;

namespace PersonalExpenseTracker
{
    partial class Dashboard : Form
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalVal = new System.Windows.Forms.Label();
            this.lblBreakdown = new System.Windows.Forms.Label();
            this.dgvSummary = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSummary)).BeginInit();
            this.SuspendLayout();

            this.panelTop.BackColor = System.Drawing.Color.FromArgb(31, 56, 100);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Height = 55;
            this.panelTop.Controls.Add(this.lblTitle);

            this.lblTitle.Text = "📊 Dashboard — Spending Summary";
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13f, System.Drawing.FontStyle.Bold);
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(20, 14);

            this.lblMonth.Text = "";
            this.lblMonth.Location = new System.Drawing.Point(30, 70);
            this.lblMonth.AutoSize = true;
            this.lblMonth.Font = new System.Drawing.Font("Segoe UI", 10f, System.Drawing.FontStyle.Bold);
            this.lblMonth.ForeColor = System.Drawing.Color.FromArgb(46, 117, 182);

            this.lblTotal.Text = "Total Spent This Month:";
            this.lblTotal.Location = new System.Drawing.Point(30, 105);
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 10f, System.Drawing.FontStyle.Bold);

            this.lblTotalVal.Text = "LKR 0.00";
            this.lblTotalVal.Location = new System.Drawing.Point(30, 128);
            this.lblTotalVal.AutoSize = true;
            this.lblTotalVal.Font = new System.Drawing.Font("Segoe UI", 18f, System.Drawing.FontStyle.Bold);
            this.lblTotalVal.ForeColor = System.Drawing.Color.FromArgb(31, 56, 100);

            this.lblBreakdown.Text = "Spending by Category:";
            this.lblBreakdown.Location = new System.Drawing.Point(30, 175);
            this.lblBreakdown.AutoSize = true;
            this.lblBreakdown.Font = new System.Drawing.Font("Segoe UI", 10f, System.Drawing.FontStyle.Bold);

            this.dgvSummary.Location = new System.Drawing.Point(30, 200);
            this.dgvSummary.Size = new System.Drawing.Size(420, 220);
            this.dgvSummary.AllowUserToAddRows = false;
            this.dgvSummary.ReadOnly = true;
            this.dgvSummary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSummary.BackgroundColor = System.Drawing.Color.White;
            this.dgvSummary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSummary.RowHeadersVisible = false;
            this.dgvSummary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSummary.MultiSelect = false;

            this.btnClose.Text = "✖ Close";
            this.btnClose.Location = new System.Drawing.Point(30, 440);
            this.btnClose.Size = new System.Drawing.Size(120, 36);
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(192, 80, 77);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10f, System.Drawing.FontStyle.Bold);
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            this.Text = "Dashboard";
            this.Size = new System.Drawing.Size(500, 520);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.BackColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.panelTop, this.lblMonth, this.lblTotal,
                this.lblTotalVal, this.lblBreakdown,
                this.dgvSummary, this.btnClose });

            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSummary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalVal;
        private System.Windows.Forms.Label lblBreakdown;
        private System.Windows.Forms.DataGridView dgvSummary;
        private System.Windows.Forms.Button btnClose;
    }
}