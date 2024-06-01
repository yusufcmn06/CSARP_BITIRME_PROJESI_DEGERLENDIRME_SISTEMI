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
    public partial class OgrenciKayit : Form
    {
        public OgrenciKayit()
        {
            InitializeComponent();
        }
        MySqlConnection baglanti = new MySqlConnection("Server=localhost;Database=akademisyenler;user=root");// veri tabanı bağlantısı

        private void OgrenciKayit_Load(object sender, EventArgs e)
        {
            txtEgitimOgretimDonemi.Focus();
        }

        private void btnTumunuTemizle_Click(object sender, EventArgs e)
        {
            txtBitirmeProjeId.Clear();
            txtEgitimOgretimDonemi.Clear();
            txtOgrenciAdSoyad.Clear();  
            txtJuri1.Clear();
            txtJuri2.Clear();
            txtJuri3.Clear();
            txtJuri4.Clear();
            txtProjeAdi.Clear();
            txtOgrenciNo.Clear();
            txtEgitimOgretimDonemi.Focus();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            // Ogrencinin zorunlu olan bilgilerini doldurarak ogrenciyi veri tabanina kaydetigimiz yer
            if (txtOgrenciAdSoyad.Text != "" && txtOgrenciNo.Text != "" && txtEgitimOgretimDonemi.Text != "")
            {
                int satirSayisi = 0;
                baglanti.Open();
                MySqlCommand komut = new MySqlCommand("INSERT INTO ogrenciler (Egitim_Ogretim_Donemi, Ogrenci_No, Ogrenci_Ad_Soyad, Proje_Id, Proje_Ad, Puan, Juri_1, Juri_2, Juri_3, Juri_4) " +
                                                      "VALUES (@Egitim_Ogretim_Donemi, @Ogrenci_No, @Ogrenci_Ad_Soyad, @Proje_Id, @Proje_Ad, 0 ,@Juri_1, @Juri_2, @Juri_3, @Juri_4)");
                komut.Connection = baglanti;
                komut.Parameters.AddWithValue("@Egitim_Ogretim_Donemi", txtEgitimOgretimDonemi.Text);
                komut.Parameters.AddWithValue("@Ogrenci_No", txtOgrenciNo.Text);
                komut.Parameters.AddWithValue("@Ogrenci_Ad_Soyad", txtOgrenciAdSoyad.Text);
                komut.Parameters.AddWithValue("@Proje_Id", txtBitirmeProjeId.Text);
                komut.Parameters.AddWithValue("@Proje_Ad", txtProjeAdi.Text);
                komut.Parameters.AddWithValue("@Juri_1", txtJuri1.Text);
                komut.Parameters.AddWithValue("@Juri_2", txtJuri2.Text);
                komut.Parameters.AddWithValue("@Juri_3", txtJuri3.Text);
                komut.Parameters.AddWithValue("@Juri_4", txtJuri4.Text);
                satirSayisi = komut.ExecuteNonQuery();
                komut.Dispose();
                baglanti.Close();
                MessageBox.Show(satirSayisi + " öğrenci kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Question);
                txtBitirmeProjeId.Clear();
                txtEgitimOgretimDonemi.Clear();
                txtOgrenciAdSoyad.Clear();
                txtJuri1.Clear();
                txtJuri2.Clear();
                txtJuri3.Clear();
                txtJuri4.Clear();
                txtProjeAdi.Clear();
                txtOgrenciNo.Clear();
                txtEgitimOgretimDonemi.Focus();
            }
            else
            {
                MessageBox.Show("Lütfen Öğrenci Bilgilerini Eksiksiz Doldurun.","Uyarı!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtEgitimOgretimDonemi.Focus();
            }
        }

    }
}
