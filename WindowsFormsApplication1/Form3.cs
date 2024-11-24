using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnMusIslem_Click(object sender, EventArgs e)
        {
            Form5 yeni = new Form5();
            yeni.Show();
            this.Hide();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 yeni = new Form1();
            yeni.Show();
            this.Hide();
        }
       
        
        private void Form3_Load(object sender, EventArgs e)
        {
            
            label1.Visible = false;
            label2.Visible = false;
           

            if (label1.Text=="DurgunSalim"&&label2.Text=="1969")
            {
                pictureBox3.ImageLocation = "E:\\Projem\\proje resimleri\\1.jpg";
               
            }
            if (label1.Text== "DurgunFerdi" && label2.Text == "3466")
            {
                pictureBox3.ImageLocation = "C:\\Users\\Ferdi\\Documents\\Projem\\proje resimleri\\2.jpg";
                
            }
            Form4 frm4 = new Form4();
            frm4.label8.Text = label1.Text;
            frm4.label9.Text = label2.Text;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
             if (pictureBox3.ImageLocation=="E:\\Projem\\proje resimleri\\1.jpg")
             {
                 MessageBox.Show("Kullanıcı"+Environment.NewLine+"SALİM DURGUN");
             }
             else if (pictureBox3.ImageLocation == "E:\\Projem\\proje resimleri\\2.jpg")
             {
                 MessageBox.Show("Kullanıcı" + Environment.NewLine + "FERDİ DURGUN");
             }
                
        }

        private void btnUrunIslem_Click(object sender, EventArgs e)
        {
            Form10 yeni = new Form10();
            yeni.Show();
            this.Hide();
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
