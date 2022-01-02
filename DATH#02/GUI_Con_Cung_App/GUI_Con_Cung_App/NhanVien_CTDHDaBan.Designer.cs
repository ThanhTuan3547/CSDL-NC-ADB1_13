
namespace GUI_Con_Cung_App
{
    partial class NhanVien_CTDHDaBan
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
            this.DHDB_dataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DHDB_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DHDB_dataGridView
            // 
            this.DHDB_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DHDB_dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.DHDB_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DHDB_dataGridView.Location = new System.Drawing.Point(12, 37);
            this.DHDB_dataGridView.Name = "DHDB_dataGridView";
            this.DHDB_dataGridView.Size = new System.Drawing.Size(696, 275);
            this.DHDB_dataGridView.TabIndex = 0;
            this.DHDB_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DHDB_dataGridView_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(225, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Các đơn hàng đã bán";
            // 
            // NhanVien_CTDHDaBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 324);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DHDB_dataGridView);
            this.Name = "NhanVien_CTDHDaBan";
            this.Text = "NhanVien_CTDHDaBan";
            this.Load += new System.EventHandler(this.NhanVien_CTDHDaBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DHDB_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DHDB_dataGridView;
        private System.Windows.Forms.Label label1;
    }
}