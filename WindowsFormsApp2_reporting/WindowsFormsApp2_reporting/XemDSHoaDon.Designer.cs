﻿
namespace WindowsFormsApp2_reporting
{
    partial class XemDSHoaDon
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.aDB_DA1DataSet = new WindowsFormsApp2_reporting.ADB_DA1DataSet();
            this.aDBDA1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDB_DA1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDBDA1DataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(247, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(280, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "Xem Danh Sách Hóa Đơn";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.aDBDA1DataSetBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(81, 129);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(621, 263);
            this.dataGridView1.TabIndex = 1;
            // 
            // aDB_DA1DataSet
            // 
            this.aDB_DA1DataSet.DataSetName = "ADB_DA1DataSet";
            this.aDB_DA1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aDBDA1DataSetBindingSource
            // 
            this.aDBDA1DataSetBindingSource.DataSource = this.aDB_DA1DataSet;
            this.aDBDA1DataSetBindingSource.Position = 0;
            // 
            // XemDSHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "XemDSHoaDon";
            this.Text = "Quan Ly Don Hang";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDB_DA1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDBDA1DataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource aDBDA1DataSetBindingSource;
        private ADB_DA1DataSet aDB_DA1DataSet;
    }
}