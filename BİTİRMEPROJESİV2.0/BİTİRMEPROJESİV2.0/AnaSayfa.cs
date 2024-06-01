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
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }
        private void btnAakademisyen_Click(object sender, EventArgs e)
        {
            AkademisyenGiris akademisyenGiris = new AkademisyenGiris();
            akademisyenGiris.Show();
        }

        private void btnOgrenci_Click(object sender, EventArgs e)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Show();
        }
    }
}
