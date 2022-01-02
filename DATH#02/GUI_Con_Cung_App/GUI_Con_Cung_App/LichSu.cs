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
    public partial class LichSu : Form
    {
        private GioHang giohang;
        private SqlConnection sqlCon;
        public LichSu(GioHang giohang, SqlConnection sqlCon)
        {
            this.giohang = giohang;
            this.sqlCon = sqlCon;
            InitializeComponent();

            dataGridView1.ReadOnly = true;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;


            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].DataPropertyName = "TenSP";
            dataGridView1.Columns[1].DataPropertyName = "Gia";
            dataGridView1.Columns[2].DataPropertyName = "SoLuong";
            dataGridView1.Columns[3].DataPropertyName = "NgayMua";
            dataGridView1.Columns[4].DataPropertyName = "ThanhTien";

            // lấy dữ liệu từ sql 

            //string query = "exec"
        }
    }
}
