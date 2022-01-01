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
    
    public partial class GioHang : Form
    {
        private HomePage home;
        private SqlConnection sqlCon;
        
        
        public GioHang(HomePage home, SqlConnection sqlCon)
        {
            this.home = home;
            this.sqlCon = sqlCon;
            InitializeComponent();

            ChiTietDonHang.ColumnCount = 5;
            ChiTietDonHang.Columns[0].DataPropertyName = "MaSp";
            ChiTietDonHang.Columns[1].DataPropertyName = "TenSp";
            ChiTietDonHang.Columns[2].DataPropertyName = "SoLuong";
            ChiTietDonHang.Columns[3].DataPropertyName = "Gia";
            ChiTietDonHang.Columns[4].DataPropertyName = "ThanhTien";
            ChiTietDonHang.DataSource = home.GioHang; 
        }

        private void ChiTietDonHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_DatHang_Click(object sender, EventArgs e)
        {

        }
    }
    public class ChiTietGioHang
    {
        int MaSp;
        string TenSp;
        int SoLuong;
        float Gia;
        float ThanhTien;
        public ChiTietGioHang ThemVaoGio(int masp, string tensp, int soluong, float gia, float thanhtien)
        {
            
            this.MaSp = masp;
            this.TenSp = tensp;
            this.SoLuong = soluong;
            this.Gia = gia;
            this.ThanhTien = thanhtien;
            return this;        }
        }
    }
