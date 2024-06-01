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
    public partial class NotGoruntule : Form
    {
        public NotGoruntule()
        {
            InitializeComponent();
        }
        MySqlConnection baglanti = new MySqlConnection("Server=localhost;Database=akademisyenler;user=root;"); // Veri tabani baglantisi
        private void listele()
        {
            // Ogrenciler tablosundaki ogrencilerin adı, numarasi, puani listeler
            baglanti.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT Ogrenci_No , Ogrenci_Ad_Soyad , Puan FROM ogrenciler ", baglanti); 
            DataTable dataTable = new DataTable();
            dataTable.Clear();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            adapter.Dispose();
            baglanti.Close();
        }

        private void NotGoruntule_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            // Arama kutusuna yazilan isim ile ilgili ogrenci bilgilerini datagride listeler
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = "Ogrenci_Ad_Soyad LIKE '%" + txtAra.Text + "%'";
            dataGridView1.DataSource = bs;
        }
    }
}
