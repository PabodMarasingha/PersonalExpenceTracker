using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using PersonalExpenseTracker.Data;

namespace PersonalExpenseTracker
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            LoadDashboard();
        }

        private void LoadDashboard()
        {
            int year = DateTime.Now.Year;
            int month = DateTime.Now.Month;

            lblMonth.Text = "📅 " + DateTime.Now.ToString("MMMM yyyy");

            var expenses = DatabaseHelper.GetExpensesByMonth(year, month);

            decimal total = 0;
            foreach (var e in expenses)
                total += e.Amount;

            lblTotalVal.Text = "LKR " + total.ToString("N2");

            var summary = new Dictionary<string, decimal>();
            foreach (var e in expenses)
            {
                if (!summary.ContainsKey(e.Category))
                    summary[e.Category] = 0;
                summary[e.Category] += e.Amount;
            }

            var table = new System.Data.DataTable();
            table.Columns.Add("Category");
            table.Columns.Add("Total (LKR)");
            table.Columns.Add("%");

            foreach (var kvp in summary)
            {
                string pct = total > 0
                    ? ((kvp.Value / total) * 100).ToString("N1") + "%"
                    : "0%";
                table.Rows.Add(kvp.Key, kvp.Value.ToString("N2"), pct);
            }

            dgvSummary.DataSource = table;

            dgvSummary.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(15, 20, 40);
            dgvSummary.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(100, 180, 255);
            dgvSummary.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
            dgvSummary.EnableHeadersVisualStyles = false;
            dgvSummary.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(25, 32, 58);
            dgvSummary.AlternatingRowsDefaultCellStyle.ForeColor = Color.FromArgb(200, 220, 255);

            if (expenses.Count == 0)
                lblTotalVal.Text = "No expenses this month yet.";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}