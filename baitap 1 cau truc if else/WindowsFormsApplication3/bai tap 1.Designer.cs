namespace WindowsFormsApplication3
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
            this.lblDiem = new System.Windows.Forms.Label();
            this.txtDiem = new System.Windows.Forms.TextBox();
            this.btnXepLoai = new System.Windows.Forms.Button();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDiem
            // 
            this.lblDiem.AutoSize = true;
            this.lblDiem.Location = new System.Drawing.Point(300, 37);
            this.lblDiem.Name = "lblDiem";
            this.lblDiem.Size = new System.Drawing.Size(59, 13);
            this.lblDiem.TabIndex = 0;
            this.lblDiem.Text = "Nhập điểm";
            // 
            // txtDiem
            // 
            this.txtDiem.Location = new System.Drawing.Point(368, 34);
            this.txtDiem.Name = "txtDiem";
            this.txtDiem.Size = new System.Drawing.Size(167, 20);
            this.txtDiem.TabIndex = 1;
            this.txtDiem.Text = "0";
            this.txtDiem.TextChanged += new System.EventHandler(this.txtDiem_TextChanged);
            // 
            // btnXepLoai
            // 
            this.btnXepLoai.Location = new System.Drawing.Point(351, 112);
            this.btnXepLoai.Name = "btnXepLoai";
            this.btnXepLoai.Size = new System.Drawing.Size(56, 23);
            this.btnXepLoai.TabIndex = 2;
            this.btnXepLoai.Text = "Xếp loại";
            this.btnXepLoai.UseVisualStyleBackColor = true;
            this.btnXepLoai.Click += new System.EventHandler(this.btnXepLoai_Click);
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKetQua.Location = new System.Drawing.Point(390, 72);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(117, 20);
            this.lblKetQua.TabIndex = 3;
            this.lblKetQua.Text = "hiện thị xếp loại";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(486, 112);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1295, 413);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.btnXepLoai);
            this.Controls.Add(this.txtDiem);
            this.Controls.Add(this.lblDiem);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDiem;
        private System.Windows.Forms.TextBox txtDiem;
        private System.Windows.Forms.Button btnXepLoai;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.Button btnXoa;
    }
}

