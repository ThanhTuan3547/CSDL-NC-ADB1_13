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
    public partial class NhanVien_CTDHDaBan : Form
    {
        private NhanVien nv;
        private SqlConnection cnn;
        private string username;
        public NhanVien_CTDHDaBan(NhanVien nv, SqlConnection cnn, string username)
        {
            this.cnn = cnn;
            this.nv = nv;
            this.username = username;
            InitializeComponent();
            this.Closing += NhanVien_CTDHDaBan_Closing;
            DHDB_dataGridView.DataSource = SoDH().Tables[0];
        }

        private void NhanVien_CTDHDaBan_Closing(object sender, CancelEventArgs e)
        {
            this.nv.Show();
        }

        private void NhanVien_CTDHDaBan_Load(object sender, EventArgs e)
        {

        }

        DataSet SoDH()
        {
            DataSet data = new DataSet();
            string query = "select hdoff.MANV as 'Mã nhân viên', nv.TENNV as 'Tên nhân viên', hdoff.MAHOADON as 'Mã hóa đơn', hdoff.MACN as 'Mã chi nhánh', hdoff.MAKH as 'Mã khách hàng', hdoff.TONGTIEN as 'Tổng tiền', hdoff.NGAYLAP as 'Ngày lập' "
                            + "from HOADONOFFLINE hdoff, NHANVIEN nv, TAIKHOAN tk "
                            + "where hdoff.MANV = nv.MANV AND nv.IDTAIKHOAN = tk.TAIKHOANID AND tk.USERNAME = '" + username + "'";

            this.cnn.Open();
            SqlDataAdapter adt = new SqlDataAdapter(query, cnn);
            adt.Fill(data);
            this.cnn.Close();

            return data;

        }

        private void DHDB_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
