using System;
using System.Reflection;
using System.Windows.Forms;

namespace DovizBar
{
    static class Program
    {
        public static Version Version;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            try
            {
                Version = Version.Parse(Application.ProductVersion);
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }
            catch (ObjectDisposedException)
            {
                //Environment.FailFast("Güncelleme Başladı!");
                Application.Exit();
            }
        }
    }
}
