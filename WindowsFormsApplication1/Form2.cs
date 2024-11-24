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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label3.Visible = false;
        }
        Form3 frm3 = new Form3();
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text==""&&textBox2p.Text=="")
            {
                Form3 yeni = new Form3();
                yeni.Show();
                this.Hide();
            }
           
           
            if (textBox1.Text=="durgunsalim"&&textBox2p.Text=="1998")
            {
               MessageBox.Show("Giriş Başarılı Olmuştur"+Environment.NewLine+"HOŞGELDİNİZ SALİM BEY");
               frm3.label1.Text = textBox1.Text;
               frm3.label2.Text = textBox2p.Text;
               frm3.ShowDialog();
               this.Hide();
               
            }
            else if (textBox1.Text=="durgunferdi"&&textBox2p.Text=="3466")
            {
                MessageBox.Show("Giriş Başarılı Olmuştur"+Environment.NewLine+"HOŞGELDİNİZ FERDİ BEY");
                frm3.label1.Text = textBox1.Text;
                frm3.label2.Text = textBox2p.Text;
                frm3.ShowDialog();
                this.Hide();
                
            }

            
            else
            {
                MessageBox.Show(":::Yanlış Girilmiştir.Tekrar Denemenizi Rica Ediyoruz:::");
                label3.Visible=true;
                label3.Text="Kullanıcı adı veya şifre hatalı";
                textBox1.Text = "";
                textBox2p.Text = "";
            }

           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 yeni = new Form1();
            yeni.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/SalimDurgun66/?fref=ts");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form1 yeni = new Form1();
            yeni.Show();
            this.Hide();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
