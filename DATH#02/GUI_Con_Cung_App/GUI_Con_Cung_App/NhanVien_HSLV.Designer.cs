
namespace GUI_Con_Cung_App
{
    partial class NhanVien_HSLV
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
            this.HSLV_dataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.HSLV_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // HSLV_dataGridView
            // 
            this.HSLV_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.HSLV_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HSLV_dataGridView.Location = new System.Drawing.Point(12, 37);
            this.HSLV_dataGridView.Name = "HSLV_dataGridView";
            this.HSLV_dataGridView.Size = new System.Drawing.Size(476, 255);
            this.HSLV_dataGridView.TabIndex = 0;
            this.HSLV_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.HSLV_dataGridView_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(166, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hiệu suất làm việc";
            // 
            // NhanVien_HSLV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 304);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HSLV_dataGridView);
            this.Name = "NhanVien_HSLV";
            this.Text = "NhanVien_HSLV";
            this.Load += new System.EventHandler(this.NhanVien_HSLV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HSLV_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView HSLV_dataGridView;
        private System.Windows.Forms.Label label1;
    }
}