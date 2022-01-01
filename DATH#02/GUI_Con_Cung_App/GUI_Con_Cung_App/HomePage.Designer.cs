
namespace GUI_Con_Cung_App
{
    partial class HomePage
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
            this.input_TimKiem = new System.Windows.Forms.TextBox();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.DS_SanPham = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btn_GioHang = new System.Windows.Forms.Button();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLTon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mua = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DS_SanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // input_TimKiem
            // 
            this.input_TimKiem.Location = new System.Drawing.Point(230, 41);
            this.input_TimKiem.Name = "input_TimKiem";
            this.input_TimKiem.Size = new System.Drawing.Size(298, 22);
            this.input_TimKiem.TabIndex = 0;
            this.input_TimKiem.TextChanged += new System.EventHandler(this.input_TimKiem_TextChanged);
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Location = new System.Drawing.Point(561, 41);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(75, 23);
            this.btn_TimKiem.TabIndex = 1;
            this.btn_TimKiem.Text = "Tìm Kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            // 
            // DS_SanPham
            // 
            this.DS_SanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DS_SanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSP,
            this.TenSP,
            this.Gia,
            this.MoTa,
            this.SLTon,
            this.Mua});
            this.DS_SanPham.Location = new System.Drawing.Point(65, 130);
            this.DS_SanPham.Name = "DS_SanPham";
            this.DS_SanPham.RowHeadersWidth = 51;
            this.DS_SanPham.RowTemplate.Height = 24;
            this.DS_SanPham.Size = new System.Drawing.Size(653, 257);
            this.DS_SanPham.TabIndex = 3;
            this.DS_SanPham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DS_SanPham_CellContentClick);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Sữa bột cao cấp ",
            "Bỉm tã ",
            "Sữa tươi các loại ",
            "Ăn dặm, dinh dưỡng ",
            "Chăm sóc gia đình "});
            this.comboBox1.Location = new System.Drawing.Point(12, 28);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 4;
            // 
            // btn_GioHang
            // 
            this.btn_GioHang.Location = new System.Drawing.Point(680, 29);
            this.btn_GioHang.Name = "btn_GioHang";
            this.btn_GioHang.Size = new System.Drawing.Size(90, 34);
            this.btn_GioHang.TabIndex = 5;
            this.btn_GioHang.Text = "Giỏ hàng";
            this.btn_GioHang.UseVisualStyleBackColor = true;
            this.btn_GioHang.Click += new System.EventHandler(this.btn_GioHang_Click);
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
            this.TenSP.HeaderText = "Tên";
            this.TenSP.MinimumWidth = 6;
            this.TenSP.Name = "TenSP";
            this.TenSP.Width = 125;
            // 
            // Gia
            // 
            this.Gia.HeaderText = "Giá";
            this.Gia.MinimumWidth = 6;
            this.Gia.Name = "Gia";
            this.Gia.Width = 125;
            // 
            // MoTa
            // 
            this.MoTa.HeaderText = "Mô Tả";
            this.MoTa.MinimumWidth = 6;
            this.MoTa.Name = "MoTa";
            this.MoTa.Width = 125;
            // 
            // SLTon
            // 
            this.SLTon.HeaderText = "Số lượng tồn";
            this.SLTon.MinimumWidth = 6;
            this.SLTon.Name = "SLTon";
            this.SLTon.Width = 125;
            // 
            // Mua
            // 
            this.Mua.HeaderText = "Thêm Vào Giỏ";
            this.Mua.MinimumWidth = 6;
            this.Mua.Name = "Mua";
            this.Mua.ReadOnly = true;
            this.Mua.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Mua.Text = "Thêm";
            this.Mua.UseColumnTextForButtonValue = true;
            this.Mua.Width = 125;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_GioHang);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.DS_SanPham);
            this.Controls.Add(this.btn_TimKiem);
            this.Controls.Add(this.input_TimKiem);
            this.Name = "HomePage";
            this.Text = "HomePage";
            ((System.ComponentModel.ISupportInitialize)(this.DS_SanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input_TimKiem;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.DataGridView DS_SanPham;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btn_GioHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoTa;
        private System.Windows.Forms.DataGridViewTextBoxColumn SLTon;
        private System.Windows.Forms.DataGridViewButtonColumn Mua;
    }
}