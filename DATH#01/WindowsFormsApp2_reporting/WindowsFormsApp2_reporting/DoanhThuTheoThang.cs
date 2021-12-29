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
    public partial class DoanhThuTheoThang : Form
    {
        public DoanhThuTheoThang()
        {
            InitializeComponent();
        }
        SqlConnection sc = new SqlConnection(@"Data Source=LAPTOP-FMCUOBFE\SQLEXPRESS;Initial Catalog=ADB1_N13_DATH#01;Integrated Security=True");
        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Hide();
            formList._f0.Show();
        }

        private void btnXemDoanhThu_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = XemDoanhThuThang().Tables[0];
        }

        DataSet XemDoanhThuThang() // lay doanh thu theo tung thang
        {
            DataSet data = new DataSet();

            if (comboBox1.Text == "2020")
            {
                string query = "EXEC DTTT2020";
                sc.Open();
                SqlDataAdapter adt = new SqlDataAdapter(query, sc);
                adt.Fill(data);
                sc.Close();

            }
            if (comboBox1.Text == "2021")
            {
                string query = "EXEC DTTT2021";
                
                sc.Open();
                SqlDataAdapter adt = new SqlDataAdapter(query, sc);
                adt.Fill(data);
                sc.Close();

            }

            return data;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
    }
}
