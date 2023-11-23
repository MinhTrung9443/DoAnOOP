namespace DoAnOOP
{
    partial class Form3
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
            this.tbx_bookName = new System.Windows.Forms.TextBox();
            this.tbx_bookcode = new System.Windows.Forms.TextBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ma sach";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(367, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ten Sach";
            // 
            // tbx_bookName
            // 
            this.tbx_bookName.Location = new System.Drawing.Point(301, 69);
            this.tbx_bookName.Multiline = true;
            this.tbx_bookName.Name = "tbx_bookName";
            this.tbx_bookName.Size = new System.Drawing.Size(177, 42);
            this.tbx_bookName.TabIndex = 3;
            // 
            // tbx_bookcode
            // 
            this.tbx_bookcode.Location = new System.Drawing.Point(34, 69);
            this.tbx_bookcode.Multiline = true;
            this.tbx_bookcode.Name = "tbx_bookcode";
            this.tbx_bookcode.Size = new System.Drawing.Size(177, 42);
            this.tbx_bookcode.TabIndex = 4;
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(180, 138);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(155, 42);
            this.btn_ok.TabIndex = 5;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 192);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.tbx_bookcode);
            this.Controls.Add(this.tbx_bookName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Search ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbx_bookName;
        private System.Windows.Forms.TextBox tbx_bookcode;
        private System.Windows.Forms.Button btn_ok;
    }
}