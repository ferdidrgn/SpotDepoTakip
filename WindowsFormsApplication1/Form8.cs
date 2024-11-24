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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=musterinot.accdb");
        OleDbCommand komut = new OleDbCommand();
        void güncelleveritabanı(string sorgu, string mesaj)
        {
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = sorgu;
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt" + mesaj);

            gridview("Selelct * From musterinot");


        }
        void gridview(string sorgu)
        {

            baglanti.Open();
            komut.CommandText = "Select * From musterinot";
            komut.Connection = baglanti;
            OleDbDataAdapter da = new OleDbDataAdapter(komut);
            DataSet ds = new DataSet();

            da.Fill(ds, "diz");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "diz";
            baglanti.Close();
            dataGridView1.Columns["Kimlik"].Visible = false;// DataGridView de gözükmeyecek sütûn
            baglanti.Close();

        }
        void temizle()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" )
            {
                MessageBox.Show("Alanları Boş Bırakmayınız...");

            }
            else
            {
                güncelleveritabanı("Insert Into musterinot ([Adi],[Soyadi],[TelNO],[Not]) Values ('" + textBox1.Text.ToUpper() + "','" + textBox2.Text.ToUpper() + "','" + textBox3.Text.ToUpper() + "','" + textBox4.Text.ToUpper() + "')", "Eklendi");
                temizle();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form5 yeni = new Form5();
            yeni.Show();
            this.Hide();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            gridview("Selelct * From musterikayit");
            foreach (DataGridViewColumn x in this.dataGridView1.Columns)
                x.SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/SalimDurgun66/?fref=ts");
        }
    }
}
