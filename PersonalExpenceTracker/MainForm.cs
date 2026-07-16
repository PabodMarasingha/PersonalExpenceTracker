using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using PersonalExpenseTracker.Data;
using PersonalExpenseTracker.Models;
using Microsoft.VisualBasic;

namespace PersonalExpenseTracker
{
    public partial class MainForm : Form
    {
        private List<Expense> _expenses = new List<Expense>();

        public MainForm()
        {
            InitializeComponent();
            LoadCategoriesToFilter();
            LoadExpenses();
            LoadSalaryInfo();
        }
        // ── SALARY METHODS ────────────────────────────────

        private void LoadSalaryInfo()
        {
            int year = DateTime.Now.Year;
            int month = DateTime.Now.Month;

            lblWelcome.Text = "👋 Welcome, " + Session.Username + "!";

            decimal salary = DatabaseHelper.GetSalary(Session.UserID, month, year);
            decimal spent = GetTotalSpentThisMonth();
            decimal remaining = salary - spent;

            if (salary > 0)
            {
                lblSalaryInfo.Text = "Monthly Salary: LKR " + salary.ToString("N2");
                lblRemaining.Text = "Remaining: LKR " + remaining.ToString("N2");

                int percentage = (int)((spent / salary) * 100);
                percentage = Math.Min(percentage, 100);
                progressBudget.Value = percentage;

                // Change color based on spending
                if (percentage >= 90)
                {
                    progressBudget.ForeColor = System.Drawing.Color.Red;
                    lblRemaining.ForeColor = System.Drawing.Color.FromArgb(255, 100, 100);
                }
                else if (percentage >= 70)
                {
                    progressBudget.ForeColor = System.Drawing.Color.Orange;
                    lblRemaining.ForeColor = System.Drawing.Color.Orange;
                }
                else
                {
                    progressBudget.ForeColor = System.Drawing.Color.FromArgb(150, 100, 255);
                    lblRemaining.ForeColor = System.Drawing.Color.FromArgb(180, 255, 180);
                }

                // Warning if over 80%
                if (percentage >= 80 && percentage < 100)
                {
                    MessageBox.Show(
                        $"⚠️ Warning!\nYou have spent {percentage}% of your monthly salary!\nRemaining: LKR {remaining:N2}",
                        "Budget Warning",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
                else if (percentage >= 100)
                {
                    MessageBox.Show(
                        "🚨 Alert!\nYou have exceeded your monthly budget!",
                        "Budget Exceeded",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else
            {
                lblSalaryInfo.Text = "Monthly Salary: Not set — click 'Set Salary'";
                lblRemaining.Text = "Remaining: --";
                progressBudget.Value = 0;
            }
        }

        private decimal GetTotalSpentThisMonth()
        {
            var expenses = DatabaseHelper.GetExpensesByMonth(
                Session.UserID, DateTime.Now.Year, DateTime.Now.Month);
            decimal total = 0;
            foreach (var e in expenses)
                total += e.Amount;
            return total;
        }

        private void btnSetSalary_Click(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox(
                "Enter your monthly salary (LKR):",
                "Set Monthly Salary",
                "");

            if (string.IsNullOrWhiteSpace(input)) return;

            if (decimal.TryParse(input, out decimal salary) && salary > 0)
            {
                DatabaseHelper.SaveSalary(
                    Session.UserID, salary,
                    DateTime.Now.Month, DateTime.Now.Year);

                MessageBox.Show(
                    "Salary saved successfully!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadSalaryInfo();
            }
            else
            {
                MessageBox.Show(
                    "Please enter a valid salary amount!",
                    "Invalid Input",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        // ── Load expenses into the grid ──────────────────
        private void LoadExpenses()
        {
            _expenses = DatabaseHelper.GetAllExpenses(Session.UserID);
            BindGrid(_expenses);
            LoadSalaryInfo();
        }

        private void BindGrid(List<Expense> list)
        {
            dgvExpenses.DataSource = null;
            dgvExpenses.DataSource = list;

            try
            {
                if (dgvExpenses.Columns.Count > 0 && list.Count > 0)
                {
                    dgvExpenses.Columns["ExpenseID"].HeaderText = "ID";
                    dgvExpenses.Columns["ExpenseID"].Width = 40;
                    dgvExpenses.Columns["Amount"].HeaderText = "Amount (LKR)";
                    dgvExpenses.Columns["Category"].HeaderText = "Category";
                    dgvExpenses.Columns["Date"].HeaderText = "Date";
                    dgvExpenses.Columns["Description"].HeaderText = "Description";

                    dgvExpenses.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(75, 0, 130);
                    dgvExpenses.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                    dgvExpenses.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
                    dgvExpenses.EnableHeadersVisualStyles = false;
                    dgvExpenses.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 240, 255);
                    dgvExpenses.AlternatingRowsDefaultCellStyle.ForeColor = Color.FromArgb(50, 0, 80);
                }
            }
            catch { }

            // Update total label
            decimal total = 0;
            foreach (var item in list)
                total += item.Amount;
            lblTotal.Text = "Total: LKR " + total.ToString("N2");
        }

        // ── Load categories into filter dropdown ─────────
        private void LoadCategoriesToFilter()
        {
            cboFilter.Items.Clear();
            cboFilter.Items.Add("All");
            foreach (var cat in DatabaseHelper.GetCategories())
                cboFilter.Items.Add(cat);
            cboFilter.SelectedIndex = 0;
        }

        // ── ADD button ───────────────────────────────────
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var form = new AddEditForm(Session.UserID);
            if (form.ShowDialog() == DialogResult.OK)
                LoadExpenses();
        }

        // ── EDIT button ──────────────────────────────────
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvExpenses.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an expense to edit.",
                    "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var selected = (Expense)dgvExpenses.SelectedRows[0].DataBoundItem;
            var form = new AddEditForm(selected);
            if (form.ShowDialog() == DialogResult.OK)
                LoadExpenses();
        }

        // ── DELETE button ─────────────────────────────────
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvExpenses.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an expense to delete.",
                    "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var selected = (Expense)dgvExpenses.SelectedRows[0].DataBoundItem;
            var confirm = MessageBox.Show(
                $"Are you sure you want to delete this expense?\n\nAmount: {selected.Amount:C}\nCategory: {selected.Category}",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                DatabaseHelper.DeleteExpense(selected.ExpenseID);
                LoadExpenses();
            }
        }

        // ── FILTER dropdown ───────────────────────────────
        private void cboFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboFilter.SelectedItem.ToString() == "All")
            {
                BindGrid(_expenses);
            }
            else
            {
                var filtered = _expenses.FindAll(
                    x => x.Category == cboFilter.SelectedItem.ToString());
                BindGrid(filtered);
            }
        }

        // ── SHOW ALL button ───────────────────────────────
        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            cboFilter.SelectedIndex = 0;
            LoadExpenses();
        }

        // ── DASHBOARD button ──────────────────────────────
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            var dash = new Dashboard();
            dash.ShowDialog();
        }

    }
}