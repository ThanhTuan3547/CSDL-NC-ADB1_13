
namespace WindowsFormsApp2_reporting
{
    partial class MainMenu
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
            this.btnThemMoiHoaDon = new System.Windows.Forms.Button();
            this.btnXemDSHoaDon = new System.Windows.Forms.Button();
            this.btnThongKeDoanhThuTheoThang = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnThemMoiHoaDon
            // 
            this.btnThemMoiHoaDon.Location = new System.Drawing.Point(304, 77);
            this.btnThemMoiHoaDon.Name = "btnThemMoiHoaDon";
            this.btnThemMoiHoaDon.Size = new System.Drawing.Size(241, 50);
            this.btnThemMoiHoaDon.TabIndex = 0;
            this.btnThemMoiHoaDon.Text = "THÊM MỚI HÓA ĐƠN";
            this.btnThemMoiHoaDon.UseVisualStyleBackColor = true;
            this.btnThemMoiHoaDon.Click += new System.EventHandler(this.btnThemMoiHoaDon_Click);
            // 
            // btnXemDSHoaDon
            // 
            this.btnXemDSHoaDon.Location = new System.Drawing.Point(304, 144);
            this.btnXemDSHoaDon.Name = "btnXemDSHoaDon";
            this.btnXemDSHoaDon.Size = new System.Drawing.Size(241, 50);
            this.btnXemDSHoaDon.TabIndex = 1;
            this.btnXemDSHoaDon.Text = "XEM DANH SÁCH HÓA ĐƠN";
            this.btnXemDSHoaDon.UseVisualStyleBackColor = true;
            this.btnXemDSHoaDon.Click += new System.EventHandler(this.btnXemDSHoaDon_Click);
            // 
            // btnThongKeDoanhThuTheoThang
            // 
            this.btnThongKeDoanhThuTheoThang.Location = new System.Drawing.Point(304, 219);
            this.btnThongKeDoanhThuTheoThang.Name = "btnThongKeDoanhThuTheoThang";
            this.btnThongKeDoanhThuTheoThang.Size = new System.Drawing.Size(241, 50);
            this.btnThongKeDoanhThuTheoThang.TabIndex = 2;
            this.btnThongKeDoanhThuTheoThang.Text = "THỐNG KÊ DOANH THU THEO THÁNG";
            this.btnThongKeDoanhThuTheoThang.UseVisualStyleBackColor = true;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThongKeDoanhThuTheoThang);
            this.Controls.Add(this.btnXemDSHoaDon);
            this.Controls.Add(this.btnThemMoiHoaDon);
            this.Name = "MainMenu";
            this.Text = "Quan Ly Don Hang";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnThemMoiHoaDon;
        private System.Windows.Forms.Button btnXemDSHoaDon;
        private System.Windows.Forms.Button btnThongKeDoanhThuTheoThang;
    }
}