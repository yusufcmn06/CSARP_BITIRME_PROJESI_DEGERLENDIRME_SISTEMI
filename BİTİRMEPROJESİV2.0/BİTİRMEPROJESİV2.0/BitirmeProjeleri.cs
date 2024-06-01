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
    public partial class BitirmeProjeleri : Form
    {
        public BitirmeProjeleri()
        {
            InitializeComponent();
        }
        MySqlConnection baglanti = new MySqlConnection("Server=localhost;Database=akademisyenler;user=root;"); // Veri tabani baglantisi
        private void listele()
        {
            baglanti.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT Proje_Id, Ogrenci_Ad_Soyad, Proje_Ad FROM ogrenciler", baglanti); // Ogrenci bilgilerinin listelendigi sql kodu
            DataTable dt = new DataTable();
            dt.Clear();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            adapter.Dispose();
            baglanti.Close();

        }
        private void BitirmeProjeleri_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void textBox1_TextChanged(object sender, EventArgs e) // Arama kutusuna yazilan metine göre veri tabaninda sorgu yaparak datagride getiren kisim
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = "Ogrenci_Ad_Soyad LIKE '%" + txtAra.Text + "%'";
            dataGridView1.DataSource = bs;
        }
    }
}
