using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LockIn
{
    public partial class AddAccForm : Form
    {
        // Public properties so Dashboard can read the result after ShowDialog()
        public string AccountType { get; private set; } = "";
        public string Username { get; private set; } = "";
        public string Password { get; private set; } = "";
        
        public string Service { get; private set; } = "";
        public AddAccForm()
        {
            InitializeComponent();
        }

        // ── Auto-generate password ────────────────────────────────────
        private void AutoGenBtn_Click(object sender, EventArgs e)
        {
            const int length = 16;
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*()";

            char[] res = new char[length];
            using (var rng = System.Security.Cryptography.RandomNumberGenerator.Create())
            {
                byte[] buf = new byte[sizeof(uint)];
                for (int i = 0; i < length; i++)
                {
                    rng.GetBytes(buf);
                    uint num = BitConverter.ToUInt32(buf, 0);
                    res[i] = valid[(int)(num % (uint)valid.Length)];
                }
            }

            PasswordField.UseSystemPasswordChar = false;   // show it so user can verify
            PasswordField.Text = new string(res);
        }

        // ── Cancel ───────────────────────────────────────────────────
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        // ── Confirm / Save ───────────────────────────────────────────
        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            Service = ServicetxtBx.Text.Trim();
            Username = UsernameField.Text.Trim();
            Password = PasswordField.Text;  
            AccountType = AccTypeCmBx.SelectedItem?.ToString() ?? "";

            // Convert string to AccountType enum
            if (!Enum.TryParse(AccountType, out AccountType accountType))
            {
                MessageBox.Show("Invalid account type selected.");
                return;
            }

            try
            {
                UtilityFunctions.CreateAccount(Service, Username, Password, accountType);
                MessageBox.Show("Account added successfully!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding account: " + ex.Message);
            }
        }

        // ── Stubs (wired in Designer) ─────────────────────────────────
        private void AccTypeCmBx_SelectedIndexChanged(object sender, EventArgs e) { }
        private void UsernameField_TextChanged(object sender, EventArgs e) { }
        private void PasswordField_TextChanged(object sender, EventArgs e) { }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ServicetxtBx_TextChanged(object sender, EventArgs e)
        {

        }
    }
}