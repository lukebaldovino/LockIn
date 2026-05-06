namespace LockIn
{
    public partial class RegisterForm : Form
    {
        private readonly LogInForm? _loginForm;

        public RegisterForm(LogInForm? loginForm)
        {
            InitializeComponent();
            StyleButton();
            ApplyTheme();
            _loginForm = loginForm;
        }

        private void CreateAccBtn_Click(object sender, EventArgs e)
        {
            string user = UsernameField.Text.Trim();
            string pass = PasswordField.Text;
            string confirm = ConfirmPasswordField.Text;

            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("All fields are required.", "Lock In",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (pass != confirm)
            {
                MessageBox.Show("Passwords do not match.", "Lock In",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MasterAccount.Save(user, pass);
            byte[] key = MasterAccount.DeriveKey(pass);
            UtilityFunctions.Initialize(key);
            Logger.Info($"New user registered: {user}");

            var dashboard = new Dashboard();
            dashboard.FormClosed += (s, args) => Application.Exit();
            dashboard.Show();
            this.Hide();
        }

        private void SignInLink_Click(object sender, EventArgs e)
        {
            if (_loginForm != null)
                _loginForm.Show();
            else
                new LogInForm().Show();
            this.Hide();
        }

        private void StyleButton()
        {
            CreateAccBtn.FlatStyle = FlatStyle.Flat;
            CreateAccBtn.FlatAppearance.BorderSize = 0;
            CreateAccBtn.Cursor = Cursors.Hand;
        }

        private void ApplyTheme()
        {
            BackColor = ThemeColors.BgCard;
            CardPanel.BackColor = ThemeColors.BgCard;
            TitleLbl.ForeColor = ThemeColors.TextBright;
            SubtitleLbl.ForeColor = ThemeColors.TextPlaceholder;
            UsernameLbl.ForeColor = ThemeColors.TextLabel;
            PasswordLbl.ForeColor = ThemeColors.TextLabel;
            ConfirmPasswordLbl.ForeColor = ThemeColors.TextLabel;
            UsernameField.BackColor = ThemeColors.BgInput;
            UsernameField.ForeColor = ThemeColors.TextBright;
            PasswordField.BackColor = ThemeColors.BgInput;
            PasswordField.ForeColor = ThemeColors.TextBright;
            ConfirmPasswordField.BackColor = ThemeColors.BgInput;
            ConfirmPasswordField.ForeColor = ThemeColors.TextBright;
            CreateAccBtn.BackColor = ThemeColors.AccentBlue;
            AlreadyHaveLbl.ForeColor = ThemeColors.TextPlaceholder;
            SignInLink.LinkColor = Color.FromArgb(100, 170, 255);
            SignInLink.ActiveLinkColor = Color.White;
            SignInLink.VisitedLinkColor = Color.FromArgb(100, 170, 255);
        }

        private void UsernameField_TextChanged(object sender, EventArgs e) { }
        private void SignInLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) { }
        private void RegisterForm_Load(object sender, EventArgs e) { }
        private void CardPanel_Paint(object sender, PaintEventArgs e) { }
    }
}
