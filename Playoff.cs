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
    public partial class Playoff : Form
    {
        public Playoff()
        {
            InitializeComponent();
        }

        public int takım1_Hücum = 0;
        public int takım1_savunma = 0;
        public int takım1_üçlük = 0;
        public int sayı = 0;
        public string[] Takımların_Hücum_Güçleri = new string[30];
        public string[] Takımların_Savunma_Güçleri = new string[30];
        public string[] üçlükşansı = new string[30];
        public string[] takımların_adları = new string[30];

        int[] numaralar_batı = new int[8];
        int[] numaralar_doğu = new int[8];
        string[] takımlar_batı = new string[8]; string[] takımlar_doğu = new string[8];
        string[] güçler_batı = new string[8]; string[] güçler_doğu = new string[8];
        string[] savunma_batı = new string[8]; string[] savunma_doğu = new string[8];
        string[] üçlük_batı = new string[8]; string[] üçlük_doğu = new string[8];
        int a = 0;
        int sayaç = 1;
        private void Playoff_Load(object sender, EventArgs e)
        {
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

            #region takım adları
            takımların_adları[0] = "Dallas Mavericks"; takımların_adları[15] = "Atlanta Hawks";
            takımların_adları[1] = "Houston Rockets"; takımların_adları[16] = "Charlotte Bobcats";
            takımların_adları[2] = "Memphis Grizzlies"; takımların_adları[17] = "Miami Heat";
            takımların_adları[3] = "New Orleans Hornets"; takımların_adları[18] = "Orlando Magic";
            takımların_adları[4] = "San Antonio Spurs"; takımların_adları[19] = "Washington Wizards";
            takımların_adları[5] = "Denver Nuggets"; takımların_adları[20] = "Chicago Bulls";
            takımların_adları[6] = "Minnesota Timberwolves"; takımların_adları[21] = "Cleveland Cavaliers";
            takımların_adları[7] = "Oklahoma City Thunder"; takımların_adları[22] = "Detroit Pistons";
            takımların_adları[8] = "Portland Trail Blazers"; takımların_adları[23] = "Indiana Pacers";
            takımların_adları[9] = "Utah Jazz"; takımların_adları[24] = "Milwaukee Bucks";
            takımların_adları[10] = "Golden State Warriors"; takımların_adları[25] = "Boston Celtics";
            takımların_adları[11] = "Los Angeles Clippers"; takımların_adları[26] = "New Jersey Nets";
            takımların_adları[12] = "Los Angeles Lakers"; takımların_adları[27] = "New York Knicks";
            takımların_adları[13] = "Phoenix Suns"; takımların_adları[28] = "Philadelphia Sixers";
            takımların_adları[14] = "Sacramento Kings"; takımların_adları[29] = "Toronto Raptors";
            #endregion
            Random rnd = new Random();
            bool brk = false;

            #region sıralamalar
            if (sayı > 14)
            {
                pb_9.Image = ımageList2.Images[sayı - 15]; //doğu
                takımlar_doğu[0] = takımların_adları[sayı - 15];
                güçler_doğu[0] = Takımların_Hücum_Güçleri[sayı - 15];
                savunma_doğu[0] = Takımların_Savunma_Güçleri[sayı - 15];
                üçlük_doğu[0] = üçlükşansı[sayı - 15];
                numaralar_doğu[0] = sayı - 15;
                for (int i = 1; i < 8; i++)
                {
                    a = rnd.Next(0, 8);
                    for (int j = 0; j < i; j++)
                    {
                        if (numaralar_doğu[j] == a)
                        {
                            i--;
                            brk = true;
                            break;
                        }
                        else
                        {
                            numaralar_doğu[i] = a;
                            brk = false;
                        }
                    }
                    if (brk == false)
                    {
                        resimEkle_doğu(a);
                        takımlar_doğu[i] = takımların_adları[a + 15];
                        güçler_doğu[i] = Takımların_Hücum_Güçleri[a + 15];
                        savunma_doğu[i] = Takımların_Savunma_Güçleri[a + 15];
                        üçlük_doğu[i] = üçlükşansı[a + 15];
                        sayaç++;
                    }
                }
                sayaç = 1;
                numaralar_batı[0] = rnd.Next(0, 8);
                takımlar_batı[0] = takımların_adları[numaralar_batı[0]];
                güçler_batı[0] = Takımların_Hücum_Güçleri[numaralar_batı[0]];
                savunma_batı[0] = Takımların_Savunma_Güçleri[numaralar_batı[0]];
                üçlük_batı[0] = üçlükşansı[numaralar_batı[0]];
                pb_1.Image = ımageList1.Images[numaralar_batı[0]];

                for (int i = 1; i < 8; i++)
                {
                    a = rnd.Next(0, 8);
                    for (int j = 0; j < i; j++)
                    {
                        if (numaralar_batı[j] == a)
                        {
                            i--;
                            brk = true;
                            break;
                        }
                        else
                        {
                            numaralar_batı[i] = a;
                            brk = false;
                        }
                    }
                    if (brk == false)
                    {
                        takımlar_batı[i] = takımların_adları[a];
                        güçler_batı[i] = Takımların_Hücum_Güçleri[a];
                        savunma_batı[i] = Takımların_Savunma_Güçleri[a];
                        üçlük_batı[i] = üçlükşansı[a];
                        resimEkle_batı(a);
                        sayaç++;
                    }
                }
            }
            else if (sayı <= 14)
            {
                pb_1.Image = ımageList1.Images[sayı]; //batı
                numaralar_batı[0] = sayı;
                takımlar_batı[0] = takımların_adları[numaralar_batı[0]];
                güçler_batı[0] = Takımların_Hücum_Güçleri[numaralar_batı[0]];
                savunma_batı[0] = Takımların_Savunma_Güçleri[numaralar_batı[0]];
                üçlük_batı[0] = üçlükşansı[numaralar_batı[0]];
                pb_1.Image = ımageList1.Images[numaralar_batı[0]];
                for (int i = 1; i < 8; i++)
                {
                    a = rnd.Next(0, 8);
                    for (int j = 0; j < i; j++)
                    {
                        if (numaralar_batı[j] == a)
                        {
                            i--;
                            brk = true;
                            break;
                        }
                        else
                        {
                            numaralar_batı[i] = a;
                            brk = false;
                        }
                    }
                    if (brk == false)
                    {
                        takımlar_batı[i] = takımların_adları[a];
                        güçler_batı[i] = Takımların_Hücum_Güçleri[a];
                        savunma_batı[i] = Takımların_Savunma_Güçleri[a];
                        üçlük_batı[i] = üçlükşansı[a];
                        resimEkle_batı(a);
                        sayaç++;
                    }
                }
                sayaç = 1;
                numaralar_doğu[0] = rnd.Next(0, 8);
                takımlar_doğu[0] = takımların_adları[numaralar_doğu[0]];
                güçler_doğu[0] = Takımların_Hücum_Güçleri[numaralar_doğu[0]];
                savunma_doğu[0] = Takımların_Savunma_Güçleri[numaralar_doğu[0]];
                üçlük_doğu[0] = üçlükşansı[numaralar_doğu[0]];
                pb_9.Image = ımageList2.Images[numaralar_doğu[0]];
                for (int i = 1; i < 8; i++)
                {
                    a = rnd.Next(0, 8);
                    for (int j = 0; j < i; j++)
                    {
                        if (numaralar_doğu[j] == a)
                        {
                            i--;
                            brk = true;
                            break;
                        }
                        else
                        {
                            numaralar_doğu[i] = a;
                            brk = false;
                        }
                    }
                    if (brk == false)
                    {
                        takımlar_doğu[i] = takımların_adları[a + 15];
                        güçler_doğu[i] = Takımların_Hücum_Güçleri[a + 15];
                        savunma_doğu[i] = Takımların_Savunma_Güçleri[a + 15];
                        üçlük_doğu[i] = üçlükşansı[a + 15];
                        resimEkle_doğu(a);
                        sayaç++;
                    }
                }
            }
            #endregion

        }

        private void resimEkle_batı(int s)
        {
            if (sayaç == 1)
                pb_2.Image = ımageList1.Images[s];
            else if (sayaç == 2)
                pb_3.Image = ımageList1.Images[s];
            else if (sayaç == 3)
                pb_4.Image = ımageList1.Images[s];
            else if (sayaç == 4)
                pb_5.Image = ımageList1.Images[s];
            else if (sayaç == 5)
                pb_6.Image = ımageList1.Images[s];
            else if (sayaç == 6)
                pb_7.Image = ımageList1.Images[s];
            else if (sayaç == 7)
                pb_8.Image = ımageList1.Images[s];
        }

        private void resimEkle_doğu(int s)
        {
            if (sayaç == 1)
                pb_10.Image = ımageList2.Images[s];
            else if (sayaç == 2)
                pb_11.Image = ımageList2.Images[s];
            else if (sayaç == 3)
                pb_12.Image = ımageList2.Images[s];
            else if (sayaç == 4)
                pb_13.Image = ımageList2.Images[s];
            else if (sayaç == 5)
                pb_14.Image = ımageList2.Images[s];
            else if (sayaç == 6)
                pb_15.Image = ımageList2.Images[s];
            else if (sayaç == 7)
                pb_16.Image = ımageList2.Images[s];
        }



        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        Form2 frm2 = new Form2();
        int güç1, güç2;
        int savunma1, savuunma2;
        int üçlük1, üçlük2;
        bool takımın_maçı = true; int puan1 = 0, puan2 = 0;
        bool turnuvada_kalma = true;

        bool çeyrek_final1 = true, çeyrek_final2 = false, yarı_final = false, final = false;
        
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (çeyrek_final1 == true && çeyrek_final2 == false && yarı_final == false && final == false)
            {
                çeyrek_final1 = false; çeyrek_final2 = true;
                //kod
            }
            else if (çeyrek_final1 == false && çeyrek_final2 == true && yarı_final == false && final == false)
            {
                çeyrek_final2 = false; yarı_final = true;
                //kod
            }
            else if (çeyrek_final1 == false && çeyrek_final2 == false && yarı_final == true && final == false)
            {
                yarı_final = false; final = true;
                //kod
            }
            else if (final == true)
            {
                //kod
            }
        }

        private void maç()
        {
        }
    }
}

