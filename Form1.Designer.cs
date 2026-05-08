namespace LockIn
{
    partial class Dashboard
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            NavBar = new Panel();
            BrandPanel = new Panel();
            LockIconLabel = new Label();
            BrandLabel = new Label();
            ActionPanel = new Panel();
            NgtMdTglBtn = new Button();
            DeleteBtn = new Button();
            AddButton = new Button();
            EditBtn = new Button();
            SearchPanel = new Panel();
            SearchIconLabel = new Label();
            SearchBox = new TextBox();
            dataGridView1 = new DataGridView();
            StatusPanel = new Panel();
            StatusDot = new Label();
            StatusLabel = new Label();
            NavBar.SuspendLayout();
            BrandPanel.SuspendLayout();
            ActionPanel.SuspendLayout();
            SearchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            StatusPanel.SuspendLayout();
            SuspendLayout();
            // 
            // NavBar
            // 
            NavBar.BackColor = Color.FromArgb(22, 25, 33);
            NavBar.Controls.Add(BrandPanel);
            NavBar.Controls.Add(ActionPanel);
            NavBar.Dock = DockStyle.Top;
            NavBar.Location = new Point(0, 0);
            NavBar.Name = "NavBar";
            NavBar.Padding = new Padding(16, 0, 16, 0);
            NavBar.Size = new Size(960, 52);
            NavBar.TabIndex = 3;
            // 
            // BrandPanel
            // 
            BrandPanel.BackColor = Color.Transparent;
            BrandPanel.Controls.Add(LockIconLabel);
            BrandPanel.Controls.Add(BrandLabel);
            BrandPanel.Dock = DockStyle.Left;
            BrandPanel.Location = new Point(16, 0);
            BrandPanel.Name = "BrandPanel";
            BrandPanel.Size = new Size(141, 52);
            BrandPanel.TabIndex = 0;
            // 
            // LockIconLabel
            // 
            LockIconLabel.AutoSize = true;
            LockIconLabel.Font = new Font("Segoe UI Emoji", 16F);
            LockIconLabel.ForeColor = Color.FromArgb(226, 232, 240);
            LockIconLabel.Location = new Point(0, 7);
            LockIconLabel.Name = "LockIconLabel";
            LockIconLabel.Size = new Size(52, 36);
            LockIconLabel.TabIndex = 0;
            LockIconLabel.Text = "🔒";
            // 
            // BrandLabel
            // 
            BrandLabel.AutoSize = true;
            BrandLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            BrandLabel.ForeColor = Color.FromArgb(226, 232, 240);
            BrandLabel.Location = new Point(45, 11);
            BrandLabel.Name = "BrandLabel";
            BrandLabel.Size = new Size(96, 32);
            BrandLabel.TabIndex = 1;
            BrandLabel.Text = "Lock In";
            BrandLabel.Click += BrandLabel_Click;
            // 
            // ActionPanel
            // 
            ActionPanel.BackColor = Color.Transparent;
            ActionPanel.Controls.Add(NgtMdTglBtn);
            ActionPanel.Controls.Add(DeleteBtn);
            ActionPanel.Controls.Add(AddButton);
            ActionPanel.Controls.Add(EditBtn);
            ActionPanel.Dock = DockStyle.Right;
            ActionPanel.ForeColor = Color.Transparent;
            ActionPanel.Location = new Point(573, 0);
            ActionPanel.Name = "ActionPanel";
            ActionPanel.Size = new Size(371, 52);
            ActionPanel.TabIndex = 1;
            // 
            // NgtMdTglBtn
            // 
            NgtMdTglBtn.BackColor = Color.FromArgb(45, 50, 65);
            NgtMdTglBtn.Cursor = Cursors.Hand;
            NgtMdTglBtn.FlatAppearance.BorderSize = 0;
            NgtMdTglBtn.FlatStyle = FlatStyle.Flat;
            NgtMdTglBtn.Font = new Font("Consolas", 9F, FontStyle.Bold);
            NgtMdTglBtn.ForeColor = Color.FromArgb(226, 232, 240);
            NgtMdTglBtn.Location = new Point(304, 11);
            NgtMdTglBtn.Name = "NgtMdTglBtn";
            NgtMdTglBtn.Size = new Size(59, 31);
            NgtMdTglBtn.TabIndex = 3;
            NgtMdTglBtn.Text = "Day";
            NgtMdTglBtn.UseVisualStyleBackColor = false;
            NgtMdTglBtn.Click += NgtMdTglBtn_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = Color.FromArgb(220, 38, 38);
            DeleteBtn.Cursor = Cursors.Hand;
            DeleteBtn.FlatAppearance.BorderSize = 0;
            DeleteBtn.FlatStyle = FlatStyle.Flat;
            DeleteBtn.Font = new Font("Consolas", 9F, FontStyle.Bold);
            DeleteBtn.ForeColor = Color.White;
            DeleteBtn.Location = new Point(16, 11);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(80, 31);
            DeleteBtn.TabIndex = 0;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // AddButton
            // 
            AddButton.BackColor = Color.FromArgb(22, 163, 74);
            AddButton.Cursor = Cursors.Hand;
            AddButton.FlatAppearance.BorderSize = 0;
            AddButton.FlatStyle = FlatStyle.Flat;
            AddButton.Font = new Font("Consolas", 9F, FontStyle.Bold);
            AddButton.ForeColor = Color.White;
            AddButton.Location = new Point(112, 11);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(80, 31);
            AddButton.TabIndex = 1;
            AddButton.Text = "+ Add";
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += AddButton_Click;
            // 
            // EditBtn
            // 
            EditBtn.BackColor = Color.FromArgb(37, 99, 235);
            EditBtn.Cursor = Cursors.Hand;
            EditBtn.FlatAppearance.BorderSize = 0;
            EditBtn.FlatStyle = FlatStyle.Flat;
            EditBtn.Font = new Font("Consolas", 9F, FontStyle.Bold);
            EditBtn.ForeColor = Color.White;
            EditBtn.Location = new Point(208, 11);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(80, 31);
            EditBtn.TabIndex = 2;
            EditBtn.Text = "Edit";
            EditBtn.UseVisualStyleBackColor = false;
            EditBtn.Click += EditBtn_Click;
            // 
            // SearchPanel
            // 
            SearchPanel.BackColor = Color.FromArgb(15, 17, 23);
            SearchPanel.Controls.Add(SearchIconLabel);
            SearchPanel.Controls.Add(SearchBox);
            SearchPanel.Dock = DockStyle.Top;
            SearchPanel.Location = new Point(0, 52);
            SearchPanel.Name = "SearchPanel";
            SearchPanel.Padding = new Padding(16, 8, 16, 8);
            SearchPanel.Size = new Size(960, 57);
            SearchPanel.TabIndex = 2;
            // 
            // SearchIconLabel
            // 
            SearchIconLabel.AutoSize = true;
            SearchIconLabel.Font = new Font("Segoe UI", 10F);
            SearchIconLabel.ForeColor = Color.FromArgb(75, 85, 99);
            SearchIconLabel.Location = new Point(7, 11);
            SearchIconLabel.Name = "SearchIconLabel";
            SearchIconLabel.Size = new Size(33, 23);
            SearchIconLabel.TabIndex = 0;
            SearchIconLabel.Text = "🔍";
            // 
            // SearchBox
            // 
            SearchBox.BackColor = Color.FromArgb(10, 12, 18);
            SearchBox.BorderStyle = BorderStyle.None;
            SearchBox.Font = new Font("Consolas", 10F);
            SearchBox.ForeColor = Color.FromArgb(156, 163, 175);
            SearchBox.Location = new Point(46, 15);
            SearchBox.Name = "SearchBox";
            SearchBox.PlaceholderText = "Search accounts...";
            SearchBox.Size = new Size(889, 20);
            SearchBox.TabIndex = 1;
            SearchBox.TextChanged += SearchBox_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(15, 17, 23);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(15, 17, 23);
            dataGridViewCellStyle1.Font = new Font("Consolas", 8F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(75, 85, 99);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(15, 17, 23);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(75, 85, 99);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeight = 40;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(15, 17, 23);
            dataGridViewCellStyle2.Font = new Font("Consolas", 10F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(156, 163, 175);
            dataGridViewCellStyle2.Padding = new Padding(4, 6, 4, 6);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(22, 25, 33);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(209, 213, 219);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.FromArgb(30, 33, 48);
            dataGridView1.Location = new Point(0, 109);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 42;
            dataGridView1.ScrollBars = ScrollBars.Vertical;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(960, 479);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // StatusPanel
            // 
            StatusPanel.BackColor = Color.FromArgb(15, 17, 23);
            StatusPanel.Controls.Add(StatusDot);
            StatusPanel.Controls.Add(StatusLabel);
            StatusPanel.Dock = DockStyle.Bottom;
            StatusPanel.Location = new Point(0, 588);
            StatusPanel.Name = "StatusPanel";
            StatusPanel.Size = new Size(960, 32);
            StatusPanel.TabIndex = 4;
            // 
            // StatusDot
            // 
            StatusDot.BackColor = Color.FromArgb(22, 163, 74);
            StatusDot.Location = new Point(15, 13);
            StatusDot.Name = "StatusDot";
            StatusDot.Size = new Size(8, 8);
            StatusDot.TabIndex = 0;
            // 
            // StatusLabel
            // 
            StatusLabel.AutoSize = true;
            StatusLabel.Font = new Font("Consolas", 9F);
            StatusLabel.ForeColor = Color.FromArgb(75, 85, 99);
            StatusLabel.Location = new Point(26, 8);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(224, 18);
            StatusLabel.TabIndex = 1;
            StatusLabel.Text = "Ready  •  0 accounts stored";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 17, 23);
            ClientSize = new Size(960, 620);
            Controls.Add(dataGridView1);
            Controls.Add(SearchPanel);
            Controls.Add(NavBar);
            Controls.Add(StatusPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(800, 498);
            Name = "Dashboard";
            Text = "Lock In — Dashboard";
            Load += Dashboard_Load;
            NavBar.ResumeLayout(false);
            BrandPanel.ResumeLayout(false);
            BrandPanel.PerformLayout();
            ActionPanel.ResumeLayout(false);
            SearchPanel.ResumeLayout(false);
            SearchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            StatusPanel.ResumeLayout(false);
            StatusPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel NavBar;
        private Panel BrandPanel;
        private Label LockIconLabel;
        private Label BrandLabel;
        private Panel ActionPanel;
        private Button DeleteBtn;
        private Button AddButton;
        private Button EditBtn;
        private Button NgtMdTglBtn;
        private Panel SearchPanel;
        private Label SearchIconLabel;
        private TextBox SearchBox;
        private DataGridView dataGridView1;
        private Panel StatusPanel;
        private Label StatusDot;
        private Label StatusLabel;
    }
}