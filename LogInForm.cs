namespace LockIn
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
            ApplyTheme();
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

            if (!MasterAccount.Verify(user, pass))
            {
                MessageBox.Show("Invalid username or password.", "Lock In",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var (_, key) = MasterAccount.Load()!.Value;
            UtilityFunctions.Initialize(key);
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

        private void ApplyTheme()
        {
            BackColor = ThemeColors.BgCard;
            CardPanel.BackColor = ThemeColors.BgCard;
            TitleLbl.ForeColor = ThemeColors.TextBright;
            SubtitleLbl.ForeColor = ThemeColors.TextPlaceholder;
            UsernameLbl.ForeColor = ThemeColors.TextLabel;
            PasswordLbl.ForeColor = ThemeColors.TextLabel;
            UsernameField.BackColor = ThemeColors.BgInput;
            UsernameField.ForeColor = ThemeColors.TextBright;
            PasswordField.BackColor = ThemeColors.BgInput;
            PasswordField.ForeColor = ThemeColors.TextBright;
            LogInButton.BackColor = ThemeColors.AccentBlue;
            LogInButton.ForeColor = Color.White;
            NoAccountLbl.ForeColor = ThemeColors.TextPlaceholder;
            RegisterLink.LinkColor = Color.FromArgb(100, 170, 255);
            RegisterLink.ActiveLinkColor = Color.White;
            RegisterLink.VisitedLinkColor = Color.FromArgb(100, 170, 255);
        }
    }
}
