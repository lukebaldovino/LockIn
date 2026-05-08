namespace LockIn
{
    partial class LogInForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInForm));
            LockIconLbl = new Label();
            TitleLbl = new Label();
            SubtitleLbl = new Label();
            UsernameLbl = new Label();
            PasswordLbl = new Label();
            UsernameField = new TextBox();
            PasswordField = new TextBox();
            LogInButton = new Button();
            NoAccountLbl = new Label();
            RegisterLink = new LinkLabel();
            CardPanel = new Panel();
            CardPanel.SuspendLayout();
            SuspendLayout();
            // 
            // LockIconLbl
            // 
            LockIconLbl.Font = new Font("Segoe UI Emoji", 26F);
            LockIconLbl.Location = new Point(3, 28);
            LockIconLbl.Name = "LockIconLbl";
            LockIconLbl.Size = new Size(354, 48);
            LockIconLbl.TabIndex = 0;
            LockIconLbl.Text = "🔒";
            LockIconLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TitleLbl
            // 
            TitleLbl.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            TitleLbl.ForeColor = Color.White;
            TitleLbl.Location = new Point(3, 80);
            TitleLbl.Name = "TitleLbl";
            TitleLbl.Size = new Size(354, 36);
            TitleLbl.TabIndex = 1;
            TitleLbl.Text = "Lock In";
            TitleLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SubtitleLbl
            // 
            SubtitleLbl.Font = new Font("Segoe UI", 9F);
            SubtitleLbl.ForeColor = Color.FromArgb(140, 140, 150);
            SubtitleLbl.Location = new Point(3, 116);
            SubtitleLbl.Name = "SubtitleLbl";
            SubtitleLbl.Size = new Size(354, 24);
            SubtitleLbl.TabIndex = 2;
            SubtitleLbl.Text = "Your secure credential vault";
            SubtitleLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UsernameLbl
            // 
            UsernameLbl.AutoSize = true;
            UsernameLbl.ForeColor = Color.FromArgb(170, 170, 180);
            UsernameLbl.Location = new Point(30, 158);
            UsernameLbl.Name = "UsernameLbl";
            UsernameLbl.Size = new Size(87, 23);
            UsernameLbl.TabIndex = 3;
            UsernameLbl.Text = "Username";
            // 
            // PasswordLbl
            // 
            PasswordLbl.AutoSize = true;
            PasswordLbl.ForeColor = Color.FromArgb(170, 170, 180);
            PasswordLbl.Location = new Point(30, 222);
            PasswordLbl.Name = "PasswordLbl";
            PasswordLbl.Size = new Size(80, 23);
            PasswordLbl.TabIndex = 5;
            PasswordLbl.Text = "Password";
            // 
            // UsernameField
            // 
            UsernameField.BackColor = Color.FromArgb(50, 50, 58);
            UsernameField.BorderStyle = BorderStyle.FixedSingle;
            UsernameField.ForeColor = Color.White;
            UsernameField.Location = new Point(30, 185);
            UsernameField.Name = "UsernameField";
            UsernameField.Size = new Size(300, 30);
            UsernameField.TabIndex = 4;
            // 
            // PasswordField
            // 
            PasswordField.BackColor = Color.FromArgb(50, 50, 58);
            PasswordField.BorderStyle = BorderStyle.FixedSingle;
            PasswordField.ForeColor = Color.White;
            PasswordField.Location = new Point(30, 249);
            PasswordField.Name = "PasswordField";
            PasswordField.Size = new Size(300, 30);
            PasswordField.TabIndex = 6;
            PasswordField.UseSystemPasswordChar = true;
            // 
            // LogInButton
            // 
            LogInButton.BackColor = Color.FromArgb(58, 130, 246);
            LogInButton.Cursor = Cursors.Hand;
            LogInButton.FlatAppearance.BorderSize = 0;
            LogInButton.FlatStyle = FlatStyle.Flat;
            LogInButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            LogInButton.ForeColor = Color.White;
            LogInButton.Location = new Point(30, 299);
            LogInButton.Name = "LogInButton";
            LogInButton.Size = new Size(300, 36);
            LogInButton.TabIndex = 7;
            LogInButton.Text = "Sign In";
            LogInButton.UseVisualStyleBackColor = false;
            LogInButton.Click += LogInButton_Click;
            // 
            // NoAccountLbl
            // 
            NoAccountLbl.AutoSize = true;
            NoAccountLbl.ForeColor = Color.FromArgb(140, 140, 150);
            NoAccountLbl.Location = new Point(65, 353);
            NoAccountLbl.Name = "NoAccountLbl";
            NoAccountLbl.Size = new Size(107, 23);
            NoAccountLbl.TabIndex = 8;
            NoAccountLbl.Text = "No account?";
            // 
            // RegisterLink
            // 
            RegisterLink.ActiveLinkColor = Color.White;
            RegisterLink.AutoSize = true;
            RegisterLink.LinkColor = Color.FromArgb(100, 170, 255);
            RegisterLink.Location = new Point(183, 353);
            RegisterLink.Name = "RegisterLink";
            RegisterLink.Size = new Size(112, 23);
            RegisterLink.TabIndex = 9;
            RegisterLink.TabStop = true;
            RegisterLink.Text = "Register Here";
            RegisterLink.VisitedLinkColor = Color.FromArgb(100, 170, 255);
            RegisterLink.Click += RegisterLink_Click;
            // 
            // CardPanel
            // 
            CardPanel.BackColor = Color.FromArgb(36, 36, 42);
            CardPanel.Controls.Add(LockIconLbl);
            CardPanel.Controls.Add(TitleLbl);
            CardPanel.Controls.Add(SubtitleLbl);
            CardPanel.Controls.Add(UsernameLbl);
            CardPanel.Controls.Add(UsernameField);
            CardPanel.Controls.Add(PasswordLbl);
            CardPanel.Controls.Add(PasswordField);
            CardPanel.Controls.Add(LogInButton);
            CardPanel.Controls.Add(NoAccountLbl);
            CardPanel.Controls.Add(RegisterLink);
            CardPanel.Location = new Point(30, 40);
            CardPanel.Name = "CardPanel";
            CardPanel.Size = new Size(360, 400);
            CardPanel.TabIndex = 0;
            // 
            // LogInForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(36, 36, 42);
            ClientSize = new Size(420, 490);
            Controls.Add(CardPanel);
            Font = new Font("Segoe UI", 10F);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "LogInForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lock In — Sign In";
            Load += LogInForm_Load;
            CardPanel.ResumeLayout(false);
            CardPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel CardPanel;
        private Label LockIconLbl;
        private Label TitleLbl;
        private Label SubtitleLbl;
        private Label UsernameLbl;
        private Label PasswordLbl;
        private TextBox UsernameField;
        private TextBox PasswordField;
        private Button LogInButton;
        private Label NoAccountLbl;
        private LinkLabel RegisterLink;
    }
}
