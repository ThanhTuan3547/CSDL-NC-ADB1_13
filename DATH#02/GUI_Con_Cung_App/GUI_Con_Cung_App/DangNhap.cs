﻿using System;
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
        public static int MaKhachHang; 
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

            MaKhachHang = int.Parse(makh);
           
            if (phanLoai == "KH")
            {
                this.Hide();
                HomePage KH = new HomePage(this, this.sqlCon);
                KH.Show(); 
            }
            if(phanLoai == "QT")
            {
                this.Hide();
            }
            if (phanLoai == "QL") // phân hệ quản lý 
            {
                this.Hide();
                // TODO: cho chuyển qua trang của quản lý  
            }
            if (phanLoai == "NS") // phân hệ nhân sự
            {
                this.Hide();
                //TODO: cho chuyển qua trang của nhân sự
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
