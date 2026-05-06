namespace LockIn
{
    partial class AddAccForm
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
            TitleLbl = new Label();
            AccTypeLbl = new Label();
            UsernameLbl = new Label();
            PasswordLbl = new Label();
            AutoGenLbl = new Label();
            AccTypeCmBx = new ComboBox();
            UsernameField = new TextBox();
            PasswordField = new TextBox();
            AutoGenBtn = new Button();
            ConfirmBtn = new Button();
            CancelBtn = new Button();
            MainPanel = new Panel();
            ServicetxtBx = new TextBox();
            Sevicelbl = new Label();
            SeparatorPanel = new Panel();
            MainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // TitleLbl
            // 
            TitleLbl.AutoSize = true;
            TitleLbl.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            TitleLbl.ForeColor = Color.White;
            TitleLbl.Location = new Point(24, 20);
            TitleLbl.Name = "TitleLbl";
            TitleLbl.Size = new Size(200, 30);
            TitleLbl.TabIndex = 0;
            TitleLbl.Text = "Add New Account";
            // 
            // AccTypeLbl
            // 
            AccTypeLbl.AutoSize = true;
            AccTypeLbl.ForeColor = Color.FromArgb(180, 180, 185);
            AccTypeLbl.Location = new Point(24, 73);
            AccTypeLbl.Name = "AccTypeLbl";
            AccTypeLbl.Size = new Size(113, 23);
            AccTypeLbl.TabIndex = 2;
            AccTypeLbl.Text = "Account Type";
            // 
            // UsernameLbl
            // 
            UsernameLbl.AutoSize = true;
            UsernameLbl.ForeColor = Color.FromArgb(180, 180, 185);
            UsernameLbl.Location = new Point(24, 153);
            UsernameLbl.Name = "UsernameLbl";
            UsernameLbl.Size = new Size(87, 23);
            UsernameLbl.TabIndex = 4;
            UsernameLbl.Text = "Username";
            // 
            // PasswordLbl
            // 
            PasswordLbl.AutoSize = true;
            PasswordLbl.ForeColor = Color.FromArgb(180, 180, 185);
            PasswordLbl.Location = new Point(24, 187);
            PasswordLbl.Name = "PasswordLbl";
            PasswordLbl.Size = new Size(80, 23);
            PasswordLbl.TabIndex = 6;
            PasswordLbl.Text = "Password";
            // 
            // AutoGenLbl
            // 
            AutoGenLbl.AutoSize = true;
            AutoGenLbl.Font = new Font("Segoe UI", 9F);
            AutoGenLbl.ForeColor = Color.FromArgb(180, 180, 185);
            AutoGenLbl.Location = new Point(15, 227);
            AutoGenLbl.Name = "AutoGenLbl";
            AutoGenLbl.Size = new Size(106, 20);
            AutoGenLbl.TabIndex = 8;
            AutoGenLbl.Text = "Auto-generate";
            // 
            // AccTypeCmBx
            // 
            AccTypeCmBx.BackColor = Color.FromArgb(50, 50, 55);
            AccTypeCmBx.DropDownStyle = ComboBoxStyle.DropDownList;
            AccTypeCmBx.FlatStyle = FlatStyle.Flat;
            AccTypeCmBx.ForeColor = Color.White;
            AccTypeCmBx.Items.AddRange(new object[] { "Personal", "Work", "Finance", "Social", "Other" });
            AccTypeCmBx.Location = new Point(129, 73);
            AccTypeCmBx.Name = "AccTypeCmBx";
            AccTypeCmBx.Size = new Size(266, 31);
            AccTypeCmBx.TabIndex = 3;
            AccTypeCmBx.SelectedIndexChanged += AccTypeCmBx_SelectedIndexChanged;
            // 
            // UsernameField
            // 
            UsernameField.BackColor = Color.FromArgb(50, 50, 55);
            UsernameField.BorderStyle = BorderStyle.FixedSingle;
            UsernameField.ForeColor = Color.White;
            UsernameField.Location = new Point(129, 151);
            UsernameField.Name = "UsernameField";
            UsernameField.Size = new Size(266, 30);
            UsernameField.TabIndex = 5;
            UsernameField.TextChanged += UsernameField_TextChanged;
            // 
            // PasswordField
            // 
            PasswordField.BackColor = Color.FromArgb(50, 50, 55);
            PasswordField.BorderStyle = BorderStyle.FixedSingle;
            PasswordField.ForeColor = Color.White;
            PasswordField.Location = new Point(129, 187);
            PasswordField.Name = "PasswordField";
            PasswordField.Size = new Size(266, 30);
            PasswordField.TabIndex = 7;
            PasswordField.UseSystemPasswordChar = true;
            PasswordField.TextChanged += PasswordField_TextChanged;
            // 
            // AutoGenBtn
            // 
            AutoGenBtn.BackColor = Color.FromArgb(55, 55, 60);
            AutoGenBtn.Cursor = Cursors.Hand;
            AutoGenBtn.FlatAppearance.BorderColor = Color.FromArgb(80, 80, 85);
            AutoGenBtn.FlatStyle = FlatStyle.Flat;
            AutoGenBtn.ForeColor = Color.FromArgb(220, 220, 220);
            AutoGenBtn.Location = new Point(129, 223);
            AutoGenBtn.Name = "AutoGenBtn";
            AutoGenBtn.Size = new Size(266, 30);
            AutoGenBtn.TabIndex = 9;
            AutoGenBtn.Text = "⚡ Generate Strong Password";
            AutoGenBtn.UseVisualStyleBackColor = false;
            AutoGenBtn.Click += AutoGenBtn_Click;
            // 
            // ConfirmBtn
            // 
            ConfirmBtn.BackColor = Color.FromArgb(40, 167, 90);
            ConfirmBtn.Cursor = Cursors.Hand;
            ConfirmBtn.FlatAppearance.BorderSize = 0;
            ConfirmBtn.FlatStyle = FlatStyle.Flat;
            ConfirmBtn.ForeColor = Color.White;
            ConfirmBtn.Location = new Point(333, 293);
            ConfirmBtn.Name = "ConfirmBtn";
            ConfirmBtn.Size = new Size(95, 34);
            ConfirmBtn.TabIndex = 11;
            ConfirmBtn.Text = "✔  Confirm";
            ConfirmBtn.UseVisualStyleBackColor = false;
            ConfirmBtn.Click += ConfirmBtn_Click;
            // 
            // CancelBtn
            // 
            CancelBtn.BackColor = Color.FromArgb(55, 55, 60);
            CancelBtn.Cursor = Cursors.Hand;
            CancelBtn.FlatAppearance.BorderColor = Color.FromArgb(80, 80, 85);
            CancelBtn.FlatStyle = FlatStyle.Flat;
            CancelBtn.ForeColor = Color.FromArgb(200, 200, 205);
            CancelBtn.Location = new Point(232, 293);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(95, 34);
            CancelBtn.TabIndex = 10;
            CancelBtn.Text = "✕  Cancel";
            CancelBtn.UseVisualStyleBackColor = false;
            CancelBtn.Click += CancelBtn_Click;
            // 
            // MainPanel
            // 
            MainPanel.BackColor = Color.FromArgb(36, 36, 40);
            MainPanel.Controls.Add(ServicetxtBx);
            MainPanel.Controls.Add(Sevicelbl);
            MainPanel.Controls.Add(TitleLbl);
            MainPanel.Controls.Add(SeparatorPanel);
            MainPanel.Controls.Add(AccTypeLbl);
            MainPanel.Controls.Add(AccTypeCmBx);
            MainPanel.Controls.Add(UsernameLbl);
            MainPanel.Controls.Add(UsernameField);
            MainPanel.Controls.Add(PasswordLbl);
            MainPanel.Controls.Add(PasswordField);
            MainPanel.Controls.Add(AutoGenLbl);
            MainPanel.Controls.Add(AutoGenBtn);
            MainPanel.Controls.Add(CancelBtn);
            MainPanel.Controls.Add(ConfirmBtn);
            MainPanel.Location = new Point(20, 20);
            MainPanel.Name = "MainPanel";
            MainPanel.Padding = new Padding(24);
            MainPanel.Size = new Size(440, 340);
            MainPanel.TabIndex = 0;
            // 
            // ServicetxtBx
            // 
            ServicetxtBx.BackColor = Color.FromArgb(50, 50, 55);
            ServicetxtBx.BorderStyle = BorderStyle.FixedSingle;
            ServicetxtBx.ForeColor = Color.White;
            ServicetxtBx.Location = new Point(129, 114);
            ServicetxtBx.Name = "ServicetxtBx";
            ServicetxtBx.Size = new Size(266, 30);
            ServicetxtBx.TabIndex = 13;
            ServicetxtBx.TextChanged += ServicetxtBx_TextChanged;
            // 
            // Sevicelbl
            // 
            Sevicelbl.AutoSize = true;
            Sevicelbl.ForeColor = Color.FromArgb(180, 180, 185);
            Sevicelbl.Location = new Point(27, 116);
            Sevicelbl.Name = "Sevicelbl";
            Sevicelbl.Size = new Size(63, 23);
            Sevicelbl.TabIndex = 12;
            Sevicelbl.Text = "Service";
            Sevicelbl.Click += label1_Click;
            // 
            // SeparatorPanel
            // 
            SeparatorPanel.BackColor = Color.FromArgb(60, 60, 65);
            SeparatorPanel.Location = new Point(24, 52);
            SeparatorPanel.Name = "SeparatorPanel";
            SeparatorPanel.Size = new Size(392, 1);
            SeparatorPanel.TabIndex = 1;
            // 
            // AddAccForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 28, 30);
            ClientSize = new Size(480, 380);
            Controls.Add(MainPanel);
            Font = new Font("Segoe UI", 10F);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AddAccForm";
            Padding = new Padding(20);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lock In — Add Account";
            MainPanel.ResumeLayout(false);
            MainPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label TitleLbl;
        private Panel MainPanel;
        private Panel SeparatorPanel;
        private Label AccTypeLbl;
        private Label UsernameLbl;
        private Label PasswordLbl;
        private Label AutoGenLbl;
        private ComboBox AccTypeCmBx;
        private TextBox UsernameField;
        private TextBox PasswordField;
        private Button AutoGenBtn;
        private Button ConfirmBtn;
        private Button CancelBtn;
        private Label Sevicelbl;
        private TextBox ServicetxtBx;
    }
}