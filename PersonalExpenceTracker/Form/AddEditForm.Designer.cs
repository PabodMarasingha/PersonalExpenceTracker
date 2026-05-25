using System.Windows.Forms;

namespace PersonalExpenseTracker
{
    partial class AddEditForm : Form
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblDesc = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();

            this.panelTop.BackColor = System.Drawing.Color.FromArgb(31, 56, 100);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Height = 55;
            this.panelTop.Controls.Add(this.lblTitle);

            this.lblTitle.Text = "Add Expense";
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13f, System.Drawing.FontStyle.Bold);
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(20, 14);

            this.lblAmount.Text = "Amount (LKR):";
            this.lblAmount.Location = new System.Drawing.Point(40, 80);
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold);

            this.txtAmount.Location = new System.Drawing.Point(40, 102);
            this.txtAmount.Size = new System.Drawing.Size(320, 23);
            this.txtAmount.Font = new System.Drawing.Font("Segoe UI", 10f);

            this.lblCategory.Text = "Category:";
            this.lblCategory.Location = new System.Drawing.Point(40, 142);
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold);

            this.cboCategory.Location = new System.Drawing.Point(40, 164);
            this.cboCategory.Size = new System.Drawing.Size(320, 23);
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.Font = new System.Drawing.Font("Segoe UI", 10f);

            this.lblDate.Text = "Date:";
            this.lblDate.Location = new System.Drawing.Point(40, 204);
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold);

            this.dtpDate.Location = new System.Drawing.Point(40, 226);
            this.dtpDate.Size = new System.Drawing.Size(320, 23);
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Font = new System.Drawing.Font("Segoe UI", 10f);

            this.lblDesc.Text = "Description (optional):";
            this.lblDesc.Location = new System.Drawing.Point(40, 266);
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold);

            this.txtDesc.Location = new System.Drawing.Point(40, 288);
            this.txtDesc.Size = new System.Drawing.Size(320, 60);
            this.txtDesc.Multiline = true;
            this.txtDesc.Font = new System.Drawing.Font("Segoe UI", 10f);

            this.btnSave.Text = "Save";
            this.btnSave.Location = new System.Drawing.Point(40, 370);
            this.btnSave.Size = new System.Drawing.Size(150, 38);
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(46, 117, 182);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10f, System.Drawing.FontStyle.Bold);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            this.btnCancel.Text = "Cancel";
            this.btnCancel.Location = new System.Drawing.Point(210, 370);
            this.btnCancel.Size = new System.Drawing.Size(150, 38);
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(192, 80, 77);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10f, System.Drawing.FontStyle.Bold);
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            this.Text = "Add / Edit Expense";
            this.Size = new System.Drawing.Size(420, 460);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.BackColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.panelTop, this.lblAmount, this.txtAmount,
                this.lblCategory, this.cboCategory,
                this.lblDate, this.dtpDate,
                this.lblDesc, this.txtDesc,
                this.btnSave, this.btnCancel });

            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}