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
            this.Closing += NhanVien_Closing; ;
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

            MessageBox.Show("Điểm danh thành công \n" + "Tháng này bạn đã điểm danh " + count + " lần");
            DiemDanh_btn.Enabled = false;
            cnn.Close();
        }
    }
}
