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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAccForm));
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
            ShowTgl = new Button();
            PassStrengthlbl = new Label();
            ServiceField = new TextBox();
            ServiceLbl = new Label();
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
            UsernameLbl.Location = new Point(24, 147);
            UsernameLbl.Name = "UsernameLbl";
            UsernameLbl.Size = new Size(87, 23);
            UsernameLbl.TabIndex = 5;
            UsernameLbl.Text = "Username";
            // 
            // PasswordLbl
            // 
            PasswordLbl.AutoSize = true;
            PasswordLbl.ForeColor = Color.FromArgb(180, 180, 185);
            PasswordLbl.Location = new Point(24, 184);
            PasswordLbl.Name = "PasswordLbl";
            PasswordLbl.Size = new Size(80, 23);
            PasswordLbl.TabIndex = 7;
            PasswordLbl.Text = "Password";
            // 
            // AutoGenLbl
            // 
            AutoGenLbl.AutoSize = true;
            AutoGenLbl.ForeColor = Color.FromArgb(180, 180, 185);
            AutoGenLbl.Location = new Point(15, 271);
            AutoGenLbl.Name = "AutoGenLbl";
            AutoGenLbl.Size = new Size(122, 23);
            AutoGenLbl.TabIndex = 10;
            AutoGenLbl.Text = "Auto-generate";
            // 
            // AccTypeCmBx
            // 
            AccTypeCmBx.BackColor = Color.FromArgb(50, 50, 55);
            AccTypeCmBx.DrawMode = DrawMode.OwnerDrawFixed;
            AccTypeCmBx.DropDownStyle = ComboBoxStyle.DropDownList;
            AccTypeCmBx.FlatStyle = FlatStyle.Flat;
            AccTypeCmBx.ForeColor = Color.White;
            AccTypeCmBx.Items.AddRange(new object[] { "Personal", "School", "Work" });
            AccTypeCmBx.Location = new Point(150, 73);
            AccTypeCmBx.Name = "AccTypeCmBx";
            AccTypeCmBx.Size = new Size(242, 31);
            AccTypeCmBx.TabIndex = 7;
            AccTypeCmBx.DrawItem += AccTypeCmBx_DrawItem;
            AccTypeCmBx.SelectedIndexChanged += AccTypeCmBx_SelectedIndexChanged;
            // 
            // UsernameField
            // 
            UsernameField.BackColor = Color.FromArgb(50, 50, 55);
            UsernameField.BorderStyle = BorderStyle.FixedSingle;
            UsernameField.ForeColor = Color.White;
            UsernameField.Location = new Point(150, 145);
            UsernameField.Name = "UsernameField";
            UsernameField.Size = new Size(242, 30);
            UsernameField.TabIndex = 8;
            UsernameField.TextChanged += UsernameField_TextChanged;
            // 
            // PasswordField
            // 
            PasswordField.BackColor = Color.FromArgb(50, 50, 55);
            PasswordField.BorderStyle = BorderStyle.FixedSingle;
            PasswordField.ForeColor = Color.White;
            PasswordField.Location = new Point(150, 182);
            PasswordField.Name = "PasswordField";
            PasswordField.Size = new Size(242, 30);
            PasswordField.TabIndex = 9;
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
            AutoGenBtn.Location = new Point(150, 263);
            AutoGenBtn.Name = "AutoGenBtn";
            AutoGenBtn.Size = new Size(242, 38);
            AutoGenBtn.TabIndex = 11;
            AutoGenBtn.Text = "Generate Strong Password";
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
            ConfirmBtn.Location = new Point(333, 330);
            ConfirmBtn.Name = "ConfirmBtn";
            ConfirmBtn.Size = new Size(95, 34);
            ConfirmBtn.TabIndex = 13;
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
            CancelBtn.Location = new Point(232, 330);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(95, 34);
            CancelBtn.TabIndex = 12;
            CancelBtn.Text = "✕  Cancel";
            CancelBtn.UseVisualStyleBackColor = false;
            CancelBtn.Click += CancelBtn_Click;
            // 
            // MainPanel
            // 
            MainPanel.BackColor = Color.FromArgb(36, 36, 40);
            MainPanel.Controls.Add(ShowTgl);
            MainPanel.Controls.Add(PassStrengthlbl);
            MainPanel.Controls.Add(ServiceField);
            MainPanel.Controls.Add(ServiceLbl);
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
            MainPanel.Size = new Size(440, 390);
            MainPanel.TabIndex = 0;
            // 
            // ShowTgl
            // 
            ShowTgl.ForeColor = Color.Black;
            ShowTgl.Image = Properties.Resources.eye_closed;
            ShowTgl.Location = new Point(398, 184);
            ShowTgl.Name = "ShowTgl";
            ShowTgl.Size = new Size(39, 28);
            ShowTgl.TabIndex = 15;
            ShowTgl.UseVisualStyleBackColor = true;
            ShowTgl.Click += ShowTgl_Click;
            // 
            // PassStrengthlbl
            // 
            PassStrengthlbl.AutoSize = true;
            PassStrengthlbl.Location = new Point(201, 226);
            PassStrengthlbl.Name = "PassStrengthlbl";
            PassStrengthlbl.Size = new Size(150, 23);
            PassStrengthlbl.TabIndex = 14;
            PassStrengthlbl.Text = "Password Strength";
            PassStrengthlbl.Click += label1_Click_1;
            // 
            // ServiceField
            // 
            ServiceField.BackColor = Color.FromArgb(50, 50, 55);
            ServiceField.BorderStyle = BorderStyle.FixedSingle;
            ServiceField.ForeColor = Color.White;
            ServiceField.Location = new Point(150, 108);
            ServiceField.Name = "ServiceField";
            ServiceField.Size = new Size(242, 30);
            ServiceField.TabIndex = 6;
            ServiceField.TextChanged += ServiceField_TextChanged;
            // 
            // ServiceLbl
            // 
            ServiceLbl.AutoSize = true;
            ServiceLbl.ForeColor = Color.FromArgb(180, 180, 185);
            ServiceLbl.Location = new Point(27, 110);
            ServiceLbl.Name = "ServiceLbl";
            ServiceLbl.Size = new Size(63, 23);
            ServiceLbl.TabIndex = 3;
            ServiceLbl.Text = "Service";
            ServiceLbl.Click += label1_Click;
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
            ClientSize = new Size(480, 440);
            Controls.Add(MainPanel);
            Font = new Font("Segoe UI", 10F);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "AddAccForm";
            Padding = new Padding(20);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lock In — Add Account";
            Load += AddAccForm_Load;
            MainPanel.ResumeLayout(false);
            MainPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        internal Label TitleLbl;
        private Panel MainPanel;
        private Panel SeparatorPanel;
        private Label AccTypeLbl;
        internal Label ServiceLbl;
        internal Label UsernameLbl;
        private Label PasswordLbl;
        private Label AutoGenLbl;
        internal ComboBox AccTypeCmBx;
        internal TextBox ServiceField;
        internal TextBox UsernameField;
        internal TextBox PasswordField;
        private Button AutoGenBtn;
        private Button ConfirmBtn;
        private Button CancelBtn;
        private Label PassStrengthlbl;
        private Button ShowTgl;
    }
}
