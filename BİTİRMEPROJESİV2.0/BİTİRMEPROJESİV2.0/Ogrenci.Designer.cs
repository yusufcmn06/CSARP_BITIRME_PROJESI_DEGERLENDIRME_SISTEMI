namespace BİTİRMEPROJESİV2._0
{
    partial class Ogrenci
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
            this.btnBitirmeProjeleri = new System.Windows.Forms.Button();
            this.btnNotGoruntule = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBitirmeProjeleri
            // 
            this.btnBitirmeProjeleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBitirmeProjeleri.ForeColor = System.Drawing.Color.Black;
            this.btnBitirmeProjeleri.Location = new System.Drawing.Point(294, 104);
            this.btnBitirmeProjeleri.Name = "btnBitirmeProjeleri";
            this.btnBitirmeProjeleri.Size = new System.Drawing.Size(146, 54);
            this.btnBitirmeProjeleri.TabIndex = 25;
            this.btnBitirmeProjeleri.Text = "Bitirme Projeleri";
            this.btnBitirmeProjeleri.UseVisualStyleBackColor = true;
            this.btnBitirmeProjeleri.Click += new System.EventHandler(this.btnBitirmeProjeleri_Click);
            // 
            // btnNotGoruntule
            // 
            this.btnNotGoruntule.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNotGoruntule.ForeColor = System.Drawing.Color.Black;
            this.btnNotGoruntule.Location = new System.Drawing.Point(73, 104);
            this.btnNotGoruntule.Name = "btnNotGoruntule";
            this.btnNotGoruntule.Size = new System.Drawing.Size(146, 54);
            this.btnNotGoruntule.TabIndex = 24;
            this.btnNotGoruntule.Text = "Not Görüntüle";
            this.btnNotGoruntule.UseVisualStyleBackColor = true;
            this.btnNotGoruntule.Click += new System.EventHandler(this.btnNotGoruntule_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(66, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 37);
            this.label1.TabIndex = 22;
            this.label1.Text = "Bilgisayar Programcılığı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(9, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(496, 37);
            this.label2.TabIndex = 23;
            this.label2.Text = "Bitirme Projleri Yönetim Sistemi";
            // 
            // Ogrenci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(513, 177);
            this.Controls.Add(this.btnBitirmeProjeleri);
            this.Controls.Add(this.btnNotGoruntule);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "Ogrenci";
            this.Text = "Öğrenci";
            this.Load += new System.EventHandler(this.Ogrenci_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBitirmeProjeleri;
        private System.Windows.Forms.Button btnNotGoruntule;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}