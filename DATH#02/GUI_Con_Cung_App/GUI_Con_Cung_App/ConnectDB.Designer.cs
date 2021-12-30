
namespace GUI_Con_Cung_App
{
    partial class ConnectDB
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
            this.Server_textBox = new System.Windows.Forms.TextBox();
            this.Database_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Connect_Button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Server_textBox
            // 
            this.Server_textBox.Location = new System.Drawing.Point(83, 72);
            this.Server_textBox.Name = "Server_textBox";
            this.Server_textBox.Size = new System.Drawing.Size(164, 20);
            this.Server_textBox.TabIndex = 0;
            // 
            // Database_textBox
            // 
            this.Database_textBox.Location = new System.Drawing.Point(83, 98);
            this.Database_textBox.Name = "Database_textBox";
            this.Database_textBox.Size = new System.Drawing.Size(164, 20);
            this.Database_textBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "SERVER";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "DATABASE";
            // 
            // Connect_Button
            // 
            this.Connect_Button.Location = new System.Drawing.Point(253, 72);
            this.Connect_Button.Name = "Connect_Button";
            this.Connect_Button.Size = new System.Drawing.Size(70, 46);
            this.Connect_Button.TabIndex = 4;
            this.Connect_Button.Text = "CONNECT";
            this.Connect_Button.UseVisualStyleBackColor = true;
            this.Connect_Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Good Times Rg", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "CONNECT DATABASE";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // ConnectDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 159);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Connect_Button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Database_textBox);
            this.Controls.Add(this.Server_textBox);
            this.Name = "ConnectDB";
            this.Text = "ConnectDB";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Server_textBox;
        private System.Windows.Forms.TextBox Database_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Connect_Button;
        private System.Windows.Forms.Label label3;
    }
}