namespace sinhvien
{
    partial class frmDangNhap
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
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lnkQuenMK = new System.Windows.Forms.LinkLabel();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.lnkDoiMatKhau = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Location = new System.Drawing.Point(452, 57);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(154, 20);
            this.txtTaiKhoan.TabIndex = 0;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(452, 110);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(154, 20);
            this.txtMatKhau.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(449, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tài khoản";
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Location = new System.Drawing.Point(488, 146);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(75, 23);
            this.btnDangNhap.TabIndex = 3;
            this.btnDangNhap.Text = "Đăng Nhập";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(449, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "MẬT KHẨU";
            // 
            // lnkQuenMK
            // 
            this.lnkQuenMK.AutoSize = true;
            this.lnkQuenMK.Location = new System.Drawing.Point(449, 185);
            this.lnkQuenMK.Name = "lnkQuenMK";
            this.lnkQuenMK.Size = new System.Drawing.Size(80, 13);
            this.lnkQuenMK.TabIndex = 5;
            this.lnkQuenMK.TabStop = true;
            this.lnkQuenMK.Text = "Quên mật khẩu";
            // 
            // btnDangKy
            // 
            this.btnDangKy.Location = new System.Drawing.Point(535, 175);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(92, 23);
            this.btnDangKy.TabIndex = 6;
            this.btnDangKy.Text = "Đăng Ký";
            this.btnDangKy.UseVisualStyleBackColor = true;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // lnkDoiMatKhau
            // 
            this.lnkDoiMatKhau.Location = new System.Drawing.Point(535, 204);
            this.lnkDoiMatKhau.Name = "lnkDoiMatKhau";
            this.lnkDoiMatKhau.Size = new System.Drawing.Size(92, 23);
            this.lnkDoiMatKhau.TabIndex = 7;
            this.lnkDoiMatKhau.Text = "đổi mật khẩu";
            this.lnkDoiMatKhau.UseVisualStyleBackColor = true;
            this.lnkDoiMatKhau.Click += new System.EventHandler(this.btnDoiMatKhau_Click);
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 363);
            this.Controls.Add(this.lnkDoiMatKhau);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.lnkQuenMK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTaiKhoan);
            this.Name = "frmDangNhap";
            this.Text = "frmDangNhap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel lnkQuenMK;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.Button lnkDoiMatKhau;
    }
}