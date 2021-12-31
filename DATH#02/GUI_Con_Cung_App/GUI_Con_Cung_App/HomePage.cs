using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GUI_Con_Cung_App
{
    public partial class HomePage : Form
    {
        private DangNhap DN;
        private SqlConnection cnn; 
        public HomePage(DangNhap DN, SqlConnection cnn)
        {
            this.cnn = cnn;
            this.DN = DN; 

            InitializeComponent();
           
        }

        private void DS_SanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void input_TimKiem_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
