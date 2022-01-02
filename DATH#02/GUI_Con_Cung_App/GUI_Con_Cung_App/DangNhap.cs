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
        public static int makhachhang;
        public DangNhap(ConnectDB cdb, SqlConnection sqlCon)
        {
            this.cdb = cdb;
            this.sqlCon = sqlCon;
            InitializeComponent();
            TaiKhoan.Text = "";
            MatKhau.Text = "";
        }

        private void buttton_DangNhap_Click(object sender, EventArgs e)
        {
            string username = TaiKhoan.Text;
            string password = MatKhau.Text; 

            if(username == "" || password == "" || username.Length > 20 || password.Length > 30)
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không hợp lệ");
                return;
            }

            string sqlquery = "exec DangNhap " + username + ", " + password + "";
            
            //sqlCon.Open();
            
            DataTable thongTinTaiKhoan = new DataTable();
            SqlDataAdapter adt = new SqlDataAdapter(sqlquery, sqlCon);
            adt.Fill(thongTinTaiKhoan);
            sqlCon.Close();
            string makh = thongTinTaiKhoan.Rows[0][1].ToString();
            string phanLoai = thongTinTaiKhoan.Rows[0][0].ToString();

            // TODO: con nua...
            /*if (phanLoai == "KH")
            {
                this.Hide();
                HomePage KH = new HomePage(this, this.sqlCon);
                KH.Show(); 
            }*/
            if(phanLoai == "QT")
            {
                this.Hide();
            }
            if (phanLoai == "QL") // phân hệ quản lý 
            {
                sqlCon.Open();
                string get_name = "select TENNV " +
                "from NHANVIEN nv, TAIKHOAN tk " +
                "where nv.IDTAIKHOAN = tk.TAIKHOANID AND tk.USERNAME = '" + username + "'";

                DataTable Name = new DataTable();
                SqlDataAdapter adt2 = new SqlDataAdapter(get_name, sqlCon);
                adt2.Fill(Name);
                string name = Name.Rows[0][0].ToString();

                MessageBox.Show("Xin chào " + name + "!! \nChúc bạn một ngày tốt lành <3");
                sqlCon.Close();

                this.Hide();
                QuanLi quanli1 = new QuanLi(this, this.sqlCon, username);
                quanli1.Show();
                // TODO: cho chuyển qua trang của quản lý  
            }
            if (phanLoai == "NV") // phân hệ nhân sự
            {
                sqlCon.Open();
                string get_name = "select TENNV " +
                "from NHANVIEN nv, TAIKHOAN tk " +
                "where nv.IDTAIKHOAN = tk.TAIKHOANID AND tk.USERNAME = '" + username + "'";

                DataTable Name = new DataTable();
                SqlDataAdapter adt2 = new SqlDataAdapter(get_name, sqlCon);
                adt2.Fill(Name);
                string name = Name.Rows[0][0].ToString();

                MessageBox.Show("Xin chào " + name + "!! \nChúc bạn một ngày tốt lành <3");
                sqlCon.Close();

                this.Hide();
                NhanVien nhanvien1 = new NhanVien(this, this.sqlCon, username);
                nhanvien1.Show();
                //TODO: cho chuyển qua trang của nhân viên
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
