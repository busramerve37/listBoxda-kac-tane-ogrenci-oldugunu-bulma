namespace button.ornek._39
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
            this.btnAranan = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAranan
            // 
            this.btnAranan.Location = new System.Drawing.Point(39, 61);
            this.btnAranan.Name = "btnAranan";
            this.btnAranan.Size = new System.Drawing.Size(75, 23);
            this.btnAranan.TabIndex = 0;
            this.btnAranan.Text = "Aranan";
            this.btnAranan.UseVisualStyleBackColor = true;
            this.btnAranan.Click += new System.EventHandler(this.btnAranan_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Büşra ",
            "Meryem",
            "Mehmet",
            "Ahmet",
            "Zeynep ",
            "Kadir",
            "Semih ",
            "Sahra",
            "Ali ",
            "Büşra",
            "Büşra",
            "Meryem ",
            "Ufuk",
            "Beyza"});
            this.listBox1.Location = new System.Drawing.Point(171, 61);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 1;
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(39, 111);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(100, 20);
            this.txtAra.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 404);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnAranan);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAranan;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtAra;
    }
}

