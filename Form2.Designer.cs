namespace LockIn
{
    partial class AddAccForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            AccTypeLbl = new Label();
            UsernameLbl = new Label();
            PasswordLbl = new Label();
            UsernameField = new TextBox();
            PasswordField = new TextBox();
            AccTypeCmBx = new ComboBox();
            ConfirmBtn = new Button();
            CancelBtn = new Button();
            SuspendLayout();
            // 
            // AccTypeLbl
            // 
            AccTypeLbl.AutoSize = true;
            AccTypeLbl.Location = new Point(12, 21);
            AccTypeLbl.Name = "AccTypeLbl";
            AccTypeLbl.Size = new Size(98, 20);
            AccTypeLbl.TabIndex = 0;
            AccTypeLbl.Text = "Account Type";
            AccTypeLbl.Click += label1_Click;
            // 
            // UsernameLbl
            // 
            UsernameLbl.AutoSize = true;
            UsernameLbl.Location = new Point(17, 57);
            UsernameLbl.Name = "UsernameLbl";
            UsernameLbl.Size = new Size(75, 20);
            UsernameLbl.TabIndex = 1;
            UsernameLbl.Text = "Username";
            // 
            // PasswordLbl
            // 
            PasswordLbl.AutoSize = true;
            PasswordLbl.Location = new Point(17, 100);
            PasswordLbl.Name = "PasswordLbl";
            PasswordLbl.Size = new Size(70, 20);
            PasswordLbl.TabIndex = 2;
            PasswordLbl.Text = "Password";
            // 
            // UsernameField
            // 
            UsernameField.Location = new Point(124, 54);
            UsernameField.Name = "UsernameField";
            UsernameField.Size = new Size(157, 27);
            UsernameField.TabIndex = 3;
            UsernameField.TextChanged += UsernameField_TextChanged;
            // 
            // PasswordField
            // 
            PasswordField.Location = new Point(124, 97);
            PasswordField.Name = "PasswordField";
            PasswordField.Size = new Size(157, 27);
            PasswordField.TabIndex = 4;
            PasswordField.TextChanged += textBox1_TextChanged;
            // 
            // AccTypeCmBx
            // 
            AccTypeCmBx.FormattingEnabled = true;
            AccTypeCmBx.Location = new Point(124, 18);
            AccTypeCmBx.Name = "AccTypeCmBx";
            AccTypeCmBx.Size = new Size(157, 28);
            AccTypeCmBx.TabIndex = 5;
            // 
            // ConfirmBtn
            // 
            ConfirmBtn.Location = new Point(281, 138);
            ConfirmBtn.Name = "ConfirmBtn";
            ConfirmBtn.Size = new Size(94, 29);
            ConfirmBtn.TabIndex = 6;
            ConfirmBtn.Text = "Confirm";
            ConfirmBtn.UseVisualStyleBackColor = true;
            ConfirmBtn.Click += ConfirmBtn_Click;
            // 
            // CancelBtn
            // 
            CancelBtn.Location = new Point(181, 138);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(94, 29);
            CancelBtn.TabIndex = 7;
            CancelBtn.Text = "Cancel";
            CancelBtn.UseVisualStyleBackColor = true;
            CancelBtn.Click += button1_Click;
            // 
            // AddAccForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(387, 179);
            Controls.Add(CancelBtn);
            Controls.Add(ConfirmBtn);
            Controls.Add(AccTypeCmBx);
            Controls.Add(PasswordField);
            Controls.Add(UsernameField);
            Controls.Add(PasswordLbl);
            Controls.Add(UsernameLbl);
            Controls.Add(AccTypeLbl);
            Name = "AddAccForm";
            Text = "Add Account";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label AccTypeLbl;
        private Label UsernameLbl;
        private Label PasswordLbl;
        private TextBox UsernameField;
        private TextBox PasswordField;
        private ComboBox AccTypeCmBx;
        private Button ConfirmBtn;
        private Button CancelBtn;
    }
}