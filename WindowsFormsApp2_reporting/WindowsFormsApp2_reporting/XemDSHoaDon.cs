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
            
            dataGridView1.DataSource = LayToanBoHoaDon().Tables[0];


        }
        DataSet LayToanBoHoaDon()
        {
            DataSet data = new DataSet();
            string query = "select * from HoaDon";
            using (SqlConnection connection = new SqlConnection())
            {
                sc.Open();
                SqlDataAdapter adt = new SqlDataAdapter(query, sc);
                adt.Fill(data);
                sc.Close();

            }
            return data;
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Hide();
            formList._f0.Show();
        }
    }
}
