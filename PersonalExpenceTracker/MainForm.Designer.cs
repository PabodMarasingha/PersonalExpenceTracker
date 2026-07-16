using System.Windows.Forms;

namespace PersonalExpenseTracker
{
    partial class MainForm : Form
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
            this.btnDashboard = new System.Windows.Forms.Button();
            this.panelSalary = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblSalaryInfo = new System.Windows.Forms.Label();
            this.lblRemaining = new System.Windows.Forms.Label();
            this.progressBudget = new System.Windows.Forms.ProgressBar();
            this.btnSetSalary = new System.Windows.Forms.Button();
            this.panelFilter = new System.Windows.Forms.Panel();
            this.lblFilter = new System.Windows.Forms.Label();
            this.cboFilter = new System.Windows.Forms.ComboBox();
            this.btnClearFilter = new System.Windows.Forms.Button();
            this.dgvExpenses = new System.Windows.Forms.DataGridView();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();

            this.panelTop.SuspendLayout();
            this.panelFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenses)).BeginInit();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();

            // panelTop
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(75, 0, 130);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Height = 75;
            this.panelTop.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblTitle, this.lblSubtitle, this.btnDashboard });

            // lblTitle
            this.lblTitle.Text = "💰  Personal Expense Tracker";
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 15f, System.Drawing.FontStyle.Bold);
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(20, 10);

            // lblSubtitle
            this.lblSubtitle.Text = "Track your daily expenses with ease";
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(220, 180, 255);
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9f);
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Location = new System.Drawing.Point(22, 44);

            // btnDashboard
            this.btnDashboard.Text = "📊  Dashboard";
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(100, 0, 180);
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.Size = new System.Drawing.Size(130, 38);
            this.btnDashboard.Location = new System.Drawing.Point(730, 18);
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 10f, System.Drawing.FontStyle.Bold);
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);

            // ── panelSalary ───────────────────────────────────
            this.panelSalary.BackColor = System.Drawing.Color.FromArgb(60, 0, 110);
            this.panelSalary.Location = new System.Drawing.Point(0, 75);
            this.panelSalary.Size = new System.Drawing.Size(884, 80);
            this.panelSalary.Controls.AddRange(new System.Windows.Forms.Control[] {
            this.lblWelcome, this.lblSalaryInfo,
            this.lblRemaining, this.progressBudget, this.btnSetSalary });

            // lblWelcome
            this.lblWelcome.Text = "👋 Welcome!";
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 10f, System.Drawing.FontStyle.Bold);
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(15, 10);

            // lblSalaryInfo
            this.lblSalaryInfo.Text = "Monthly Salary: Not set";
            this.lblSalaryInfo.ForeColor = System.Drawing.Color.FromArgb(220, 180, 255);
            this.lblSalaryInfo.Font = new System.Drawing.Font("Segoe UI", 9f);
            this.lblSalaryInfo.AutoSize = true;
            this.lblSalaryInfo.Location = new System.Drawing.Point(15, 35);

            // lblRemaining
            this.lblRemaining.Text = "Remaining: --";
            this.lblRemaining.ForeColor = System.Drawing.Color.FromArgb(180, 255, 180);
            this.lblRemaining.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold);
            this.lblRemaining.AutoSize = true;
            this.lblRemaining.Location = new System.Drawing.Point(15, 55);

            // progressBudget
            this.progressBudget.Location = new System.Drawing.Point(280, 38);
            this.progressBudget.Size = new System.Drawing.Size(380, 16);
            this.progressBudget.Maximum = 100;
            this.progressBudget.Value = 0;
            this.progressBudget.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBudget.ForeColor = System.Drawing.Color.FromArgb(150, 100, 255);

            // btnSetSalary
            this.btnSetSalary.Text = "💰 Set Salary";
            this.btnSetSalary.Location = new System.Drawing.Point(700, 25);
            this.btnSetSalary.Size = new System.Drawing.Size(120, 34);
            this.btnSetSalary.BackColor = System.Drawing.Color.FromArgb(100, 0, 180);
            this.btnSetSalary.ForeColor = System.Drawing.Color.White;
            this.btnSetSalary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetSalary.FlatAppearance.BorderSize = 0;
            this.btnSetSalary.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold);
            this.btnSetSalary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetSalary.Click += new System.EventHandler(this.btnSetSalary_Click);

            // panelFilter
            this.panelFilter.BackColor = System.Drawing.Color.FromArgb(245, 240, 255);
            this.panelFilter.Location = new System.Drawing.Point(0, 155);
            this.panelFilter.Size = new System.Drawing.Size(884, 52);
            this.panelFilter.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblFilter, this.cboFilter, this.btnClearFilter });

            // lblFilter
            this.lblFilter.Text = "Filter by Category:";
            this.lblFilter.ForeColor = System.Drawing.Color.FromArgb(75, 0, 130);
            this.lblFilter.AutoSize = true;
            this.lblFilter.Location = new System.Drawing.Point(15, 16);
            this.lblFilter.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold);

            // cboFilter
            this.cboFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilter.Location = new System.Drawing.Point(155, 13);
            this.cboFilter.Size = new System.Drawing.Size(180, 25);
            this.cboFilter.Font = new System.Drawing.Font("Segoe UI", 9f);
            this.cboFilter.BackColor = System.Drawing.Color.White;
            this.cboFilter.ForeColor = System.Drawing.Color.FromArgb(75, 0, 130);
            this.cboFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboFilter.SelectedIndexChanged += new System.EventHandler(this.cboFilter_SelectedIndexChanged);

            // btnClearFilter
            this.btnClearFilter.Text = "Show All";
            this.btnClearFilter.Location = new System.Drawing.Point(350, 12);
            this.btnClearFilter.Size = new System.Drawing.Size(80, 28);
            this.btnClearFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearFilter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(75, 0, 130);
            this.btnClearFilter.FlatAppearance.BorderSize = 1;
            this.btnClearFilter.BackColor = System.Drawing.Color.White;
            this.btnClearFilter.ForeColor = System.Drawing.Color.FromArgb(75, 0, 130);
            this.btnClearFilter.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold);
            this.btnClearFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearFilter.Click += new System.EventHandler(this.btnClearFilter_Click);

            // dgvExpenses
            this.dgvExpenses.Location = new System.Drawing.Point(0, 207);
            this.dgvExpenses.Size = new System.Drawing.Size(884, 280);
            this.dgvExpenses.AllowUserToAddRows = false;
            this.dgvExpenses.ReadOnly = true;
            this.dgvExpenses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExpenses.BackgroundColor = System.Drawing.Color.White;
            this.dgvExpenses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvExpenses.RowHeadersVisible = false;
            this.dgvExpenses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvExpenses.MultiSelect = false;
            this.dgvExpenses.GridColor = System.Drawing.Color.FromArgb(230, 220, 255);
            this.dgvExpenses.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvExpenses.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(50, 0, 80);
            this.dgvExpenses.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(75, 0, 130);
            this.dgvExpenses.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvExpenses.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.5f);

            // panelButtons
            this.panelButtons.BackColor = System.Drawing.Color.FromArgb(245, 240, 255);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtons.Height = 62;
            this.panelButtons.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.btnAdd, this.btnEdit, this.btnDelete, this.lblTotal });

            // btnAdd
            this.btnAdd.Text = "➕  Add Expense";
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(75, 0, 130);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.Size = new System.Drawing.Size(145, 38);
            this.btnAdd.Location = new System.Drawing.Point(15, 12);
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10f, System.Drawing.FontStyle.Bold);
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            // btnEdit
            this.btnEdit.Text = "✏️  Edit";
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(120, 50, 180);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.Size = new System.Drawing.Size(110, 38);
            this.btnEdit.Location = new System.Drawing.Point(172, 12);
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 10f, System.Drawing.FontStyle.Bold);
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);

            // btnDelete
            this.btnDelete.Text = "🗑️  Delete";
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(180, 0, 80);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.Size = new System.Drawing.Size(110, 38);
            this.btnDelete.Location = new System.Drawing.Point(295, 12);
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 10f, System.Drawing.FontStyle.Bold);
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            // lblTotal
            this.lblTotal.Text = "Total: LKR 0.00";
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(75, 0, 130);
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 11f, System.Drawing.FontStyle.Bold);
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(620, 22);

            // MainForm
            this.Text = "Personal Expense Tracker";
            this.Size = new System.Drawing.Size(900, 620);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BackColor = System.Drawing.Color.White;
            this.Font = new System.Drawing.Font("Segoe UI", 9f);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
            this.panelTop, this.panelSalary, this.panelFilter,
            this.dgvExpenses, this.panelButtons });

            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelFilter.ResumeLayout(false);
            this.panelFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenses)).EndInit();
            this.panelButtons.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Panel panelFilter;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.ComboBox cboFilter;
        private System.Windows.Forms.Button btnClearFilter;
        private System.Windows.Forms.DataGridView dgvExpenses;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Panel panelSalary;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblSalaryInfo;
        private System.Windows.Forms.Label lblRemaining;
        private System.Windows.Forms.ProgressBar progressBudget;
        private System.Windows.Forms.Button btnSetSalary;
    }
}