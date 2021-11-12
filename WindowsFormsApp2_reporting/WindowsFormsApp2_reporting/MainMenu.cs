using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2_reporting
{
    //public static MainMenu fo0 = new MainMenu();
    //public static QuanLyHoaDon fo1 = new QuanLyHoaDon();
    //public class Anyclass
    //{
    //    public static Form2 fo0 = new Form2();
    //    public static QuanLyHoaDon fo1 = new QuanLyHoaDon();

    //}
    public partial class MainMenu : Form
    {
        
        public MainMenu()
        {
            InitializeComponent();

        }

        private void btnThemMoiHoaDon_Click(object sender, EventArgs e)
        {
            QuanLyHoaDon fo1 = new QuanLyHoaDon();
            fo1.Show();
            MainMenu fo2 = new MainMenu();
            fo2.Hide();
        }

        private void btnXemDSHoaDon_Click(object sender, EventArgs e)
        {
            XemDSHoaDon fo3 = new XemDSHoaDon();
            fo3.Show();
        }
    }
}
