using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BİTİRMEPROJESİV2._0
{
    public partial class Akademisyen : Form
    {
        public Akademisyen()
        {
            InitializeComponent();
        }

        private void Akademisyen_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void btnNotGir_Click(object sender, EventArgs e)
        {
            NotGiris notGiris = new NotGiris();
            notGiris.Show();
        }

        private void btnOgrenciKaydet_Click(object sender, EventArgs e)
        {
            OgrenciKayit ogrenci = new OgrenciKayit();
            ogrenci.Show(); 
        }
    }
}
