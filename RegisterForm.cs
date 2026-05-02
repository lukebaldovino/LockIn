using System;
using System.Windows.Forms;

namespace LockIn
{
    public partial class RegisterForm : Form
    {
        private readonly LogInForm _loginForm;

        public RegisterForm(LogInForm loginForm)
        {
            InitializeComponent();
            StyleButton();
            _loginForm = loginForm;
        }

        // ── Create Account ────────────────────────────────────────────
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

            // TODO: hash + store master credentials
            Logger.Info($"New user registered: {user}");
            _loginForm.Show();
            this.Hide();
        }

        // ── Sign In link ──────────────────────────────────────────────
        private void SignInLink_Click(object sender, EventArgs e)
        {
            _loginForm.Show();
            this.Hide();
        }

        // ── Pill-shaped button styling ────────────────────────────────
        private void StyleButton()
        {
            CreateAccBtn.FlatStyle = FlatStyle.Flat;
            CreateAccBtn.FlatAppearance.BorderSize = 0;
            CreateAccBtn.Cursor = Cursors.Hand;

            CreateAccBtn.Paint += (s, e) =>
            {
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                e.Graphics.Clear(CardPanel.BackColor);

                int radius = CreateAccBtn.Height / 2;
                using var path = RoundedRect(new Rectangle(0, 0, CreateAccBtn.Width - 1, CreateAccBtn.Height - 1), radius);
                using var brush = new SolidBrush(Color.FromArgb(22, 163, 74));
                e.Graphics.FillPath(brush, path);

                using var sf = new StringFormat
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center
                };
                e.Graphics.DrawString(CreateAccBtn.Text, CreateAccBtn.Font, new SolidBrush(Color.White),
                    new Rectangle(0, 0, CreateAccBtn.Width, CreateAccBtn.Height), sf);
            };
        }

        private static System.Drawing.Drawing2D.GraphicsPath RoundedRect(Rectangle r, int radius)
        {
            var path = new System.Drawing.Drawing2D.GraphicsPath();
            int d = radius * 2;
            path.AddArc(r.X, r.Y, d, d, 180, 90);
            path.AddArc(r.Right - d, r.Y, d, d, 270, 90);
            path.AddArc(r.Right - d, r.Bottom - d, d, d, 0, 90);
            path.AddArc(r.X, r.Bottom - d, d, d, 90, 90);
            path.CloseFigure();
            return path;
        }

        // ── Stubs (wired in Designer) ─────────────────────────────────
        private void UsernameField_TextChanged(object sender, EventArgs e) { }
        private void SignInLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) { }
        private void RegisterForm_Load(object sender, EventArgs e) { }
        private void CardPanel_Paint(object sender, PaintEventArgs e) { }
    }
}