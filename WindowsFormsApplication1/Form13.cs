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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }
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
                komut.CommandText = "SELECT * FROM urun";
            }
            else
                komut.CommandText = sorgu;
            ds.Clear();
            komut.Connection = baglanti;
            da = new OleDbDataAdapter(komut);
            da.Fill(ds, "urun");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "urun";
            dataGridView1.Columns["urun_id"].Visible = false;
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
                textBox1.Text = oku["urun_adi"].ToString();
                textBox2.Text = oku["urun_fiyati"].ToString();
                
            }
            oku.Close();
            baglanti.Close();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/SalimDurgun66/?fref=ts");//Facebook Hesabımız....
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "Update urun Set [urun_adi]='" + textBox1.Text.ToUpper() +"',[urun_fiyati]='" + textBox2.Text.ToUpper() +  "' Where[urun_id]=" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "";
            komut.ExecuteNonQuery();//hata verirse sql bağlantısı hatalıdır...
            baglanti.Close();
            MessageBox.Show(":::Kayıtlar Düzenlendi:::");
            gridgoster("SELECT * FROM urun");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form10 yeni = new Form10();
            yeni.Show();
            this.Hide();
        }
        
        private void Form13_Load(object sender, EventArgs e)
        {
            gridgoster("SELECT * FROM urun");
            foreach (DataGridViewColumn x in this.dataGridView1.Columns)
                x.SortMode = DataGridViewColumnSortMode.NotSortable;
            
          
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                kimlik = int.Parse(ds.Tables["Not"].Rows[e.RowIndex]["urun_id"].ToString());
                bilglilerigoster("Select * From urun Where [urun_id]=" + kimlik.ToString());
            }
            catch (Exception)
            {

            }
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /*private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "select * from urun where [urun_adi]='" + textBox1.Text + "'";
            OleDbDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                id = Convert.ToInt32(oku[1]);
            }
            oku.Close();

            baglanti.Close();
            
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "select * from Kategori where [Adi_id]=" + id + "";
            OleDbDataReader oku2 = komut.ExecuteReader();
            while (oku2.Read())
            {
                comboBox2.Items.Add(oku2[0].ToString());
            }
            oku2.Close();
            baglanti.Close();


            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "select * from urun where [urun_adi]='" + textBox1.Text + "'";
            OleDbDataReader oku4 = komut.ExecuteReader();
            if (oku4.Read())
            {
                id = Convert.ToInt32(oku4[2]);
            }
            oku4.Close();
            baglanti.Close();


            comboBox3.Items.Clear();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "select * from Model where [id2_id]=" + id + "";
            OleDbDataReader oku3 = komut.ExecuteReader();
            oku.Close();
            while (oku3.Read())
            {
                comboBox3.Items.Add(oku3[0].ToString());
            }
            oku3.Close();
            baglanti.Close();*/
        }
}
