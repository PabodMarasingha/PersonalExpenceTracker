using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using PersonalExpenseTracker.Models;

namespace PersonalExpenseTracker.Data
{
    public class DatabaseHelper
    {
        private static string dbPath = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "PersonalExpenseTracker", "expenses.db");

        private static string ConnectionString =>
            $"Data Source={dbPath};Version=3;";

        // Creates the database file and tables if they don't exist
        public static void InitializeDatabase()
        {
            string folder = Path.GetDirectoryName(dbPath);
            if (!Directory.Exists(folder))
                Directory.CreateDirectory(folder);

            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();

                string createCategory = @"
                    CREATE TABLE IF NOT EXISTS Category (
                        CategoryID   INTEGER PRIMARY KEY AUTOINCREMENT,
                        CategoryName TEXT NOT NULL
                    );";

                string createExpense = @"
                    CREATE TABLE IF NOT EXISTS Expense (
                        ExpenseID   INTEGER PRIMARY KEY AUTOINCREMENT,
                        Amount      REAL    NOT NULL,
                        Category    TEXT    NOT NULL,
                        Date        TEXT    NOT NULL,
                        Description TEXT
                    );";

                new SQLiteCommand(createCategory, conn).ExecuteNonQuery();
                new SQLiteCommand(createExpense, conn).ExecuteNonQuery();

                // Seed default categories if empty
                string checkCats = "SELECT COUNT(*) FROM Category;";
                long count = (long)new SQLiteCommand(checkCats, conn).ExecuteScalar();
                if (count == 0)
                {
                    string[] defaults = { "Food", "Transport", "Utilities",
                                          "Entertainment", "Health", "Other" };
                    foreach (var cat in defaults)
                    {
                        string ins = $"INSERT INTO Category (CategoryName) VALUES ('{cat}');";
                        new SQLiteCommand(ins, conn).ExecuteNonQuery();
                    }
                }
            }
        }

        // ── EXPENSE CRUD ──────────────────────────────────

        public static void InsertExpense(Expense e)
        {
            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();
                string sql = @"INSERT INTO Expense (Amount, Category, Date, Description)
                               VALUES (@amt, @cat, @dt, @desc);";
                var cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@amt", e.Amount);
                cmd.Parameters.AddWithValue("@cat", e.Category);
                cmd.Parameters.AddWithValue("@dt", e.Date.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@desc", e.Description ?? "");
                cmd.ExecuteNonQuery();
            }
        }

        public static void UpdateExpense(Expense e)
        {
            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();
                string sql = @"UPDATE Expense
                               SET Amount=@amt, Category=@cat, Date=@dt, Description=@desc
                               WHERE ExpenseID=@id;";
                var cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@amt", e.Amount);
                cmd.Parameters.AddWithValue("@cat", e.Category);
                cmd.Parameters.AddWithValue("@dt", e.Date.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@desc", e.Description ?? "");
                cmd.Parameters.AddWithValue("@id", e.ExpenseID);
                cmd.ExecuteNonQuery();
            }
        }

        public static void DeleteExpense(int id)
        {
            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();
                string sql = "DELETE FROM Expense WHERE ExpenseID=@id;";
                var cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }

        public static List<Expense> GetAllExpenses()
        {
            var list = new List<Expense>();
            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();
                string sql = "SELECT * FROM Expense ORDER BY Date DESC;";
                var reader = new SQLiteCommand(sql, conn).ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new Expense
                    {
                        ExpenseID = reader.GetInt32(0),
                        Amount = reader.GetDecimal(1),
                        Category = reader.GetString(2),
                        Date = DateTime.Parse(reader.GetString(3)),
                        Description = reader.GetString(4)
                    });
                }
            }
            return list;
        }

        public static List<Expense> GetExpensesByMonth(int year, int month)
        {
            var list = new List<Expense>();
            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();
                string sql = @"SELECT * FROM Expense
                               WHERE strftime('%Y', Date) = @yr
                                 AND strftime('%m', Date) = @mo
                               ORDER BY Date DESC;";
                var cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@yr", year.ToString("D4"));
                cmd.Parameters.AddWithValue("@mo", month.ToString("D2"));
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new Expense
                    {
                        ExpenseID = reader.GetInt32(0),
                        Amount = reader.GetDecimal(1),
                        Category = reader.GetString(2),
                        Date = DateTime.Parse(reader.GetString(3)),
                        Description = reader.GetString(4)
                    });
                }
            }
            return list;
        }

        public static List<string> GetCategories()
        {
            var list = new List<string>();
            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();
                var reader = new SQLiteCommand(
                    "SELECT CategoryName FROM Category ORDER BY CategoryName;", conn)
                    .ExecuteReader();
                while (reader.Read())
                    list.Add(reader.GetString(0));
            }
            return list;
        }
    }
}