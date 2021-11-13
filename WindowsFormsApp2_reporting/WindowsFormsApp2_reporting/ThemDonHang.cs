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
        // tao connection toi local database
        SqlConnection sc = new SqlConnection(@"Data Source=LAPTOP-FMCUOBFE\SQLEXPRESS;Initial Catalog=ADB1_N13_DATH#01;Integrated Security=True");
        private void btnThemHoaDon_Click(object sender, EventArgs e)
        {
            
            var MaKH = textBox2.Text;   // lay ma khach hang tu textbox
            SqlCommand checkMaKH = new SqlCommand("select dbo.TonTaiMaKH(@MaKH)", sc);  // goi ham kiem tra ma khach hang trong database
            checkMaKH.Parameters.Add(new SqlParameter("@MaKH", MaKH));
            sc.Open();
            checkMaKH.ExecuteNonQuery();
            var tonTaiMaKH = checkMaKH.ExecuteScalar().ToString();
            if (tonTaiMaKH == "True")   // neu ma khach hang ton tai --> them don hang 
            {
                string orderDate = dateTimePicker1.Value.ToString("MM-dd-yyyy");    // lay ngay tu dateTimePicker

                SqlCommand sm = new SqlCommand("insert into Hoadon values('" + textBox2.Text + "', @date,0)", sc);  // insert data vao database
                sm.Parameters.Add(new SqlParameter("@date", orderDate));    
                sm.ExecuteNonQuery();
                MessageBox.Show("Thêm hóa đơn thành công!!");
            }
            else {  // ma khach hang khong ton tai
                MessageBox.Show("Mã khách hàng không tồn tại");

            }
     
            sc.Close();
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            formList._f1.Hide(); 

            formList._f0.Show();

        }
    }
}
