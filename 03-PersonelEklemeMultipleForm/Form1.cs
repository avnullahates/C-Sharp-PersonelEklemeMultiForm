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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void grbPersonelBilgiler_Enter(object sender, EventArgs e)
        {
            chkErkek.Checked = true;
            btnTemizle.Enabled = btnKaydiGoruntule.Enabled = false;
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            foreach (Control item in grbPersonelEkle.Controls) //this.Controls => Bu formun kontroller
            {
                if (item is TextBox)
                    ((TextBox)item).Text = "";
                else if (item is CheckBox)
                {
                    if (((CheckBox)item).Name == "chkErkek") // Name ozelligi chkErkek olan CheckBox in check ini true yap                  
                        ((CheckBox)item).Checked = true;   
                }
                else if (item is DateTimePicker)
                    ((DateTimePicker)item).Value = DateTime.Now;

                btnTemizle.Enabled = false;
            }
        }

        private void chkErkek_CheckedChanged(object sender, EventArgs e)
        {
            chkKadin.Checked = !chkErkek.Checked;
        }

        private void chkKadin_CheckedChanged(object sender, EventArgs e)
        {
            chkErkek.Checked = !chkKadin.Checked;
        }
        List<string> adSoyadList = new List<string>();
        List<string> birimList = new List<string>();
        List<string> TCNOList = new List<string>();
        List<string> dogumYeriList = new List<string>();
        List<string> dogumTarihiList = new List<string>();
        List<string> cinsiyetList = new List<string>();

        private void btnKaydet_Click(object sender, EventArgs e)
        {

            if (BosAlanVarmi())
            {
                MessageBox.Show("Lutfen bos alan birakmayiniz");

            }
            else
            {
                adSoyadList.Add(txtAdSoyad.Text);
                birimList.Add(txtBirim.Text);
                TCNOList.Add(txtTcNo.Text);
                dogumYeriList.Add(txtDogumYeri.Text);
                dogumTarihiList.Add(dtpDogumTarihi.Text);
                cinsiyetList.Add(chkErkek.Checked ? "ERKEK" : "KADIN");

                MessageBox.Show("Personmel Ekleme Basarili!");

                btnTemizle.Enabled = btnKaydiGoruntule.Enabled = true;
            }



        }

        private bool BosAlanVarmi()
        {
            foreach (Control item in grbPersonelEkle.Controls)
            {
                if (item is TextBox)
                {
                    if (item.Text == "")
                        return true;
                }
                else if (item is DateTimePicker)
                {
                    if (((DateTimePicker)item).Value.Date == DateTime.Now.Date)
                        return true;
                }
            }
            return false; //Yukaridaki kara yapilarindan herhangi biri bir return degeri geri dondurmex ise bos alan yoktur. False dondurur
        }

        private void btnKaydiGoruntule_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.VerileriAl(adSoyadList, birimList, TCNOList, dogumYeriList, dogumTarihiList, cinsiyetList,this); //Metodun son parametresi olarak this ifadesi ile bu formu gonderiyoruz
            frm2.Show();
            this.Hide();
        }
    }
}
