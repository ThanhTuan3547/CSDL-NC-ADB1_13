using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Con_Cung_App
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
            Application.Run(new ConnectDB()); // go to ConnectDB.cs, F7 view code

        }
    }
    public class Products
    {
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public string Gia { get; set; }
        public string MoTa { get; set; }
        public string SoLuongTon { get; set;  }
    }
}
