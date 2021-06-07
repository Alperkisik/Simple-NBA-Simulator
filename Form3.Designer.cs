namespace WindowsFormsApplication10
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl_ad = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.ımageList2 = new System.Windows.Forms.ImageList(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl3_3 = new System.Windows.Forms.Label();
            this.lbl2_2 = new System.Windows.Forms.Label();
            this.lbl1_1 = new System.Windows.Forms.Label();
            this.lbl_ad2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbl3);
            this.panel1.Controls.Add(this.lbl2);
            this.panel1.Controls.Add(this.lbl1);
            this.panel1.Controls.Add(this.lbl_ad);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(356, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(411, 176);
            this.panel1.TabIndex = 0;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(166, 126);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(85, 13);
            this.lbl3.TabIndex = 4;
            this.lbl3.Text = "Üçlük Şansı : 25";
            this.lbl3.Click += new System.EventHandler(this.label4_Click);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(166, 94);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(102, 13);
            this.lbl2.TabIndex = 3;
            this.lbl2.Text = "Savunma Gücü : 30";
            this.lbl2.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(166, 67);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(91, 13);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = "Hücum Gücü : 85";
            // 
            // lbl_ad
            // 
            this.lbl_ad.AutoSize = true;
            this.lbl_ad.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ad.Location = new System.Drawing.Point(169, 16);
            this.lbl_ad.Name = "lbl_ad";
            this.lbl_ad.Size = new System.Drawing.Size(115, 16);
            this.lbl_ad.TabIndex = 1;
            this.lbl_ad.Text = "Dallas Mavericks";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::WindowsFormsApplication10.Properties.Resources.dallas_mavericks_logo1;
            this.pictureBox1.Location = new System.Drawing.Point(17, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Dallas Mavericks",
            "Houston Rockets",
            "Memphis Grizzlies",
            "New Orleans Hornets",
            "San Antonio Spurs",
            "Denver Nuggets",
            "Minnesota Timberwolves",
            "Oklahoma City Thunder",
            "Portland Trail Blazers",
            "Utah Jazz",
            "Golden State Warriors",
            "Los Angeles Clippers",
            "Los Angeles Lakers",
            "Phoenix Suns",
            "Sacramento Kings"});
            this.listBox1.Location = new System.Drawing.Point(12, 37);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(157, 329);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Items.AddRange(new object[] {
            "Atlanta Hawks",
            "Charlotte Bobcats",
            "Miami Heat",
            "Orlando Magic",
            "Washington Wizards",
            "Chicago Bulls",
            "Cleveland Cavaliers",
            "Detroit Pistons",
            "Indiana Pacers",
            "Milwaukee Bucks",
            "Boston Celtics",
            "New Jersey Nets",
            "New York Knicks",
            "Philadelphia Sixers",
            "Toronto Raptors"});
            this.listBox2.Location = new System.Drawing.Point(175, 37);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(165, 329);
            this.listBox2.TabIndex = 2;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Batı Konferansı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(172, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Doğu Konferansı";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 383);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Takımını Seç";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(692, 383);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "İptal";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "dallas_mavericks_logo1.jpg");
            this.ımageList1.Images.SetKeyName(1, "houston-rockets-logo.gif");
            this.ımageList1.Images.SetKeyName(2, "memphis-grizzlies-logo.gif");
            this.ımageList1.Images.SetKeyName(3, "new-orleans-hornets-logo.gif");
            this.ımageList1.Images.SetKeyName(4, "san antonio spurs logo.gif");
            this.ımageList1.Images.SetKeyName(5, "DENVER-NUGGETS-LOGO.jpg");
            this.ımageList1.Images.SetKeyName(6, "timberwolves_detail.gif");
            this.ımageList1.Images.SetKeyName(7, "oklahoma-city-thunder-logo.jpg");
            this.ımageList1.Images.SetKeyName(8, "Portland-Trail-Blazers-Logo.png");
            this.ımageList1.Images.SetKeyName(9, "UtahJazz_UNS1_2011-9999.png");
            this.ımageList1.Images.SetKeyName(10, "golden state.jpg");
            this.ımageList1.Images.SetKeyName(11, "LAclippers-teamlogo.gif");
            this.ımageList1.Images.SetKeyName(12, "LAlakers-teamlogo.PNG");
            this.ımageList1.Images.SetKeyName(13, "phoenix-suns-logo.jpg");
            this.ımageList1.Images.SetKeyName(14, "sactamento-kings-logo.gif");
            // 
            // ımageList2
            // 
            this.ımageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList2.ImageStream")));
            this.ımageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList2.Images.SetKeyName(0, "atlanta-hawks-logo.gif");
            this.ımageList2.Images.SetKeyName(1, "charlotte_bobcats_logo1.jpg");
            this.ımageList2.Images.SetKeyName(2, "miami heat logo.gif");
            this.ımageList2.Images.SetKeyName(3, "OrlandoMagic_PML1_2011-9999.png");
            this.ımageList2.Images.SetKeyName(4, "Washington-Wizards.jpg");
            this.ımageList2.Images.SetKeyName(5, "chicago_bulls_logo.jpg");
            this.ımageList2.Images.SetKeyName(6, "ClevelandCavaliers_PML1_2011-9999.png");
            this.ımageList2.Images.SetKeyName(7, "Detroit-Pistons-Logo.gif");
            this.ımageList2.Images.SetKeyName(8, "indiana-pacers-logo.gif");
            this.ımageList2.Images.SetKeyName(9, "bucks-logo.gif");
            this.ımageList2.Images.SetKeyName(10, "Boston-Celtics-logo.jpg");
            this.ımageList2.Images.SetKeyName(11, "pic_492635_New-Jersey-Nets-Logo1.gif");
            this.ımageList2.Images.SetKeyName(12, "New-York-Knicks-Logo.gif");
            this.ımageList2.Images.SetKeyName(13, "Philadelphia-76ers-logo.png");
            this.ımageList2.Images.SetKeyName(14, "Toronto_Raptors_logo.png");
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(205, 383);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(173, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Rakip Takımı seç";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(611, 384);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "Devam";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lbl3_3);
            this.panel2.Controls.Add(this.lbl2_2);
            this.panel2.Controls.Add(this.lbl1_1);
            this.panel2.Controls.Add(this.lbl_ad2);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(356, 194);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(411, 176);
            this.panel2.TabIndex = 9;
            // 
            // lbl3_3
            // 
            this.lbl3_3.AutoSize = true;
            this.lbl3_3.Location = new System.Drawing.Point(166, 126);
            this.lbl3_3.Name = "lbl3_3";
            this.lbl3_3.Size = new System.Drawing.Size(85, 13);
            this.lbl3_3.TabIndex = 4;
            this.lbl3_3.Text = "Üçlük Şansı : 20";
            // 
            // lbl2_2
            // 
            this.lbl2_2.AutoSize = true;
            this.lbl2_2.Location = new System.Drawing.Point(166, 94);
            this.lbl2_2.Name = "lbl2_2";
            this.lbl2_2.Size = new System.Drawing.Size(102, 13);
            this.lbl2_2.TabIndex = 3;
            this.lbl2_2.Text = "Savunma Gücü : 24";
            // 
            // lbl1_1
            // 
            this.lbl1_1.AutoSize = true;
            this.lbl1_1.Location = new System.Drawing.Point(166, 67);
            this.lbl1_1.Name = "lbl1_1";
            this.lbl1_1.Size = new System.Drawing.Size(91, 13);
            this.lbl1_1.TabIndex = 2;
            this.lbl1_1.Text = "Hücum Gücü : 74";
            // 
            // lbl_ad2
            // 
            this.lbl_ad2.AutoSize = true;
            this.lbl_ad2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ad2.Location = new System.Drawing.Point(169, 25);
            this.lbl_ad2.Name = "lbl_ad2";
            this.lbl_ad2.Size = new System.Drawing.Size(103, 16);
            this.lbl_ad2.TabIndex = 1;
            this.lbl_ad2.Text = "Atlanta Hawks";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = global::WindowsFormsApplication10.Properties.Resources.atlanta_hawks_logo;
            this.pictureBox2.Location = new System.Drawing.Point(17, 16);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(135, 140);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(789, 418);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form3";
            this.Text = "Takım Seç";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl_ad;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.ImageList ımageList2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lbl3_3;
        private System.Windows.Forms.Label lbl2_2;
        private System.Windows.Forms.Label lbl1_1;
        private System.Windows.Forms.Label lbl_ad2;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.Panel panel2;
    }
}