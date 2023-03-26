namespace WindowsFormsApp2
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbCpu3 = new System.Windows.Forms.RadioButton();
            this.rbCpu5 = new System.Windows.Forms.RadioButton();
            this.rbCpui3 = new System.Windows.Forms.RadioButton();
            this.rbCpui5 = new System.Windows.Forms.RadioButton();
            this.rbCpui7 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbRam4 = new System.Windows.Forms.RadioButton();
            this.rbRam8 = new System.Windows.Forms.RadioButton();
            this.rbRam16 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbHdd320 = new System.Windows.Forms.RadioButton();
            this.rbHdd500 = new System.Windows.Forms.RadioButton();
            this.rbHdd1000 = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbWifi = new System.Windows.Forms.CheckBox();
            this.cbCam = new System.Windows.Forms.CheckBox();
            this.cbDvd = new System.Windows.Forms.CheckBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rbEkranKartiIris = new System.Windows.Forms.RadioButton();
            this.rbEkranKarti1080 = new System.Windows.Forms.RadioButton();
            this.rbEkranKarti3080 = new System.Windows.Forms.RadioButton();
            this.rbEkranKarti4080 = new System.Windows.Forms.RadioButton();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lblIslemci = new System.Windows.Forms.Label();
            this.lblEkranKarti = new System.Windows.Forms.Label();
            this.lblRamBellek = new System.Windows.Forms.Label();
            this.lblSabitDisk = new System.Windows.Forms.Label();
            this.lblEkDonanimlar = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbCpu3);
            this.groupBox1.Controls.Add(this.rbCpu5);
            this.groupBox1.Controls.Add(this.rbCpui3);
            this.groupBox1.Controls.Add(this.rbCpui5);
            this.groupBox1.Controls.Add(this.rbCpui7);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 155);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İşlemciler";
            // 
            // rbCpu3
            // 
            this.rbCpu3.AutoSize = true;
            this.rbCpu3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbCpu3.ForeColor = System.Drawing.Color.White;
            this.rbCpu3.Location = new System.Drawing.Point(20, 122);
            this.rbCpu3.Name = "rbCpu3";
            this.rbCpu3.Size = new System.Drawing.Size(98, 19);
            this.rbCpu3.TabIndex = 4;
            this.rbCpu3.TabStop = true;
            this.rbCpu3.Text = "AMD Ryzen 3";
            this.rbCpu3.UseVisualStyleBackColor = true;
            this.rbCpu3.Click += new System.EventHandler(this.yazdir);
            // 
            // rbCpu5
            // 
            this.rbCpu5.AutoSize = true;
            this.rbCpu5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbCpu5.ForeColor = System.Drawing.Color.White;
            this.rbCpu5.Location = new System.Drawing.Point(20, 99);
            this.rbCpu5.Name = "rbCpu5";
            this.rbCpu5.Size = new System.Drawing.Size(98, 19);
            this.rbCpu5.TabIndex = 3;
            this.rbCpu5.TabStop = true;
            this.rbCpu5.Text = "AMD Ryzen 5";
            this.rbCpu5.UseVisualStyleBackColor = true;
            this.rbCpu5.Click += new System.EventHandler(this.yazdir);
            // 
            // rbCpui3
            // 
            this.rbCpui3.AutoSize = true;
            this.rbCpui3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbCpui3.ForeColor = System.Drawing.Color.White;
            this.rbCpui3.Location = new System.Drawing.Point(20, 76);
            this.rbCpui3.Name = "rbCpui3";
            this.rbCpui3.Size = new System.Drawing.Size(92, 19);
            this.rbCpui3.TabIndex = 2;
            this.rbCpui3.TabStop = true;
            this.rbCpui3.Text = "İntel Core İ3";
            this.rbCpui3.UseVisualStyleBackColor = true;
            this.rbCpui3.Click += new System.EventHandler(this.yazdir);
            // 
            // rbCpui5
            // 
            this.rbCpui5.AutoSize = true;
            this.rbCpui5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbCpui5.ForeColor = System.Drawing.Color.White;
            this.rbCpui5.Location = new System.Drawing.Point(20, 53);
            this.rbCpui5.Name = "rbCpui5";
            this.rbCpui5.Size = new System.Drawing.Size(92, 19);
            this.rbCpui5.TabIndex = 1;
            this.rbCpui5.TabStop = true;
            this.rbCpui5.Text = "İntel Core İ5";
            this.rbCpui5.UseVisualStyleBackColor = true;
            this.rbCpui5.Click += new System.EventHandler(this.yazdir);
            // 
            // rbCpui7
            // 
            this.rbCpui7.AutoSize = true;
            this.rbCpui7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbCpui7.ForeColor = System.Drawing.Color.White;
            this.rbCpui7.Location = new System.Drawing.Point(20, 30);
            this.rbCpui7.Name = "rbCpui7";
            this.rbCpui7.Size = new System.Drawing.Size(92, 19);
            this.rbCpui7.TabIndex = 0;
            this.rbCpui7.TabStop = true;
            this.rbCpui7.Text = "İntel Core İ7";
            this.rbCpui7.UseVisualStyleBackColor = true;
            this.rbCpui7.Click += new System.EventHandler(this.yazdir);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbRam4);
            this.groupBox2.Controls.Add(this.rbRam8);
            this.groupBox2.Controls.Add(this.rbRam16);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(442, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(114, 155);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ram Bellek";
            // 
            // rbRam4
            // 
            this.rbRam4.AutoSize = true;
            this.rbRam4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbRam4.ForeColor = System.Drawing.Color.White;
            this.rbRam4.Location = new System.Drawing.Point(20, 76);
            this.rbRam4.Name = "rbRam4";
            this.rbRam4.Size = new System.Drawing.Size(51, 19);
            this.rbRam4.TabIndex = 7;
            this.rbRam4.TabStop = true;
            this.rbRam4.Text = "4 GB";
            this.rbRam4.UseVisualStyleBackColor = true;
            this.rbRam4.Click += new System.EventHandler(this.yazdir);
            // 
            // rbRam8
            // 
            this.rbRam8.AutoSize = true;
            this.rbRam8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbRam8.ForeColor = System.Drawing.Color.White;
            this.rbRam8.Location = new System.Drawing.Point(20, 53);
            this.rbRam8.Name = "rbRam8";
            this.rbRam8.Size = new System.Drawing.Size(51, 19);
            this.rbRam8.TabIndex = 6;
            this.rbRam8.TabStop = true;
            this.rbRam8.Text = "8 GB";
            this.rbRam8.UseVisualStyleBackColor = true;
            this.rbRam8.Click += new System.EventHandler(this.yazdir);
            // 
            // rbRam16
            // 
            this.rbRam16.AutoSize = true;
            this.rbRam16.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbRam16.ForeColor = System.Drawing.Color.White;
            this.rbRam16.Location = new System.Drawing.Point(20, 30);
            this.rbRam16.Name = "rbRam16";
            this.rbRam16.Size = new System.Drawing.Size(58, 19);
            this.rbRam16.TabIndex = 5;
            this.rbRam16.TabStop = true;
            this.rbRam16.Text = "16 GB";
            this.rbRam16.UseVisualStyleBackColor = true;
            this.rbRam16.Click += new System.EventHandler(this.yazdir);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbHdd320);
            this.groupBox3.Controls.Add(this.rbHdd500);
            this.groupBox3.Controls.Add(this.rbHdd1000);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(247, 173);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(114, 108);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sabit Disk";
            // 
            // rbHdd320
            // 
            this.rbHdd320.AutoSize = true;
            this.rbHdd320.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbHdd320.ForeColor = System.Drawing.Color.White;
            this.rbHdd320.Location = new System.Drawing.Point(20, 76);
            this.rbHdd320.Name = "rbHdd320";
            this.rbHdd320.Size = new System.Drawing.Size(65, 19);
            this.rbHdd320.TabIndex = 10;
            this.rbHdd320.TabStop = true;
            this.rbHdd320.Text = "320 GB";
            this.rbHdd320.UseVisualStyleBackColor = true;
            this.rbHdd320.Click += new System.EventHandler(this.yazdir);
            // 
            // rbHdd500
            // 
            this.rbHdd500.AutoSize = true;
            this.rbHdd500.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbHdd500.ForeColor = System.Drawing.Color.White;
            this.rbHdd500.Location = new System.Drawing.Point(20, 53);
            this.rbHdd500.Name = "rbHdd500";
            this.rbHdd500.Size = new System.Drawing.Size(65, 19);
            this.rbHdd500.TabIndex = 9;
            this.rbHdd500.TabStop = true;
            this.rbHdd500.Text = "500 GB";
            this.rbHdd500.UseVisualStyleBackColor = true;
            this.rbHdd500.Click += new System.EventHandler(this.yazdir);
            // 
            // rbHdd1000
            // 
            this.rbHdd1000.AutoSize = true;
            this.rbHdd1000.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbHdd1000.ForeColor = System.Drawing.Color.White;
            this.rbHdd1000.Location = new System.Drawing.Point(20, 30);
            this.rbHdd1000.Name = "rbHdd1000";
            this.rbHdd1000.Size = new System.Drawing.Size(50, 19);
            this.rbHdd1000.TabIndex = 8;
            this.rbHdd1000.TabStop = true;
            this.rbHdd1000.Text = "1 TB";
            this.rbHdd1000.UseVisualStyleBackColor = true;
            this.rbHdd1000.Click += new System.EventHandler(this.yazdir);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbWifi);
            this.groupBox4.Controls.Add(this.cbCam);
            this.groupBox4.Controls.Add(this.cbDvd);
            this.groupBox4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(12, 173);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(229, 107);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ek Donanımlar";
            this.groupBox4.MouseHover += new System.EventHandler(this.yazdir);
            // 
            // cbWifi
            // 
            this.cbWifi.AutoSize = true;
            this.cbWifi.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbWifi.ForeColor = System.Drawing.Color.White;
            this.cbWifi.Location = new System.Drawing.Point(20, 76);
            this.cbWifi.Name = "cbWifi";
            this.cbWifi.Size = new System.Drawing.Size(97, 19);
            this.cbWifi.TabIndex = 13;
            this.cbWifi.Text = "Wirless Kart";
            this.cbWifi.UseVisualStyleBackColor = true;
            this.cbWifi.Click += new System.EventHandler(this.yazdir);
            // 
            // cbCam
            // 
            this.cbCam.AutoSize = true;
            this.cbCam.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbCam.ForeColor = System.Drawing.Color.White;
            this.cbCam.Location = new System.Drawing.Point(20, 53);
            this.cbCam.Name = "cbCam";
            this.cbCam.Size = new System.Drawing.Size(81, 19);
            this.cbCam.TabIndex = 12;
            this.cbCam.Text = "Web Cam";
            this.cbCam.UseVisualStyleBackColor = true;
            this.cbCam.Click += new System.EventHandler(this.yazdir);
            // 
            // cbDvd
            // 
            this.cbDvd.AutoSize = true;
            this.cbDvd.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbDvd.ForeColor = System.Drawing.Color.White;
            this.cbDvd.Location = new System.Drawing.Point(20, 30);
            this.cbDvd.Name = "cbDvd";
            this.cbDvd.Size = new System.Drawing.Size(77, 19);
            this.cbDvd.TabIndex = 11;
            this.cbDvd.Text = "DvD Rom";
            this.cbDvd.UseVisualStyleBackColor = true;
            this.cbDvd.Click += new System.EventHandler(this.yazdir);
            // 
            // btnHesapla
            // 
            this.btnHesapla.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnHesapla.FlatAppearance.BorderSize = 0;
            this.btnHesapla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHesapla.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapla.ForeColor = System.Drawing.Color.White;
            this.btnHesapla.Location = new System.Drawing.Point(367, 173);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(399, 49);
            this.btnHesapla.TabIndex = 14;
            this.btnHesapla.Text = "Satın Al";
            this.btnHesapla.UseVisualStyleBackColor = false;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(367, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 55);
            this.label1.TabIndex = 18;
            this.label1.Text = "Toplam Fiyat : 0 TL";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.yazdir);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rbEkranKartiIris);
            this.groupBox5.Controls.Add(this.rbEkranKarti1080);
            this.groupBox5.Controls.Add(this.rbEkranKarti3080);
            this.groupBox5.Controls.Add(this.rbEkranKarti4080);
            this.groupBox5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox5.ForeColor = System.Drawing.Color.White;
            this.groupBox5.Location = new System.Drawing.Point(247, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(189, 155);
            this.groupBox5.TabIndex = 16;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Ekran Kartı";
            // 
            // rbEkranKartiIris
            // 
            this.rbEkranKartiIris.AutoSize = true;
            this.rbEkranKartiIris.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbEkranKartiIris.ForeColor = System.Drawing.Color.White;
            this.rbEkranKartiIris.Location = new System.Drawing.Point(20, 99);
            this.rbEkranKartiIris.Name = "rbEkranKartiIris";
            this.rbEkranKartiIris.Size = new System.Drawing.Size(142, 19);
            this.rbEkranKartiIris.TabIndex = 5;
            this.rbEkranKartiIris.TabStop = true;
            this.rbEkranKartiIris.Text = "İntel İris Xe Graphics";
            this.rbEkranKartiIris.UseVisualStyleBackColor = true;
            this.rbEkranKartiIris.Click += new System.EventHandler(this.yazdir);
            // 
            // rbEkranKarti1080
            // 
            this.rbEkranKarti1080.AutoSize = true;
            this.rbEkranKarti1080.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbEkranKarti1080.ForeColor = System.Drawing.Color.White;
            this.rbEkranKarti1080.Location = new System.Drawing.Point(20, 76);
            this.rbEkranKarti1080.Name = "rbEkranKarti1080";
            this.rbEkranKarti1080.Size = new System.Drawing.Size(138, 19);
            this.rbEkranKarti1080.TabIndex = 5;
            this.rbEkranKarti1080.TabStop = true;
            this.rbEkranKarti1080.Text = "Nvidia Geforce 1080";
            this.rbEkranKarti1080.UseVisualStyleBackColor = true;
            this.rbEkranKarti1080.Click += new System.EventHandler(this.yazdir);
            // 
            // rbEkranKarti3080
            // 
            this.rbEkranKarti3080.AutoSize = true;
            this.rbEkranKarti3080.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbEkranKarti3080.ForeColor = System.Drawing.Color.White;
            this.rbEkranKarti3080.Location = new System.Drawing.Point(20, 53);
            this.rbEkranKarti3080.Name = "rbEkranKarti3080";
            this.rbEkranKarti3080.Size = new System.Drawing.Size(138, 19);
            this.rbEkranKarti3080.TabIndex = 5;
            this.rbEkranKarti3080.TabStop = true;
            this.rbEkranKarti3080.Text = "Nvidia Geforce 3080";
            this.rbEkranKarti3080.UseVisualStyleBackColor = true;
            this.rbEkranKarti3080.Click += new System.EventHandler(this.yazdir);
            // 
            // rbEkranKarti4080
            // 
            this.rbEkranKarti4080.AutoSize = true;
            this.rbEkranKarti4080.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbEkranKarti4080.ForeColor = System.Drawing.Color.White;
            this.rbEkranKarti4080.Location = new System.Drawing.Point(20, 30);
            this.rbEkranKarti4080.Name = "rbEkranKarti4080";
            this.rbEkranKarti4080.Size = new System.Drawing.Size(138, 19);
            this.rbEkranKarti4080.TabIndex = 5;
            this.rbEkranKarti4080.TabStop = true;
            this.rbEkranKarti4080.Text = "Nvidia Geforce 4080";
            this.rbEkranKarti4080.UseVisualStyleBackColor = true;
            this.rbEkranKarti4080.Click += new System.EventHandler(this.yazdir);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lblEkDonanimlar);
            this.groupBox6.Controls.Add(this.lblSabitDisk);
            this.groupBox6.Controls.Add(this.lblRamBellek);
            this.groupBox6.Controls.Add(this.lblEkranKarti);
            this.groupBox6.Controls.Add(this.lblIslemci);
            this.groupBox6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox6.ForeColor = System.Drawing.Color.White;
            this.groupBox6.Location = new System.Drawing.Point(562, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(204, 155);
            this.groupBox6.TabIndex = 17;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Parça Fiyatları";
            // 
            // lblIslemci
            // 
            this.lblIslemci.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIslemci.ForeColor = System.Drawing.Color.White;
            this.lblIslemci.Location = new System.Drawing.Point(6, 30);
            this.lblIslemci.Name = "lblIslemci";
            this.lblIslemci.Size = new System.Drawing.Size(192, 19);
            this.lblIslemci.TabIndex = 19;
            this.lblIslemci.Text = "İşlemci : Parça Seçilmedi";
            this.lblIslemci.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEkranKarti
            // 
            this.lblEkranKarti.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEkranKarti.ForeColor = System.Drawing.Color.White;
            this.lblEkranKarti.Location = new System.Drawing.Point(6, 53);
            this.lblEkranKarti.Name = "lblEkranKarti";
            this.lblEkranKarti.Size = new System.Drawing.Size(192, 19);
            this.lblEkranKarti.TabIndex = 19;
            this.lblEkranKarti.Text = "Ekran Kartı : Parça Seçilmedi";
            this.lblEkranKarti.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRamBellek
            // 
            this.lblRamBellek.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRamBellek.ForeColor = System.Drawing.Color.White;
            this.lblRamBellek.Location = new System.Drawing.Point(6, 76);
            this.lblRamBellek.Name = "lblRamBellek";
            this.lblRamBellek.Size = new System.Drawing.Size(192, 19);
            this.lblRamBellek.TabIndex = 19;
            this.lblRamBellek.Text = "Ram Bellek : Parça Seçilmedi";
            this.lblRamBellek.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSabitDisk
            // 
            this.lblSabitDisk.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSabitDisk.ForeColor = System.Drawing.Color.White;
            this.lblSabitDisk.Location = new System.Drawing.Point(6, 99);
            this.lblSabitDisk.Name = "lblSabitDisk";
            this.lblSabitDisk.Size = new System.Drawing.Size(192, 19);
            this.lblSabitDisk.TabIndex = 19;
            this.lblSabitDisk.Text = "Sabit Disk : Parça Seçilmedi";
            this.lblSabitDisk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEkDonanimlar
            // 
            this.lblEkDonanimlar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEkDonanimlar.ForeColor = System.Drawing.Color.White;
            this.lblEkDonanimlar.Location = new System.Drawing.Point(6, 122);
            this.lblEkDonanimlar.Name = "lblEkDonanimlar";
            this.lblEkDonanimlar.Size = new System.Drawing.Size(192, 19);
            this.lblEkDonanimlar.TabIndex = 19;
            this.lblEkDonanimlar.Text = "Ek Donanımlar : Parça Seçilmedi";
            this.lblEkDonanimlar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(779, 297);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bilgisayar Sipariş";
            this.Click += new System.EventHandler(this.yazdir);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbCpu3;
        private System.Windows.Forms.RadioButton rbCpu5;
        private System.Windows.Forms.RadioButton rbCpui3;
        private System.Windows.Forms.RadioButton rbCpui5;
        private System.Windows.Forms.RadioButton rbCpui7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbRam4;
        private System.Windows.Forms.RadioButton rbRam8;
        private System.Windows.Forms.RadioButton rbRam16;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbHdd320;
        private System.Windows.Forms.RadioButton rbHdd500;
        private System.Windows.Forms.RadioButton rbHdd1000;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox cbWifi;
        private System.Windows.Forms.CheckBox cbCam;
        private System.Windows.Forms.CheckBox cbDvd;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton rbEkranKartiIris;
        private System.Windows.Forms.RadioButton rbEkranKarti1080;
        private System.Windows.Forms.RadioButton rbEkranKarti3080;
        private System.Windows.Forms.RadioButton rbEkranKarti4080;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEkDonanimlar;
        private System.Windows.Forms.Label lblSabitDisk;
        private System.Windows.Forms.Label lblRamBellek;
        private System.Windows.Forms.Label lblEkranKarti;
        private System.Windows.Forms.Label lblIslemci;
    }
}

