namespace LockIn
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            LockIconLbl = new Label();
            TitleLbl = new Label();
            SubtitleLbl = new Label();
            UsernameLbl = new Label();
            PasswordLbl = new Label();
            ConfirmPasswordLbl = new Label();
            UsernameField = new TextBox();
            PasswordField = new TextBox();
            ConfirmPasswordField = new TextBox();
            CreateAccBtn = new Button();
            AlreadyHaveLbl = new Label();
            SignInLink = new LinkLabel();
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
            TitleLbl.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            TitleLbl.ForeColor = Color.White;
            TitleLbl.Location = new Point(3, 76);
            TitleLbl.Name = "TitleLbl";
            TitleLbl.Size = new Size(354, 34);
            TitleLbl.TabIndex = 1;
            TitleLbl.Text = "Create Account";
            TitleLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SubtitleLbl
            // 
            SubtitleLbl.Font = new Font("Segoe UI", 9F);
            SubtitleLbl.ForeColor = Color.FromArgb(156, 163, 175);
            SubtitleLbl.Location = new Point(3, 110);
            SubtitleLbl.Name = "SubtitleLbl";
            SubtitleLbl.Size = new Size(354, 25);
            SubtitleLbl.TabIndex = 2;
            SubtitleLbl.Text = "Secure your credentials with Lock In";
            SubtitleLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UsernameLbl
            // 
            UsernameLbl.AutoSize = true;
            UsernameLbl.ForeColor = Color.FromArgb(156, 163, 175);
            UsernameLbl.Location = new Point(30, 148);
            UsernameLbl.Name = "UsernameLbl";
            UsernameLbl.Size = new Size(87, 23);
            UsernameLbl.TabIndex = 3;
            UsernameLbl.Text = "Username";
            // 
            // PasswordLbl
            // 
            PasswordLbl.AutoSize = true;
            PasswordLbl.ForeColor = Color.FromArgb(156, 163, 175);
            PasswordLbl.Location = new Point(30, 214);
            PasswordLbl.Name = "PasswordLbl";
            PasswordLbl.Size = new Size(80, 23);
            PasswordLbl.TabIndex = 5;
            PasswordLbl.Text = "Password";
            // 
            // ConfirmPasswordLbl
            // 
            ConfirmPasswordLbl.AutoSize = true;
            ConfirmPasswordLbl.ForeColor = Color.FromArgb(156, 163, 175);
            ConfirmPasswordLbl.Location = new Point(30, 280);
            ConfirmPasswordLbl.Name = "ConfirmPasswordLbl";
            ConfirmPasswordLbl.Size = new Size(146, 23);
            ConfirmPasswordLbl.TabIndex = 7;
            ConfirmPasswordLbl.Text = "Confirm Password";
            // 
            // UsernameField
            // 
            UsernameField.BackColor = Color.FromArgb(50, 50, 58);
            UsernameField.BorderStyle = BorderStyle.FixedSingle;
            UsernameField.ForeColor = Color.White;
            UsernameField.Location = new Point(30, 175);
            UsernameField.Name = "UsernameField";
            UsernameField.Size = new Size(300, 30);
            UsernameField.TabIndex = 4;
            UsernameField.TextChanged += UsernameField_TextChanged;
            // 
            // PasswordField
            // 
            PasswordField.BackColor = Color.FromArgb(50, 50, 58);
            PasswordField.BorderStyle = BorderStyle.FixedSingle;
            PasswordField.ForeColor = Color.White;
            PasswordField.Location = new Point(30, 241);
            PasswordField.Name = "PasswordField";
            PasswordField.Size = new Size(300, 30);
            PasswordField.TabIndex = 6;
            PasswordField.UseSystemPasswordChar = true;
            // 
            // ConfirmPasswordField
            // 
            ConfirmPasswordField.BackColor = Color.FromArgb(50, 50, 58);
            ConfirmPasswordField.BorderStyle = BorderStyle.FixedSingle;
            ConfirmPasswordField.ForeColor = Color.White;
            ConfirmPasswordField.Location = new Point(30, 307);
            ConfirmPasswordField.Name = "ConfirmPasswordField";
            ConfirmPasswordField.Size = new Size(300, 30);
            ConfirmPasswordField.TabIndex = 8;
            ConfirmPasswordField.UseSystemPasswordChar = true;
            // 
            // CreateAccBtn
            // 
            CreateAccBtn.BackColor = Color.FromArgb(58, 130, 246);
            CreateAccBtn.Cursor = Cursors.Hand;
            CreateAccBtn.FlatAppearance.BorderSize = 0;
            CreateAccBtn.FlatStyle = FlatStyle.Flat;
            CreateAccBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            CreateAccBtn.ForeColor = Color.White;
            CreateAccBtn.Location = new Point(30, 357);
            CreateAccBtn.Name = "CreateAccBtn";
            CreateAccBtn.Size = new Size(300, 36);
            CreateAccBtn.TabIndex = 9;
            CreateAccBtn.Text = "Create Account";
            CreateAccBtn.UseVisualStyleBackColor = false;
            CreateAccBtn.Click += CreateAccBtn_Click;
            // 
            // AlreadyHaveLbl
            // 
            AlreadyHaveLbl.AutoSize = true;
            AlreadyHaveLbl.ForeColor = Color.FromArgb(156, 163, 175);
            AlreadyHaveLbl.Location = new Point(40, 409);
            AlreadyHaveLbl.Name = "AlreadyHaveLbl";
            AlreadyHaveLbl.Size = new Size(206, 23);
            AlreadyHaveLbl.TabIndex = 10;
            AlreadyHaveLbl.Text = "Already have an account?";
            // 
            // SignInLink
            // 
            SignInLink.ActiveLinkColor = Color.White;
            SignInLink.AutoSize = true;
            SignInLink.LinkColor = Color.FromArgb(96, 165, 250);
            SignInLink.Location = new Point(255, 409);
            SignInLink.Name = "SignInLink";
            SignInLink.Size = new Size(63, 23);
            SignInLink.TabIndex = 11;
            SignInLink.TabStop = true;
            SignInLink.Text = "Sign In";
            SignInLink.VisitedLinkColor = Color.FromArgb(96, 165, 250);
            SignInLink.LinkClicked += SignInLink_LinkClicked;
            SignInLink.Click += SignInLink_Click;
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
            CardPanel.Controls.Add(ConfirmPasswordLbl);
            CardPanel.Controls.Add(ConfirmPasswordField);
            CardPanel.Controls.Add(CreateAccBtn);
            CardPanel.Controls.Add(AlreadyHaveLbl);
            CardPanel.Controls.Add(SignInLink);
            CardPanel.Location = new Point(30, 40);
            CardPanel.Name = "CardPanel";
            CardPanel.Size = new Size(360, 445);
            CardPanel.TabIndex = 0;
            CardPanel.Paint += CardPanel_Paint;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(36, 36, 42);
            ClientSize = new Size(420, 530);
            Controls.Add(CardPanel);
            Font = new Font("Segoe UI", 10F);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lock In — Register";
            Load += RegisterForm_Load;
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
        private Label ConfirmPasswordLbl;
        private TextBox UsernameField;
        private TextBox PasswordField;
        private TextBox ConfirmPasswordField;
        private Button CreateAccBtn;
        private Label AlreadyHaveLbl;
        private LinkLabel SignInLink;
    }
}
