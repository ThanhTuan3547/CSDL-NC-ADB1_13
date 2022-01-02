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
        public List<ChiTietGioHang> GioHang = new List<ChiTietGioHang>();
        public DataTable CTgiohang = new DataTable(); 
        
        public HomePage(DangNhap DN, SqlConnection cnn)
        {
            this.cnn = cnn;
            this.DN = DN;
           // this.FormClosing += HomePage_FormClosing; 
            InitializeComponent();
            //
            DS_SanPham.ReadOnly = true;
            DS_SanPham.AutoGenerateColumns = false;
            DS_SanPham.AllowUserToResizeColumns = false;
            DS_SanPham.AllowUserToResizeRows = false;
            // load product to show 
            string sqlquery = "select MaSP, TenSP, Gia, MoTa, SoLuongTon from sanpham";
            DataSet dt = new DataSet();
            this.cnn.Open();
            SqlDataAdapter adt = new SqlDataAdapter(sqlquery, cnn);
            adt.Fill(dt);
            
            
            DS_SanPham.AutoResizeColumns();
            DS_SanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            this.cnn.Close();

            DS_SanPham.ColumnCount = 6;
            DS_SanPham.Columns[0].DataPropertyName = "MaSP";
            DS_SanPham.Columns[1].DataPropertyName = "TenSP";
            DS_SanPham.Columns[2].DataPropertyName = "Gia";
            DS_SanPham.Columns[3].DataPropertyName = "MoTa";
            DS_SanPham.Columns[4].DataPropertyName = "SoLuongTon";
            //DS_SanPham.Columns[5].
            DS_SanPham.DataSource = dt.Tables[0];
            // setup gio hang 
            CTgiohang.Columns.Add("MaSP", typeof(int));
            CTgiohang.Columns.Add( "TenSP", typeof(string));
            CTgiohang.Columns.Add( "SoLuong", typeof(int));
            CTgiohang.Columns.Add( "Gia", typeof(float));
            CTgiohang.Columns.Add( "ThanhTien", typeof(float));
        }
        private void DS_SanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(DS_SanPham.Columns[e.ColumnIndex].Name == "Mua")
            {
                if(MessageBox.Show("Bạn muốn thêm sản phẩm vào giỏ hàng?","Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int masp = int.Parse(DS_SanPham.Rows[e.RowIndex].Cells[0].Value.ToString());
                    string tensp = DS_SanPham.Rows[e.RowIndex].Cells[1].Value.ToString();
                    int soluong = 1;
                    float gia = float.Parse(DS_SanPham.Rows[e.RowIndex].Cells[2].Value.ToString());
                    float thanhtien = soluong * gia;
                    //
                    DataRow row = CTgiohang.NewRow();
                    row["MaSP"] = masp;
                    row["TenSP"] = tensp;
                    row["SoLuong"] = soluong;
                    row["Gia"] = gia;
                    row["ThanhTien"] = thanhtien;
                    CTgiohang.Rows.Add(row);


                }
            }
        }
        
        private void input_TimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_GioHang_Click(object sender, EventArgs e)
        {
            this.Hide();
            GioHang gioHang = new GioHang(this, this.cnn);
            gioHang.Show();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            
        }
        
    }
}
