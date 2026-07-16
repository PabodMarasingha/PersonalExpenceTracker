namespace PersonalExpenseTracker.Models
{
    public static class Session
    {
        public static User CurrentUser { get; set; }

        public static int UserID =>
            CurrentUser != null ? CurrentUser.UserID : 0;

        public static string Username =>
            CurrentUser != null ? CurrentUser.Username : "";

        public static void Logout()
        {
            CurrentUser = null;
        }
    }
}