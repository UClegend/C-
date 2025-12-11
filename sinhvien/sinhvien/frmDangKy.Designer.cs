namespace sinhvien
{
    partial class frmDangKy
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
            this.txtDK_TaiKhoan = new System.Windows.Forms.TextBox();
            this.txtDK_MatKhau = new System.Windows.Forms.TextBox();
            this.txtDK_Email = new System.Windows.Forms.TextBox();
            this.btnXacNhanDK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDK_TaiKhoan
            // 
            this.txtDK_TaiKhoan.Location = new System.Drawing.Point(441, 49);
            this.txtDK_TaiKhoan.Name = "txtDK_TaiKhoan";
            this.txtDK_TaiKhoan.Size = new System.Drawing.Size(118, 20);
            this.txtDK_TaiKhoan.TabIndex = 0;
            // 
            // txtDK_MatKhau
            // 
            this.txtDK_MatKhau.Location = new System.Drawing.Point(441, 90);
            this.txtDK_MatKhau.Name = "txtDK_MatKhau";
            this.txtDK_MatKhau.PasswordChar = '*';
            this.txtDK_MatKhau.Size = new System.Drawing.Size(118, 20);
            this.txtDK_MatKhau.TabIndex = 1;
            // 
            // txtDK_Email
            // 
            this.txtDK_Email.Location = new System.Drawing.Point(441, 128);
            this.txtDK_Email.Name = "txtDK_Email";
            this.txtDK_Email.Size = new System.Drawing.Size(118, 20);
            this.txtDK_Email.TabIndex = 2;
            // 
            // btnXacNhanDK
            // 
            this.btnXacNhanDK.Location = new System.Drawing.Point(460, 164);
            this.btnXacNhanDK.Name = "btnXacNhanDK";
            this.btnXacNhanDK.Size = new System.Drawing.Size(75, 23);
            this.btnXacNhanDK.TabIndex = 3;
            this.btnXacNhanDK.Text = "Đăng Ký";
            this.btnXacNhanDK.UseVisualStyleBackColor = true;
            this.btnXacNhanDK.Click += new System.EventHandler(this.btnXacNhanDK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(438, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tài khoản ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(438, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mật khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(438, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Email";
            // 
            // frmDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 352);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnXacNhanDK);
            this.Controls.Add(this.txtDK_Email);
            this.Controls.Add(this.txtDK_MatKhau);
            this.Controls.Add(this.txtDK_TaiKhoan);
            this.Name = "frmDangKy";
            this.Text = "frmDangKy";
            this.Click += new System.EventHandler(this.btnXacNhanDK_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDK_TaiKhoan;
        private System.Windows.Forms.TextBox txtDK_MatKhau;
        private System.Windows.Forms.TextBox txtDK_Email;
        private System.Windows.Forms.Button btnXacNhanDK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}