
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
            this.label1.Location = new System.Drawing.Point(31, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "USERNAME";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 99);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "PASSWORD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Good Times Rg", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(154, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "LOG IN";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TaiKhoan
            // 
            this.TaiKhoan.Location = new System.Drawing.Point(107, 72);
            this.TaiKhoan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TaiKhoan.Name = "TaiKhoan";
            this.TaiKhoan.Size = new System.Drawing.Size(186, 20);
            this.TaiKhoan.TabIndex = 3;
            // 
            // MatKhau
            // 
            this.MatKhau.Location = new System.Drawing.Point(107, 96);
            this.MatKhau.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MatKhau.MaxLength = 20;
            this.MatKhau.Name = "MatKhau";
            this.MatKhau.PasswordChar = '*';
            this.MatKhau.Size = new System.Drawing.Size(186, 20);
            this.MatKhau.TabIndex = 4;
            // 
            // buttton_DangNhap
            // 
            this.buttton_DangNhap.Location = new System.Drawing.Point(308, 72);
            this.buttton_DangNhap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttton_DangNhap.Name = "buttton_DangNhap";
            this.buttton_DangNhap.Size = new System.Drawing.Size(60, 44);
            this.buttton_DangNhap.TabIndex = 5;
            this.buttton_DangNhap.Text = "LOG IN";
            this.buttton_DangNhap.UseVisualStyleBackColor = true;
            this.buttton_DangNhap.Click += new System.EventHandler(this.buttton_DangNhap_Click);
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 154);
            this.Controls.Add(this.buttton_DangNhap);
            this.Controls.Add(this.MatKhau);
            this.Controls.Add(this.TaiKhoan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DangNhap";
            this.Text = "LOG IN";
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

