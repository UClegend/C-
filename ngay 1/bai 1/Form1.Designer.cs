namespace bai_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button_ClickHere = new System.Windows.Forms.Button();
            this.label_message = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_ClickHere
            // 
            resources.ApplyResources(this.button_ClickHere, "button_ClickHere");
            this.button_ClickHere.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button_ClickHere.Name = "button_ClickHere";
            this.button_ClickHere.UseVisualStyleBackColor = true;
            this.button_ClickHere.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_message
            // 
            resources.ApplyResources(this.label_message, "label_message");
            this.label_message.Name = "label_message";
            this.label_message.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_message);
            this.Controls.Add(this.button_ClickHere);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_ClickHere;
        private System.Windows.Forms.Label label_message;
    }
}

