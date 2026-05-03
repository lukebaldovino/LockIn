namespace LockIn
{
    public partial class Dashboard : Form
    {
        // ── Color constants matching the dark theme ──────────────────
        private static readonly Color BgPrimary = Color.FromArgb(15, 17, 23);
        private static readonly Color BgSurface = Color.FromArgb(22, 25, 33);
        private static readonly Color BorderColor = Color.FromArgb(30, 33, 48);
        private static readonly Color TextMuted = Color.FromArgb(156, 163, 175);
        private static readonly Color TextBright = Color.FromArgb(209, 213, 219);

        // Badge colors: (background, foreground)
        private static readonly (Color bg, Color fg) BadgePersonal = (Color.FromArgb(30, 58, 95), Color.FromArgb(96, 165, 250));
        private static readonly (Color bg, Color fg) BadgeWork = (Color.FromArgb(20, 83, 45), Color.FromArgb(74, 222, 128));
        private static readonly (Color bg, Color fg) BadgeSchool = (Color.FromArgb(69, 26, 3), Color.FromArgb(251, 146, 60));

        // ── Night-mode state ─────────────────────────────────────────
        private bool _isDayMode = true;   // starts in Night (dark) mode; button shows "Day" to switch

        public Dashboard()
        {
            InitializeComponent();
            SetupColumns();
            SetupDgvPainting();
            LoadSampleData();
            RoundStatusDot();
            StyleButtons();
            SetupPanelBorders();
            SearchBox.TextChanged += SearchBox_TextChanged;
            
        }

        // ── Columns ──────────────────────────────────────────────────
        private void SetupColumns()
        {
            dataGridView1.Columns.Clear();

            // TYPE — owner-drawn badge (uses CellPainting)
            var colType = new DataGridViewTextBoxColumn
            {
                Name = "colType",
                HeaderText = "TYPE",
                DataPropertyName = "Type",
                FillWeight = 14
            };

            // USERNAME / EMAIL
            var colUser = new DataGridViewTextBoxColumn
            {
                Name = "colUser",
                HeaderText = "USERNAME / EMAIL",
                DataPropertyName = "Username",
                FillWeight = 28
            };

            // SERVICE
            var colService = new DataGridViewTextBoxColumn
            {
                Name = "colService",
                HeaderText = "SERVICE",
                DataPropertyName = "Service",
                FillWeight = 20
            };
            colService.DefaultCellStyle.ForeColor = TextBright;

            // PASSWORD — always shows dots, owner-drawn
            var colPassword = new DataGridViewTextBoxColumn
            {
                Name = "colPassword",
                HeaderText = "PASSWORD",
                DataPropertyName = "Password",
                FillWeight = 22
            };

            // ACTIONS — button column
            var colAction = new DataGridViewButtonColumn
            {
                Name = "colAction",
                HeaderText = "ACTIONS",
                Text = "View",
                UseColumnTextForButtonValue = true,
                FillWeight = 16
            };
            colAction.DefaultCellStyle.BackColor = Color.FromArgb(37, 99, 235);
            colAction.DefaultCellStyle.ForeColor = Color.White;
            colAction.DefaultCellStyle.SelectionBackColor = Color.FromArgb(37, 99, 235);
            colAction.DefaultCellStyle.SelectionForeColor = Color.White;
            colAction.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colAction.DefaultCellStyle.Font = new Font("Consolas", 9F, FontStyle.Bold);
            colAction.DefaultCellStyle.Padding = new Padding(2);

            dataGridView1.Columns.AddRange(colType, colUser, colService, colPassword, colAction);
        }

        // ── Owner-draw: badges + password dots ───────────────────────
        private void SetupDgvPainting()
        {
            dataGridView1.CellPainting += DataGridView1_CellPainting;
        }

        private void DataGridView1_CellPainting(object? sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            bool selected = (e.State & DataGridViewElementStates.Selected) != 0;
            Color rowBg = selected ? BgSurface : BgPrimary;

            // ── Type badge ───────────────────────────────────────────
            if (e.ColumnIndex == dataGridView1.Columns["colType"]!.Index)
            {
                e.Graphics!.FillRectangle(new SolidBrush(rowBg), e.CellBounds);

                string typeVal = e.Value?.ToString() ?? "";
                var (bg, fg) = typeVal switch
                {
                    "Work" => BadgeWork,
                    "School" => BadgeSchool,
                    _ => BadgePersonal
                };

                using var badgeBrush = new SolidBrush(bg);
                using var textBrush = new SolidBrush(fg);
                using var badgeFont = new Font("Consolas", 8.5F, FontStyle.Bold);

                var textSize = e.Graphics.MeasureString(typeVal, badgeFont);
                int padX = 10, padY = 3;
                int bw = (int)textSize.Width + padX * 2;
                int bh = (int)textSize.Height + padY * 2;
                int bx = e.CellBounds.X + 6;
                int by = e.CellBounds.Y + (e.CellBounds.Height - bh) / 2;

                using var path = RoundedRect(new Rectangle(bx, by, bw, bh), 10);
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                e.Graphics.FillPath(badgeBrush, path);
                e.Graphics.DrawString(typeVal, badgeFont, textBrush, bx + padX, by + padY);

                e.Handled = true;
                return;
            }

            // ── Password dots ────────────────────────────────────────
            if (e.ColumnIndex == dataGridView1.Columns["colPassword"]!.Index)
            {
                e.Graphics!.FillRectangle(new SolidBrush(rowBg), e.CellBounds);

                int dotSize = 5, dotGap = 4, dotCount = 8;
                int startX = e.CellBounds.X + 8;
                int startY = e.CellBounds.Y + (e.CellBounds.Height - dotSize) / 2;

                using var dotBrush = new SolidBrush(Color.FromArgb(55, 65, 81));
                for (int i = 0; i < dotCount; i++)
                {
                    int dx = startX + i * (dotSize + dotGap);
                    e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    e.Graphics.FillEllipse(dotBrush, dx, startY, dotSize, dotSize);
                }

                e.Handled = true;
                return;
            }

            // ── Action buttons (View) ────────────────────────────────
            if (e.ColumnIndex == dataGridView1.Columns["colAction"]!.Index)
            {
                e.Graphics!.FillRectangle(new SolidBrush(rowBg), e.CellBounds);

                string buttonText = "View";
                Color buttonBg = Color.FromArgb(37, 99, 235);
                Color buttonFg = Color.White;

                using var buttonBrush = new SolidBrush(buttonBg);
                using var textBrush = new SolidBrush(buttonFg);
                using var buttonFont = new Font("Consolas", 9F, FontStyle.Bold);

                var textSize = e.Graphics.MeasureString(buttonText, buttonFont);
                int padX = 12, padY = 4;
                int bw = (int)textSize.Width + padX * 2;
                int bh = (int)textSize.Height + padY * 2;
                int bx = e.CellBounds.X + (e.CellBounds.Width - bw) / 2;
                int by = e.CellBounds.Y + (e.CellBounds.Height - bh) / 2;

                int radius = bh / 2;
                using var path = RoundedRect(new Rectangle(bx, by, bw, bh), radius);
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                e.Graphics.FillPath(buttonBrush, path);
                e.Graphics.DrawString(buttonText, buttonFont, textBrush, bx + padX, by + padY);

                e.Handled = true;
                return;
            }
        }

        // ── Sample data ───────────────────────────────────────────────
        private List<PasswordEntry> _allAccounts = new();

        private void LoadSampleData()
        {
            _allAccounts = new List<PasswordEntry>
            {
                new("Personal", "luke@gmail.com",              "Gmail",            "hunter2"),
                new("Work",     "l.baldovino@batstate.edu",     "BatStateU Portal", "p@ssword1"),
                new("School",   "ronjae@github.com",            "GitHub",           "gh_secret"),
                new("Personal", "ace.botones",                  "Discord",          "discordpw"),
            };
            BindAccounts(_allAccounts);
        }

        private void BindAccounts(IEnumerable<PasswordEntry> accounts)
        {
            dataGridView1.DataSource = accounts.ToList();
            UpdateStatus();
        }

        private void UpdateStatus()
        {
            int count = dataGridView1.RowCount;
            StatusLabel.Text = $"Ready  •  {count} account{(count == 1 ? "" : "s")} stored";
        }

        // ── Search ───────────────────────────────────────────────────
        private void SearchBox_TextChanged(object? sender, EventArgs e)
        {
            string q = SearchBox.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(q))
                BindAccounts(_allAccounts);
            else
                BindAccounts(_allAccounts.Where(a =>
                    a.Username.ToLower().Contains(q) ||
                    a.Service.ToLower().Contains(q) ||
                    a.Type.ToLower().Contains(q)));
        }

        // ── Button handlers ──────────────────────────────────────────
        private void AddButton_Click(object sender, EventArgs e)
        {
            AddAccForm addAcc = new AddAccForm();
            addAcc.ShowDialog();
            // TODO: after AddAccForm returns, refresh _allAccounts from your data source
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dataGridView1.Columns[e.ColumnIndex].Name == "colAction")
            {
                var acc = _allAccounts[e.RowIndex];
                MessageBox.Show(
                    $"Password: {acc.Password}",
                    $"{acc.Service} — {acc.Username}",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.None);
            }
        }

        // ── Night / Day mode toggle ───────────────────────────────────
        private void NgtMdTglBtn_Click(object sender, EventArgs e)
        {
            _isDayMode = !_isDayMode;

            if (_isDayMode)
            {
                // Switch to Day (light) mode
                NgtMdTglBtn.Text = "Night";

                Color lightBg = Color.FromArgb(245, 247, 250);
                Color lightSurface = Color.FromArgb(255, 255, 255);
                Color lightNav = Color.FromArgb(255, 255, 255);
                Color lightBorder = Color.FromArgb(209, 213, 219);
                Color lightText = Color.FromArgb(55, 65, 81);
                Color lightMuted = Color.FromArgb(107, 114, 128);

                this.BackColor = lightBg;
                NavBar.BackColor = lightNav;
                SearchPanel.BackColor = lightBg;
                StatusPanel.BackColor = lightBg;
                SearchBox.BackColor = lightSurface;
                SearchBox.ForeColor = lightText;
                BrandLabel.ForeColor = Color.FromArgb(17, 24, 39);
                LockIconLabel.ForeColor = Color.FromArgb(17, 24, 39);
                StatusLabel.ForeColor = lightMuted;
                SearchIconLabel.ForeColor = lightMuted;
                NgtMdTglBtn.BackColor = Color.FromArgb(229, 231, 235);
                NgtMdTglBtn.ForeColor = Color.FromArgb(17, 24, 39);

                // DataGridView
                var dgvBg = new DataGridViewCellStyle(dataGridView1.DefaultCellStyle)
                {
                    BackColor = lightSurface,
                    ForeColor = lightText,
                    SelectionBackColor = lightBorder,
                    SelectionForeColor = Color.FromArgb(17, 24, 39)
                };
                dataGridView1.DefaultCellStyle = dgvBg;
                dataGridView1.BackgroundColor = lightBg;
                dataGridView1.GridColor = lightBorder;

                var hdrStyle = new DataGridViewCellStyle(dataGridView1.ColumnHeadersDefaultCellStyle)
                {
                    BackColor = lightBg,
                    ForeColor = lightMuted,
                    SelectionBackColor = lightBg,
                    SelectionForeColor = lightMuted
                };
                dataGridView1.ColumnHeadersDefaultCellStyle = hdrStyle;
            }
            else
            {
                // Switch back to Night (dark) mode

                NgtMdTglBtn.Text = "Day";

                this.BackColor = Color.FromArgb(15, 17, 23);
                NavBar.BackColor = Color.FromArgb(22, 25, 33);
                SearchPanel.BackColor = Color.FromArgb(15, 17, 23);
                StatusPanel.BackColor = Color.FromArgb(15, 17, 23);
                SearchBox.BackColor = Color.FromArgb(10, 12, 18);
                SearchBox.ForeColor = Color.FromArgb(156, 163, 175);
                BrandLabel.ForeColor = Color.FromArgb(226, 232, 240);
                LockIconLabel.ForeColor = Color.FromArgb(226, 232, 240);
                StatusLabel.ForeColor = Color.FromArgb(75, 85, 99);
                SearchIconLabel.ForeColor = Color.FromArgb(75, 85, 99);
                NgtMdTglBtn.BackColor = Color.FromArgb(45, 50, 65);
                NgtMdTglBtn.ForeColor = Color.FromArgb(226, 232, 240);

                // DataGridView
                var dgvBg = new DataGridViewCellStyle(dataGridView1.DefaultCellStyle)
                {
                    BackColor = Color.FromArgb(15, 17, 23),
                    ForeColor = Color.FromArgb(156, 163, 175),
                    SelectionBackColor = Color.FromArgb(22, 25, 33),
                    SelectionForeColor = Color.FromArgb(209, 213, 219)
                };
                dataGridView1.DefaultCellStyle = dgvBg;
                dataGridView1.BackgroundColor = Color.FromArgb(15, 17, 23);
                dataGridView1.GridColor = Color.FromArgb(30, 33, 48);

                var hdrStyle = new DataGridViewCellStyle(dataGridView1.ColumnHeadersDefaultCellStyle)
                {
                    BackColor = Color.FromArgb(15, 17, 23),
                    ForeColor = Color.FromArgb(75, 85, 99),
                    SelectionBackColor = Color.FromArgb(15, 17, 23),
                    SelectionForeColor = Color.FromArgb(75, 85, 99)
                };
                dataGridView1.ColumnHeadersDefaultCellStyle = hdrStyle;
            }

            dataGridView1.Invalidate();
        }

        // ── Helpers ──────────────────────────────────────────────────
        private void RoundStatusDot()
        {
            StatusDot.Paint += (s, e) =>
            {
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                e.Graphics.Clear(StatusPanel.BackColor);
                using var b = new SolidBrush(Color.FromArgb(22, 163, 74));
                e.Graphics.FillEllipse(b, 0, 0, StatusDot.Width, StatusDot.Height);
            };
        }

        private void StyleButtons()
        {
            var buttons = new[] {
                (AddButton, Color.FromArgb(22, 163, 74)),
                (EditBtn,   Color.FromArgb(37, 99, 235)),
                (DeleteBtn, Color.FromArgb(220, 38, 38)),
                (NgtMdTglBtn, Color.FromArgb(45, 50, 65)),
            };

            foreach (var (btn, color) in buttons)
            {
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.Cursor = Cursors.Hand;

                btn.Paint += (s, e) =>
                {
                    e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    e.Graphics.Clear(btn.Parent!.BackColor);

                    int radius = btn.Height / 2;
                    using var path = RoundedRect(new Rectangle(0, 0, btn.Width - 1, btn.Height - 1), radius);
                    using var brush = new SolidBrush(color);
                    e.Graphics.FillPath(brush, path);

                    // Draw text centered
                    using var sf = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
                    e.Graphics.DrawString(btn.Text, btn.Font, new SolidBrush(Color.White),
                        new Rectangle(0, 0, btn.Width, btn.Height), sf);
                };
            }
        }

        private void SetupPanelBorders()
        {
            NavBar.Paint += (s, e) =>
            {
                using var borderPen = new Pen(BorderColor, 1);
                e.Graphics.DrawLine(borderPen, 0, NavBar.Height - 1, NavBar.Width, NavBar.Height - 1);
            };

            SearchPanel.Paint += (s, e) =>
            {
                using var borderPen = new Pen(BorderColor, 1);
                e.Graphics.DrawLine(borderPen, 0, SearchPanel.Height - 1, SearchPanel.Width, SearchPanel.Height - 1);
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

        private void BrandLabel_Click(object sender, EventArgs e)
        {
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {

        }
    }

    // ── Data model ───────────────────────────────────────────────────
    public record PasswordEntry(string Type, string Username, string Service, string Password);
}