using System;
using System.Windows.Forms;

namespace LockIn
{
    public partial class AddAccForm : Form
    {
        public AddAccForm()
        {
            InitializeComponent();
        }

        private void AutoGenBtn_Click(object sender, EventArgs e)
        {
            // TODO: Generate strong password and populate PasswordField
            const int length = 16;
             const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*()";
            char[] res = new char[length];
            using (var rng = System.Security.Cryptography.RandomNumberGenerator.Create())
            {
                byte[] uintBuffer = new byte[sizeof(uint)];
                for (int i = 0; i < length; i++)
                {
                    rng.GetBytes(uintBuffer);
                    uint num = BitConverter.ToUInt32(uintBuffer, 0);
                    res[i] = valid[(int)(num % (uint)valid.Length)];
                }
            }
            PasswordField.Text = new string(res); 
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            // TODO: Validate and save account
            
        }

        private void AccTypeCmBx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UsernameField_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordField_TextChanged(object sender, EventArgs e)
        {

        }
    }
}