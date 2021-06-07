using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication10
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public int takım1_güç = 90, takım2_güç = 60, süre = 120, sayaç = 0;
        public int takım1_savunmaPuanı = 40, takım2_savunmaPuanı = 30;
        int sayı1 = 0, sayı2 = 0;
        public int üçlükşansı_1 = 20, üçlükşansı_2 = 20;
        bool evsahibi = true;
        Random rnd = new Random();
        private void Form2_Load(object sender, EventArgs e)
        {
            button1.Enabled = true;
            listBox1.Items.Clear();
            listBox2.Items.Clear(); süre = 120;
            lbl_evSahibi.Text = "0";
            lbl_rakip.Text = "0";
            sayı1 = 0; sayı2 = 0;
            süre = 120;
            sayaç = 0;
        }
        int a, b, c, d,e,f;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayaç++;
            lbl_süre.Text = string.Format("Süre : {0}", sayaç.ToString());
            if (sayaç == 30)
            {
                a = sayı1; b = sayı2;
                listBox1.Items.Add(string.Format("1.periyot attığı sayı : {0}",sayı1));
                listBox2.Items.Add(string.Format("1.periyot attığı sayı : {0}", sayı2));
            }
            else if (sayaç == 60)
            {
                c = sayı1 ;
                d = sayı2 ;
                listBox1.Items.Add(string.Format("2.periyot attığı sayı : {0}", sayı1 - a));
                listBox2.Items.Add(string.Format("2.periyot attığı sayı : {0}", sayı2 - b));
                timer1.Stop();
                MessageBox.Show("İlk yarı bitti","Bilgilendirme");
                button1.Enabled = true;
            }
            else if (sayaç == 90)
            {
                listBox1.Items.Add(string.Format("3.periyot attığı sayı : {0}", sayı1 - c));
                listBox2.Items.Add(string.Format("3.periyot attığı sayı : {0}", sayı2 - d));
                c = sayı1;
                d = sayı2;
            }
            //lbl_süre.Text = string.Format("Süre : {0}",sayaç.ToString());
            if (sayaç == süre)
            {
                listBox1.Items.Add(string.Format("4.periyot attığı sayı : {0}", sayı1 - c));
                listBox2.Items.Add(string.Format("4.periyot attığı sayı : {0}", sayı2 - d));
                if (sayı1 == sayı2)
                {
                    süre = 150;
                }
                else
                {
                    timer1.Stop();
                    MessageBox.Show("Maç bitti.", "Bilgilendirme");
                    Close();
                }
            }
            if (evsahibi)
            {
                evsahibi = false;
                if (rnd.Next(0, 100) <= takım1_güç - takım2_savunmaPuanı / 2)
                {
                    if (rnd.Next(0, 100) <= üçlükşansı_1)
                    {
                        sayı1 += 3;
                    }
                    else
                    {
                        sayı1 += 2;
                    }
                    lbl_evSahibi.Text = sayı1.ToString();
                }
            }
            else if (evsahibi == false)
            {
                evsahibi = true;
                if (rnd.Next(0, 100) <= takım2_güç - takım1_savunmaPuanı / 2)
                {
                    if (rnd.Next(0, 100) <= üçlükşansı_2)
                    {
                        sayı2 += 3;
                    }
                    else
                    {
                        sayı2 += 2;
                    }
                    lbl_rakip.Text = sayı2.ToString();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            timer1.Start();
        }
    }
}
