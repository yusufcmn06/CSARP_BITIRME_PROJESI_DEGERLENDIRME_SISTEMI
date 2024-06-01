namespace BİTİRMEPROJESİV2._0
{
    partial class Akademisyen
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
            this.btnOgrenciKaydet = new System.Windows.Forms.Button();
            this.btnNotGir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOgrenciKaydet
            // 
            this.btnOgrenciKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOgrenciKaydet.ForeColor = System.Drawing.Color.Black;
            this.btnOgrenciKaydet.Location = new System.Drawing.Point(294, 104);
            this.btnOgrenciKaydet.Name = "btnOgrenciKaydet";
            this.btnOgrenciKaydet.Size = new System.Drawing.Size(146, 54);
            this.btnOgrenciKaydet.TabIndex = 19;
            this.btnOgrenciKaydet.Text = "Öğrenci Kaydet";
            this.btnOgrenciKaydet.UseVisualStyleBackColor = true;
            this.btnOgrenciKaydet.Click += new System.EventHandler(this.btnOgrenciKaydet_Click);
            // 
            // btnNotGir
            // 
            this.btnNotGir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNotGir.ForeColor = System.Drawing.Color.Black;
            this.btnNotGir.Location = new System.Drawing.Point(73, 104);
            this.btnNotGir.Name = "btnNotGir";
            this.btnNotGir.Size = new System.Drawing.Size(146, 54);
            this.btnNotGir.TabIndex = 18;
            this.btnNotGir.Text = "Not Kaydet";
            this.btnNotGir.UseVisualStyleBackColor = true;
            this.btnNotGir.Click += new System.EventHandler(this.btnNotGir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(66, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 37);
            this.label1.TabIndex = 20;
            this.label1.Text = "Bilgisayar Programcılığı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(9, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(496, 37);
            this.label2.TabIndex = 21;
            this.label2.Text = "Bitirme Projleri Yönetim Sistemi";
            // 
            // Akademisyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(513, 177);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOgrenciKaydet);
            this.Controls.Add(this.btnNotGir);
            this.Name = "Akademisyen";
            this.Text = "Akademisyen";
            this.Load += new System.EventHandler(this.Akademisyen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOgrenciKaydet;
        private System.Windows.Forms.Button btnNotGir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}