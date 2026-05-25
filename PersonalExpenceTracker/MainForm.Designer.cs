namespace PersonalExpenseTracker
{
    partial class MainForm
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
            this.btnDashboard = new System.Windows.Forms.Button();
            this.panelFilter = new System.Windows.Forms.Panel();
            this.lblFilter = new System.Windows.Forms.Label();
            this.cboFilter = new System.Windows.Forms.ComboBox();
            this.btnClearFilter = new System.Windows.Forms.Button();
            this.dgvExpenses = new System.Windows.Forms.DataGridView();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();

            this.panelTop.SuspendLayout();
            this.panelFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenses)).BeginInit();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();

            // ── panelTop ──────────────────────────────────
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(31, 56, 100);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Height = 60;
            this.panelTop.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblTitle, this.btnDashboard });

            // ── lblTitle ──────────────────────────────────
            this.lblTitle.Text = "💰 Personal Expense Tracker";
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14f, System.Drawing.FontStyle.Bold);
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(20, 15);

            // ── btnDashboard ──────────────────────────────
            this.btnDashboard.Text = "📊 Dashboard";
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(46, 117, 182);
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Size = new System.Drawing.Size(120, 35);
            this.btnDashboard.Location = new System.Drawing.Point(740, 12);
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);

            // ── panelFilter ───────────────────────────────
            this.panelFilter.BackColor = System.Drawing.Color.FromArgb(242, 247, 252);
            this.panelFilter.Dock = System.Windows.Forms.DockStyle.None;
            this.panelFilter.Location = new System.Drawing.Point(0, 60);
            this.panelFilter.Size = new System.Drawing.Size(884, 50);
            this.panelFilter.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblFilter, this.cboFilter, this.btnClearFilter });

            // ── lblFilter ─────────────────────────────────
            this.lblFilter.Text = "Filter by Category:";
            this.lblFilter.AutoSize = true;
            this.lblFilter.Location = new System.Drawing.Point(15, 15);
            this.lblFilter.Font = new System.Drawing.Font("Segoe UI", 9f);

            // ── cboFilter ─────────────────────────────────
            this.cboFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilter.Location = new System.Drawing.Point(155, 12);
            this.cboFilter.Size = new System.Drawing.Size(180, 25);
            this.cboFilter.SelectedIndexChanged += new System.EventHandler(this.cboFilter_SelectedIndexChanged);

            // ── btnClearFilter ────────────────────────────
            this.btnClearFilter.Text = "Show All";
            this.btnClearFilter.Location = new System.Drawing.Point(350, 11);
            this.btnClearFilter.Size = new System.Drawing.Size(80, 26);
            this.btnClearFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearFilter.Click += new System.EventHandler(this.btnClearFilter_Click);

            // ── dgvExpenses ───────────────────────────────
            this.dgvExpenses.Location = new System.Drawing.Point(10, 118);
            this.dgvExpenses.Size = new System.Drawing.Size(864, 370);
            this.dgvExpenses.AllowUserToAddRows = false;
            this.dgvExpenses.ReadOnly = true;
            this.dgvExpenses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExpenses.BackgroundColor = System.Drawing.Color.White;
            this.dgvExpenses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvExpenses.RowHeadersVisible = false;
            this.dgvExpenses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvExpenses.MultiSelect = false;

            // ── panelButtons ──────────────────────────────
            this.panelButtons.BackColor = System.Drawing.Color.FromArgb(242, 247, 252);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtons.Height = 55;
            this.panelButtons.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.btnAdd, this.btnEdit, this.btnDelete });

            // ── btnAdd ────────────────────────────────────
            this.btnAdd.Text = "➕ Add Expense";
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(46, 117, 182);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Size = new System.Drawing.Size(130, 35);
            this.btnAdd.Location = new System.Drawing.Point(15, 10);
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            // ── btnEdit ───────────────────────────────────
            this.btnEdit.Text = "✏️ Edit";
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(91, 155, 213);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Size = new System.Drawing.Size(100, 35);
            this.btnEdit.Location = new System.Drawing.Point(160, 10);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);

            // ── btnDelete ─────────────────────────────────
            this.btnDelete.Text = "🗑️ Delete";
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(192, 80, 77);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Size = new System.Drawing.Size(100, 35);
            this.btnDelete.Location = new System.Drawing.Point(275, 10);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            // ── MainForm ──────────────────────────────────
            this.Text = "Personal Expense Tracker";
            this.Size = new System.Drawing.Size(900, 600);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Font = new System.Drawing.Font("Segoe UI", 9f);
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.panelTop, this.panelFilter, this.dgvExpenses, this.panelButtons });

            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelFilter.ResumeLayout(false);
            this.panelFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenses)).EndInit();
            this.panelButtons.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        // Control declarations
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitle;
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
    }
}