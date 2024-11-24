using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApplication1
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }
        public Form1 frm1;
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=spotcu.accdb");
        OleDbCommand komut = new OleDbCommand();
        void gridview(string sorgu)
        {

            baglanti.Open();
            komut.CommandText = "Select * From urun";
            komut.Connection = baglanti;
            OleDbDataAdapter da = new OleDbDataAdapter(komut);
            DataSet ds = new DataSet();

            da.Fill(ds, "diz");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "diz";
            dataGridView1.Columns["urun_id"].Visible = false;// DataGridView de gözükmeyecek sütûn
            baglanti.Close();
            
        
        }

        void güncelleveritabanı(string sorgu, string mesaj)
        {
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = sorgu;
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt" + mesaj);

            gridview("Selelct * From urun");


        }
       /*Tümü
Ürün Kodu
Ürün Adı
Ürün Markası
Modeli
Özellik
Alış Fiyatı
Satış Fiyatı
Kategori
Kayıt Tarihi*/
        
        private void btnAra_Click(object sender, EventArgs e)
        {
            baglanti.Open();
           
 
            if (comboBox1.Text=="Tümü")
            {
                komut.CommandText = "Select * From urun";
            }
            else if (comboBox1.Text == "Ürün Kodu")
            {
                komut.CommandText = "Select urun_id From urun";
            }
            else if (comboBox1.Text == "Ürün Adı")
            {
                komut.CommandText = "Select urun_adi From urun";
            }
            else if (comboBox1.Text == "Satış Fiyatı")
            {
                komut.CommandText = "Select urun_fiyati From urun";
            }
           

           /* else if (textBox1.Text!=null)
            {
                 komut.CommandText = "Select * From urunkayit WHERE [" + comboBox1.Text + "] LIKE % '" + textBox1.Text.ToUpper() + "'%";
             OleDbDataReader oku = komut.ExecuteReader();
             while(oku.Read())
             {         
                dataGridView1.CurrentRow.Cells[0].Value=oku[0].ToString();
                dataGridView1.CurrentRow.Cells[1].Value = oku[1].ToString();
                dataGridView1.CurrentRow.Cells[2].Value = oku[2].ToString();
                dataGridView1.CurrentRow.Cells[3].Value = oku[3].ToString();
                dataGridView1.CurrentRow.Cells[4].Value = oku[4].ToString();
                dataGridView1.CurrentRow.Cells[5].Value = oku[5].ToString();
                dataGridView1.CurrentRow.Cells[5].Value = oku[6].ToString();
                dataGridView1.CurrentRow.Cells[5].Value = oku[7].ToString();
                dataGridView1.CurrentRow.Cells[5].Value = oku[8].ToString();
                dataGridView1.CurrentRow.Cells[5].Value = oku[9].ToString();
              
             }
            }*/
               
            komut.Connection = baglanti;
            OleDbDataAdapter da = new OleDbDataAdapter(komut);
            DataSet ds = new DataSet();

            da.Fill(ds, "diz");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "diz";
            baglanti.Close();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            gridview("Selelct * From urun");
            foreach (DataGridViewColumn x in this.dataGridView1.Columns)
                x.SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form3 yeni = new Form3();
            yeni.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           System.Diagnostics.Process.Start("https://www.facebook.com/SalimDurgun66/?fref=ts");//Facebook Hesabımız....
        }

        private void ekle_Click(object sender, EventArgs e)
        {
            Form11 yeni = new Form11();
            yeni.Show();
            this.Hide();
        }

        private void kapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void sil_Click(object sender, EventArgs e)
        {
            Form12 yeni = new Form12();
            yeni.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form13 yeni = new Form13();
            yeni.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
