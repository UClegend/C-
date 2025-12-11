namespace baitap_2
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
            this.txtN = new System.Windows.Forms.TextBox();
            this.radToanBo = new System.Windows.Forms.RadioButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.radChan = new System.Windows.Forms.RadioButton();
            this.radLe = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "số chắn và lẻ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "số chắn và lẻ";
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(183, 63);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(142, 20);
            this.txtN.TabIndex = 2;
            this.txtN.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // radToanBo
            // 
            this.radToanBo.AutoSize = true;
            this.radToanBo.Location = new System.Drawing.Point(373, 63);
            this.radToanBo.Name = "radToanBo";
            this.radToanBo.Size = new System.Drawing.Size(58, 17);
            this.radToanBo.TabIndex = 3;
            this.radToanBo.TabStop = true;
            this.radToanBo.Text = "toanbo";
            this.radToanBo.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(183, 167);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(222, 108);
            this.listBox1.TabIndex = 4;
            // 
            // radChan
            // 
            this.radChan.AutoSize = true;
            this.radChan.Location = new System.Drawing.Point(373, 86);
            this.radChan.Name = "radChan";
            this.radChan.Size = new System.Drawing.Size(49, 17);
            this.radChan.TabIndex = 5;
            this.radChan.TabStop = true;
            this.radChan.Text = "chẳn";
            this.radChan.UseVisualStyleBackColor = true;
            // 
            // radLe
            // 
            this.radLe.AutoSize = true;
            this.radLe.Location = new System.Drawing.Point(373, 109);
            this.radLe.Name = "radLe";
            this.radLe.Size = new System.Drawing.Size(33, 17);
            this.radLe.TabIndex = 6;
            this.radLe.TabStop = true;
            this.radLe.Text = "lẻ";
            this.radLe.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 422);
            this.Controls.Add(this.radLe);
            this.Controls.Add(this.radChan);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.radToanBo);
            this.Controls.Add(this.txtN);
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
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.RadioButton radToanBo;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RadioButton radChan;
        private System.Windows.Forms.RadioButton radLe;
    }
}

