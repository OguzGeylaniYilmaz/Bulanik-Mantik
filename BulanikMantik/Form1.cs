using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BulanikMantik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void cizim(double sayi)
        {
            if (sayi == 0)
            {
                Graphics g = pictureBox1.CreateGraphics();
                var p = new Pen(Color.Black, 3);
                var point1 = new Point(70, 310);
                var point2 = new Point(70, 25);
                g.DrawLine(p, point1, point2);
            }

            else if (sayi <= 20)
            {
                Graphics g = pictureBox1.CreateGraphics();
                var p = new Pen(Color.Black, 3);
                int p1 = Convert.ToInt32((61 + (3 * sayi)));
                var point1 = new Point(p1, 310);
                var point2 = new Point(p1, 25);
                g.DrawLine(p, point1, point2);
            }
            else if (sayi <= 27.4 & sayi >= 20.1)
            {
                Graphics g = pictureBox1.CreateGraphics();
                var p = new Pen(Color.Black, 3);
                int p1 = Convert.ToInt32(120 + sayi - 20);
                var point1 = new Point(p1, 310);
                var point2 = new Point(p1, 25);
                g.DrawLine(p, point1, point2);

            }
            else if (sayi==27.5)
            {
                Graphics g = pictureBox1.CreateGraphics();
                var p = new Pen(Color.Black, 3);
                
                var point1 = new Point(135, 310);
                var point2 = new Point(135, 25);
                g.DrawLine(p, point1, point2);
            }
            else if (sayi >= 27.6 & sayi <= 40)
            {
                Graphics g = pictureBox1.CreateGraphics();
                var p = new Pen(Color.Black, 3);
                int p1 = Convert.ToInt32(135 + sayi - 8);
                var point1 = new Point(p1, 310);
                var point2 = new Point(p1, 25);
                g.DrawLine(p, point1, point2);

            }
            else if (sayi >= 40.1 & sayi <= 46.9)
            {
                Graphics g = pictureBox1.CreateGraphics();
                var p = new Pen(Color.Black, 3);
                int p1 = Convert.ToInt32(167 + sayi - 39);
                var point1 = new Point(p1, 310);
                var point2 = new Point(p1, 25);
                g.DrawLine(p, point1, point2);

            }
            else if (sayi >= 47 & sayi <= 48)
            {
                Graphics g = pictureBox1.CreateGraphics();
                var p = new Pen(Color.Black, 3);

                var point1 = new Point(184, 310);
                var point2 = new Point(184, 25);
                g.DrawLine(p, point1, point2);
            }
            else if (sayi <= 60 & sayi >= 48.1)
            {
                Graphics g = pictureBox1.CreateGraphics();
                var p = new Pen(Color.Black, 3);
                int p1 = Convert.ToInt32(184 + sayi - 27);
                var point1 = new Point(p1, 310);
                var point2 = new Point(p1, 25);
                g.DrawLine(p, point1, point2);
            }
            else if (sayi <= 67.5 & sayi >= 60.1)
            {
                Graphics g = pictureBox1.CreateGraphics();
                var p = new Pen(Color.Black, 3);
                int p1 = Convert.ToInt32(217 + sayi - 50);
                var point1 = new Point(p1, 310);
                var point2 = new Point(p1, 25);
                g.DrawLine(p, point1, point2);
            }
            else if (sayi <= 80 & sayi >= 67.6)
            {
                Graphics g = pictureBox1.CreateGraphics();
                var p = new Pen(Color.Black, 3);
                int p1 = Convert.ToInt32(234 + sayi - 49);
                var point1 = new Point(p1, 310);
                var point2 = new Point(p1, 25);
                g.DrawLine(p, point1, point2);
            }
            else if (sayi <= 90 & sayi >= 80.1)
            {
                Graphics g = pictureBox1.CreateGraphics();
                var p = new Pen(Color.Black, 3);
                int p1 = Convert.ToInt32(265 + sayi - 71);
                var point1 = new Point(p1, 310);
                var point2 = new Point(p1, 25);
                g.DrawLine(p, point1, point2);
            }
            else if (sayi <= 100 & sayi >= 90.1)
            {
                Graphics g = pictureBox1.CreateGraphics();
                var p = new Pen(Color.Black, 3);
                int p1 = Convert.ToInt32(284 + sayi - 72);
                var point1 = new Point(p1, 310);
                var point2 = new Point(p1, 25);
                g.DrawLine(p, point1, point2);
            }


        }
        void grafik2(double sayi)
        {
            if (sayi == 0)
            {
                Graphics g = pictureBox2.CreateGraphics();
                var p = new Pen(Color.Black, 3);
                var point1 = new Point(68, 310);
                var point2 = new Point(68, 25);
                g.DrawLine(p, point1, point2);
            }
            
            else if (sayi<= 0.9)
            { 
                Graphics g = pictureBox2.CreateGraphics();
                var p = new Pen(Color.Black, 3);
                int p1 = Convert.ToInt32((80+ (3 * (sayi*10))));
                var point1 = new Point(p1, 310);
                var point2 = new Point(p1, 25);
                g.DrawLine(p, point1, point2);
            }
            else if (sayi<=1 & sayi >=1.24 )
            {
                Graphics g = pictureBox2.CreateGraphics();
                var p = new Pen(Color.Black, 3);
                int p1 = Convert.ToInt32(120 + sayi );
                var point1 = new Point(p1, 310);
                var point2 = new Point(p1, 25);
                g.DrawLine(p, point1, point2);

            }
            else if (sayi == 1.25)
            {
                Graphics g = pictureBox2.CreateGraphics();
                var p = new Pen(Color.Black, 3);

                var point1 = new Point(135, 310);
                var point2 = new Point(135, 25);
                g.DrawLine(p, point1, point2);
            }
            else if (sayi >= 1.26 & sayi <= 2)
            {
                Graphics g = pictureBox2.CreateGraphics();
                var p = new Pen(Color.Black, 3);
                int p1 = Convert.ToInt32(155 + sayi*10);
                var point1 = new Point(p1, 310);
                var point2 = new Point(p1, 25);
                g.DrawLine(p, point1, point2);

            }
            else if (sayi >= 2.1 & sayi <= 2.4)
            {
                Graphics g = pictureBox2.CreateGraphics();
                var p = new Pen(Color.Black, 3);
                int p1 = Convert.ToInt32(156+sayi*10);
                var point1 = new Point(p1, 310);
                var point2 = new Point(p1, 25);
                g.DrawLine(p, point1, point2);

            }
            else if (sayi >= 2.5 & sayi <= 2.9)
            {
                Graphics g = pictureBox2.CreateGraphics();
                var p = new Pen(Color.Black, 3);

                var point1 = new Point(203, 310);
                var point2 = new Point(203, 25);
                g.DrawLine(p, point1, point2);
            }
            else if (sayi <= 3.5 & sayi >= 3)
            {
                Graphics g = pictureBox2.CreateGraphics();
                var p = new Pen(Color.Black, 3);
                int p1 = Convert.ToInt32(205+ sayi*10);
                var point1 = new Point(p1, 310);
                var point2 = new Point(p1, 25);
                g.DrawLine(p, point1, point2);
            }
            else if (sayi <= 3.74 & sayi >= 3.6)
            {
                Graphics g = pictureBox2.CreateGraphics();
                var p = new Pen(Color.Black, 3);
                int p1 = Convert.ToInt32(233+sayi*10);
                var point1 = new Point(p1, 310);
                var point2 = new Point(p1, 25);
                g.DrawLine(p, point1, point2);
            }
            else if (sayi <=3.75 & sayi >= 3.76)
            {
                Graphics g = pictureBox2.CreateGraphics();
                var p = new Pen(Color.Black, 3);
                int p1 = Convert.ToInt32(225 + sayi*10);
                var point1 = new Point(p1, 310);
                var point2 = new Point(p1, 25);
                g.DrawLine(p, point1, point2);
            }
            else if (sayi <= 4.5 & sayi >= 3.76)
            {
                Graphics g = pictureBox2.CreateGraphics();
                var p = new Pen(Color.Black, 3);
                int p1 = Convert.ToInt32(267+sayi*10);
                var point1 = new Point(p1, 310);
                var point2 = new Point(p1, 25);
                g.DrawLine(p, point1, point2);
            }
            else if (sayi <= 5 & sayi >= 4.6)
            {
                Graphics g = pictureBox2.CreateGraphics();
                var p = new Pen(Color.Black, 3);
                int p1 = Convert.ToInt32(290 + sayi*10);
                var point1 = new Point(p1, 310);
                var point2 = new Point(p1, 25);
                g.DrawLine(p, point1, point2);
            }
        }
        void grafik3(double sayi)
        {
            if (sayi == 0)
            {
                Graphics g = pictureBox3.CreateGraphics();
                var p = new Pen(Color.Black, 3);
                var point1 = new Point(68, 310);
                var point2 = new Point(68, 25);
                g.DrawLine(p, point1, point2);
            }

            else if (sayi <= 0.9)
            {
                Graphics g = pictureBox3.CreateGraphics();
                var p = new Pen(Color.Black, 3);
                int p1 = Convert.ToInt32((80 + (3 * (sayi * 10))));
                var point1 = new Point(p1, 310);
                var point2 = new Point(p1, 25);
                g.DrawLine(p, point1, point2);
            }
            else if (sayi <= 1 & sayi >= 1.24)
            {
                Graphics g = pictureBox3.CreateGraphics();
                var p = new Pen(Color.Black, 3);
                int p1 = Convert.ToInt32(120 + sayi);
                var point1 = new Point(p1, 310);
                var point2 = new Point(p1, 25);
                g.DrawLine(p, point1, point2);

            }
            else if (sayi == 1.25)
            {
                Graphics g = pictureBox3.CreateGraphics();
                var p = new Pen(Color.Black, 3);

                var point1 = new Point(135, 310);
                var point2 = new Point(135, 25);
                g.DrawLine(p, point1, point2);
            }
            else if (sayi >= 1.26 & sayi <= 2)
            {
                Graphics g = pictureBox3.CreateGraphics();
                var p = new Pen(Color.Black, 3);
                int p1 = Convert.ToInt32(155 + sayi * 10);
                var point1 = new Point(p1, 310);
                var point2 = new Point(p1, 25);
                g.DrawLine(p, point1, point2);

            }
            else if (sayi >= 2.1 & sayi <= 2.4)
            {
                Graphics g = pictureBox3.CreateGraphics();
                var p = new Pen(Color.Black, 3);
                int p1 = Convert.ToInt32(156 + sayi * 10);
                var point1 = new Point(p1, 310);
                var point2 = new Point(p1, 25);
                g.DrawLine(p, point1, point2);

            }
            else if (sayi >= 2.5 & sayi <= 2.9)
            {
                Graphics g = pictureBox3.CreateGraphics();
                var p = new Pen(Color.Black, 3);

                var point1 = new Point(203, 310);
                var point2 = new Point(203, 25);
                g.DrawLine(p, point1, point2);
            }
            else if (sayi <= 3.5 & sayi >= 3)
            {
                Graphics g = pictureBox3.CreateGraphics();
                var p = new Pen(Color.Black, 3);
                int p1 = Convert.ToInt32(205 + sayi * 10);
                var point1 = new Point(p1, 310);
                var point2 = new Point(p1, 25);
                g.DrawLine(p, point1, point2);
            }
            else if (sayi <= 3.74 & sayi >= 3.6)
            {
                Graphics g = pictureBox3.CreateGraphics();
                var p = new Pen(Color.Black, 3);
                int p1 = Convert.ToInt32(233 + sayi * 10);
                var point1 = new Point(p1, 310);
                var point2 = new Point(p1, 25);
                g.DrawLine(p, point1, point2);
            }
            else if (sayi <= 3.75 & sayi >= 3.76)
            {
                Graphics g = pictureBox3.CreateGraphics();
                var p = new Pen(Color.Black, 3);
                int p1 = Convert.ToInt32(225 + sayi * 10);
                var point1 = new Point(p1, 310);
                var point2 = new Point(p1, 25);
                g.DrawLine(p, point1, point2);
            }
            else if (sayi <= 4.5 & sayi >= 3.76)
            {
                Graphics g = pictureBox3.CreateGraphics();
                var p = new Pen(Color.Black, 3);
                int p1 = Convert.ToInt32(267 + sayi * 10);
                var point1 = new Point(p1, 310);
                var point2 = new Point(p1, 25);
                g.DrawLine(p, point1, point2);
            }
            else if (sayi <= 10 & sayi >= 4.6)
            {
                Graphics g = pictureBox3.CreateGraphics();
                var p = new Pen(Color.Black, 3);
                int p1 = Convert.ToInt32(290 + sayi * 10);
                var point1 = new Point(p1, 310);
                var point2 = new Point(p1, 25);
                g.DrawLine(p, point1, point2);
            }
        }
        Girisler grsler = new Girisler();
        Cıkıs cks = new Cıkıs();
        private void btnHesapla_Click(object sender, EventArgs e)
        {
           
            double ÜyelikSıcaklık = 0;
            double ÜyelikSeviye = 0;
            if (txtSıcaklık.Text == "")
            {
                MessageBox.Show("Sıcaklık tablosuna uygun değerler giriniz!!");
            }
            if (txtSeviye.Text == "")
            {
                MessageBox.Show("Seviye tablosuna uygun değerler giriniz!!");
            }
            double sicaklik = Convert.ToDouble(txtSıcaklık.Text);
            double seviye = Convert.ToDouble(txtSeviye.Text);
            cizim(sicaklik);
            grafik2(seviye);
            if (sicaklik > 100)
            {
                MessageBox.Show("Sıcaklık tablosuna uygun değerler giriniz!!");
            }
            if (seviye > 5)
            {
                MessageBox.Show("Seviye tablosuna uygun değerler giriniz!!");
            }
           

            //Sıcaklık Üyelik Hesapları
            if (sicaklik>=0 && sicaklik<=20)
            {
                if (sicaklik >= 0 && sicaklik <= 10)
                {
                    ÜyelikSıcaklık = 1;
                }
                if (sicaklik >= 10 && sicaklik <= 20)
                {
                    ÜyelikSıcaklık = (20 - sicaklik) / 10;
                }
                if (sicaklik > 20)
                {
                    ÜyelikSıcaklık = 0;
                }
                lblCokDüsük.Text = ÜyelikSıcaklık.ToString();
            }
            if (sicaklik >= 15 && sicaklik <= 40)
            {
                
                if (sicaklik > 40 && sicaklik < 15)
                {
                    ÜyelikSıcaklık = 0;
                }
                if (sicaklik >= 15 && sicaklik <= 27.5)
                {
                    ÜyelikSıcaklık = (sicaklik-15)/12.5;
                }
                if (sicaklik >= 27.5 && sicaklik <= 40)
                {
                    ÜyelikSıcaklık = (40-sicaklik)/12.5;
                }
                lblDüsük.Text = ÜyelikSıcaklık.ToString();
            }
            if (sicaklik >= 35 && sicaklik <= 60)
            {

                if (sicaklik > 60 && sicaklik < 35)
                {
                    ÜyelikSıcaklık = 0;
                }
                if (sicaklik >= 35 && sicaklik <= 47.5)
                {
                    ÜyelikSıcaklık = (sicaklik - 35) / 12.5;
                }
                if (sicaklik >=47.5  && sicaklik <= 60)
                {
                    ÜyelikSıcaklık = (60 - sicaklik) / 12.5;
                }
                lblOrta.Text = ÜyelikSıcaklık.ToString();
            }
            if (sicaklik >= 55 && sicaklik <= 80)
            {

                if (sicaklik > 80 && sicaklik < 55)
                {
                    ÜyelikSıcaklık = 0;
                }
                if (sicaklik >= 55 && sicaklik <= 67.5)
                {
                    ÜyelikSıcaklık = (sicaklik - 55) / 12.5;
                }
                if (sicaklik >= 67.5 && sicaklik <= 80)
                {
                    ÜyelikSıcaklık = (80 - sicaklik) / 12.5;
                }
                lblYüksek.Text = ÜyelikSıcaklık.ToString();
            }
            if (sicaklik >= 75 && sicaklik <= 100)
            {
                if (sicaklik >= 90 && sicaklik <= 100)
                {
                    ÜyelikSıcaklık = 1;
                }
                if (sicaklik >= 75 && sicaklik <= 90)
                {
                    ÜyelikSıcaklık = (sicaklik-75) / 15;
                }
                if (sicaklik < 75)
                {
                    ÜyelikSıcaklık = 0;
                }
                lblCokYüksek.Text = ÜyelikSıcaklık.ToString();
            }
            //Seviye Üyelik Hesapları
            if (seviye >= 0 && seviye <= 1)
            {
                if (seviye >= 0 && seviye <= 0.5)
                {
                    ÜyelikSeviye = 1;
                }
                if (seviye >=0.5  && seviye <= 1)
                {
                    ÜyelikSeviye = (1 - seviye) / 0.75;
                }
                if (seviye > 1)
                {
                    ÜyelikSeviye = 0;
                }
                lblSCokDüsük.Text = ÜyelikSeviye.ToString();
            }
            if (seviye >= 0.5 && seviye <= 2)
            {
                if (seviye > 2 || seviye < 0.5)
                {
                    ÜyelikSeviye = 0;
                }
                if (seviye >= 0.5 && seviye <= 1.25)
                {
                    ÜyelikSeviye = (seviye-0.5) / 0.75;
                }
                if (seviye >= 1.25 && seviye <= 2)
                {
                    ÜyelikSeviye = (2-seviye) / 0.75;
                }

                lblSDüsük.Text = ÜyelikSeviye.ToString();
            }
            if (seviye >= 1.5 && seviye <= 3.5)
            {
                if (seviye > 3.5 || seviye < 1.5)
                {
                    ÜyelikSeviye = 0;
                }
                if (seviye >= 1.5 && seviye <= 2.5)
                {
                    ÜyelikSeviye = (seviye - 1.5) / 1;
                }
                if (seviye >= 2.5 && seviye <= 3.5)
                {
                    ÜyelikSeviye = (3.5- seviye) / 1;
                }

                lblSOrta.Text = ÜyelikSeviye.ToString();
            }
            if (seviye >= 3 && seviye <= 4.5)
            {
                if (seviye > 4.5 || seviye < 3)
                {
                    ÜyelikSeviye = 0;
                }
                if (seviye >= 3 && seviye <= 3.75)
                {
                    ÜyelikSeviye = (seviye - 3) / 0.75;
                }
                if (seviye >= 3.75 && seviye <= 4.5)
                {
                    ÜyelikSeviye = (4.5 - seviye) / 0.75;
                }

                lblSYüksek.Text = ÜyelikSeviye.ToString();
            }
            if (seviye >= 4 && seviye <= 5)
            {
                if (seviye >= 4.5 && seviye <= 5)
                {
                    ÜyelikSeviye = 1;
                }
                if (seviye >= 4 && seviye <= 4.5)
                {
                    ÜyelikSeviye = (seviye - 4) / 0.5;
                }
                if (seviye < 4 )
                {
                    ÜyelikSeviye = 0;
                }
                lblSCokYüksek.Text = ÜyelikSeviye.ToString();
            }
            double[] degerler = new double[50];
            double[] cıkıslar = new double[50];
            //Uygulanan Kurallar
            //Cok Düsük için Kurallar
            if (Convert.ToDouble(lblCokDüsük.Text) > 0)
            {
                if (Convert.ToDouble(lblSCokDüsük.Text) > 0)
                {
                    if (Convert.ToDouble(lblSCokDüsük.Text) > Convert.ToDouble(lblCokDüsük.Text))
                    {
                        listBox1.Items.Add("EĞER Su Sıcaklığı Çok Düşük(" + lblCokDüsük.Text + ")" + " ve Su Seviyesi Çok Düşük(" + lblSCokDüsük.Text + ")" + " O HALDE Çıkış Orta(" +lblCokDüsük.Text+")");
                        degerler[0] = Convert.ToDouble(lblCokDüsük.Text);
                        double x1 = ((Convert.ToDouble(lblCokDüsük.Text) * 1) + 1.5) * (Convert.ToDouble(lblCokDüsük.Text));
                        double x2 = (3.5 - (Convert.ToDouble(lblCokDüsük.Text) * 1)) * (Convert.ToDouble(lblCokDüsük.Text));
                        cıkıslar[0] = x1 + x2;
                    }
                    if (Convert.ToDouble(lblCokDüsük.Text) > Convert.ToDouble(lblSCokDüsük.Text))
                    {
                        listBox1.Items.Add("EĞER Su Sıcaklığı Çok Düşük(" + lblCokDüsük.Text + ")" + " ve Su Seviyesi Çok Düşük(" + lblSCokDüsük.Text + ")" + " O HALDE Çıkış Orta(" + lblSCokDüsük.Text + ")");
                        degerler[1] = Convert.ToDouble(lblSCokDüsük.Text);
                        double x1 = ((Convert.ToDouble(lblSCokDüsük.Text) * 1) + 1.5) * (Convert.ToDouble(lblSCokDüsük.Text));
                        double x2 = (3.5 - (Convert.ToDouble(lblSCokDüsük.Text) * 1)) * (Convert.ToDouble(lblSCokDüsük.Text));
                        cıkıslar[1] = x1 + x2;
                    }
                }
                if (Convert.ToDouble(lblSDüsük.Text) > 0)
                {
                    if (Convert.ToDouble(lblSDüsük.Text) > Convert.ToDouble(lblCokDüsük.Text))
                    {
                        listBox1.Items.Add("EĞER Su Sıcaklığı Çok Düşük(" + lblCokDüsük.Text + ")" + " ve Su Seviyesi Düşük(" + lblSDüsük.Text + ")" + " O HALDE Çıkış Az(" + lblCokDüsük.Text + ")");
                        degerler[2] = Convert.ToDouble(lblCokDüsük.Text);
                        double x1 = ((Convert.ToDouble(lblCokDüsük.Text) * 0.75) + 0.5) * (Convert.ToDouble(lblCokDüsük.Text));
                        double x2 = (2 - (Convert.ToDouble(lblCokDüsük.Text) * 0.75)) * (Convert.ToDouble(lblCokDüsük.Text));
                        cıkıslar[2] = x1 + x2;
                    }
                    if (Convert.ToDouble(lblCokDüsük.Text) > Convert.ToDouble(lblSDüsük.Text))
                    {
                        listBox1.Items.Add("EĞER Su Sıcaklığı Çok Düşük(" + lblCokDüsük.Text + ")" + " ve Su Seviyesi Düşük(" + lblSDüsük.Text + ")" + " O HALDE Çıkış Az(" + lblSDüsük.Text + ")");
                        degerler[3] = Convert.ToDouble(lblSDüsük.Text);
                        double x1 = ((Convert.ToDouble(lblSDüsük.Text) * 0.75) + 0.5) * (Convert.ToDouble(lblSDüsük.Text));
                        double x2 = (2 - (Convert.ToDouble(lblSDüsük.Text) * 0.75)) * (Convert.ToDouble(lblSDüsük.Text));
                        cıkıslar[3] = x1 + x2;
                    }

                }
                if (Convert.ToDouble(lblSOrta.Text) > 0)
                {
                    if (Convert.ToDouble(lblSOrta.Text) > Convert.ToDouble(lblCokDüsük.Text))
                    {
                        listBox1.Items.Add("EĞER Su Sıcaklığı Çok Düşük(" + lblCokDüsük.Text + ")" + " ve Su Seviyesi Orta(" + lblSOrta.Text + ")" + " O HALDE Çıkış Çok Az(" + lblCokDüsük.Text + ")");
                        degerler[4] = Convert.ToDouble(lblCokDüsük.Text);
                        
                        double x2 = (1 - (Convert.ToDouble(lblCokDüsük.Text) * 0.5)) * (Convert.ToDouble(lblCokDüsük.Text));
                        cıkıslar[4] =x2;
                    }
                    if (Convert.ToDouble(lblCokDüsük.Text) > Convert.ToDouble(lblSOrta.Text))
                    {
                        listBox1.Items.Add("EĞER Su Sıcaklığı Çok Düşük(" + lblCokDüsük.Text + ")" + " ve Su Seviyesi Orta(" + lblSOrta.Text + ")" + " O HALDE Çıkış Çok Az(" + lblSOrta.Text + ")");
                        degerler[5] = Convert.ToDouble(lblSOrta.Text);
                        double x2 = (1 - (Convert.ToDouble(lblSOrta.Text) * 0.5)) * (Convert.ToDouble(lblSOrta.Text));
                        cıkıslar[5] = x2;
                    }

                }
                if (Convert.ToDouble(lblSYüksek.Text) > 0)
                {
                    if (Convert.ToDouble(lblSYüksek.Text) > Convert.ToDouble(lblCokDüsük.Text))
                    {
                        listBox1.Items.Add("EĞER Su Sıcaklığı Çok Düşük(" + lblCokDüsük.Text + ")" + " ve Su Seviyesi Yüksek(" + lblSYüksek.Text + ")" + " O HALDE Çıkış Çıkışta Hareket Yok(" + lblCokDüsük.Text + ")");
                        degerler[6] = Convert.ToDouble(lblCokDüsük.Text);

                    }
                    if (Convert.ToDouble(lblCokDüsük.Text) > Convert.ToDouble(lblSYüksek.Text))
                    {
                        listBox1.Items.Add("EĞER Su Sıcaklığı Çok Düşük(" + lblCokDüsük.Text + ")" + " ve Su Seviyesi Yüksek(" + lblSYüksek.Text + ")" + " O HALDE Çıkış Çıkışta Hareket Yok(" + lblSYüksek.Text + ")");
                        degerler[7] = Convert.ToDouble(lblSYüksek.Text);
                    }

                }
                if (Convert.ToDouble(lblSCokYüksek.Text) > 0)
                {
                    if (Convert.ToDouble(lblSCokYüksek.Text) > Convert.ToDouble(lblCokDüsük.Text))
                    {
                        listBox1.Items.Add("EĞER Su Sıcaklığı Çok Düşük(" + lblCokDüsük.Text + ")" + " ve Su Seviyesi Çok Yüksek(" + lblSCokYüksek.Text + ")" + " O HALDE Çıkış Çıkışta Hareket Yok(" + lblCokDüsük.Text + ")");
                        degerler[8] = Convert.ToDouble(lblCokDüsük.Text);
                    }
                    if (Convert.ToDouble(lblCokDüsük.Text) > Convert.ToDouble(lblSCokYüksek.Text))
                    {
                        listBox1.Items.Add("EĞER Su Sıcaklığı Çok Düşük(" + lblCokDüsük.Text + ")" + " ve Su Seviyesi Çok Yüksek(" + lblSCokYüksek.Text + ")" + " O HALDE Çıkış Çıkışta Hareket Yok(" + lblSCokYüksek.Text + ")");
                        degerler[9] = Convert.ToDouble(lblSCokYüksek.Text);
                    }

                }
            }
            //Düsük için Kurallar
            if (Convert.ToDouble(lblDüsük.Text) > 0)
            {
                if (Convert.ToDouble(lblSCokDüsük.Text) > 0)
                {
                    if (Convert.ToDouble(lblSCokDüsük.Text) > Convert.ToDouble(lblDüsük.Text))
                    {
                        listBox1.Items.Add("EĞER Su Sıcaklığı Düşük(" + lblDüsük.Text + ")" + " ve Su Seviyesi Çok Düşük(" + lblSCokDüsük.Text + ")" + " O HALDE Çıkış Çok(" + lblDüsük.Text + ")");
                        degerler[10] = Convert.ToDouble(lblDüsük.Text);
                        double x1 = ((Convert.ToDouble(lblDüsük.Text) * 0.75) + 3) * (Convert.ToDouble(lblDüsük.Text));
                        double x2 = (4.5 - (Convert.ToDouble(lblDüsük.Text) * 0.75)) * (Convert.ToDouble(lblDüsük.Text));
                        cıkıslar[6] = x1 + x2;
                    }
                    if (Convert.ToDouble(lblDüsük.Text) > Convert.ToDouble(lblSCokDüsük.Text))
                    {
                        listBox1.Items.Add("EĞER Su Sıcaklığı Düşük(" + lblDüsük.Text + ")" + " ve Su Seviyesi Çok Düşük(" + lblSCokDüsük.Text + ")" + " O HALDE Çıkış Çok(" + lblSCokDüsük.Text + ")");
                        degerler[11] = Convert.ToDouble(lblSCokDüsük.Text);
                        double x1 = ((Convert.ToDouble(lblSCokDüsük.Text) * 0.75) + 3) * (Convert.ToDouble(lblSCokDüsük.Text));
                        double x2 = (4.5 - (Convert.ToDouble(lblSCokDüsük.Text) * 0.75)) * (Convert.ToDouble(lblSCokDüsük.Text));
                        cıkıslar[7] = x1 + x2;
                    }
                }
                if (Convert.ToDouble(lblSDüsük.Text) > 0)
                {
                    if (Convert.ToDouble(lblSDüsük.Text) > Convert.ToDouble(lblDüsük.Text))
                    {
                        listBox1.Items.Add("EĞER Su Sıcaklığı Düşük(" + lblDüsük.Text + ")" + " ve Su Seviyesi Düşük(" + lblSDüsük.Text + ")" + " O HALDE Çıkış Orta(" + lblDüsük.Text + ")");
                        degerler[12] = Convert.ToDouble(lblDüsük.Text);
                        double x1 = ((Convert.ToDouble(lblDüsük.Text) * 1) + 1.5) * (Convert.ToDouble(lblDüsük.Text));
                        double x2 = (3.5 - (Convert.ToDouble(lblDüsük.Text) * 1)) * (Convert.ToDouble(lblDüsük.Text));
                        cıkıslar[8] = x1 + x2;
                    }
                    if (Convert.ToDouble(lblDüsük.Text) > Convert.ToDouble(lblSDüsük.Text))
                    {
                        listBox1.Items.Add("EĞER Su Sıcaklığı Düşük(" + lblDüsük.Text + ")" + " ve Su Seviyesi Düşük(" + lblSDüsük.Text + ")" + " O HALDE Çıkış Orta(" + lblSDüsük.Text + ")");
                        degerler[13] = Convert.ToDouble(lblSDüsük.Text);
                        double x1 = ((Convert.ToDouble(lblSDüsük.Text) * 1) + 1.5) * (Convert.ToDouble(lblSDüsük.Text));
                        double x2 = (3.5 - (Convert.ToDouble(lblSDüsük.Text) * 1)) * (Convert.ToDouble(lblSDüsük.Text));
                        cıkıslar[9] = x1 + x2;
                    }

                }
                if (Convert.ToDouble(lblSOrta.Text) > 0)
                {
                    if (Convert.ToDouble(lblSOrta.Text) > Convert.ToDouble(lblDüsük.Text))
                    {
                        listBox1.Items.Add("EĞER Su Sıcaklığı Düşük(" + lblDüsük.Text + ")" + " ve Su Seviyesi Orta(" + lblSOrta.Text + ")" + " O HALDE Çıkış Çok Az(" + lblDüsük.Text + ")");
                        degerler[14] = Convert.ToDouble(lblDüsük.Text);
                        double x2 = (1 - (Convert.ToDouble(lblDüsük.Text) * 0.5)) * (Convert.ToDouble(lblDüsük.Text));
                        cıkıslar[10] = x2;
                    }
                    if (Convert.ToDouble(lblDüsük.Text) > Convert.ToDouble(lblSOrta.Text))
                    {
                        listBox1.Items.Add("EĞER Su Sıcaklığı Düşük(" + lblDüsük.Text + ")" + " ve Su Seviyesi Orta(" + lblSOrta.Text + ")" + " O HALDE Çıkış Çok Az(" + lblSOrta.Text + ")");
                        degerler[15] = Convert.ToDouble(lblSOrta.Text);
                        double x2 = (1 - (Convert.ToDouble(lblSOrta.Text) * 0.5)) * (Convert.ToDouble(lblSOrta.Text));
                        cıkıslar[11] = x2;
                    }

                }
                if (Convert.ToDouble(lblSYüksek.Text) > 0)
                {
                    if (Convert.ToDouble(lblSYüksek.Text) > Convert.ToDouble(lblDüsük.Text))
                    {
                        listBox1.Items.Add("EĞER Su Sıcaklığı Düşük(" + lblDüsük.Text + ")" + " ve Su Seviyesi Yüksek(" + lblSYüksek.Text + ")" + " O HALDE Çıkış Çok Az(" + lblDüsük.Text + ")");
                        degerler[16] = Convert.ToDouble(lblDüsük.Text);
                        double x2 = (1 - (Convert.ToDouble(lblDüsük.Text) * 0.5)) * (Convert.ToDouble(lblDüsük.Text));
                        cıkıslar[12] = x2;
                    }
                    if (Convert.ToDouble(lblDüsük.Text) > Convert.ToDouble(lblSYüksek.Text))
                    {
                        listBox1.Items.Add("EĞER Su Sıcaklığı Düşük(" + lblDüsük.Text + ")" + " ve Su Seviyesi Yüksek(" + lblSYüksek.Text + ")" + " O HALDE Çıkış Çok Az(" + lblSYüksek.Text + ")");
                        degerler[17] = Convert.ToDouble(lblSYüksek.Text);
                        double x2 = (1 - (Convert.ToDouble(lblSYüksek.Text) * 0.5)) * (Convert.ToDouble(lblSYüksek.Text));
                        cıkıslar[13] = x2;
                    }

                }
                if (Convert.ToDouble(lblSCokYüksek.Text) > 0)
                {
                    if (Convert.ToDouble(lblSCokYüksek.Text) > Convert.ToDouble(lblDüsük.Text))
                    {
                        listBox1.Items.Add("EĞER Su Sıcaklığı Düşük(" + lblDüsük.Text + ")" + " ve Su Seviyesi Çok Yüksek(" + lblSCokYüksek.Text + ")" + " O HALDE Çıkış Çıkışta Hareket Yok(" + lblDüsük.Text + ")");
                        degerler[18] = Convert.ToDouble(lblDüsük.Text);
                    }
                    if (Convert.ToDouble(lblDüsük.Text) > Convert.ToDouble(lblSCokYüksek.Text))
                    {
                        listBox1.Items.Add("EĞER Su Sıcaklığı Düşük(" + lblDüsük.Text + ")" + " ve Su Seviyesi Çok Yüksek(" + lblSCokYüksek.Text + ")" + " O HALDE Çıkış Çıkışta Hareket Yok(" + lblSCokYüksek.Text + ")");
                        degerler[19] = Convert.ToDouble(lblSCokYüksek.Text);
                    }

                }
            }
            //Orta İçin 
            if (Convert.ToDouble(lblOrta.Text) > 0)
            {
                if (Convert.ToDouble(lblSCokDüsük.Text) > 0)
                {
                    if (Convert.ToDouble(lblSCokDüsük.Text) > Convert.ToDouble(lblOrta.Text))
                    {
                        listBox1.Items.Add("EĞER Su Sıcaklığı Orta(" + lblOrta.Text + ")" + " ve Su Seviyesi Çok Düşük(" + lblSCokDüsük.Text + ")" + " O HALDE Çıkış Aşırı Çok(" + lblOrta.Text + ")");
                        degerler[20] = Convert.ToDouble(lblOrta.Text);
                        double x1 = ((Convert.ToDouble(lblOrta.Text) * 0.5) + 4) * (Convert.ToDouble(lblOrta.Text));
                        cıkıslar[14] = x1 ;
                    }
                    if (Convert.ToDouble(lblOrta.Text) > Convert.ToDouble(lblSCokDüsük.Text))
                    {
                        listBox1.Items.Add("EĞER Su Sıcaklığı Orta(" + lblOrta.Text + ")" + " ve Su Seviyesi Çok Düşük(" + lblSCokDüsük.Text + ")" + " O HALDE Çıkış Aşırı Çok(" + lblSCokDüsük.Text + ")");
                        degerler[21] = Convert.ToDouble(lblSCokDüsük.Text);
                        double x1 = ((Convert.ToDouble(lblSCokDüsük.Text) * 0.5) + 4) * (Convert.ToDouble(lblSCokDüsük.Text));
                        cıkıslar[15] = x1;
                    }
                }
                if (Convert.ToDouble(lblSDüsük.Text) > 0)
                {
                    if (Convert.ToDouble(lblSDüsük.Text) > Convert.ToDouble(lblOrta.Text))
                    {
                        listBox1.Items.Add("EĞER Su Sıcaklığı Orta(" + lblOrta.Text + ")" + " ve Su Seviyesi Düşük(" + lblSDüsük.Text + ")" + " O HALDE Çıkış Çok(" + lblOrta.Text + ")");
                        degerler[22] = Convert.ToDouble(lblOrta.Text);
                        double x1 = ((Convert.ToDouble(lblOrta.Text) * 0.75) + 3) * (Convert.ToDouble(lblOrta.Text));
                        double x2 = (4.5 - (Convert.ToDouble(lblOrta.Text) * 0.75)) * (Convert.ToDouble(lblOrta.Text));
                        cıkıslar[16] = x1 + x2;
                    }
                    if (Convert.ToDouble(lblOrta.Text) > Convert.ToDouble(lblSDüsük.Text))
                    {
                        listBox1.Items.Add("EĞER Su Sıcaklığı Orta(" + lblOrta.Text + ")" + " ve Su Seviyesi Düşük(" + lblSDüsük.Text + ")" + " O HALDE Çıkış Çok(" + lblSDüsük.Text + ")");
                        degerler[23] = Convert.ToDouble(lblSDüsük.Text);
                        double x1 = ((Convert.ToDouble(lblSDüsük.Text) * 0.75) + 3) * (Convert.ToDouble(lblSDüsük.Text));
                        double x2 = (4.5 - (Convert.ToDouble(lblSDüsük.Text) * 0.75)) * (Convert.ToDouble(lblSDüsük.Text));
                        cıkıslar[17] = x1 + x2;
                    }

                }
                if (Convert.ToDouble(lblSOrta.Text) > 0)
                {
                    if (Convert.ToDouble(lblSOrta.Text) > Convert.ToDouble(lblOrta.Text))
                    {
                        listBox1.Items.Add("EĞER Su Sıcaklığı Orta(" + lblOrta.Text + ")" + " ve Su Seviyesi Orta(" + lblSOrta.Text + ")" + " O HALDE Çıkış Orta(" + lblOrta.Text + ")");
                        degerler[24] = Convert.ToDouble(lblOrta.Text);
                        double x1 = ((Convert.ToDouble(lblOrta.Text) * 1) + 1.5) * (Convert.ToDouble(lblOrta.Text));
                        double x2 = (3.5 - (Convert.ToDouble(lblOrta.Text) * 1)) * (Convert.ToDouble(lblOrta.Text));
                        cıkıslar[18] = x1 + x2;
                    }
                    if (Convert.ToDouble(lblOrta.Text) > Convert.ToDouble(lblSOrta.Text))
                    {
                        listBox1.Items.Add("EĞER Su Sıcaklığı Orta(" + lblOrta.Text + ")" + " ve Su Seviyesi Orta(" + lblSOrta.Text + ")" + " O HALDE Çıkış Orta(" + lblSOrta.Text + ")");
                        degerler[25] = Convert.ToDouble(lblSOrta.Text);
                        double x1 = ((Convert.ToDouble(lblSOrta.Text) * 1) + 1.5) * (Convert.ToDouble(lblSOrta.Text));
                        double x2 = (3.5 - (Convert.ToDouble(lblSOrta.Text) * 1)) * (Convert.ToDouble(lblSOrta.Text));
                        cıkıslar[19] = x1 + x2;
                    }

                }
                if (Convert.ToDouble(lblSYüksek.Text) > 0)
                {
                    if (Convert.ToDouble(lblSYüksek.Text) > Convert.ToDouble(lblOrta.Text))
                    {
                        listBox1.Items.Add("EĞER Su Sıcaklığı Orta(" + lblOrta.Text + ")" + " ve Su Seviyesi Yüksek(" + lblSYüksek.Text + ")" + " O HALDE Çıkış Çok Az(" + lblOrta.Text + ")");
                        degerler[26] = Convert.ToDouble(lblOrta.Text);
                        double x2 = (1 - (Convert.ToDouble(lblOrta.Text) * 0.5)) * (Convert.ToDouble(lblOrta.Text));
                        cıkıslar[20] = x2;

                    }
                    if (Convert.ToDouble(lblOrta.Text) > Convert.ToDouble(lblSYüksek.Text))
                    {
                        listBox1.Items.Add("EĞER Su Sıcaklığı Orta(" + lblOrta.Text + ")" + " ve Su Seviyesi Yüksek(" + lblSYüksek.Text + ")" + " O HALDE Çıkış Çok Az(" + lblSYüksek.Text + ")");
                        degerler[27] = Convert.ToDouble(lblSYüksek.Text);
                        double x2 = (1 - (Convert.ToDouble(lblSYüksek.Text) * 0.5)) * (Convert.ToDouble(lblSYüksek.Text));
                        cıkıslar[21] = x2;
                    }

                }
                if (Convert.ToDouble(lblSCokYüksek.Text) > 0)
                {
                    if (Convert.ToDouble(lblSCokYüksek.Text) > Convert.ToDouble(lblOrta.Text))
                    {
                        listBox1.Items.Add("EĞER Su Sıcaklığı Orta(" + lblOrta.Text + ")" + " ve Su Seviyesi Çok Yüksek(" + lblSCokYüksek.Text + ")" + " O HALDE Çıkış Çıkışta Hareket Yok(" + lblOrta.Text + ")");
                        degerler[28] = Convert.ToDouble(lblOrta.Text);
                    }
                    if (Convert.ToDouble(lblOrta.Text) > Convert.ToDouble(lblSCokYüksek.Text))
                    {
                        listBox1.Items.Add("EĞER Su Sıcaklığı Orta(" + lblOrta.Text + ")" + " ve Su Seviyesi Çok Yüksek(" + lblSCokYüksek.Text + ")" + " O HALDE Çıkış Çıkışta Hareket Yok(" + lblSCokYüksek.Text + ")");
                        degerler[29] = Convert.ToDouble(lblSCokYüksek.Text);
                    }

                }
            }
            //Yüksek İçin
            if (Convert.ToDouble(lblYüksek.Text) > 0)
            {
                if (Convert.ToDouble(lblSCokDüsük.Text) > 0)
                {
                    if (Convert.ToDouble(lblSCokDüsük.Text) > Convert.ToDouble(lblYüksek.Text))
                    {
                        listBox1.Items.Add("EĞER Su Sıcaklığı Yüksek(" + lblYüksek.Text + ")" + " ve Su Seviyesi Çok Düşük(" + lblSCokDüsük.Text + ")" + " O HALDE Çıkış Aşırı Çok(" + lblYüksek.Text + ")");
                        degerler[30] = Convert.ToDouble(lblYüksek.Text);
                        double x1 = ((Convert.ToDouble(lblYüksek.Text) * 0.5) + 4) * (Convert.ToDouble(lblYüksek.Text));
                        cıkıslar[22] = x1;
                    }
                    if (Convert.ToDouble(lblYüksek.Text) > Convert.ToDouble(lblSCokDüsük.Text))
                    {
                        listBox1.Items.Add("EĞER Su Sıcaklığı Yüksek(" + lblYüksek.Text + ")" + " ve Su Seviyesi Çok Düşük(" + lblSCokDüsük.Text + ")" + " O HALDE Çıkış Aşırı Çok(" + lblSCokDüsük.Text + ")");
                        degerler[31] = Convert.ToDouble(lblSCokDüsük.Text);
                        double x1 = ((Convert.ToDouble(lblSCokDüsük.Text) * 0.5) + 4) * (Convert.ToDouble(lblSCokDüsük.Text));
                        cıkıslar[23] = x1;
                    }
                }
                if (Convert.ToDouble(lblSDüsük.Text) > 0)
                {
                    if (Convert.ToDouble(lblSDüsük.Text) > Convert.ToDouble(lblYüksek.Text))
                    {
                        listBox1.Items.Add("EĞER Su Sıcaklığı Yüksek(" + lblYüksek.Text + ")" + " ve Su Seviyesi Düşük(" + lblSDüsük.Text + ")" + " O HALDE Çıkış Çok(" + lblYüksek.Text + ")");
                        degerler[32] = Convert.ToDouble(lblYüksek.Text);
                        double x1 = ((Convert.ToDouble(lblYüksek.Text) * 0.75) + 3) * (Convert.ToDouble(lblYüksek.Text));
                        double x2 = (4.5 - (Convert.ToDouble(lblYüksek.Text) * 0.75)) * (Convert.ToDouble(lblYüksek.Text));
                        cıkıslar[24] = x1 + x2;
                    }
                    if (Convert.ToDouble(lblYüksek.Text) > Convert.ToDouble(lblSDüsük.Text))
                    {
                        listBox1.Items.Add("EĞER Su Sıcaklığı Yüksek(" + lblYüksek.Text + ")" + " ve Su Seviyesi Düşük(" + lblSDüsük.Text + ")" + " O HALDE Çıkış Çok(" + lblSDüsük.Text + ")");
                        degerler[33] = Convert.ToDouble(lblSDüsük.Text);
                        double x1 = ((Convert.ToDouble(lblSDüsük.Text) * 0.75) + 3) * (Convert.ToDouble(lblSDüsük.Text));
                        double x2 = (4.5 - (Convert.ToDouble(lblSDüsük.Text) * 0.75)) * (Convert.ToDouble(lblSDüsük.Text));
                        cıkıslar[25] = x1 + x2;
                    }

                }
                if (Convert.ToDouble(lblSOrta.Text) > 0)
                {
                    if (Convert.ToDouble(lblSOrta.Text) > Convert.ToDouble(lblYüksek.Text))
                    {
                        listBox1.Items.Add("EĞER Su Sıcaklığı Yüksek(" + lblYüksek.Text + ")" + " ve Su Seviyesi Orta(" + lblSOrta.Text + ")" + " O HALDE Çıkış Çok(" + lblYüksek.Text + ")");
                        degerler[34] = Convert.ToDouble(lblYüksek.Text);
                        double x1 = ((Convert.ToDouble(lblYüksek.Text) * 0.75) + 3) * (Convert.ToDouble(lblYüksek.Text));
                        double x2 = (4.5 - (Convert.ToDouble(lblYüksek.Text) * 0.75)) * (Convert.ToDouble(lblYüksek.Text));
                        cıkıslar[26] = x1 + x2;

                    }
                    if (Convert.ToDouble(lblYüksek.Text) > Convert.ToDouble(lblSOrta.Text))
                    {
                        listBox1.Items.Add("EĞER Su Sıcaklığı Yüksek(" + lblYüksek.Text + ")" + " ve Su Seviyesi Orta(" + lblSOrta.Text + ")" + " O HALDE Çıkış Çok(" + lblSOrta.Text + ")");
                        degerler[35] = Convert.ToDouble(lblSOrta.Text);
                        double x1 = ((Convert.ToDouble(lblSOrta.Text) * 0.75) + 3) * (Convert.ToDouble(lblSOrta.Text));
                        double x2 = (4.5 - (Convert.ToDouble(lblSOrta.Text) * 0.75)) * (Convert.ToDouble(lblSOrta.Text));
                        cıkıslar[27] = x1 + x2;

                    }

                }
                if (Convert.ToDouble(lblSYüksek.Text) > 0)
                {
                    if (Convert.ToDouble(lblSYüksek.Text) > Convert.ToDouble(lblYüksek.Text))
                    {
                        listBox1.Items.Add("EĞER Su Sıcaklığı Yüksek(" + lblYüksek.Text + ")" + " ve Su Seviyesi Yüksek(" + lblSYüksek.Text + ")" + " O HALDE Çıkış Az(" + lblYüksek.Text + ")");
                        degerler[36] = Convert.ToDouble(lblYüksek.Text);
                        double x1 = ((Convert.ToDouble(lblYüksek.Text) * 0.75) + 0.5) * (Convert.ToDouble(lblYüksek.Text));
                        double x2 = (2 - (Convert.ToDouble(lblYüksek.Text) * 0.75)) * (Convert.ToDouble(lblYüksek.Text));
                        cıkıslar[28] = x1 + x2;
                    }
                    if (Convert.ToDouble(lblYüksek.Text) > Convert.ToDouble(lblSYüksek.Text))
                    {
                        listBox1.Items.Add("EĞER Su Sıcaklığı Yüksek(" + lblYüksek.Text + ")" + " ve Su Seviyesi Yüksek(" + lblSYüksek.Text + ")" + " O HALDE Çıkış Az(" + lblSYüksek.Text + ")");
                        degerler[37] = Convert.ToDouble(lblSYüksek.Text);
                        double x1 = ((Convert.ToDouble(lblSYüksek.Text) * 0.75) + 0.5) * (Convert.ToDouble(lblSYüksek.Text));
                        double x2 = (2 - (Convert.ToDouble(lblSYüksek.Text) * 0.75)) * (Convert.ToDouble(lblSYüksek.Text));
                        cıkıslar[29] = x1 + x2;
                    }

                }
                if (Convert.ToDouble(lblSCokYüksek.Text) > 0)
                {
                    if (Convert.ToDouble(lblSCokYüksek.Text) > Convert.ToDouble(lblYüksek.Text))
                    {
                        listBox1.Items.Add("EĞER Su Sıcaklığı Yüksek(" + lblYüksek.Text + ")" + " ve Su Seviyesi Çok Yüksek(" + lblSCokYüksek.Text + ")" + " O HALDE Çıkış Çıkışta Hareket Yok(" + lblYüksek.Text + ")");
                        degerler[38] = Convert.ToDouble(lblYüksek.Text);
                    }
                    if (Convert.ToDouble(lblYüksek.Text) > Convert.ToDouble(lblSCokYüksek.Text))
                    {
                        listBox1.Items.Add("EĞER Su Sıcaklığı Yüksek(" + lblYüksek.Text + ")" + " ve Su Seviyesi Çok Yüksek(" + lblSCokYüksek.Text + ")" + " O HALDE Çıkış Çıkışta Hareket Yok(" + lblSCokYüksek.Text + ")");
                        degerler[39] = Convert.ToDouble(lblSCokYüksek.Text);
                    }

                }
            }
            //Çok Yüksek İçin
            if (Convert.ToDouble(lblCokYüksek.Text) > 0)
            {
                if (Convert.ToDouble(lblSCokDüsük.Text) > 0)
                {
                    if (Convert.ToDouble(lblSCokDüsük.Text) > Convert.ToDouble(lblCokYüksek.Text))
                    {
                        listBox1.Items.Add("EĞER Su Sıcaklığı Çok Yüksek(" + lblCokYüksek.Text + ")" + " ve Su Seviyesi Çok Düşük(" + lblSCokDüsük.Text + ")" + " O HALDE Çıkış Aşırı Çok(" + lblCokYüksek.Text + ")");
                        degerler[40] = Convert.ToDouble(lblCokYüksek.Text);
                        double x1 = ((Convert.ToDouble(lblCokYüksek.Text) * 0.5) + 4) * (Convert.ToDouble(lblCokYüksek.Text));
                        cıkıslar[29] = x1 ;
                    }
                    if (Convert.ToDouble(lblCokYüksek.Text) > Convert.ToDouble(lblSCokDüsük.Text))
                    {
                        listBox1.Items.Add("EĞER Su Sıcaklığı Çok Yüksek(" + lblCokYüksek.Text + ")" + " ve Su Seviyesi Çok Düşük(" + lblSCokDüsük.Text + ")" + " O HALDE Çıkış Aşırı Çok(" + lblSCokDüsük.Text + ")");
                        degerler[41]= Convert.ToDouble(lblSCokDüsük.Text);
                        double x1 = ((Convert.ToDouble(lblSCokDüsük.Text) * 0.5) + 4) * (Convert.ToDouble(lblSCokDüsük.Text));
                        cıkıslar[30] = x1;
                    }
                }
                if (Convert.ToDouble(lblSDüsük.Text) > 0)
                {
                    if (Convert.ToDouble(lblSDüsük.Text) > Convert.ToDouble(lblCokYüksek.Text))
                    {
                        listBox1.Items.Add("EĞER Su Sıcaklığı Çok Yüksek(" + lblCokYüksek.Text + ")" + " ve Su Seviyesi Düşük(" + lblSDüsük.Text + ")" + " O HALDE Çıkış Çok(" + lblCokYüksek.Text + ")");
                        degerler[42] = Convert.ToDouble(lblCokYüksek.Text);
                        double x1 = ((Convert.ToDouble(lblCokYüksek.Text) * 0.75) + 3) * (Convert.ToDouble(lblCokYüksek.Text));
                        double x2 = (4.5 - (Convert.ToDouble(lblCokYüksek.Text) * 0.75)) * (Convert.ToDouble(lblCokYüksek.Text));
                        cıkıslar[31] = x1 + x2;
                    }
                    if (Convert.ToDouble(lblCokYüksek.Text) > Convert.ToDouble(lblSDüsük.Text))
                    {
                        listBox1.Items.Add("EĞER Su Sıcaklığı Çok Yüksek(" + lblCokYüksek.Text + ")" + " ve Su Seviyesi Düşük(" + lblSDüsük.Text + ")" + " O HALDE Çıkış Çok(" + lblSDüsük.Text + ")");
                        degerler[43] = Convert.ToDouble(lblSDüsük.Text);
                        double x1 = ((Convert.ToDouble(lblSDüsük.Text) * 0.75) + 3) * (Convert.ToDouble(lblSDüsük.Text));
                        double x2 = (4.5 - (Convert.ToDouble(lblSDüsük.Text) * 0.75)) * (Convert.ToDouble(lblSDüsük.Text));
                        cıkıslar[32] = x1 + x2;
                    }

                }
                if (Convert.ToDouble(lblSOrta.Text) > 0)
                {
                    if (Convert.ToDouble(lblSOrta.Text) > Convert.ToDouble(lblCokYüksek.Text))
                    {
                        listBox1.Items.Add("EĞER Su Sıcaklığı Çok Yüksek(" + lblCokYüksek.Text + ")" + " ve Su Seviyesi Orta(" + lblSOrta.Text + ")" + " O HALDE Çıkış Çok(" + lblCokYüksek.Text + ")");
                        degerler[44] = Convert.ToDouble(lblCokYüksek.Text);
                        double x1 = ((Convert.ToDouble(lblCokYüksek.Text) * 0.75) + 3) * (Convert.ToDouble(lblCokYüksek.Text));
                        double x2 = (4.5 - (Convert.ToDouble(lblCokYüksek.Text) * 0.75)) * (Convert.ToDouble(lblCokYüksek.Text));
                        cıkıslar[33] = x1 + x2;
                    }
                    if (Convert.ToDouble(lblCokYüksek.Text) > Convert.ToDouble(lblSOrta.Text))
                    {
                        listBox1.Items.Add("EĞER Su Sıcaklığı Çok Yüksek(" + lblCokYüksek.Text + ")" + " ve Su Seviyesi Orta(" + lblSOrta.Text + ")" + " O HALDE Çıkış Çok(" + lblSOrta.Text + ")");
                        degerler[45] = Convert.ToDouble(lblSOrta.Text);
                        double x1 = ((Convert.ToDouble(lblSOrta.Text) * 0.75) + 3) * (Convert.ToDouble(lblSOrta.Text));
                        double x2 = (4.5 - (Convert.ToDouble(lblSOrta.Text) * 0.75)) * (Convert.ToDouble(lblSOrta.Text));
                        cıkıslar[34] = x1 + x2;
                    }

                }
                if (Convert.ToDouble(lblSYüksek.Text) > 0)
                {
                    if (Convert.ToDouble(lblSYüksek.Text) > Convert.ToDouble(lblCokYüksek.Text))
                    {
                        listBox1.Items.Add("EĞER Su Sıcaklığı Çok Yüksek(" + lblCokYüksek.Text + ")" + " ve Su Seviyesi Yüksek(" + lblSYüksek.Text + ")" + " O HALDE Çıkış Orta(" + lblCokYüksek.Text + ")");
                        degerler[46] = Convert.ToDouble(lblCokYüksek.Text);
                        double x1 = ((Convert.ToDouble(lblCokYüksek.Text) * 1) + 1.5) * (Convert.ToDouble(lblCokYüksek.Text));
                        double x2 = (3.5 - (Convert.ToDouble(lblCokYüksek.Text) * 1)) * (Convert.ToDouble(lblCokYüksek.Text));
                        cıkıslar[35] = x1 + x2;
                    }
                    if (Convert.ToDouble(lblCokYüksek.Text) > Convert.ToDouble(lblSYüksek.Text))
                    {
                        listBox1.Items.Add("EĞER Su Sıcaklığı Çok Yüksek(" + lblCokYüksek.Text + ")" + " ve Su Seviyesi Yüksek(" + lblSYüksek.Text + ")" + " O HALDE Çıkış Orta(" + lblSYüksek.Text + ")");
                        degerler[47] = Convert.ToDouble(lblSYüksek.Text);
                        double x1 = ((Convert.ToDouble(lblSYüksek.Text) * 1) + 1.5) * (Convert.ToDouble(lblSYüksek.Text));
                        double x2 = (3.5 - (Convert.ToDouble(lblSYüksek.Text) * 1)) * (Convert.ToDouble(lblSYüksek.Text));
                        cıkıslar[36] = x1 + x2;
                    }

                }
                if (Convert.ToDouble(lblSCokYüksek.Text) > 0)
                {
                    if (Convert.ToDouble(lblSCokYüksek.Text) > Convert.ToDouble(lblCokYüksek.Text))
                    {
                        listBox1.Items.Add("EĞER Su Sıcaklığı Çok Yüksek(" + lblCokYüksek.Text + ")" + " ve Su Seviyesi Çok Yüksek(" + lblSCokYüksek.Text + ")" + " O HALDE Çıkış Çıkışta Hareket Yok(" + lblCokYüksek.Text + ")");
                        degerler[48] = Convert.ToDouble(lblCokYüksek.Text);
                    }
                    if (Convert.ToDouble(lblCokYüksek.Text) > Convert.ToDouble(lblSCokYüksek.Text))
                    {

                       listBox1.Items.Add("EĞER Su Sıcaklığı Çok Yüksek(" + lblCokYüksek.Text + ")" + " ve Su Seviyesi Çok Yüksek(" + lblSCokYüksek.Text + ")" + " O HALDE Çıkış Çıkışta Hareket Yok(" + lblSCokYüksek.Text + ")");
                        degerler[49] = Convert.ToDouble(lblSCokYüksek.Text);
                    }

                }
            }
            double max = degerler[0];
            for (int i = 1; i < degerler.Length; i++)
            {
                
                if (max < degerler[i])
                    max = degerler[i];
            }
            listBox2.Items.Add("Kuralların Ateşlenmesiyle Bulunan Üyelik:" + max);
            double toplam = 0;
            for (int i = 0; i < degerler.Length; ++i)
            {
                toplam += degerler[i];
            }
            double toplam2 = 0;
            for (int i = 0; i < cıkıslar.Length; ++i)
            {
                toplam2 += cıkıslar[i];
            }
            double sonuc = toplam2 / toplam;
            listBox3.Items.Add("Durulaştırılmış Çıkış:" + sonuc);
            grafik3(sonuc);
        }

        

       

        private void label18_Click(object sender, EventArgs e)
        {

        }
    }
}
