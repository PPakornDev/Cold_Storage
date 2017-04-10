using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIAM_Temp_App
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());
            GC.Collect();
        }

        public static string GetIP()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            var address = host
                .AddressList
                .FirstOrDefault(ip => ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork);
            if (address == null)
            {
                return "localhost";
            }
            else
            {
                return address.ToString();
            }
        }
    }
}
