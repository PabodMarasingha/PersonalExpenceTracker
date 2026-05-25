namespace PersonalExpenseTracker.Models
{
    public class Expense
    {
        public int ExpenseID { get; set; }
        public decimal Amount { get; set; }
        public string Category { get; set; }
        public System.DateTime Date { get; set; }
        public string Description { get; set; }
    }
}