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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=spotcu.accdb");
        OleDbCommand komut = new OleDbCommand();
       
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form10 yeni = new Form10();
            yeni.Show();
            this.Hide();
        }
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
            baglanti.Close();
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
        void temizle()
        {
            textBox1.Text = "";
            textBox2.Text="";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/SalimDurgun66/?fref=ts");//Facebook Hesabımız....
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Alanları Boş Bırakmayınız...");

            }
            else
            {
                güncelleveritabanı("Insert Into urun ([urun_adi],[urun_fiyati]) Values ('" + textBox1.Text.ToUpper() + "','" + textBox2.Text.ToUpper() + "')", "Eklendi");
                temizle();
            }
        }
        void veritabanisorgu(int gelenindex,string sorgu)
        {
            baglanti.Open();
            komut.CommandText = sorgu;
            komut.Connection = baglanti;
            OleDbDataReader oku = komut.ExecuteReader();
            if(gelenindex == 0)
            {
                while(oku.Read())
                    textBox1.Text.ToString();
            }
            
            oku.Close();
            baglanti.Close();
           

        }
        private void Form11_Load(object sender, EventArgs e)
        {

            gridview("Selelct * From urun");
            foreach (DataGridViewColumn x in this.dataGridView1.Columns)
                x.SortMode = DataGridViewColumnSortMode.NotSortable;
            gridview("Select * From urun");

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/SalimDurgun66/?fref=ts");//Facebook Hesabımız....
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
