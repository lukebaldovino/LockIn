namespace LockIn
{
    partial class Dashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            NavBar = new GroupBox();
            AddButton = new Button();
            AccountLists = new ListView();
            button1 = new Button();
            EditBtn = new Button();
            NavBar.SuspendLayout();
            SuspendLayout();
            // 
            // NavBar
            // 
            NavBar.BackColor = Color.MidnightBlue;
            NavBar.Controls.Add(EditBtn);
            NavBar.Controls.Add(button1);
            NavBar.Controls.Add(AddButton);
            NavBar.Location = new Point(0, 0);
            NavBar.Name = "NavBar";
            NavBar.Size = new Size(919, 43);
            NavBar.TabIndex = 0;
            NavBar.TabStop = false;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(12, 8);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(57, 29);
            AddButton.TabIndex = 0;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // AccountLists
            // 
            AccountLists.Location = new Point(29, 71);
            AccountLists.Name = "AccountLists";
            AccountLists.Size = new Size(875, 484);
            AccountLists.TabIndex = 1;
            AccountLists.UseCompatibleStateImageBehavior = false;
            AccountLists.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(149, 8);
            button1.Name = "button1";
            button1.Size = new Size(64, 29);
            button1.TabIndex = 1;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = true;
            // 
            // EditBtn
            // 
            EditBtn.Location = new Point(75, 8);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(64, 29);
            EditBtn.TabIndex = 2;
            EditBtn.Text = "Edit";
            EditBtn.UseVisualStyleBackColor = true;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(916, 585);
            Controls.Add(AccountLists);
            Controls.Add(NavBar);
            Name = "Dashboard";
            Text = "Lock In - Dashboard";
            NavBar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox NavBar;
        private Button AddButton;
        private ListView AccountLists;
        private Button button1;
        private Button EditBtn;
    }
}
