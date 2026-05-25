using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using PersonalExpenseTracker.Data;
using PersonalExpenseTracker.Models;

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
        }

        // ── Load expenses into the grid ──────────────────
        private void LoadExpenses()
        {
            _expenses = DatabaseHelper.GetAllExpenses();
            BindGrid(_expenses);
        }

        private void BindGrid(List<Expense> list)
        {
            dgvExpenses.DataSource = null;
            dgvExpenses.DataSource = list;

            if (dgvExpenses.Columns.Count > 0 && list.Count > 0)
            {
                dgvExpenses.Columns["ExpenseID"].HeaderText = "ID";
                dgvExpenses.Columns["ExpenseID"].Width = 40;
                dgvExpenses.Columns["Amount"].HeaderText = "Amount (LKR)";
                dgvExpenses.Columns["Category"].HeaderText = "Category";
                dgvExpenses.Columns["Date"].HeaderText = "Date";
                dgvExpenses.Columns["Description"].HeaderText = "Description";

                dgvExpenses.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(31, 56, 100);
                dgvExpenses.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgvExpenses.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
                dgvExpenses.EnableHeadersVisualStyles = false;
                dgvExpenses.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(242, 247, 252);
            }
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
            var form = new AddEditForm();
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