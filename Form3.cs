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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public string[] Takımların_Hücum_Güçleri = new string[30];
        public string[] Takımların_Savunma_Güçleri = new string[30];
        public string[] üçlükşansı = new string[30];
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        bool devam1 = false, devam2 = false;
        Form2 frm2 = new Form2();
        Playoff playoff = new Playoff();
        public bool plyof = false;
        private void Form3_Load(object sender, EventArgs e)
        {
            if (plyof == false)
            {
                devam1 = false; devam2 = false;
                button1.Enabled = true; button3.Enabled = false;
                button4.Enabled = false;
                panel2.Visible = true;
            }
            else if (plyof == true)
            {
                panel2.Visible = false;
                button3.Visible = false;
            }
            #region hücum puanları
            Takımların_Hücum_Güçleri[0] = "85"; Takımların_Hücum_Güçleri[11] = "80"; Takımların_Hücum_Güçleri[22] = "80";
            Takımların_Hücum_Güçleri[1] = "80"; Takımların_Hücum_Güçleri[12] = "85"; Takımların_Hücum_Güçleri[23] = "72";
            Takımların_Hücum_Güçleri[2] = "76"; Takımların_Hücum_Güçleri[13] = "80"; Takımların_Hücum_Güçleri[24] = "70";
            Takımların_Hücum_Güçleri[3] = "71"; Takımların_Hücum_Güçleri[14] = "75"; Takımların_Hücum_Güçleri[25] = "85";
            Takımların_Hücum_Güçleri[4] = "85"; Takımların_Hücum_Güçleri[15] = "74"; Takımların_Hücum_Güçleri[26] = "75";
            Takımların_Hücum_Güçleri[5] = "85"; Takımların_Hücum_Güçleri[16] = "70"; Takımların_Hücum_Güçleri[27] = "80";
            Takımların_Hücum_Güçleri[6] = "75"; Takımların_Hücum_Güçleri[17] = "90"; Takımların_Hücum_Güçleri[28] = "80";
            Takımların_Hücum_Güçleri[7] = "85"; Takımların_Hücum_Güçleri[18] = "80"; Takımların_Hücum_Güçleri[29] = "75";
            Takımların_Hücum_Güçleri[8] = "75"; Takımların_Hücum_Güçleri[19] = "78";
            Takımların_Hücum_Güçleri[9] = "70"; Takımların_Hücum_Güçleri[20] = "84";
            Takımların_Hücum_Güçleri[10] = "80"; Takımların_Hücum_Güçleri[21] = "80";
            #endregion

            #region savunma puanları
            Takımların_Savunma_Güçleri[0] = "30"; Takımların_Savunma_Güçleri[11] = "20"; Takımların_Savunma_Güçleri[22] = "20";
            Takımların_Savunma_Güçleri[1] = "16"; Takımların_Savunma_Güçleri[12] = "34"; Takımların_Savunma_Güçleri[23] = "20";
            Takımların_Savunma_Güçleri[2] = "24"; Takımların_Savunma_Güçleri[13] = "26"; Takımların_Savunma_Güçleri[24] = "20";
            Takımların_Savunma_Güçleri[3] = "16"; Takımların_Savunma_Güçleri[14] = "20"; Takımların_Savunma_Güçleri[25] = "26";
            Takımların_Savunma_Güçleri[4] = "24"; Takımların_Savunma_Güçleri[15] = "24"; Takımların_Savunma_Güçleri[26] = "24";
            Takımların_Savunma_Güçleri[5] = "26"; Takımların_Savunma_Güçleri[16] = "20"; Takımların_Savunma_Güçleri[27] = "24";
            Takımların_Savunma_Güçleri[6] = "26"; Takımların_Savunma_Güçleri[17] = "30"; Takımların_Savunma_Güçleri[28] = "26";
            Takımların_Savunma_Güçleri[7] = "26"; Takımların_Savunma_Güçleri[18] = "24"; Takımların_Savunma_Güçleri[29] = "20";
            Takımların_Savunma_Güçleri[8] = "20"; Takımların_Savunma_Güçleri[19] = "20";
            Takımların_Savunma_Güçleri[9] = "20"; Takımların_Savunma_Güçleri[20] = "26";
            Takımların_Savunma_Güçleri[10] = "20"; Takımların_Savunma_Güçleri[21] = "24";
            #endregion

            #region üçlük puanı
            üçlükşansı[0] = "30"; üçlükşansı[11] = "20"; üçlükşansı[22] = "20";
            üçlükşansı[1] = "20"; üçlükşansı[12] = "36"; üçlükşansı[23] = "15";
            üçlükşansı[2] = "15"; üçlükşansı[13] = "20"; üçlükşansı[24] = "15";
            üçlükşansı[3] = "15"; üçlükşansı[14] = "15"; üçlükşansı[25] = "36";
            üçlükşansı[4] = "20"; üçlükşansı[15] = "20"; üçlükşansı[26] = "20";
            üçlükşansı[5] = "25"; üçlükşansı[16] = "20"; üçlükşansı[27] = "20";
            üçlükşansı[6] = "20"; üçlükşansı[17] = "38"; üçlükşansı[28] = "20";
            üçlükşansı[7] = "25"; üçlükşansı[18] = "25"; üçlükşansı[29] = "20";
            üçlükşansı[8] = "20"; üçlükşansı[19] = "20";
            üçlükşansı[9] = "15"; üçlükşansı[20] = "24";
            üçlükşansı[10] = "20"; üçlükşansı[21] = "20";
            #endregion
        }
        
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (plyof == false)
            {
                if (devam1 == false)
                {
                    pictureBox1.Image = ımageList1.Images[listBox1.SelectedIndex];
                    frm2.takım1_güç = Convert.ToInt32(Takımların_Hücum_Güçleri[listBox1.SelectedIndex]);
                    frm2.takım1_savunmaPuanı = Convert.ToInt32(Takımların_Savunma_Güçleri[listBox1.SelectedIndex]);
                    frm2.üçlükşansı_1 = Convert.ToInt32(üçlükşansı[listBox1.SelectedIndex]);
                    frm2.lbl_ev.Text = listBox1.Items[listBox1.SelectedIndex].ToString();
                    frm2.pictureBox1.Image = ımageList1.Images[listBox1.SelectedIndex];
                    lbl1.Text = "Hücum Gücü : " + Takımların_Hücum_Güçleri[listBox1.SelectedIndex];
                    lbl2.Text = "Savunma Gücü : " + Takımların_Savunma_Güçleri[listBox1.SelectedIndex];
                    lbl3.Text = "Üçlük Şansı : " + üçlükşansı[listBox1.SelectedIndex];
                    lbl_ad.Text = listBox1.Items[listBox1.SelectedIndex].ToString();
                }
                else if (devam1 == true)
                {
                    frm2.takım2_güç = Convert.ToInt32(Takımların_Hücum_Güçleri[listBox1.SelectedIndex]);
                    frm2.takım2_savunmaPuanı = Convert.ToInt32(Takımların_Savunma_Güçleri[listBox1.SelectedIndex]);
                    frm2.üçlükşansı_2 = Convert.ToInt32(üçlükşansı[listBox1.SelectedIndex]);
                    frm2.lbl_rakp.Text = listBox1.Items[listBox1.SelectedIndex].ToString();
                    frm2.pictureBox2.Image = ımageList1.Images[listBox1.SelectedIndex];
                    pictureBox2.Image = ımageList1.Images[listBox1.SelectedIndex];
                    lbl_ad2.Text = listBox1.Items[listBox1.SelectedIndex].ToString();
                    lbl1_1.Text = "Hücum Gücü : " + Takımların_Hücum_Güçleri[listBox1.SelectedIndex];
                    lbl2_2.Text = "Savunma Gücü : " + Takımların_Savunma_Güçleri[listBox1.SelectedIndex];
                    lbl3_3.Text = "Üçlük Şansı : " + üçlükşansı[listBox1.SelectedIndex];
                }
            }
            else if (plyof == true)
            {
                lbl1.Text = "Hücum Gücü : " + Takımların_Hücum_Güçleri[listBox1.SelectedIndex];
                lbl2.Text = "Savunma Gücü : " + Takımların_Savunma_Güçleri[listBox1.SelectedIndex];
                lbl3.Text = "Üçlük Şansı : " + üçlükşansı[listBox1.SelectedIndex];
                lbl_ad.Text = listBox1.Items[listBox1.SelectedIndex].ToString();
                pictureBox1.Image = ımageList1.Images[listBox1.SelectedIndex];
                playoff.takım1_Hücum = Convert.ToInt32(Takımların_Hücum_Güçleri[listBox1.SelectedIndex]);
                playoff.takım1_savunma = Convert.ToInt32(Takımların_Savunma_Güçleri[listBox1.SelectedIndex]);
                playoff.takım1_üçlük = Convert.ToInt32(üçlükşansı[listBox1.SelectedIndex]);
                playoff.sayı = listBox1.SelectedIndex ;
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (plyof == false)
            {
                if (devam1 == false)
                {
                    frm2.takım1_güç = Convert.ToInt32(Takımların_Hücum_Güçleri[listBox2.SelectedIndex + 15]);
                    frm2.takım1_savunmaPuanı = Convert.ToInt32(Takımların_Savunma_Güçleri[listBox2.SelectedIndex + 15]);
                    frm2.üçlükşansı_1 = Convert.ToInt32(üçlükşansı[listBox2.SelectedIndex + 15]);
                    frm2.lbl_ev.Text = listBox2.Items[listBox2.SelectedIndex].ToString();
                    frm2.pictureBox1.Image = ımageList2.Images[listBox2.SelectedIndex];
                    pictureBox1.Image = ımageList2.Images[listBox2.SelectedIndex];
                    lbl1.Text = "Hücum Gücü : " + Takımların_Hücum_Güçleri[listBox2.SelectedIndex + 15];
                    lbl2.Text = "Savunma Gücü : " + Takımların_Savunma_Güçleri[listBox2.SelectedIndex + 15];
                    lbl3.Text = "Üçlük Şansı : " + üçlükşansı[listBox2.SelectedIndex + 15];
                    lbl_ad.Text = listBox2.Items[listBox2.SelectedIndex].ToString();
                }
                else if (devam1 == true)
                {
                    frm2.takım2_güç = Convert.ToInt32(Takımların_Hücum_Güçleri[listBox2.SelectedIndex + 15]);
                    frm2.takım2_savunmaPuanı = Convert.ToInt32(Takımların_Savunma_Güçleri[listBox2.SelectedIndex + 15]);
                    frm2.üçlükşansı_2 = Convert.ToInt32(üçlükşansı[listBox2.SelectedIndex + 15]);
                    frm2.lbl_rakp.Text = listBox2.Items[listBox2.SelectedIndex].ToString();
                    frm2.pictureBox2.Image = ımageList2.Images[listBox2.SelectedIndex];
                    pictureBox2.Image = ımageList2.Images[listBox2.SelectedIndex];
                    lbl_ad2.Text = listBox2.Items[listBox2.SelectedIndex].ToString();
                    lbl1_1.Text = "Hücum Gücü : " + Takımların_Hücum_Güçleri[listBox2.SelectedIndex + 15];
                    lbl2_2.Text = "Savunma Gücü : " + Takımların_Savunma_Güçleri[listBox2.SelectedIndex + 15];
                    lbl3_3.Text = "Üçlük Şansı : " + üçlükşansı[listBox2.SelectedIndex + 15];
                }
            }
            else if(plyof == true)
            {
                pictureBox1.Image = ımageList2.Images[listBox2.SelectedIndex];
                lbl1.Text = "Hücum Gücü : " + Takımların_Hücum_Güçleri[listBox2.SelectedIndex + 15];
                lbl2.Text = "Savunma Gücü : " + Takımların_Savunma_Güçleri[listBox2.SelectedIndex + 15];
                lbl3.Text = "Üçlük Şansı : " + üçlükşansı[listBox2.SelectedIndex + 15];
                lbl_ad.Text = listBox2.Items[listBox2.SelectedIndex].ToString();
                playoff.takım1_Hücum = Convert.ToInt32(Takımların_Hücum_Güçleri[listBox2.SelectedIndex +15]);
                playoff.takım1_savunma = Convert.ToInt32(Takımların_Savunma_Güçleri[listBox2.SelectedIndex+15]);
                playoff.takım1_üçlük = Convert.ToInt32(üçlükşansı[listBox2.SelectedIndex+15]);
                playoff.sayı = listBox2.SelectedIndex + 15;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (plyof == false)
            {
                button1.Enabled = false;
                button3.Enabled = true;
                devam1 = true;
                if (devam2)
                {
                    button4.Enabled = true;
                }
            }
            else if (plyof)
            {
                button1.Enabled = false;
                button4.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
            devam2 = true;
            if (devam1)
            {
                button4.Enabled = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (plyof == false)
            {
                Close();
                frm2.Owner = this;
                frm2.ShowDialog();
            }
            else if (plyof == true)
            {
                Close();
                playoff.ShowDialog();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
