namespace sinhvien
{
    partial class frmQuenMatKhau
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
            this.txtQMK_TaiKhoan = new System.Windows.Forms.TextBox();
            this.btnLayLaiMK = new System.Windows.Forms.Button();
            this.txtQMK_Email = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label1.Location = new System.Drawing.Point(271, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập tài khoản và Email đã đăng ký để lấy lại mật khẩu";
            // 
            // txtQMK_TaiKhoan
            // 
            this.txtQMK_TaiKhoan.Location = new System.Drawing.Point(362, 69);
            this.txtQMK_TaiKhoan.Name = "txtQMK_TaiKhoan";
            this.txtQMK_TaiKhoan.Size = new System.Drawing.Size(135, 20);
            this.txtQMK_TaiKhoan.TabIndex = 1;
            // 
            // btnLayLaiMK
            // 
            this.btnLayLaiMK.Location = new System.Drawing.Point(376, 137);
            this.btnLayLaiMK.Name = "btnLayLaiMK";
            this.btnLayLaiMK.Size = new System.Drawing.Size(103, 23);
            this.btnLayLaiMK.TabIndex = 2;
            this.btnLayLaiMK.Text = "Lấy lại mật khẩu";
            this.btnLayLaiMK.UseVisualStyleBackColor = true;
            this.btnLayLaiMK.Click += new System.EventHandler(this.btnLayLaiMK_Click);
            // 
            // txtQMK_Email
            // 
            this.txtQMK_Email.Location = new System.Drawing.Point(362, 111);
            this.txtQMK_Email.Name = "txtQMK_Email";
            this.txtQMK_Email.Size = new System.Drawing.Size(135, 20);
            this.txtQMK_Email.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(359, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tài khoản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(359, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Email  đã dăng ký";
            // 
            // frmQuenMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 325);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtQMK_Email);
            this.Controls.Add(this.btnLayLaiMK);
            this.Controls.Add(this.txtQMK_TaiKhoan);
            this.Controls.Add(this.label1);
            this.Name = "frmQuenMatKhau";
            this.Text = "frmQuenMatKhau";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQMK_TaiKhoan;
        private System.Windows.Forms.Button btnLayLaiMK;
        private System.Windows.Forms.TextBox txtQMK_Email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}