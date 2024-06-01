using MySql.Data.MySqlClient;
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
    public partial class NotGiris : Form
    {
        public static string kullaniciAdi;
        public NotGiris()
        {
            InitializeComponent();
        }
        double toplamNot = 0;
        MySqlConnection baglanti = new MySqlConnection("Server=localhost;Database=akademisyenler;user=root"); //  Veri tabani baglantisi
        private void listele()
        {
            // Hangi akademisyen girdiyse onun puan verebilecegi tüm ogrencileri datagride yazdiran kisim
            baglanti.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM ogrenciler WHERE '" + kullaniciAdi + "' IN (Juri_1, Juri_2, Juri_3, Juri_4)", baglanti);
            DataTable dataTable = new DataTable();
            dataTable.Clear();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            adapter.Dispose();
            baglanti.Close();
        }
        private void NotGiris_Load(object sender, EventArgs e)
        {
            // Hangi akademisyen not vermek icin girdiyse onun adini veri tabaninda buluyor ve txtJuriUyesi textbox' a yaziyor.
            listele();
            txtJuriUyesi.Text = kullaniciAdi;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Datagridden secilen satirdaki bilgileri ilgili yerlere yaziyoruz
            txtOgrenciAdSoyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtOgrenciNo.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtProjeAd.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtProjeId.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtJuri1.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtJuri2.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txtJuri3.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            txtJuri4.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
        }

        private void btnTumunuSil_Click(object sender, EventArgs e)
        {
            txtAraDegerlendirme.Clear();    
            txtDegerlendirme1.Clear();  
            txtDegerlendirme2.Clear();
            txtDegerlendirme3.Clear();
            toplamNot = 0;
        }
        private void btnHesapla_Click(object sender, EventArgs e) // Girilen not hesaplama kismi
        {
            int degerlendirme1 = Convert.ToInt32(txtDegerlendirme1.Text);
            int degerlendirme2 = Convert.ToInt32(txtDegerlendirme2.Text);
            int degerlendirme3 = Convert.ToInt32(txtDegerlendirme3.Text);
            toplamNot = (degerlendirme1 + degerlendirme2 + degerlendirme3) / 3;
            txtAraDegerlendirme.Text = toplamNot.ToString();
        }
        private void btnKaydet_Click(object sender, EventArgs e)// Not kaydetme kismi 
        {
            // Eger veritabaninda onceden girilmis bir not varsa onu puan degiskenine atıyoruz.
            int puan=0;
            baglanti.Open();
            MySqlCommand komut1 = new MySqlCommand("SELECT Puan AS Puan FROM ogrenciler WHERE Ogrenci_No = @Ogrenci_No", baglanti);
            komut1.Parameters.AddWithValue("@Ogrenci_No", txtOgrenciNo.Text);
            MySqlDataReader okuyucu = komut1.ExecuteReader();
            if (okuyucu.Read())
            {
               puan = Convert.ToInt32(okuyucu["Puan"].ToString());
            }
            komut1.Dispose();
            okuyucu.Close();
            baglanti.Close();

            // Verilen puani ilgili ogrencinin puan kismina ekliyor eger onceden not verildiyse onun ustune ekleyerek notu kaydediyor
            baglanti.Open();
            double YeniPuan=0;
            int araDeger = 0;
            if (int.TryParse(txtAraDegerlendirme.Text, out araDeger))
            {
                YeniPuan = puan + (araDeger / 4);
            }
            MySqlCommand komut = new MySqlCommand("UPDATE ogrenciler SET Puan=@Puan WHERE Ogrenci_No = @Ogrenci_No", baglanti);
            komut.Parameters.AddWithValue("@Puan", YeniPuan);
            komut.Parameters.AddWithValue("@Ogrenci_No", txtOgrenciNo.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show(txtOgrenciAdSoyad.Text + " adlı öğrencinin notu kaydedildi.");
            komut.Dispose();
            baglanti.Close();
            txtAraDegerlendirme.Clear();
            txtDegerlendirme1.Clear();
            txtDegerlendirme2.Clear();
            txtDegerlendirme3.Clear();
            txtOgrenciAdSoyad.Clear();
            txtOgrenciNo.Clear();
            txtProjeAd.Clear();
            txtProjeId.Clear();
            toplamNot = 0;
            listele();
        }
    }
}
