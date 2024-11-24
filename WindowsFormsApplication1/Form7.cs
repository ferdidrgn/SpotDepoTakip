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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        //Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Ferdi\Documents\WindowsFormsApplication1\WindowsFormsApplication1\bin\Debug\musterikayit.accdb
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source= spotcu.accdb");
        OleDbCommand komut = new OleDbCommand();
        DataSet ds = new DataSet();
        OleDbDataAdapter da;
        int kimlik = 0;

        void gridgoster(string sorgu)
        {
            baglanti.Open();
            if (sorgu == "")
            {
                komut.CommandText = "SELECT * FROM musteri";
            }
            else
                komut.CommandText = sorgu;
            ds.Clear();
            komut.Connection = baglanti;
            da = new OleDbDataAdapter(komut);
            da.Fill(ds, "StokTablo");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "StokTablo";
            dataGridView1.Columns["musteri_id"].Visible = false;
            baglanti.Close();
        }
        void bilglilerigoster(string sorgu)
        {
            baglanti.Open();
            komut.CommandText = sorgu;
            komut.Connection = baglanti;
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                textBox1.Text = oku["adi"].ToString();
                textBox2.Text = oku["soyadi"].ToString();
                textBox4.Text = oku["telno"].ToString();
                textBox3.Text = oku["adres"].ToString();
            }
            oku.Close();
            baglanti.Close();
        }
     
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "Update musteri Set [adi]='" + textBox1.Text.ToUpper() + "',[soyadi]='" + textBox2.Text.ToUpper() + "',[telno]='" + textBox4.Text.ToUpper() + "',[adres]='" + textBox3.Text.ToUpper() + "' Where[musteri_id]="+dataGridView1.CurrentRow.Cells[0].Value.ToString()+"";
            komut.ExecuteNonQuery();//hata verirse sql bağlantısı hatalıdır...
            baglanti.Close();
            MessageBox.Show(":::Kayıtlar Düzenlendi:::");
            gridgoster("SELECT * FROM musteri");
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            gridgoster("SELECT * FROM musteri");
            foreach (DataGridViewColumn x in this.dataGridView1.Columns)
                x.SortMode = DataGridViewColumnSortMode.NotSortable;
           
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            try
            {
                kimlik = int.Parse(ds.Tables["Not"].Rows[e.RowIndex]["musteri_id"].ToString());
                bilglilerigoster("Select * From musteri Where [musteri_id]=" + kimlik.ToString());
            }
            catch (Exception)
            {

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form5 yeni = new Form5();
            yeni.Show();
            this.Hide();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/SalimDurgun66/?fref=ts");
        }
        private void dataGridView1_CellMouseDoubleClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {

            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       
       

    }
}
