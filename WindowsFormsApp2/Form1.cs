using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            if (Form2.secim == 1)
            {
                rbEkranKarti4080.Enabled = false;
                rbEkranKarti3080.Enabled = false;
                rbEkranKarti1080.Enabled = false;
                rbCpui3.Enabled = false;
                rbCpu3.Enabled = false;
                rbHdd320.Enabled = false;
                rbRam4.Enabled = false;
            }
            else if(Form2.secim == 2)
            {
                rbEkranKartiIris.Enabled = false;
                rbCpui3.Enabled = false;
                rbCpu3.Enabled = false;
                rbHdd320.Enabled = false;
                rbRam4.Enabled = false;
            }
        }

        int toplamFiyat, cpuFiyat, ekranKartiFiyat, ramFiyat, hddFiyat, ekDonanimFiyat;


        private void Form2_KeyPress(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show(e.KeyChar.ToString());
        }

        int hesapla()
        {
            toplamFiyat = 0;

            cpuFiyat = 0;

            if (rbCpui7.Checked)
            {
                cpuFiyat += 5500;
            }
            else if (rbCpui5.Checked)
            {
                cpuFiyat += 4000;
            }
            else if (rbCpui3.Checked)
            {
                cpuFiyat += 3000;
            }
            else if (rbCpu5.Checked)
            {
                cpuFiyat += 4500;
            }
            else if (rbCpu3.Checked)
            {
                cpuFiyat += 3500;
            }

            ekranKartiFiyat = 0;

            if (rbEkranKarti4080.Checked)
            {
                ekranKartiFiyat += 8500;
            }
            else if (rbEkranKarti3080.Checked)
            {
                ekranKartiFiyat += 7000;
            }
            else if (rbEkranKarti1080.Checked)
            {
                ekranKartiFiyat += 3500;
            }
            else if (rbEkranKartiIris.Checked)
            {
                ekranKartiFiyat += 4500;
            }

             ramFiyat = 0;

            if (rbRam16.Checked)
            {
                ramFiyat += 2000;
            }
            else if (rbRam8.Checked)
            {
                ramFiyat += 1250;
            }
            else if (rbRam4.Checked)
            {
                ramFiyat += 750;
            }

            hddFiyat = 0;

            if (rbHdd1000.Checked)
            {
                hddFiyat += 1000;
            }
            else if (rbHdd500.Checked)
            {
                hddFiyat += 750;
            }
            else if (rbHdd320.Checked)
            {
                hddFiyat += 500;
            }

            ekDonanimFiyat = 0;

            if (cbDvd.Checked)
            {
                ekDonanimFiyat += 500;
            }
            if (cbCam.Checked)
            {
                ekDonanimFiyat += 250;
            }
            if (cbWifi.Checked)
            {
                ekDonanimFiyat += 350;
            }

            return toplamFiyat = cpuFiyat + ekranKartiFiyat + ramFiyat + hddFiyat + ekDonanimFiyat;
        }
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int toplamFiyat = hesapla();

            if(toplamFiyat == 0)
            {
                MessageBox.Show("Hiç Bir Şey Satın Almadınız !");
            }
            else
            {
                if(cpuFiyat != 0 && ekranKartiFiyat != 0 && ramFiyat != 0 && hddFiyat != 0)
                {
                    DialogResult cevap = MessageBox.Show($"Toplam Fiyat :   {toplamFiyat} TL \n\nSatın Almak İstiyormusunuz ?", "Satın Al", MessageBoxButtons.YesNo);
                    if (cevap == DialogResult.Yes)
                    {
                        MessageBox.Show("Satın Alındı !");
                    }
                    else
                    {
                        MessageBox.Show("Satın Alma İptal Edildi !");
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen Temel Parçaların Hepsini Seçiniz !");
                }
            }
        }

        private void yazdir(object sender, EventArgs e)
        {
            int toplamFiyat = hesapla();
            if(cpuFiyat != 0)
            {
                lblIslemci.Text = $"İşlemci : {cpuFiyat} TL";
            }
            if (ekranKartiFiyat != 0)
            {
                lblEkranKarti.Text = $"Ekran Kartı : {ekranKartiFiyat} TL";
            }
            if (ramFiyat != 0)
            {
                lblRamBellek.Text = $"Ram Bellek : {ramFiyat} TL";
            }
            if (hddFiyat != 0)
            {
                lblSabitDisk.Text = $"Sabit Disk : {hddFiyat} TL";
            }
            if (ekDonanimFiyat != 0)
            {
                lblEkDonanimlar.Text = $"Ek Donanımlar : {ekDonanimFiyat} TL";
            }
            else
            {
                lblEkDonanimlar.Text = $"Ek Donanımlar : Parça Seçilmedi";
            }
                label1.Text = $"Toplam Fiyat : {toplamFiyat} TL";
        }
    }
}
