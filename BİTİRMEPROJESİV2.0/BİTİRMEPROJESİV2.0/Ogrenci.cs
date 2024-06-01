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
    public partial class Ogrenci : Form
    {
        public Ogrenci()
        {
            InitializeComponent();
        }

        private void Ogrenci_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void btnBitirmeProjeleri_Click(object sender, EventArgs e)
        {
            BitirmeProjeleri bitirmeProjeleri = new BitirmeProjeleri();
            bitirmeProjeleri.Show();
        }

        private void btnNotGoruntule_Click(object sender, EventArgs e)
        {
            NotGoruntule notGoruntule = new NotGoruntule();
            notGoruntule.Show();
        }
    }
}
