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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=spotcu.accdb");
        OleDbCommand komut = new OleDbCommand();
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.label1.Text = label8.Text;
            frm3.label2.Text = label9.Text;

            Form5 yeni = new Form5();
            yeni.Show();
            this.Hide();
            
        }
       
       
        void gridview(string sorgu)
        {
            
            baglanti.Open();
            komut.CommandText = "Select * From musteri";
            komut.Connection = baglanti;
            OleDbDataAdapter da = new OleDbDataAdapter(komut);
            DataSet ds = new DataSet();

            da.Fill(ds, "diz");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "diz";
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
            
            gridview("Selelct * From musteri");
            
           
        }
        void temizle ()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
             if (textBox1.Text == "" || textBox4.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Alanları Boş Bırakmayınız...");
                
            }
            else
             {
                 güncelleveritabanı("Insert Into musteri ([adi],[soyadi],[telno],[adres]) Values ('" + textBox1.Text.ToUpper() + "','" + textBox2.Text.ToUpper() + "','" + textBox3.Text.ToUpper() + "','" + textBox4.Text.ToUpper() + "')", "Eklendi");
                 temizle();
             }
         }
                

            

            private void Form4_Load_1(object sender, EventArgs e)
            {
                label8.Visible = false;
                label9.Visible = false;
                gridview("Selelct * From musteri");
                foreach (DataGridViewColumn x in this.dataGridView1.Columns)
                    x.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            private void button2_Click(object sender, EventArgs e)
            {
                Close();
            }

            private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {

            }

            private void pictureBox2_Click(object sender, EventArgs e)
            {
                System.Diagnostics.Process.Start("https://www.facebook.com/SalimDurgun66/?fref=ts");
            }

            private void label1_Click(object sender, EventArgs e)
            {

            }

        }

    }

