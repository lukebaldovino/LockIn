namespace LockIn
{
    public partial class AddAccForm : Form
    {
        public string AccountTypeName { get; private set; } = "";
        public string Username { get; private set; } = "";
        public string Password { get; private set; } = "";
        public string Service { get; private set; } = "";

        public AddAccForm()
        {
            InitializeComponent();
            ApplyTheme();
            if (AccTypeCmBx.Items.Count > 0)
                AccTypeCmBx.SelectedIndex = 0;
        }

        private void AutoGenBtn_Click(object sender, EventArgs e)
        {
            const int length = 16;
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*()";

            char[] res = new char[length];
            using (var rng = System.Security.Cryptography.RandomNumberGenerator.Create())
            {
                byte[] buf = new byte[sizeof(uint)];
                for (int i = 0; i < length; i++)
                {
                    rng.GetBytes(buf);
                    uint num = BitConverter.ToUInt32(buf, 0);
                    res[i] = valid[(int)(num % (uint)valid.Length)];
                }
            }

            PasswordField.UseSystemPasswordChar = false;
            PasswordField.Text = new string(res);
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            string type = AccTypeCmBx.SelectedItem?.ToString() ?? "";
            string service = ServiceField.Text.Trim();
            string username = UsernameField.Text.Trim();
            string password = PasswordField.Text;

            if (string.IsNullOrEmpty(service))
            {
                MessageBox.Show("Please enter a service name.", "Lock In",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ServiceField.Focus();
                return;
            }

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Please enter a username.", "Lock In",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                UsernameField.Focus();
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter a password.", "Lock In",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                PasswordField.Focus();
                return;
            }

            Service = service;
            Username = username;
            Password = password;
            AccountTypeName = type;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void ApplyTheme()
        {
            BackColor = ThemeColors.BgPrimary;
            MainPanel.BackColor = ThemeColors.BgCard;
            TitleLbl.ForeColor = ThemeColors.TextBright;
            SeparatorPanel.BackColor = ThemeColors.BorderColor;
            AccTypeLbl.ForeColor = ThemeColors.TextMuted;
            ServiceLbl.ForeColor = ThemeColors.TextMuted;
            UsernameLbl.ForeColor = ThemeColors.TextMuted;
            PasswordLbl.ForeColor = ThemeColors.TextMuted;
            AutoGenLbl.ForeColor = ThemeColors.TextMuted;
            AccTypeCmBx.BackColor = ThemeColors.BgInput;
            AccTypeCmBx.ForeColor = ThemeColors.TextBright;
            ServiceField.BackColor = ThemeColors.BgInput;
            ServiceField.ForeColor = ThemeColors.TextBright;
            UsernameField.BackColor = ThemeColors.BgInput;
            UsernameField.ForeColor = ThemeColors.TextBright;
            PasswordField.BackColor = ThemeColors.BgInput;
            PasswordField.ForeColor = ThemeColors.TextBright;
            AutoGenBtn.BackColor = ThemeColors.IsDarkMode ? Color.FromArgb(55, 55, 60) : Color.FromArgb(229, 231, 235);
            AutoGenBtn.ForeColor = ThemeColors.IsDarkMode ? Color.FromArgb(220, 220, 220) : Color.FromArgb(55, 65, 81);
            CancelBtn.BackColor = Color.FromArgb(55, 55, 60);
            ConfirmBtn.BackColor = ThemeColors.AccentGreen;
            ConfirmBtn.ForeColor = Color.White;
        }

        private void AccTypeCmBx_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;
            e.DrawBackground();
            Color bg = ThemeColors.IsDarkMode ? Color.FromArgb(50, 50, 58) : Color.FromArgb(255, 255, 255);
            Color fg = ThemeColors.TextBright;
            using var bgBrush = new SolidBrush(bg);
            using var textBrush = new SolidBrush(fg);
            e.Graphics.FillRectangle(bgBrush, e.Bounds);
            string text = AccTypeCmBx.Items[e.Index]?.ToString() ?? "";
            using var itemFont = new Font(e.Font ?? AccTypeCmBx.Font, FontStyle.Regular);
            e.Graphics.DrawString(text, itemFont, textBrush, e.Bounds);
            e.DrawFocusRectangle();
        }

        private void AccTypeCmBx_SelectedIndexChanged(object sender, EventArgs e) { }
        private void UsernameField_TextChanged(object sender, EventArgs e) { }
        private void PasswordField_TextChanged(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void ServiceField_TextChanged(object sender, EventArgs e) { }

        private void AddAccForm_Load(object sender, EventArgs e)
        {

        }
    }
}
