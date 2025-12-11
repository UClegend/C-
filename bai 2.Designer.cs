namespace WindowsFormsApplication2
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
            this.txt_SoHang1 = new System.Windows.Forms.TextBox();
            this.txt_SoHang2 = new System.Windows.Forms.TextBox();
            this.txt_KetQua = new System.Windows.Forms.TextBox();
            this.btn_Cong = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_SoHang1
            // 
            this.txt_SoHang1.Location = new System.Drawing.Point(597, 119);
            this.txt_SoHang1.Name = "txt_SoHang1";
            this.txt_SoHang1.Size = new System.Drawing.Size(100, 20);
            this.txt_SoHang1.TabIndex = 0;
            // 
            // txt_SoHang2
            // 
            this.txt_SoHang2.Location = new System.Drawing.Point(597, 160);
            this.txt_SoHang2.Name = "txt_SoHang2";
            this.txt_SoHang2.Size = new System.Drawing.Size(100, 20);
            this.txt_SoHang2.TabIndex = 1;
            // 
            // txt_KetQua
            // 
            this.txt_KetQua.Location = new System.Drawing.Point(597, 250);
            this.txt_KetQua.Name = "txt_KetQua";
            this.txt_KetQua.Size = new System.Drawing.Size(100, 20);
            this.txt_KetQua.TabIndex = 3;
            // 
            // btn_Cong
            // 
            this.btn_Cong.Location = new System.Drawing.Point(610, 210);
            this.btn_Cong.Name = "btn_Cong";
            this.btn_Cong.Size = new System.Drawing.Size(75, 23);
            this.btn_Cong.TabIndex = 4;
            this.btn_Cong.Text = "Cộng";
            this.btn_Cong.UseVisualStyleBackColor = true;
            this.btn_Cong.Click += new System.EventHandler(this.btn_Cong_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(540, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Chương trình cộng hai số";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(497, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "số hạng 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(497, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "số hạng 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(497, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Kết quả";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 371);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Cong);
            this.Controls.Add(this.txt_KetQua);
            this.Controls.Add(this.txt_SoHang2);
            this.Controls.Add(this.txt_SoHang1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_SoHang1;
        private System.Windows.Forms.TextBox txt_SoHang2;
        private System.Windows.Forms.TextBox txt_KetQua;
        private System.Windows.Forms.Button btn_Cong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

