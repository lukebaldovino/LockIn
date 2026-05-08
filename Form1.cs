using System.ComponentModel;

namespace LockIn
{
    public partial class Dashboard : Form
    {
        private BindingSource bindingSource = new BindingSource();
        private static readonly Color BgPrimary = Color.FromArgb(15, 17, 23);
        private static readonly Color BgSurface = Color.FromArgb(22, 25, 33);
        private static readonly Color BorderColor = Color.FromArgb(30, 33, 48);
        private static readonly Color TextMuted = Color.FromArgb(156, 163, 175);
        private static readonly Color TextBright = Color.FromArgb(209, 213, 219);

        private static readonly (Color bg, Color fg) BadgePersonal = (Color.FromArgb(30, 58, 95), Color.FromArgb(96, 165, 250));
        private static readonly (Color bg, Color fg) BadgeWork = (Color.FromArgb(20, 83, 45), Color.FromArgb(74, 222, 128));
        private static readonly (Color bg, Color fg) BadgeSchool = (Color.FromArgb(69, 26, 3), Color.FromArgb(251, 146, 60));

        private bool _isDayMode;

        public Dashboard()
        {
            InitializeComponent();
            SetupColumns();
            SetupDgvPainting();
            RoundStatusDot();
            StyleButtons();
            SetupPanelBorders();
            SearchBox.TextChanged += SearchBox_TextChanged;
            dataGridView1.DataSource = bindingSource;
            LoadAccounts();
            var colEnc = dataGridView1.Columns["EncryptedPassword"];
            if (colEnc != null) colEnc.Visible = false;
            var colIv = dataGridView1.Columns["IV"];
            if (colIv != null) colIv.Visible = false;
        }

        private void SetupColumns()
        {
            dataGridView1.Columns.Clear();

            var colType = new DataGridViewTextBoxColumn
            {
                Name = "colType",
                HeaderText = "TYPE",
                DataPropertyName = "Type",
                FillWeight = 14
            };

            var colUser = new DataGridViewTextBoxColumn
            {
                Name = "colUser",
                HeaderText = "USERNAME / EMAIL",
                DataPropertyName = "Username",
                FillWeight = 28
            };

            var colService = new DataGridViewTextBoxColumn
            {
                Name = "colService",
                HeaderText = "SERVICE",
                DataPropertyName = "Service",
                FillWeight = 20
            };
            colService.DefaultCellStyle.ForeColor = TextBright;

            var colPassword = new DataGridViewTextBoxColumn
            {
                Name = "colPassword",
                HeaderText = "PASSWORD",
                DataPropertyName = "Password",
                FillWeight = 22
            };

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

        private void SetupDgvPainting()
        {
            dataGridView1.CellPainting += DataGridView1_CellPainting;
        }

        private void DataGridView1_CellPainting(object? sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            bool selected = (e.State & DataGridViewElementStates.Selected) != 0;
            Color rowBg;
            if (_isDayMode)
            {
                rowBg = selected ? Color.FromArgb(209, 213, 219) : Color.FromArgb(255, 255, 255);
            }
            else
            {
                rowBg = selected ? BgSurface : BgPrimary;
            }

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

            if (e.ColumnIndex == dataGridView1.Columns["colPassword"]!.Index)
            {
                e.Graphics!.FillRectangle(new SolidBrush(rowBg), e.CellBounds);

                int dotSize = 5, dotGap = 4, dotCount = 8;
                int startX = e.CellBounds.X + 8;
                int startY = e.CellBounds.Y + (e.CellBounds.Height - dotSize) / 2;

                Color dotColor = _isDayMode ? Color.FromArgb(156, 163, 175) : Color.FromArgb(55, 65, 81);
                using var dotBrush = new SolidBrush(dotColor);
                for (int i = 0; i < dotCount; i++)
                {
                    int dx = startX + i * (dotSize + dotGap);
                    e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    e.Graphics.FillEllipse(dotBrush, dx, startY, dotSize, dotSize);
                }

                e.Handled = true;
                return;
            }

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

        private void LoadAccounts()
        {
            try
            {
                var decrypted = UtilityFunctions.LoadAllDecrypted();
                var accList = decrypted.Select(x => new AccountView
                {
                    Type = x.Type,
                    Username = x.Username,
                    Service = x.Service,
                    Password = x.Password
                }).ToList();
                bindingSource.DataSource = new BindingList<AccountView>(accList);
            }
            catch (Exception ex)
            {
                Logger.Error("LoadAccounts failed", ex);
                bindingSource.DataSource = new BindingList<AccountView>();
            }
            UpdateStatus();
        }

        private void UpdateStatus()
        {
            int count = bindingSource.Count;
            StatusLabel.Text = $"Ready  •  {count} account{(count == 1 ? "" : "s")} stored";
        }

        private void SearchBox_TextChanged(object? sender, EventArgs e)
        {
            string q = SearchBox.Text.Trim().ToLower();
            try
            {
                var decrypted = UtilityFunctions.LoadAllDecrypted();
                var allList = decrypted.Select(x => new AccountView
                {
                    Type = x.Type,
                    Username = x.Username,
                    Service = x.Service,
                    Password = x.Password
                }).ToList();

                if (string.IsNullOrEmpty(q))
                {
                    bindingSource.DataSource = new BindingList<AccountView>(allList);
                }
                else
                {
                    var filtered = allList.Where(a =>
                        a.Username.ToLower().Contains(q) ||
                        a.Service.ToLower().Contains(q) ||
                        a.Type.ToLower().Contains(q)
                    ).ToList();
                    bindingSource.DataSource = new BindingList<AccountView>(filtered);
                }
            }
            catch
            {
                bindingSource.DataSource = new BindingList<AccountView>();
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var addAcc = new AddAccForm();
            if (addAcc.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (Enum.TryParse<AccountType>(addAcc.AccountTypeName, out var accType))
                    {
                        UtilityFunctions.CreateAccount(addAcc.Service, addAcc.Username, addAcc.Password, accType);
                        Logger.Info($"Account added: {addAcc.Service}");
                    }
                    LoadAccounts();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to save account: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (bindingSource.Count == 0)
            {
                MessageBox.Show("No accounts to edit.", "Lock In",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (bindingSource.Current is not AccountView current) return;

            var editForm = new AddAccForm();
            editForm.AccTypeCmBx.SelectedItem = current.Type;
            editForm.ServiceField.Text = current.Service;
            editForm.ServiceField.Enabled = false;
            editForm.UsernameField.Text = current.Username;
            editForm.Text = "Lock In — Edit Account";
            editForm.TitleLbl.Text = "Edit Account";

            if (editForm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    UtilityFunctions.UpdatePassword(editForm.Service, editForm.Password);
                    Logger.Info($"Password updated for: {editForm.Service}");
                    LoadAccounts();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to update account: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (bindingSource.Count == 0)
            {
                MessageBox.Show("No accounts to delete.", "Lock In",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (bindingSource.Current is not AccountView current) return;

            var result = MessageBox.Show(
                $"Delete the account for \"{current.Service}\" ({current.Username})?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    UtilityFunctions.DeleteAccount(current.Service);
                    Logger.Info($"Account deleted: {current.Service}");
                    LoadAccounts();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to delete account: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var col = dataGridView1.Columns[e.ColumnIndex];
            if (col != null && col.Name == "colAction")
            {
                if (bindingSource[e.RowIndex] is AccountView acc)
                {
                    MessageBox.Show(
                        $"Password: {acc.Password}",
                        $"{acc.Service} — {acc.Username}",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.None);
                }
            }
        }

        private void NgtMdTglBtn_Click(object sender, EventArgs e)
        {
            _isDayMode = !_isDayMode;
            ThemeColors.IsDarkMode = !_isDayMode;

            if (_isDayMode)
            {
                NgtMdTglBtn.Text = "Night";

                Color lightBg = Color.FromArgb(245, 247, 250);
                Color lightSurface = Color.FromArgb(255, 255, 255);
                Color lightNav = Color.FromArgb(255, 255, 255);
                Color lightBorder = Color.FromArgb(209, 213, 219);
                Color lightText = Color.FromArgb(55, 65, 81);
                Color lightMuted = Color.FromArgb(107, 114, 128);

                BackColor = lightBg;
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
                NgtMdTglBtn.Text = "Day";

                BackColor = Color.FromArgb(15, 17, 23);
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

            AddButton.Invalidate();
            EditBtn.Invalidate();
            DeleteBtn.Invalidate();
            NavBar.Invalidate();
            dataGridView1.Invalidate();
        }

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
                (DeleteBtn, Color.FromArgb(220, 38, 38))
            };

            foreach (var (btn, color) in buttons)
            {
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.FlatAppearance.MouseDownBackColor = Color.Transparent;
                btn.FlatAppearance.MouseOverBackColor = Color.Transparent;
                btn.Cursor = Cursors.Hand;

                btn.Paint += (s, e) =>
                {
                    e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    Color navBg = _isDayMode ? Color.FromArgb(255, 255, 255) : Color.FromArgb(22, 25, 33);
                    e.Graphics.Clear(navBg);

                    int radius = btn.Height / 2;
                    using var path = RoundedRect(new Rectangle(0, 0, btn.Width - 1, btn.Height - 1), radius);
                    using var brush = new SolidBrush(color);
                    e.Graphics.FillPath(brush, path);

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

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }
    }

    public class AccountView
    {
        public string Type { get; set; } = "";
        public string Username { get; set; } = "";
        public string Service { get; set; } = "";
        public string Password { get; set; } = "";
    }
}
