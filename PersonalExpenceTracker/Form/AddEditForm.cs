using System;
using System.Windows.Forms;
using PersonalExpenseTracker.Data;
using PersonalExpenseTracker.Models;

namespace PersonalExpenseTracker
{
    public partial class AddEditForm : Form
    {
        private Expense _expense;
        private bool _isEdit;
        private int _userID;

        // Adding new expense
        public AddEditForm(int userID)
        {
            InitializeComponent();
            _isEdit = false;
            _userID = userID;
            LoadCategories();
            dtpDate.Value = DateTime.Today;
        }

        // Editing existing expense
        public AddEditForm(Expense expense)
        {
            InitializeComponent();
            _isEdit = true;
            _expense = expense;
            LoadCategories();
            PopulateFields();
        }

        private void LoadCategories()
        {
            cboCategory.Items.Clear();
            foreach (var cat in DatabaseHelper.GetCategories())
                cboCategory.Items.Add(cat);
            if (cboCategory.Items.Count > 0)
                cboCategory.SelectedIndex = 0;
        }

        private void PopulateFields()
        {
            txtAmount.Text = _expense.Amount.ToString();
            cboCategory.SelectedItem = _expense.Category;
            dtpDate.Value = _expense.Date;
            txtDesc.Text = _expense.Description;
            lblTitle.Text = "Edit Expense";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAmount.Text))
            {
                MessageBox.Show("Please enter an amount.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!decimal.TryParse(txtAmount.Text, out decimal amount) || amount <= 0)
            {
                MessageBox.Show("Please enter a valid positive amount.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cboCategory.SelectedItem == null)
            {
                MessageBox.Show("Please select a category.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var expense = new Expense
            {
                Amount = amount,
                Category = cboCategory.SelectedItem.ToString(),
                Date = dtpDate.Value,
                Description = txtDesc.Text.Trim()
            };

            if (_isEdit)
            {
                expense.ExpenseID = _expense.ExpenseID;
                DatabaseHelper.UpdateExpense(expense);
                MessageBox.Show("Expense updated!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DatabaseHelper.InsertExpense(expense, _userID);
                MessageBox.Show("Expense added!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}