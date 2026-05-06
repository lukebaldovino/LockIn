namespace LockIn
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Logger.Info("App started");

            try
            {
                if (MasterAccount.Exists())
                {
                    Application.Run(new LogInForm());
                }
                else
                {
                    Application.Run(new RegisterForm(null));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Startup Error");
            }
        }
    }
}
