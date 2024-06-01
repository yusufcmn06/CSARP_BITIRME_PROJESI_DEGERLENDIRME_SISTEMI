using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BİTİRMEPROJESİV2._0
{
    public partial class AkademisyenGiris : Form
    {
        public AkademisyenGiris()
        {
            InitializeComponent();
        }
        MySqlConnection baglanti = new MySqlConnection("Server=localhost;Database=akademisyenler;user=root;"); // Veri tabani baglantisi

        private void AkademisyenGiris_Load(object sender, EventArgs e) // Veri tabanindaki akademisyenlerin adlarinin adlarinin cmb ye yazdirildigi yer
        {
            this.CenterToScreen();
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("SELECT KULLANICI_ADI FROM akademisyenler", baglanti); // Akademisyen isimlerinin listeledigi sql sorgusu
            MySqlDataReader okuyucu = komut.ExecuteReader();
            while (okuyucu.Read())
            {
                string cikti = okuyucu["KULLANICI_ADI"].ToString();
                cmbAkademisyen.Items.Add(cikti);
            }
            okuyucu.Close();
            baglanti.Close();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            // Secilen akademisyen ismi ile girilen sifrenin dogrulunun kontorlunun yapildigi yer
            string secilenKullaniciAdi = cmbAkademisyen.SelectedItem.ToString();
            NotGiris.kullaniciAdi = secilenKullaniciAdi;
            string sifreKomutu = "SELECT SIFRE FROM akademisyenler WHERE KULLANICI_ADI = '" + secilenKullaniciAdi + "'";
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand(sifreKomutu, baglanti);
            MySqlDataReader okuyucu = komut.ExecuteReader();
            while (okuyucu.Read())
            {
                // Sifre kontrolunun yapildigi yer
                string sifre = okuyucu["SIFRE"].ToString();
                string girilenSifre = txtSifre.Text;
                if (girilenSifre.Equals(sifre))
                {
                    MessageBox.Show("Giriş başarılı!", "Uyarı!", MessageBoxButtons.OK);
                    Akademisyen akademisyen = new Akademisyen();
                    akademisyen.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Girilen Şifre Yanlış.", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSifre.Clear();
                    txtSifre.Focus();
                }
            }
            okuyucu.Close();
            baglanti.Close();
        }

        private void cmbAkademisyen_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Akademisyen secildigi zaman sifre kutusunu temizleyip oraya focuslanıyor
            txtSifre.Clear();
            txtSifre.Focus();
        }
    }
}
