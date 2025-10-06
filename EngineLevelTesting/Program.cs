using System;
using System.Windows.Forms;

namespace EngineLevelTesting
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Mjc3MTI2NUAzMjMyMmUzMDJlMzBnOEZsZlBUZGxxSkVPazZ6NksyNm1xaTBzZFd3aGYrcm1xam9yNlZyZDg0PQ==");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Forms.MenuV2());

        }
    }
}
