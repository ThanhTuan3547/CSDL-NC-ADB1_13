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
            
            ChiTietDonHang.ReadOnly = true;
            ChiTietDonHang.AutoGenerateColumns = false;
            ChiTietDonHang.AllowUserToResizeColumns = false;
            ChiTietDonHang.AllowUserToResizeRows = false;


            ChiTietDonHang.AutoResizeColumns();
            ChiTietDonHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            ChiTietDonHang.ColumnCount = 5;
            ChiTietDonHang.Columns[0].DataPropertyName = "MaSP";
            ChiTietDonHang.Columns[1].DataPropertyName = "TenSP";
            ChiTietDonHang.Columns[2].DataPropertyName = "SoLuong";
            ChiTietDonHang.Columns[3].DataPropertyName = "Gia";
            ChiTietDonHang.Columns[4].DataPropertyName = "ThanhTien";

            ChiTietDonHang.DataSource = home.CTgiohang;

            // tinh tong tien don hang 
            float tongtien = 0;
            for(int i = 0; i < home.CTgiohang.Rows.Count; i++)
            {
                tongtien += float.Parse(home.CTgiohang.Rows[i][4].ToString());
            }
            //ThanhTien.HeaderText = tongtien.ToString(); 
            if (tongtien < 300000)
                tongtien += 25000;
            TongTien.Text = tongtien.ToString();
        }

        private void ChiTietDonHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_DatHang_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn đặt hàng?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.sqlCon.Open();
                string taoMaDonHang = "exec TaoMaHoaDonMoi 0";
                SqlDataAdapter adt = new SqlDataAdapter(taoMaDonHang, sqlCon);
                DataTable dt = new DataTable();

                adt.Fill(dt);

                int maDonHang = int.Parse(dt.Rows[0][0].ToString());

                int makh = DangNhap.makhachhang;
                string sdt = textBox1.Text;
                DateTime current = DateTime.Now;
                string diachi = textBox2.Text;
                string HTTT = hinhthucthanhtoan.Text;
                string DVvanChuyen = "Giao hàng nhanh";
                float phivanchuyen = 0;
                float tongtien = float.Parse(TongTien.Text.ToString());
                if (tongtien < 300000)
                {
                    phivanchuyen = 25000;
                }
                string tgDathang = current.Day.ToString() + "-" + current.Month.ToString() + "-" + current.Year.ToString();

                //SqlCommand query = "exec ThemDonHangOnline ";

                string query = "exec ThemDonHangOnline " + maDonHang + "," + makh + ",'" + sdt + "','" + tgDathang + "', N'" + diachi + "', N'" + HTTT + "', N'" + DVvanChuyen + "'," + phivanchuyen + "," + tongtien;
                //SqlCommand = 
                SqlCommand command = new SqlCommand(query, sqlCon);
                command.ExecuteNonQuery();

                //them chi tiet hoa don 
                for (int i = 0; i < home.CTgiohang.Rows.Count; i ++)
                {
                    query = "exec ThemCTDHOnline " + maDonHang + "," + home.CTgiohang.Rows[i][0] + ",'" + home.CTgiohang.Rows[i][2] + "','" + home.CTgiohang.Rows[i][3] + "', " + home.CTgiohang.Rows[i][4] ;
                    command.Parameters.Clear();
                    command.CommandText = query;
                    command.ExecuteNonQuery();
                }

                this.sqlCon.Close();
                MessageBox.Show("Đặt hàng thành công");
                ChiTietDonHang.DataSource = null;
                TongTien.Text = "0"; 
            }
        }

        private void GioHang_Load(object sender, EventArgs e)
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
            return this;        
        }
    }
    
}
