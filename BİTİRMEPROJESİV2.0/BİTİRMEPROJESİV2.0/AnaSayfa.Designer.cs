namespace BİTİRMEPROJESİV2._0
{
    partial class AnaSayfa
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
            this.btnOgrenci = new System.Windows.Forms.Button();
            this.btnAakademisyen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(66, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bilgisayar Programcılığı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(9, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(496, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bitirme Projleri Yönetim Sistemi";
            // 
            // btnOgrenci
            // 
            this.btnOgrenci.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOgrenci.ForeColor = System.Drawing.Color.Black;
            this.btnOgrenci.Location = new System.Drawing.Point(294, 104);
            this.btnOgrenci.Name = "btnOgrenci";
            this.btnOgrenci.Size = new System.Drawing.Size(146, 54);
            this.btnOgrenci.TabIndex = 21;
            this.btnOgrenci.Text = "Öğrenci";
            this.btnOgrenci.UseVisualStyleBackColor = true;
            this.btnOgrenci.Click += new System.EventHandler(this.btnOgrenci_Click);
            // 
            // btnAakademisyen
            // 
            this.btnAakademisyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAakademisyen.ForeColor = System.Drawing.Color.Black;
            this.btnAakademisyen.Location = new System.Drawing.Point(73, 104);
            this.btnAakademisyen.Name = "btnAakademisyen";
            this.btnAakademisyen.Size = new System.Drawing.Size(146, 54);
            this.btnAakademisyen.TabIndex = 20;
            this.btnAakademisyen.Text = "Akademisyen";
            this.btnAakademisyen.UseVisualStyleBackColor = true;
            this.btnAakademisyen.Click += new System.EventHandler(this.btnAakademisyen_Click);
            // 
            // AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(513, 177);
            this.Controls.Add(this.btnOgrenci);
            this.Controls.Add(this.btnAakademisyen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "AnaSayfa";
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.AnaSayfa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOgrenci;
        private System.Windows.Forms.Button btnAakademisyen;
    }
}

