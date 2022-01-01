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
            this.hello = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DiemDanh_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hello
            // 
            this.hello.AutoSize = true;
            this.hello.Location = new System.Drawing.Point(327, 9);
            this.hello.Name = "hello";
            this.hello.Size = new System.Drawing.Size(49, 13);
            this.hello.TabIndex = 0;
            this.hello.Text = "Xin chào";
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
            this.DiemDanh_btn.Location = new System.Drawing.Point(320, 38);
            this.DiemDanh_btn.Name = "DiemDanh_btn";
            this.DiemDanh_btn.Size = new System.Drawing.Size(72, 32);
            this.DiemDanh_btn.TabIndex = 2;
            this.DiemDanh_btn.Text = "Điểm danh";
            this.DiemDanh_btn.UseVisualStyleBackColor = true;
            this.DiemDanh_btn.Click += new System.EventHandler(this.DiemDanh_btn_Click);
            // 
            // NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 235);
            this.Controls.Add(this.DiemDanh_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hello);
            this.Name = "NhanVien";
            this.Text = "NhanVien";
            this.Load += new System.EventHandler(this.NhanVien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hello;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DiemDanh_btn;
    }
}