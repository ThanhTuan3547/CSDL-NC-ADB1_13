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

namespace WindowsFormsApp2_reporting
{
    public partial class QuanLyHoaDon : Form
    {
       
        public QuanLyHoaDon()
        {
            InitializeComponent();
        }
        SqlConnection sc = new SqlConnection(@"Data Source=LAPTOP-FMCUOBFE\SQLEXPRESS;Initial Catalog=ADB_DA1;Integrated Security=True");
        private void btnThemHoaDon_Click(object sender, EventArgs e)
        {
            SqlCommand sm = new SqlCommand("insert into Hoadon values('"+textBox1.Text+"','"+textBox2.Text+"', '"+textBox3.Text+"', '"+textBox4.Text+"')", sc);

            sc.Open();

            sm.ExecuteNonQuery();

            sc.Close();

            MessageBox.Show("Thêm hóa đơn thành công!!"); 
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            formList._f1.Hide(); 

            formList._f0.Show();

        }
    }
}
