
namespace GUI_Con_Cung_App
{
    partial class GioHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.ChiTietDonHang = new System.Windows.Forms.DataGridView();
            this.SDT = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.DiaChi = new System.Windows.Forms.Label();
            this.HT_ThanhToan = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_DatHang = new System.Windows.Forms.Button();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ChiTietDonHang)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(296, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "THANH TOÁN";
            // 
            // ChiTietDonHang
            // 
            this.ChiTietDonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ChiTietDonHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSP,
            this.TenSP,
            this.SoLuong,
            this.Gia,
            this.ThanhTien});
            this.ChiTietDonHang.Location = new System.Drawing.Point(100, 29);
            this.ChiTietDonHang.Name = "ChiTietDonHang";
            this.ChiTietDonHang.RowHeadersWidth = 51;
            this.ChiTietDonHang.RowTemplate.Height = 24;
            this.ChiTietDonHang.Size = new System.Drawing.Size(517, 150);
            this.ChiTietDonHang.TabIndex = 1;
            this.ChiTietDonHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ChiTietDonHang_CellContentClick);
            // 
            // SDT
            // 
            this.SDT.AutoSize = true;
            this.SDT.Location = new System.Drawing.Point(97, 225);
            this.SDT.Name = "SDT";
            this.SDT.Size = new System.Drawing.Size(108, 17);
            this.SDT.TabIndex = 2;
            this.SDT.Text = "SĐT nhận hàng";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(361, 222);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 22);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(361, 252);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(120, 22);
            this.textBox2.TabIndex = 4;
            // 
            // DiaChi
            // 
            this.DiaChi.AutoSize = true;
            this.DiaChi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DiaChi.Location = new System.Drawing.Point(97, 255);
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Size = new System.Drawing.Size(123, 17);
            this.DiaChi.TabIndex = 5;
            this.DiaChi.Text = "Địa chỉ nhận hàng";
            // 
            // HT_ThanhToan
            // 
            this.HT_ThanhToan.AutoSize = true;
            this.HT_ThanhToan.Location = new System.Drawing.Point(97, 289);
            this.HT_ThanhToan.Name = "HT_ThanhToan";
            this.HT_ThanhToan.Size = new System.Drawing.Size(140, 17);
            this.HT_ThanhToan.TabIndex = 6;
            this.HT_ThanhToan.Text = "Hình thức thanh toán";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "Thanh toán khi nhận hàng",
            "Momo ",
            "Visa ",
            "Internet Banking"});
            this.listBox1.Location = new System.Drawing.Point(361, 289);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 20);
            this.listBox1.TabIndex = 7;
            // 
            // btn_DatHang
            // 
            this.btn_DatHang.Location = new System.Drawing.Point(299, 345);
            this.btn_DatHang.Name = "btn_DatHang";
            this.btn_DatHang.Size = new System.Drawing.Size(151, 23);
            this.btn_DatHang.TabIndex = 8;
            this.btn_DatHang.Text = "ĐẶT HÀNG";
            this.btn_DatHang.UseVisualStyleBackColor = true;
            this.btn_DatHang.Click += new System.EventHandler(this.btn_DatHang_Click);
            // 
            // MaSP
            // 
            this.MaSP.HeaderText = "Mã sản phẩm";
            this.MaSP.MinimumWidth = 6;
            this.MaSP.Name = "MaSP";
            this.MaSP.ReadOnly = true;
            this.MaSP.Width = 125;
            // 
            // TenSP
            // 
            this.TenSP.HeaderText = "Tên sản phẩm";
            this.TenSP.MinimumWidth = 6;
            this.TenSP.Name = "TenSP";
            this.TenSP.ReadOnly = true;
            this.TenSP.Width = 125;
            // 
            // SoLuong
            // 
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            this.SoLuong.Width = 125;
            // 
            // Gia
            // 
            this.Gia.HeaderText = "Giá";
            this.Gia.MinimumWidth = 6;
            this.Gia.Name = "Gia";
            this.Gia.ReadOnly = true;
            this.Gia.Width = 125;
            // 
            // ThanhTien
            // 
            this.ThanhTien.HeaderText = "Thành tiền";
            this.ThanhTien.MinimumWidth = 6;
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.ReadOnly = true;
            this.ThanhTien.Width = 125;
            // 
            // GioHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_DatHang);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.HT_ThanhToan);
            this.Controls.Add(this.DiaChi);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.SDT);
            this.Controls.Add(this.ChiTietDonHang);
            this.Controls.Add(this.label1);
            this.Name = "GioHang";
            this.Text = "Giỏ Hàng";
            ((System.ComponentModel.ISupportInitialize)(this.ChiTietDonHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ChiTietDonHang;
        private System.Windows.Forms.Label SDT;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label DiaChi;
        private System.Windows.Forms.Label HT_ThanhToan;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_DatHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
    }
}