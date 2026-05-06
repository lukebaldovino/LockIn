using System.Security.Cryptography.X509Certificates;

namespace LockIn
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            
            ApplicationConfiguration.Initialize();
            Logger.Info("App started");

            try
            {
                string base64Key = AesCrypto.GenerateKey();
                byte[] key = Convert.FromBase64String(base64Key);
                AesCrypto.SetKey(key);
                UtilityFunctions.Initialize(key);
                Application.Run(new LogInForm());
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Startup Error");
            }
        }
    }
}