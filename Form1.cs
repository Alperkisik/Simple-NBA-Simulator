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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Owner = this;
            frm3.plyof = false;
            frm3.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value++;
            label3.Text = "%" + progressBar1.Value.ToString();
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                panel1.Visible = false;
            }
        }

        //playoff
        private void button4_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.plyof = true;
            frm3.ShowDialog();
        }
        //sezon
        private void button2_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.plyof = false;
        }
        
    }
}
