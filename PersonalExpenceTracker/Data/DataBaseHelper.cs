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
    $"Data Source={dbPath};Version=3;Journal Mode=WAL;";

        public static void InitializeDatabase()
        {
            string folder = Path.GetDirectoryName(dbPath);
            if (!Directory.Exists(folder))
                Directory.CreateDirectory(folder);

            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();

                // Users table
                string createUsers = @"
                    CREATE TABLE IF NOT EXISTS Users (
                        UserID    INTEGER PRIMARY KEY AUTOINCREMENT,
                        Username  TEXT NOT NULL UNIQUE,
                        Password  TEXT NOT NULL,
                        Email     TEXT,
                        Phone     TEXT,
                        CreatedAt TEXT
                    );";

                // Category table
                string createCategory = @"
                    CREATE TABLE IF NOT EXISTS Category (
                        CategoryID   INTEGER PRIMARY KEY AUTOINCREMENT,
                        CategoryName TEXT NOT NULL
                    );";

                // Expense table with UserID
                string createExpense = @"
                    CREATE TABLE IF NOT EXISTS Expense (
                        ExpenseID   INTEGER PRIMARY KEY AUTOINCREMENT,
                        UserID      INTEGER NOT NULL,
                        Amount      REAL    NOT NULL,
                        Category    TEXT    NOT NULL,
                        Date        TEXT    NOT NULL,
                        Description TEXT,
                        FOREIGN KEY (UserID) REFERENCES Users(UserID)
                    );";

                new SQLiteCommand(createUsers, conn).ExecuteNonQuery();
                new SQLiteCommand(createCategory, conn).ExecuteNonQuery();
                new SQLiteCommand(createExpense, conn).ExecuteNonQuery();

                // Seed default categories
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

        // ── USER OPERATIONS ───────────────────────────────

        public static bool RegisterUser(string username, string password,
                                        string email, string phone)
        {
            try
            {
                using (var conn = new SQLiteConnection(ConnectionString))
                {
                    conn.Open();
                    string sql = @"INSERT INTO Users 
                                   (Username, Password, Email, Phone, CreatedAt)
                                   VALUES (@u, @p, @e, @ph, @dt);";
                    var cmd = new SQLiteCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@u", username);
                    cmd.Parameters.AddWithValue("@p", password);
                    cmd.Parameters.AddWithValue("@e", email ?? "");
                    cmd.Parameters.AddWithValue("@ph", phone ?? "");
                    cmd.Parameters.AddWithValue("@dt", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch { return false; }
        }

        public static User LoginUser(string username, string password)
        {
            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();
                string sql = @"SELECT * FROM Users 
                               WHERE Username=@u AND Password=@p;";
                var cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@u", username);
                cmd.Parameters.AddWithValue("@p", password);
                var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return new User
                    {
                        UserID = reader.GetInt32(0),
                        Username = reader.GetString(1),
                        Email = reader.IsDBNull(3) ? "" : reader.GetString(3),
                        Phone = reader.IsDBNull(4) ? "" : reader.GetString(4)
                    };
                }
                return null;
            }
        }

        public static bool UsernameExists(string username)
        {
            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();
                string sql = "SELECT COUNT(*) FROM Users WHERE Username=@u;";
                var cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@u", username);
                return (long)cmd.ExecuteScalar() > 0;
            }
        }

        // ── EXPENSE CRUD ──────────────────────────────────

        public static void InsertExpense(Expense e, int userID)
        {
            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();
                string sql = @"INSERT INTO Expense 
                               (UserID, Amount, Category, Date, Description)
                               VALUES (@uid, @amt, @cat, @dt, @desc);";
                var cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@uid", userID);
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
                               SET Amount=@amt, Category=@cat, 
                                   Date=@dt, Description=@desc
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

        public static List<Expense> GetAllExpenses(int userID)
        {
            var list = new List<Expense>();
            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();
                string sql = @"SELECT * FROM Expense 
                               WHERE UserID=@uid 
                               ORDER BY Date DESC;";
                var cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@uid", userID);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new Expense
                    {
                        ExpenseID = reader.GetInt32(0),
                        Amount = reader.GetDecimal(2),
                        Category = reader.GetString(3),
                        Date = DateTime.Parse(reader.GetString(4)),
                        Description = reader.GetString(5)
                    });
                }
            }
            return list;
        }

        public static List<Expense> GetExpensesByMonth(int userID, int year, int month)
        {
            var list = new List<Expense>();
            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();
                string sql = @"SELECT * FROM Expense
                               WHERE UserID=@uid
                                 AND strftime('%Y', Date) = @yr
                                 AND strftime('%m', Date) = @mo
                               ORDER BY Date DESC;";
                var cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@uid", userID);
                cmd.Parameters.AddWithValue("@yr", year.ToString("D4"));
                cmd.Parameters.AddWithValue("@mo", month.ToString("D2"));
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new Expense
                    {
                        ExpenseID = reader.GetInt32(0),
                        Amount = reader.GetDecimal(2),
                        Category = reader.GetString(3),
                        Date = DateTime.Parse(reader.GetString(4)),
                        Description = reader.GetString(5)
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
        // ── SALARY OPERATIONS ─────────────────────────────

        public static void SaveSalary(int userID, decimal salary, int month, int year)
        {
            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();

                // Create salary table if not exists
                string createSalary = @"
            CREATE TABLE IF NOT EXISTS Salary (
                SalaryID  INTEGER PRIMARY KEY AUTOINCREMENT,
                UserID    INTEGER NOT NULL,
                Amount    REAL    NOT NULL,
                Month     INTEGER NOT NULL,
                Year      INTEGER NOT NULL
            );";
                new SQLiteCommand(createSalary, conn).ExecuteNonQuery();

                // Check if salary exists for this month
                string check = @"SELECT COUNT(*) FROM Salary 
                         WHERE UserID=@uid AND Month=@mo AND Year=@yr;";
                var checkCmd = new SQLiteCommand(check, conn);
                checkCmd.Parameters.AddWithValue("@uid", userID);
                checkCmd.Parameters.AddWithValue("@mo", month);
                checkCmd.Parameters.AddWithValue("@yr", year);
                long count = (long)checkCmd.ExecuteScalar();

                if (count > 0)
                {
                    // Update existing
                    string update = @"UPDATE Salary SET Amount=@amt 
                              WHERE UserID=@uid AND Month=@mo AND Year=@yr;";
                    var cmd = new SQLiteCommand(update, conn);
                    cmd.Parameters.AddWithValue("@amt", salary);
                    cmd.Parameters.AddWithValue("@uid", userID);
                    cmd.Parameters.AddWithValue("@mo", month);
                    cmd.Parameters.AddWithValue("@yr", year);
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    // Insert new
                    string insert = @"INSERT INTO Salary (UserID, Amount, Month, Year)
                              VALUES (@uid, @amt, @mo, @yr);";
                    var cmd = new SQLiteCommand(insert, conn);
                    cmd.Parameters.AddWithValue("@uid", userID);
                    cmd.Parameters.AddWithValue("@amt", salary);
                    cmd.Parameters.AddWithValue("@mo", month);
                    cmd.Parameters.AddWithValue("@yr", year);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static decimal GetSalary(int userID, int month, int year)
        {
            try
            {
                using (var conn = new SQLiteConnection(ConnectionString))
                {
                    conn.Open();

                    string createSalary = @"
                CREATE TABLE IF NOT EXISTS Salary (
                    SalaryID  INTEGER PRIMARY KEY AUTOINCREMENT,
                    UserID    INTEGER NOT NULL,
                    Amount    REAL    NOT NULL,
                    Month     INTEGER NOT NULL,
                    Year      INTEGER NOT NULL
                );";
                    new SQLiteCommand(createSalary, conn).ExecuteNonQuery();

                    string sql = @"SELECT Amount FROM Salary 
                           WHERE UserID=@uid AND Month=@mo AND Year=@yr;";
                    var cmd = new SQLiteCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@uid", userID);
                    cmd.Parameters.AddWithValue("@mo", month);
                    cmd.Parameters.AddWithValue("@yr", year);
                    var result = cmd.ExecuteScalar();
                    return result != null ? Convert.ToDecimal(result) : 0;
                }
            }
            catch { return 0; }
        }
    }
}