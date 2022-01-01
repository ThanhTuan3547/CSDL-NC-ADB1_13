namespace GUI_Con_Cung_App
{
    partial class NhanVien
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
            this.DiemDanh_btn = new System.Windows.Forms.Button();
            this.XemCTDH_btn = new System.Windows.Forms.Button();
            this.DaDiemDanh = new System.Windows.Forms.Label();
            this.SoNDD_label = new System.Windows.Forms.Label();
            this.SoDH_label = new System.Windows.Forms.Label();
            this.name_label = new System.Windows.Forms.Label();
            this.DSBH_label = new System.Windows.Forms.Label();
            this.Thuong_label = new System.Windows.Forms.Label();
            this.Luong_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(382, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // DiemDanh_btn
            // 
            this.DiemDanh_btn.Location = new System.Drawing.Point(15, 9);
            this.DiemDanh_btn.Name = "DiemDanh_btn";
            this.DiemDanh_btn.Size = new System.Drawing.Size(72, 32);
            this.DiemDanh_btn.TabIndex = 2;
            this.DiemDanh_btn.Text = "Điểm danh";
            this.DiemDanh_btn.UseVisualStyleBackColor = true;
            this.DiemDanh_btn.Click += new System.EventHandler(this.DiemDanh_btn_Click);
            // 
            // XemCTDH_btn
            // 
            this.XemCTDH_btn.Location = new System.Drawing.Point(189, 91);
            this.XemCTDH_btn.Name = "XemCTDH_btn";
            this.XemCTDH_btn.Size = new System.Drawing.Size(60, 28);
            this.XemCTDH_btn.TabIndex = 3;
            this.XemCTDH_btn.Text = "Chi tiết";
            this.XemCTDH_btn.UseVisualStyleBackColor = true;
            this.XemCTDH_btn.Click += new System.EventHandler(this.XemCTDH_btn_Click);
            // 
            // DaDiemDanh
            // 
            this.DaDiemDanh.AutoSize = true;
            this.DaDiemDanh.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DaDiemDanh.ForeColor = System.Drawing.Color.ForestGreen;
            this.DaDiemDanh.Location = new System.Drawing.Point(12, 13);
            this.DaDiemDanh.Name = "DaDiemDanh";
            this.DaDiemDanh.Size = new System.Drawing.Size(107, 16);
            this.DaDiemDanh.TabIndex = 7;
            this.DaDiemDanh.Text = "Đã điểm danh";
            // 
            // SoNDD_label
            // 
            this.SoNDD_label.AutoSize = true;
            this.SoNDD_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoNDD_label.Location = new System.Drawing.Point(12, 70);
            this.SoNDD_label.Name = "SoNDD_label";
            this.SoNDD_label.Size = new System.Drawing.Size(55, 16);
            this.SoNDD_label.TabIndex = 9;
            this.SoNDD_label.Text = "SoNDD";
            // 
            // SoDH_label
            // 
            this.SoDH_label.AutoSize = true;
            this.SoDH_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoDH_label.Location = new System.Drawing.Point(12, 100);
            this.SoDH_label.Name = "SoDH_label";
            this.SoDH_label.Size = new System.Drawing.Size(45, 16);
            this.SoDH_label.TabIndex = 10;
            this.SoDH_label.Text = "SoDH";
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_label.Location = new System.Drawing.Point(330, 13);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(46, 16);
            this.name_label.TabIndex = 11;
            this.name_label.Text = "Name";
            // 
            // DSBH_label
            // 
            this.DSBH_label.AutoSize = true;
            this.DSBH_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DSBH_label.Location = new System.Drawing.Point(12, 130);
            this.DSBH_label.Name = "DSBH_label";
            this.DSBH_label.Size = new System.Drawing.Size(46, 16);
            this.DSBH_label.TabIndex = 12;
            this.DSBH_label.Text = "DSBH";
            // 
            // Thuong_label
            // 
            this.Thuong_label.AutoSize = true;
            this.Thuong_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Thuong_label.Location = new System.Drawing.Point(12, 160);
            this.Thuong_label.Name = "Thuong_label";
            this.Thuong_label.Size = new System.Drawing.Size(54, 16);
            this.Thuong_label.TabIndex = 13;
            this.Thuong_label.Text = "Thuong";
            // 
            // Luong_label
            // 
            this.Luong_label.AutoSize = true;
            this.Luong_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Luong_label.Location = new System.Drawing.Point(12, 190);
            this.Luong_label.Name = "Luong_label";
            this.Luong_label.Size = new System.Drawing.Size(45, 16);
            this.Luong_label.TabIndex = 14;
            this.Luong_label.Text = "Luong";
            // 
            // NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 235);
            this.Controls.Add(this.Luong_label);
            this.Controls.Add(this.Thuong_label);
            this.Controls.Add(this.DSBH_label);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.SoDH_label);
            this.Controls.Add(this.SoNDD_label);
            this.Controls.Add(this.DaDiemDanh);
            this.Controls.Add(this.XemCTDH_btn);
            this.Controls.Add(this.DiemDanh_btn);
            this.Controls.Add(this.label1);
            this.Name = "NhanVien";
            this.Text = "NhanVien";
            this.Load += new System.EventHandler(this.NhanVien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DiemDanh_btn;
        private System.Windows.Forms.Button XemCTDH_btn;
        private System.Windows.Forms.Label DaDiemDanh;
        private System.Windows.Forms.Label SoNDD_label;
        private System.Windows.Forms.Label SoDH_label;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label DSBH_label;
        private System.Windows.Forms.Label Thuong_label;
        private System.Windows.Forms.Label Luong_label;
    }
}