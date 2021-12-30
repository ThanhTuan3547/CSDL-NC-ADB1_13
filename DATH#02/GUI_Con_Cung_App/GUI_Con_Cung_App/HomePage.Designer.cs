
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
            this.Menu = new System.Windows.Forms.ListBox();
            this.DS_SanPham = new System.Windows.Forms.DataGridView();
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
            // Menu
            // 
            this.Menu.FormattingEnabled = true;
            this.Menu.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.Menu.ItemHeight = 16;
            this.Menu.Items.AddRange(new object[] {
            "Sữa bột cao cấp ",
            "Bỉm tã khuyến mãi ",
            "Sữa tươi các loại"});
            this.Menu.Location = new System.Drawing.Point(13, 13);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(120, 20);
            this.Menu.TabIndex = 2;
            // 
            // DS_SanPham
            // 
            this.DS_SanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DS_SanPham.Location = new System.Drawing.Point(177, 129);
            this.DS_SanPham.Name = "DS_SanPham";
            this.DS_SanPham.RowHeadersWidth = 51;
            this.DS_SanPham.RowTemplate.Height = 24;
            this.DS_SanPham.Size = new System.Drawing.Size(459, 257);
            this.DS_SanPham.TabIndex = 3;
            this.DS_SanPham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DS_SanPham_CellContentClick);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DS_SanPham);
            this.Controls.Add(this.Menu);
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
        private System.Windows.Forms.ListBox Menu;
        private System.Windows.Forms.DataGridView DS_SanPham;
    }
}