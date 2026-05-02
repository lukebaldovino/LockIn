using System;
using System.Windows.Forms;

namespace LockIn
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            string user = UsernameField.Text.Trim();
            string pass = PasswordField.Text;

            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Please enter your username and password.", "Lock In",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // TODO: actual credential check against stored master password
            Logger.Info($"User logged in: {user}");
            var dashboard = new Dashboard();
            dashboard.FormClosed += (s, args) => this.Close();
            dashboard.Show();
            this.Hide();
        }

        private void RegisterLink_Click(object sender, EventArgs e)
        {
            new RegisterForm(this).Show();
            this.Hide();
        }

        private void LogInForm_Load(object sender, EventArgs e)
        {
        }

        private void LogInForm_Load(object sender, EventArgs e)
        {

        }
    }
}