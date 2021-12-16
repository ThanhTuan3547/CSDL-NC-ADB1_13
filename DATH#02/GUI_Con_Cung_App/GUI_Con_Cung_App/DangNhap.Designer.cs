
namespace GUI_Con_Cung_App
{
    partial class DangNhap
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TaiKhoan = new System.Windows.Forms.TextBox();
            this.MatKhau = new System.Windows.Forms.TextBox();
            this.buttton_DangNhap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(222, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài Khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật Khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(356, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "ĐĂNG NHẬP";
            // 
            // TaiKhoan
            // 
            this.TaiKhoan.Location = new System.Drawing.Point(322, 128);
            this.TaiKhoan.Name = "TaiKhoan";
            this.TaiKhoan.Size = new System.Drawing.Size(163, 22);
            this.TaiKhoan.TabIndex = 3;
            // 
            // MatKhau
            // 
            this.MatKhau.Location = new System.Drawing.Point(322, 169);
            this.MatKhau.MaxLength = 20;
            this.MatKhau.Name = "MatKhau";
            this.MatKhau.PasswordChar = '*';
            this.MatKhau.Size = new System.Drawing.Size(163, 22);
            this.MatKhau.TabIndex = 4;
            // 
            // buttton_DangNhap
            // 
            this.buttton_DangNhap.Location = new System.Drawing.Point(322, 233);
            this.buttton_DangNhap.Name = "buttton_DangNhap";
            this.buttton_DangNhap.Size = new System.Drawing.Size(124, 30);
            this.buttton_DangNhap.TabIndex = 5;
            this.buttton_DangNhap.Text = "ĐĂNG NHẬP";
            this.buttton_DangNhap.UseVisualStyleBackColor = true;
            this.buttton_DangNhap.Click += new System.EventHandler(this.buttton_DangNhap_Click);
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttton_DangNhap);
            this.Controls.Add(this.MatKhau);
            this.Controls.Add(this.TaiKhoan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DangNhap";
            this.Text = "Đăng Nhập";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TaiKhoan;
        private System.Windows.Forms.TextBox MatKhau;
        private System.Windows.Forms.Button buttton_DangNhap;
    }
}

