using System.Windows.Forms;

namespace PersonalExpenseTracker
{
    partial class AddEditForm : Form
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
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblDesc = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            this.panelBody.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(20)))), ((int)(((byte)(40)))));
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Controls.Add(this.lblSubtitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(438, 75);
            this.panelTop.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(209, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "💰  Add Expense";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(160)))), ((int)(((byte)(210)))));
            this.lblSubtitle.Location = new System.Drawing.Point(22, 44);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(162, 20);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Fill in the details below";
            // 
            // panelBody
            // 
            this.panelBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(24)))), ((int)(((byte)(45)))));
            this.panelBody.Controls.Add(this.lblAmount);
            this.panelBody.Controls.Add(this.txtAmount);
            this.panelBody.Controls.Add(this.lblCategory);
            this.panelBody.Controls.Add(this.cboCategory);
            this.panelBody.Controls.Add(this.lblDate);
            this.panelBody.Controls.Add(this.dtpDate);
            this.panelBody.Controls.Add(this.lblDesc);
            this.panelBody.Controls.Add(this.txtDesc);
            this.panelBody.Location = new System.Drawing.Point(0, 75);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(440, 350);
            this.panelBody.TabIndex = 1;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(160)))), ((int)(((byte)(230)))));
            this.lblAmount.Location = new System.Drawing.Point(30, 25);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(111, 19);
            this.lblAmount.TabIndex = 0;
            this.lblAmount.Text = "AMOUNT (LKR)";
            // 
            // txtAmount
            // 
            this.txtAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(36)))), ((int)(((byte)(65)))));
            this.txtAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAmount.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtAmount.ForeColor = System.Drawing.Color.White;
            this.txtAmount.Location = new System.Drawing.Point(30, 45);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(370, 34);
            this.txtAmount.TabIndex = 1;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(160)))), ((int)(((byte)(230)))));
            this.lblCategory.Location = new System.Drawing.Point(30, 98);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(81, 19);
            this.lblCategory.TabIndex = 2;
            this.lblCategory.Text = "CATEGORY";
            // 
            // cboCategory
            // 
            this.cboCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(36)))), ((int)(((byte)(65)))));
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCategory.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cboCategory.ForeColor = System.Drawing.Color.White;
            this.cboCategory.Location = new System.Drawing.Point(30, 118);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(370, 33);
            this.cboCategory.TabIndex = 3;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(160)))), ((int)(((byte)(230)))));
            this.lblDate.Location = new System.Drawing.Point(30, 168);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(43, 19);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "DATE";
            // 
            // dtpDate
            // 
            this.dtpDate.CalendarForeColor = System.Drawing.Color.White;
            this.dtpDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(36)))), ((int)(((byte)(65)))));
            this.dtpDate.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(30, 188);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(370, 32);
            this.dtpDate.TabIndex = 5;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(160)))), ((int)(((byte)(230)))));
            this.lblDesc.Location = new System.Drawing.Point(30, 238);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(173, 19);
            this.lblDesc.TabIndex = 6;
            this.lblDesc.Text = "DESCRIPTION  (optional)";
            // 
            // txtDesc
            // 
            this.txtDesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(36)))), ((int)(((byte)(65)))));
            this.txtDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDesc.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtDesc.ForeColor = System.Drawing.Color.White;
            this.txtDesc.Location = new System.Drawing.Point(30, 258);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(370, 70);
            this.txtDesc.TabIndex = 7;
            // 
            // panelButtons
            // 
            this.panelButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(20)))), ((int)(((byte)(40)))));
            this.panelButtons.Controls.Add(this.btnSave);
            this.panelButtons.Controls.Add(this.btnCancel);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtons.Location = new System.Drawing.Point(0, 426);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(438, 65);
            this.panelButtons.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(90)))), ((int)(((byte)(180)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(25, 14);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(180, 38);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "✔  Save Expense";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(220, 14);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(180, 38);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "✖  Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AddEditForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(24)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(438, 491);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.panelButtons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Expense";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelBody.ResumeLayout(false);
            this.panelBody.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}