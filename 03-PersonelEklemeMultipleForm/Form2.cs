using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_PersonelEklemeMultipleForm
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        Form1 mainForm = new Form1(); // Ana form
        List<string> adSoyadListesi = new List<string>();
        List<string> birimListesi = new List<string>();
        List<string> TCNOListesi = new List<string>();
        List<string> dogumYeriListesi = new List<string>();
        List<string> dogumTarihiListesi = new List<string>();
        List<string> cinsiyetListesi = new List<string>();

        public void VerileriAl(List<string> adSoyadlar, List<string> birimler, List<string> tcNolar, List<string> dogumYerleri, List<string> dogumTarihleri, List<string> cinsiyetler, Form1 gelenAnaForm)
        {
            adSoyadListesi = adSoyadlar;
            birimListesi = birimler;
            TCNOListesi = tcNolar;
            dogumYeriListesi = dogumYerleri;
            dogumTarihiListesi = dogumTarihleri;
            cinsiyetListesi = cinsiyetler;
            mainForm = gelenAnaForm;
        }

        int goruntulemeIndexi;
        private void Form2_Load(object sender, EventArgs e)
        {
            goruntulemeIndexi = adSoyadListesi.Count - 1;
            KaydiGoruntule();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            lblKayit.Text = "";
            btnTemizle.Enabled = btnIleri.Enabled = btnGeri.Enabled = false; // Ekrani temizledigi icin hangi elemandan geri veya ileri gidecegi belli degildir. Dolayisyla butonlarin enebled ozelligi false olsun
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            if (goruntulemeIndexi > 0)  //Bir onceki elemanin indexi olsun
                goruntulemeIndexi--;
            else
                goruntulemeIndexi = 0;  //Aksi halde en ilk elemandayim. Goruntuleme indexin ilk elemanin indexi olsun.

            KaydiGoruntule();           //Olgili elemanin ecersindeki degerleri Laber a yaz

        }

        private void btnIleri_Click(object sender, EventArgs e)
        {
            if (goruntulemeIndexi < adSoyadListesi.Count - 1)
                goruntulemeIndexi++;                            //Bir sonraki elemanin indexi olsun
            else
                goruntulemeIndexi = adSoyadListesi.Count - 1;   //Aksi halde en son elemandayim goruntumene indexi son elemanin idexi olsun       
            KaydiGoruntule();

        }


        private void KaydiGoruntule()
        {
            lblKayit.Text = "Adi Soyadi: " + adSoyadListesi[goruntulemeIndexi];
            lblKayit.Text += "\nT.C No: " + TCNOListesi[goruntulemeIndexi];
            lblKayit.Text += "\nDogum Yeri: " + dogumYeriListesi[goruntulemeIndexi];
            lblKayit.Text += "\nDogum Tarihi: " + dogumTarihiListesi[goruntulemeIndexi];
            lblKayit.Text += "\nCinsiyet: " + cinsiyetListesi[goruntulemeIndexi];
            lblKayit.Text += "\nBirim: " + birimListesi[goruntulemeIndexi];

            ButonlariKontrolEt();
        }

        private void ButonlariKontrolEt()
        {
            if (goruntulemeIndexi == 0)// Ilk kayittaysak
            {
                btnGeri.Enabled = false;

                //Birden fazla kayit var ve ilk kayittaysak
                if (adSoyadListesi.Count > 1)
                    btnIleri.Enabled = true;
                else
                    btnIleri.Enabled = false;
            }
            else if (goruntulemeIndexi == adSoyadListesi.Count - 1) // Son kayittaysak
            {
                btnIleri.Enabled = false;
                if (adSoyadListesi.Count > 1)
                    btnGeri.Enabled = true;
                else
                    btnGeri.Enabled = false;
            }
            else
            {
                btnGeri.Enabled = true;
                btnIleri.Enabled = true;
            }

        }


        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            this.Close();

        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Show();
        }
    }
}
