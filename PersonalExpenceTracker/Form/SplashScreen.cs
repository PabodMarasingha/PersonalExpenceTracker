using System;
using System.Windows.Forms;
using PersonalExpenseTracker.Data;

namespace PersonalExpenseTracker
{
    public partial class SplashScreen : Form
    {
        private int _progress = 0;

        public SplashScreen()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                _progress += 2;
                progressBar.Value = Math.Min(_progress, 100);

                if (_progress <= 30)
                    lblLoading.Text = "Initializing...";
                else if (_progress <= 60)
                    lblLoading.Text = "Loading database...";
                else if (_progress <= 85)
                    lblLoading.Text = "Preparing your data...";
                else
                    lblLoading.Text = "Almost ready...";

                if (_progress >= 100)
                {
                    timer1.Stop();
                    try
                    {
                        DatabaseHelper.InitializeDatabase();
                        LoginForm login = new LoginForm();
                        this.Hide();
                        login.ShowDialog();
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed to open: " + ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Application.Exit();
                    }
                }
            }
            catch (Exception ex)
            {
                timer1.Stop();
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}