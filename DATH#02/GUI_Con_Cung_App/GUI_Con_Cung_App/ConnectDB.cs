using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Con_Cung_App
{
    public partial class ConnectDB : Form
    {
        public ConnectDB()
        {
            InitializeComponent();
            Server_textBox.Text = "PIKACHU\\PIKACHU";
            //Server_textBox.Text = "PIKACHU\\PIKACHU";
            Database_textBox.Text = "ADB1_N13_DATH#02";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString;
            SqlConnection cnn;
            // build connection string to sql
            connectionString = @"Data Source=";
            connectionString += Server_textBox.Text + ";Initial Catalog=" + Database_textBox.Text + ";Integrated Security=True";
            //System.Diagnostics.Debug.WriteLine(connectionString);
            try
            {
                cnn = new SqlConnection(connectionString);
                //cnn.Open();
                //this.Hide();
                cnn.Open();
                if (cnn.State == ConnectionState.Open)
                {
                    MessageBox.Show("Connected");
                    // open new form Interface()
                    this.Hide();
                    DangNhap DangNhap1 = new DangNhap(this, cnn);
                    DangNhap1.Show();
                }
                else
                {
                    MessageBox.Show("Connect Failed");
                   
                }


            }
            catch
            {// do nothing }

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
