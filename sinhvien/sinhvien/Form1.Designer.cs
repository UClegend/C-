namespace sinhvien
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
            this.tbtHoten = new System.Windows.Forms.TextBox();
            this.tbtDiemvan = new System.Windows.Forms.TextBox();
            this.tbtDiemtoan = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLuu_Click = new System.Windows.Forms.Button();
            this.btnMo_Click = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnXoa_Click = new System.Windows.Forms.Button();
            this.LayIdTiepTheo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(453, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ho tên";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(655, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "điểm toán";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(551, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "điểm văn";
            // 
            // tbtHoten
            // 
            this.tbtHoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbtHoten.Location = new System.Drawing.Point(417, 78);
            this.tbtHoten.Name = "tbtHoten";
            this.tbtHoten.Size = new System.Drawing.Size(100, 23);
            this.tbtHoten.TabIndex = 3;
            this.tbtHoten.TextChanged += new System.EventHandler(this.tbtHoten_TextChanged);
            // 
            // tbtDiemvan
            // 
            this.tbtDiemvan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbtDiemvan.Location = new System.Drawing.Point(523, 78);
            this.tbtDiemvan.Name = "tbtDiemvan";
            this.tbtDiemvan.Size = new System.Drawing.Size(100, 23);
            this.tbtDiemvan.TabIndex = 4;
            this.tbtDiemvan.TextChanged += new System.EventHandler(this.tbtDiemvan_TextChanged);
            // 
            // tbtDiemtoan
            // 
            this.tbtDiemtoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbtDiemtoan.Location = new System.Drawing.Point(629, 78);
            this.tbtDiemtoan.Name = "tbtDiemtoan";
            this.tbtDiemtoan.Size = new System.Drawing.Size(100, 23);
            this.tbtDiemtoan.TabIndex = 5;
            this.tbtDiemtoan.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnThem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThem.Location = new System.Drawing.Point(761, 72);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(101, 35);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "thêm học sinh";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.Location = new System.Drawing.Point(320, 154);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(542, 150);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(317, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "danh sách học sinh sinh viên";
            // 
            // btnLuu_Click
            // 
            this.btnLuu_Click.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnLuu_Click.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLuu_Click.Location = new System.Drawing.Point(868, 154);
            this.btnLuu_Click.Name = "btnLuu_Click";
            this.btnLuu_Click.Size = new System.Drawing.Size(101, 35);
            this.btnLuu_Click.TabIndex = 9;
            this.btnLuu_Click.Text = "lưu bài";
            this.btnLuu_Click.UseVisualStyleBackColor = false;
            this.btnLuu_Click.Click += new System.EventHandler(this.btnLuu_Click_Click);
            // 
            // btnMo_Click
            // 
            this.btnMo_Click.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnMo_Click.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMo_Click.Location = new System.Drawing.Point(761, 108);
            this.btnMo_Click.Name = "btnMo_Click";
            this.btnMo_Click.Size = new System.Drawing.Size(101, 35);
            this.btnMo_Click.TabIndex = 10;
            this.btnMo_Click.Text = "nhập file";
            this.btnMo_Click.UseVisualStyleBackColor = false;
            this.btnMo_Click.Click += new System.EventHandler(this.btnMo_Click_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(298, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tìm kiếm";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(353, 114);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(376, 23);
            this.textBox1.TabIndex = 12;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnXoa_Click
            // 
            this.btnXoa_Click.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnXoa_Click.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnXoa_Click.Location = new System.Drawing.Point(868, 195);
            this.btnXoa_Click.Name = "btnXoa_Click";
            this.btnXoa_Click.Size = new System.Drawing.Size(101, 35);
            this.btnXoa_Click.TabIndex = 14;
            this.btnXoa_Click.Text = "Xoa";
            this.btnXoa_Click.UseVisualStyleBackColor = false;
            this.btnXoa_Click.Click += new System.EventHandler(this.btnXoa_Click_Click);
            // 
            // LayIdTiepTheo
            // 
            this.LayIdTiepTheo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LayIdTiepTheo.Location = new System.Drawing.Point(353, 78);
            this.LayIdTiepTheo.Name = "LayIdTiepTheo";
            this.LayIdTiepTheo.Size = new System.Drawing.Size(58, 23);
            this.LayIdTiepTheo.TabIndex = 15;
            this.LayIdTiepTheo.TextChanged += new System.EventHandler(this.LayIdTiepTheo_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(369, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "ID";
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSua.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSua.Location = new System.Drawing.Point(868, 236);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(101, 35);
            this.btnSua.TabIndex = 17;
            this.btnSua.Text = "Sữa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 435);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LayIdTiepTheo);
            this.Controls.Add(this.btnXoa_Click);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnMo_Click);
            this.Controls.Add(this.btnLuu_Click);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tbtDiemtoan);
            this.Controls.Add(this.tbtDiemvan);
            this.Controls.Add(this.tbtHoten);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbtHoten;
        private System.Windows.Forms.TextBox tbtDiemvan;
        private System.Windows.Forms.TextBox tbtDiemtoan;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLuu_Click;
        private System.Windows.Forms.Button btnMo_Click;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnXoa_Click;
        private System.Windows.Forms.TextBox LayIdTiepTheo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSua;
    }
}

