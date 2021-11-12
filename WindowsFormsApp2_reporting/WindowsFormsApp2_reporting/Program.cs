using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2_reporting
{
    public class formList
    {
            private static MainMenu f0 = new MainMenu(); 
            public static MainMenu _f0 { get {return f0;}}

            private static QuanLyHoaDon f1 = new QuanLyHoaDon();
            public static QuanLyHoaDon _f1 { get {return f1;}}

            private static XemDSHoaDon f2 = new XemDSHoaDon();
            public static XemDSHoaDon _f2 { get {return f2;}}

            private static DoanhThuTheoThang f3 = new DoanhThuTheoThang();
            public static DoanhThuTheoThang _f3 { get { return f3; } }
    }
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        //public static MainMenu f0 = new MainMenu();
        //public static QuanLyHoaDon f1 = new QuanLyHoaDon();

        

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MainMenu fo0 = new MainMenu();
            QuanLyHoaDon fo1 = new QuanLyHoaDon();
            XemDSHoaDon fo2 = new XemDSHoaDon();
            
            Application.Run(formList._f0);
            
        }
    }
}
