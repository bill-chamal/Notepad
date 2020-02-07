using System;
using System.Windows.Forms;

namespace Notepad_2000
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Fix DPI Blur in Windows 10 Issue
            if (Environment.OSVersion.Version.Major >= 6)
                SetProcessDPIAware();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // In case the app crash
            try
            {
                Application.Run(new Form1());
            }
            catch (Exception ex)
            {
                if (MessageBox.Show("The application has occurred an error and will close! \nIf the same error exist again please reinstall the application or try to constact me.\nDo you want to restart? ",
                        "Error", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.ServiceNotification) == DialogResult.Yes)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
                    Application.Restart();
                    Console.WriteLine(ex);
                    throw;
                }
                else
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
                    Console.WriteLine(ex);
                    throw;
                }
            }
        }
        // Fix DPI Blur in Windows 10 Issue
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();
    }
}