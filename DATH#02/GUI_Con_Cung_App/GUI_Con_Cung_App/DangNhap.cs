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
    public partial class DangNhap : Form
    {
        private ConnectDB cdb;
        private SqlConnection sqlCon;
        public DangNhap(ConnectDB cdb, SqlConnection sqlCon)
        {
            this.cdb = cdb;
            this.sqlCon = sqlCon;
            InitializeComponent();
        }

        private void buttton_DangNhap_Click(object sender, EventArgs e)
        {
            string username = TaiKhoan.Text;
            string password = MatKhau.Text; 

            if(username == "" || password == "" || username.Length > 20 || password.Length > 20)
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không hợp lệ");
                return;
            }

            string sqlquery = "exec DangNhap " + username + ", " + password + "";
            SqlCommand sm = new SqlCommand(sqlquery);
            sqlCon.Open();
            //sm.ExecuteNonQuery();

            DataSet thongTinTaiKhoan = new DataSet();
            SqlDataAdapter adt = new SqlDataAdapter(sqlquery, sqlCon);
            adt.Fill(thongTinTaiKhoan);
            sqlCon.Close();
            string makh = thongTinTaiKhoan.Tables[0].Rows[0][0].ToString();
            string phanLoai = thongTinTaiKhoan.Tables[0].Rows[0][1].ToString();
            // TODO: con nua...
            if(phanLoai == "KH")
            {
                MessageBox.Show("dang nhap thanh cong");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
