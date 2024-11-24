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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= spotcu.accdb");
        OleDbCommand komut = new OleDbCommand();
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
            //dataGridView1.Columns["Kimlik"].Visible = false;// DataGridView de gözükmeyecek sütûn
            baglanti.Close();

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form5 yeni = new Form5();
            yeni.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult cevap;
                cevap = MessageBox.Show("Kaydı silmek istediğinizden eminmisiniz", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cevap == DialogResult.Yes && dataGridView1.CurrentRow.Cells[0].Value.ToString().Trim() != "")
                {
                    baglanti.Open();
                    komut.Connection = baglanti;
                    //komut.CommandText = "Delete From  musterikayit  Where [Adi]= '" +textBox2.Text+"'";
                    //"DELETE from musterikayit WHERE Kimlik='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'";
                    komut.CommandText  /*update kullan*/= "DELETE From musteri WHERE [musteri_id]=" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "";
                    komut.ExecuteNonQuery();//hata verirse sql bağlantısı hatalıdır...
                    baglanti.Close();
                    MessageBox.Show(":::Kayıtlar Silindi:::");
                    gridview("Selelct * From musteri");
                }
            }
            catch
            {
                ;
            }
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            gridview("Selelct * From musteri");
            foreach (DataGridViewColumn x in this.dataGridView1.Columns)
                x.SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/SalimDurgun66/?fref=ts");
        }
       
    }
}
