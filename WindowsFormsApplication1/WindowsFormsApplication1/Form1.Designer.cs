namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.label4 = new System.Windows.Forms.Label();
            this.txt_SoHang1 = new System.Windows.Forms.TextBox();
            this.txt_SoHang2 = new System.Windows.Forms.TextBox();
            this.txt_KetQua = new System.Windows.Forms.TextBox();
            this.btn_Cong = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(398, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chuong trinh cong hai so";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(364, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "số hạng 1:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(367, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "số hạng 2:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(367, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Kết quả";
            // 
            // txt_SoHang1
            // 
            this.txt_SoHang1.Location = new System.Drawing.Point(487, 114);
            this.txt_SoHang1.Name = "txt_SoHang1";
            this.txt_SoHang1.Size = new System.Drawing.Size(100, 20);
            this.txt_SoHang1.TabIndex = 7;
            this.txt_SoHang1.TextChanged += new System.EventHandler(this.txt_SoHang1_TextChanged);
            // 
            // txt_SoHang2
            // 
            this.txt_SoHang2.Location = new System.Drawing.Point(487, 167);
            this.txt_SoHang2.Name = "txt_SoHang2";
            this.txt_SoHang2.Size = new System.Drawing.Size(100, 20);
            this.txt_SoHang2.TabIndex = 8;
            // 
            // txt_KetQua
            // 
            this.txt_KetQua.Location = new System.Drawing.Point(487, 238);
            this.txt_KetQua.Name = "txt_KetQua";
            this.txt_KetQua.Size = new System.Drawing.Size(100, 20);
            this.txt_KetQua.TabIndex = 9;
            // 
            // btn_Cong
            // 
            this.btn_Cong.Location = new System.Drawing.Point(503, 203);
            this.btn_Cong.Name = "btn_Cong";
            this.btn_Cong.Size = new System.Drawing.Size(66, 20);
            this.btn_Cong.TabIndex = 10;
            this.btn_Cong.Text = "button";
            this.btn_Cong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Cong.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 401);
            this.Controls.Add(this.btn_Cong);
            this.Controls.Add(this.txt_KetQua);
            this.Controls.Add(this.txt_SoHang2);
            this.Controls.Add(this.txt_SoHang1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_SoHang1;
        private System.Windows.Forms.TextBox txt_SoHang2;
        private System.Windows.Forms.TextBox txt_KetQua;
        private System.Windows.Forms.TextBox btn_Cong;
    }
}

