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
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            // TODO: Validate and save account
        }
    }
}