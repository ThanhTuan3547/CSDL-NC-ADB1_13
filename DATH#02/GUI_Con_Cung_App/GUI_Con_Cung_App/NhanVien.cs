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
    public partial class NhanVien : Form
    {
        private DangNhap DN;
        private SqlConnection cnn;
        private string username;
        public NhanVien(DangNhap DN, SqlConnection cnn, string username)
        {
            this.cnn = cnn;
            this.DN = DN;
            this.username = username;
            InitializeComponent();
            this.Closing += NhanVien_Closing;

            DaDiemDanh.Hide();
            

            string get_soDH = "SELECT COUNT(*) "
                            + "from HOADONOFFLINE hdoff, NHANVIEN nv, TAIKHOAN tk "
                            + "where hdoff.MANV = nv.MANV AND nv.IDTAIKHOAN = tk.TAIKHOANID AND tk.USERNAME = '" + username + "'";

            string get_name = "select TENNV " +
                "from NHANVIEN nv, TAIKHOAN tk " +
                "where nv.IDTAIKHOAN = tk.TAIKHOANID AND tk.USERNAME = '" + username + "'";

            string get_DSBH = "select DOANHSOBANHANG " +
                "from NHANVIEN nv, TAIKHOAN tk " +
                "where nv.IDTAIKHOAN = tk.TAIKHOANID AND tk.USERNAME = '" + username + "'";

            string get_Thuong = "select THUONG " +
                "from NHANVIEN nv, TAIKHOAN tk " +
                "where nv.IDTAIKHOAN = tk.TAIKHOANID AND tk.USERNAME = '" + username + "'";

            string get_Luong = "select LUONG " +
                "from NHANVIEN nv, TAIKHOAN tk " +
                "where nv.IDTAIKHOAN = tk.TAIKHOANID AND tk.USERNAME = '" + username + "'";

            string get_ChucVu = "select LOAINV " +
                "from NHANVIEN nv, TAIKHOAN tk " +
                "where nv.IDTAIKHOAN = tk.TAIKHOANID AND tk.USERNAME = '" + username + "'";


            DataTable Name = new DataTable();
            SqlDataAdapter adt2 = new SqlDataAdapter(get_name, cnn);
            adt2.Fill(Name);
            string name = Name.Rows[0][0].ToString();

            DataTable dtSoDH = new DataTable();
            SqlDataAdapter adt3 = new SqlDataAdapter(get_soDH, cnn);
            adt3.Fill(dtSoDH);
            string SoDH = dtSoDH.Rows[0][0].ToString();

            DataTable DSBH = new DataTable();
            SqlDataAdapter adt5 = new SqlDataAdapter(get_DSBH, cnn);
            adt5.Fill(DSBH);
            string sDSBH = DSBH.Rows[0][0].ToString();

            DataTable Thuong = new DataTable();
            SqlDataAdapter adt6 = new SqlDataAdapter(get_Thuong, cnn);
            adt6.Fill(Thuong);
            string sThuong = Thuong.Rows[0][0].ToString();

            DataTable Luong = new DataTable();
            SqlDataAdapter adt7 = new SqlDataAdapter(get_Luong, cnn);
            adt7.Fill(Luong);
            string sLuong = Luong.Rows[0][0].ToString();

            DataTable ChucVu = new DataTable();
            SqlDataAdapter adt8 = new SqlDataAdapter(get_ChucVu, cnn);
            adt8.Fill(ChucVu);
            string sChucVu = ChucVu.Rows[0][0].ToString();

            name1_label.Text = "Tên nhân viên: " + name;
            ChucVu_label.Text = "Chức vụ: " + sChucVu;
            name_label.Text = "Hi "+ name;
            SoDH_label.Text = "Số đơn hàng đã bán: " + SoDH;
            DSBH_label.Text = "Doanh số bán hàng: " + sDSBH;
            Thuong_label.Text = "Thưởng: " + sThuong;
            Luong_label.Text = "Lương: " + sLuong;

            string dd = "select DIEMDANH " +
                "from NHANVIEN nv, TAIKHOAN tk " +
                "where nv.IDTAIKHOAN = tk.TAIKHOANID AND tk.USERNAME = '" + username + "'";

            DataTable DiemDanh = new DataTable();
            SqlDataAdapter adt4 = new SqlDataAdapter(dd, cnn);
            adt4.Fill(DiemDanh);
            string count = DiemDanh.Rows[0][0].ToString();

            this.SoNDD_label.Text = "Số ngày đã điểm danh: " + count;


        }

        private void NhanVien_Closing(object sender, CancelEventArgs e)
        {
            this.DN.Show();
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {

        }

        private void DiemDanh_btn_Click(object sender, EventArgs e)
        {
           
            cnn.Open();
            SqlCommand sc = new SqlCommand("EXEC DiemDanh '" + username + "'", cnn);
            sc.ExecuteNonQuery();
            string dd = "select DIEMDANH " +
                "from NHANVIEN nv, TAIKHOAN tk " +
                "where nv.IDTAIKHOAN = tk.TAIKHOANID AND tk.USERNAME = '" + username + "'";
  
            DataTable DiemDanh = new DataTable();
            SqlDataAdapter adt = new SqlDataAdapter(dd, cnn);
            adt.Fill(DiemDanh);
            string count = DiemDanh.Rows[0][0].ToString();

            MessageBox.Show("Điểm danh thành công!!! \n" + "Tháng này bạn đã điểm danh " + count + " lần");
            DiemDanh_btn.Hide();
            DaDiemDanh.Show();
            this.SoNDD_label.Text = "Số ngày đã điểm danh: " + count;
            cnn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
 
        }

        private void SoDH_listView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void XemCTDH_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            NhanVien_CTDHDaBan nvct1 = new NhanVien_CTDHDaBan(this, this.cnn, username);
            nvct1.Show();
        }
    }
}
