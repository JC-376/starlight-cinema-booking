using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.IO;
using ADOX;
using System.Windows.Forms;

namespace Cinema_Booking_System
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMainMenu());
        }
    }
}
