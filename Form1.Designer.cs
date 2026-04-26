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
            EditBtn = new Button();
            button1 = new Button();
            AddButton = new Button();
            dataGridView1 = new DataGridView();
            NavBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            // EditBtn
            // 
            EditBtn.Location = new Point(75, 8);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(64, 29);
            EditBtn.TabIndex = 2;
            EditBtn.Text = "Edit";
            EditBtn.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(145, 8);
            button1.Name = "button1";
            button1.Size = new Size(64, 29);
            button1.TabIndex = 1;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = true;
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
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 67);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(892, 506);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(916, 585);
            Controls.Add(dataGridView1);
            Controls.Add(NavBar);
            Name = "Dashboard";
            Text = "Lock In - Dashboard";
            NavBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox NavBar;
        private Button AddButton;
        private Button button1;
        private Button EditBtn;
        private DataGridView dataGridView1;
    }
}
