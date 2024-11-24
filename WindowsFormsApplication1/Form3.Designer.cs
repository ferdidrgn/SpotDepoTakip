namespace WindowsFormsApplication1
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnSatisIslem = new System.Windows.Forms.Button();
            this.btnStokIslem = new System.Windows.Forms.Button();
            this.btnUrunIslem = new System.Windows.Forms.Button();
            this.btnMusIslem = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "cikis.png");
            this.ımageList1.Images.SetKeyName(1, "list.png");
            this.ımageList1.Images.SetKeyName(2, "musteri.png");
            this.ımageList1.Images.SetKeyName(3, "person.png");
            this.ımageList1.Images.SetKeyName(4, "satış.png");
            this.ımageList1.Images.SetKeyName(5, "stok.png");
            this.ımageList1.Images.SetKeyName(6, "urun.png");
            // 
            // btnCikis
            // 
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCikis.ImageKey = "cikis.png";
            this.btnCikis.ImageList = this.ımageList1;
            this.btnCikis.Location = new System.Drawing.Point(787, 85);
            this.btnCikis.Margin = new System.Windows.Forms.Padding(4);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(161, 113);
            this.btnCikis.TabIndex = 145;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnSatisIslem
            // 
            this.btnSatisIslem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSatisIslem.ImageKey = "satış.png";
            this.btnSatisIslem.ImageList = this.ımageList1;
            this.btnSatisIslem.Location = new System.Drawing.Point(589, 85);
            this.btnSatisIslem.Margin = new System.Windows.Forms.Padding(4);
            this.btnSatisIslem.Name = "btnSatisIslem";
            this.btnSatisIslem.Size = new System.Drawing.Size(155, 113);
            this.btnSatisIslem.TabIndex = 144;
            this.btnSatisIslem.Text = "Satış İşlemleri";
            this.btnSatisIslem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSatisIslem.UseVisualStyleBackColor = true;
            // 
            // btnStokIslem
            // 
            this.btnStokIslem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnStokIslem.ImageKey = "stok.png";
            this.btnStokIslem.ImageList = this.ımageList1;
            this.btnStokIslem.Location = new System.Drawing.Point(395, 208);
            this.btnStokIslem.Margin = new System.Windows.Forms.Padding(4);
            this.btnStokIslem.Name = "btnStokIslem";
            this.btnStokIslem.Size = new System.Drawing.Size(152, 113);
            this.btnStokIslem.TabIndex = 143;
            this.btnStokIslem.Text = "Stok İşlemleri";
            this.btnStokIslem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStokIslem.UseVisualStyleBackColor = true;
            // 
            // btnUrunIslem
            // 
            this.btnUrunIslem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnUrunIslem.ImageIndex = 6;
            this.btnUrunIslem.ImageList = this.ımageList1;
            this.btnUrunIslem.Location = new System.Drawing.Point(217, 85);
            this.btnUrunIslem.Margin = new System.Windows.Forms.Padding(4);
            this.btnUrunIslem.Name = "btnUrunIslem";
            this.btnUrunIslem.Size = new System.Drawing.Size(148, 113);
            this.btnUrunIslem.TabIndex = 142;
            this.btnUrunIslem.Text = "Ürün İşlemleri";
            this.btnUrunIslem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUrunIslem.UseVisualStyleBackColor = true;
            this.btnUrunIslem.Click += new System.EventHandler(this.btnUrunIslem_Click);
            // 
            // btnMusIslem
            // 
            this.btnMusIslem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnMusIslem.ImageKey = "musteri.png";
            this.btnMusIslem.ImageList = this.ımageList1;
            this.btnMusIslem.Location = new System.Drawing.Point(21, 85);
            this.btnMusIslem.Margin = new System.Windows.Forms.Padding(4);
            this.btnMusIslem.Name = "btnMusIslem";
            this.btnMusIslem.Size = new System.Drawing.Size(159, 113);
            this.btnMusIslem.TabIndex = 141;
            this.btnMusIslem.Text = "Müşteri İşlemleri";
            this.btnMusIslem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMusIslem.UseVisualStyleBackColor = true;
            this.btnMusIslem.Click += new System.EventHandler(this.btnMusIslem_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.ErrorImage")));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(696, 367);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(283, 121);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 146;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.ImageKey = "person.png";
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(388, 367);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 113);
            this.button1.TabIndex = 147;
            this.button1.Text = "Müşteri  Fırsatları Düzenle";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 148;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pictureBox3.Location = new System.Drawing.Point(12, 361);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(159, 113);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 149;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 150;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 151;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label3.Location = new System.Drawing.Point(43, 332);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 152;
            this.label3.Text = "KULLANICI:";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(975, 486);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnSatisIslem);
            this.Controls.Add(this.btnStokIslem);
            this.Controls.Add(this.btnUrunIslem);
            this.Controls.Add(this.btnMusIslem);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form3";
            this.Text = "SİSTEM";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnSatisIslem;
        private System.Windows.Forms.Button btnStokIslem;
        private System.Windows.Forms.Button btnUrunIslem;
        private System.Windows.Forms.Button btnMusIslem;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.PictureBox pictureBox3;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;

    }
}