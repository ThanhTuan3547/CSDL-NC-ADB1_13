using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Con_Cung_App
{
    static class Connection_string
    {
        public static string Conn_String()
        {
            return "Data Source=LAPTOP-FMCUOBFE\\SQLEXPRESS;Initial Catalog=DB_QLDatChuyenHang;Integrated Security=True";
        }   
    }
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
            Application.Run(new HomePage());

        }
    }
}
