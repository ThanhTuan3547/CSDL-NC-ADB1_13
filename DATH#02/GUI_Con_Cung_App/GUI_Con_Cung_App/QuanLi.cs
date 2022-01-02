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
    public partial class QuanLi : Form
    {
        private DangNhap DN;
        private SqlConnection cnn;
        private string username;
        public QuanLi(DangNhap DN, SqlConnection cnn, string username)
        {
            this.cnn = cnn;
            this.DN = DN;
            this.username = username;
            InitializeComponent();
            this.FormClosing += QuanLi_FormClosing;

            DaDiemDanh.Hide();

        }

        private void QuanLi_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DN.Show();
        }

        private void QuanLi_Load(object sender, EventArgs e)
        {

        }

        private void DTOn_btn_Click(object sender, EventArgs e)
        {
            cnn.Open();
            string qDTOn = "SELECT ((SELECT SUM(TONGTIEN) FROM HOADONONLINE) - (SELECT SUM(PHIVANCHUYEN) FROM HOADONONLINE))";

            DataTable DTOn = new DataTable();
            SqlDataAdapter adt = new SqlDataAdapter(qDTOn, cnn);
            adt.Fill(DTOn);
            string sDTOn = DTOn.Rows[0][0].ToString();

            DTOn_textBox.Text = sDTOn;
            DTOn_textBox.ReadOnly = true;
            DTOn_textBox.BackColor = System.Drawing.SystemColors.Window;

            cnn.Close();
        }

        private void DTOff_btn_Click(object sender, EventArgs e)
        {
            cnn.Open();
            string qDTOff = "SELECT SUM(TONGTIEN) FROM HOADONOFFLINE";

            DataTable DTOff = new DataTable();
            SqlDataAdapter adt = new SqlDataAdapter(qDTOff, cnn);
            adt.Fill(DTOff);
            string sDTOff = DTOff.Rows[0][0].ToString();

            DTOff_textBox.Text = sDTOff;
            DTOff_textBox.ReadOnly = true;
            DTOff_textBox.BackColor = System.Drawing.SystemColors.Window;

            cnn.Close();
        }

        private void SDT_btn_Click(object sender, EventArgs e)
        {
            cnn.Open();
            string qSDT = "SELECT ((SELECT SUM(TONGTIEN) FROM HOADONONLINE) + (SELECT SUM(TONGTIEN) FROM HOADONOFFLINE) - (SELECT SUM(PHIVANCHUYEN) FROM HOADONONLINE))";

            DataTable SDT = new DataTable();
            SqlDataAdapter adt = new SqlDataAdapter(qSDT, cnn);
            adt.Fill(SDT);
            string sSDT = SDT.Rows[0][0].ToString();

            SDT_textBox.Text = sSDT;
            SDT_textBox.ReadOnly = true;
            SDT_textBox.BackColor = System.Drawing.SystemColors.Window;

            cnn.Close();
        }


        private void DiemDanh_btn_Click_1(object sender, EventArgs e)
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

        private void DTOff_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void HS_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            NhanVien_HSLV hslv1 = new NhanVien_HSLV(this, this.cnn, username);
            hslv1.Show();
        }

        private void SPbanchay_btn_Click(object sender, EventArgs e)
        {
            SP_dataGridView.DataSource =SPbanchay().Tables[0];
        }

        DataSet SPbanchay()
        {
            DataSet data = new DataSet();
            string query = "SELECT TOP 10 SP.MASP AS 'Mã sản phẩm', TENSP AS 'Tên sản phẩm', SUM(CTHDoff.SOLUONG + CTHDon.SOLUONG)  AS 'Số lượng đã bán' "
                            + "FROM CTHOADONONLINE CTHDon, SANPHAM SP, CTHOADONOFFLINE CTHDoff "
                            +"WHERE CTHDon.MASP = SP.MASP AND CTHDoff.MASP = SP.MASP "
                            +"GROUP BY SP.MASP, TENSP "
                            +"ORDER BY SUM(CTHDoff.SOLUONG +CTHDon.SOLUONG) DESC";

            this.cnn.Open();
            SqlDataAdapter adt = new SqlDataAdapter(query, cnn);
            adt.Fill(data);
            this.cnn.Close();

            return data;

        }

        private void SPbancham_btn_Click(object sender, EventArgs e)
        {
            SP_dataGridView.DataSource = SPbancham().Tables[0];
        }

        DataSet SPbancham()
        {
            DataSet data = new DataSet();
            string query = "SELECT TOP 10 SP.MASP AS 'Mã sản phẩm', TENSP AS 'Tên sản phẩm', SUM(CTHDoff.SOLUONG + CTHDon.SOLUONG)  AS 'Số lượng đã bán' "
                            + "FROM CTHOADONONLINE CTHDon, SANPHAM SP, CTHOADONOFFLINE CTHDoff "
                            + "WHERE CTHDon.MASP = SP.MASP AND CTHDoff.MASP = SP.MASP "
                            + "GROUP BY SP.MASP, TENSP "
                            + "ORDER BY SUM(CTHDoff.SOLUONG +CTHDon.SOLUONG) ASC";

            this.cnn.Open();
            SqlDataAdapter adt = new SqlDataAdapter(query, cnn);
            adt.Fill(data);
            this.cnn.Close();

            return data;

        }
    }
}
