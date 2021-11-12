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

namespace WindowsFormsApp2_reporting
{
    public partial class XemDSHoaDon : Form
    {
        public XemDSHoaDon()
        {
            InitializeComponent();
        }
        SqlConnection sc = new SqlConnection(@"Data Source=LAPTOP-FMCUOBFE\SQLEXPRESS;Initial Catalog=ADB_DA1;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter adt = new SqlDataAdapter("select * from HOADON", sc);

            adt.Fill(ds,"HOADON");

            dataGridView1.DataSource = ds.Tables[0];


        }
    }
}
