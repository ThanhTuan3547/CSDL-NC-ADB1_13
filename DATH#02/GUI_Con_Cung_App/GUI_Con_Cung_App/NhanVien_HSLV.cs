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
    public partial class NhanVien_HSLV : Form
    {
        private QuanLi ql;
        private SqlConnection cnn;
        private string username;
        public NhanVien_HSLV(QuanLi ql, SqlConnection cnn, string username)
        {
            this.cnn = cnn;
            this.ql = ql;
            this.username = username;
            InitializeComponent();
            this.Closing += NhanVien_HSLV_Closing;
            HSLV_dataGridView.DataSource = HSLV().Tables[0];
        }

        DataSet HSLV()
        {
            DataSet data = new DataSet();
            string query = "select nv.MANV as 'Mã nhân viên' , nv.TENNV as 'Tên Nhân Viên', nv.DIEMDANH as 'Số ngày đi làm' "
                            + "from  NHANVIEN nv, TAIKHOAN tk "
                            + "where nv.IDTAIKHOAN = tk.TAIKHOANID";

            this.cnn.Open();
            SqlDataAdapter adt = new SqlDataAdapter(query, cnn);
            adt.Fill(data);
            this.cnn.Close();

            return data;

        }
        private void NhanVien_HSLV_Closing(object sender, CancelEventArgs e)
        {
            this.ql.Show();
        }

        private void NhanVien_HSLV_Load(object sender, EventArgs e)
        {

        }

        private void HSLV_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
