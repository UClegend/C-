namespace bai_lap_trinh_huong_doi_tuong
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDai = new System.Windows.Forms.TextBox();
            this.txtRong = new System.Windows.Forms.TextBox();
            this.btnTinh = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblChuVi = new System.Windows.Forms.Label();
            this.lblDienTich = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(304, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "chiều rộng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(304, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "chiều dài:";
            // 
            // txtDai
            // 
            this.txtDai.Location = new System.Drawing.Point(403, 66);
            this.txtDai.Name = "txtDai";
            this.txtDai.Size = new System.Drawing.Size(136, 20);
            this.txtDai.TabIndex = 3;
            // 
            // txtRong
            // 
            this.txtRong.Location = new System.Drawing.Point(403, 105);
            this.txtRong.Name = "txtRong";
            this.txtRong.Size = new System.Drawing.Size(136, 20);
            this.txtRong.TabIndex = 4;
            // 
            // btnTinh
            // 
            this.btnTinh.Location = new System.Drawing.Point(425, 157);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(75, 23);
            this.btnTinh.TabIndex = 5;
            this.btnTinh.Text = "tính";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(304, 202);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(47, 13);
            this.lblInfo.TabIndex = 6;
            this.lblInfo.Text = "Kết quả:";
            // 
            // lblChuVi
            // 
            this.lblChuVi.AutoSize = true;
            this.lblChuVi.Location = new System.Drawing.Point(304, 236);
            this.lblChuVi.Name = "lblChuVi";
            this.lblChuVi.Size = new System.Drawing.Size(41, 13);
            this.lblChuVi.TabIndex = 7;
            this.lblChuVi.Text = "Chu Vi:";
            // 
            // lblDienTich
            // 
            this.lblDienTich.AutoSize = true;
            this.lblDienTich.Location = new System.Drawing.Point(303, 270);
            this.lblDienTich.Name = "lblDienTich";
            this.lblDienTich.Size = new System.Drawing.Size(54, 13);
            this.lblDienTich.TabIndex = 8;
            this.lblDienTich.Text = "Diện tích:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 468);
            this.Controls.Add(this.lblDienTich);
            this.Controls.Add(this.lblChuVi);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.txtRong);
            this.Controls.Add(this.txtDai);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDai;
        private System.Windows.Forms.TextBox txtRong;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblChuVi;
        private System.Windows.Forms.Label lblDienTich;
    }
}

