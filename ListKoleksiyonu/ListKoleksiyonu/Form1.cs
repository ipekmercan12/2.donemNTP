using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListKoleksiyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        List<int> numaralarList = new List<int>();
        List<string> adsoyadList = new List<string>();
        List<ogrenciler> ogrencilerList = new List<ogrenciler>();


        private void btnSayiEkle_Click(object sender, EventArgs e)
        {
            numaralarList.Add(int.Parse(txtNumara.Text));
            lbSayi.Items.Clear();
            foreach (var item in numaralarList)
            {
                lbSayi.Items.Add(item);
            }
        }

        private void btnEkleMetin_Click(object sender, EventArgs e)
        {
            adsoyadList.Add(txtAdSoyad.Text);
            lbMetin.Items.Clear();
            foreach (var item in adsoyadList)
            {
                lbMetin.Items.Add(item);
            }


        }
        private void btnEkleNesne_Click(object sender, EventArgs e)
        {
            {
                ogrenciler ogrenci = new ogrenciler();
                ogrenci.Numara = int.Parse(txtNumaran.Text);
                ogrenci.AdSoyad = txtNumaran.Text;
                ogrencilerList.Add(ogrenci);
                lbNesne.Items.Clear();
                foreach (var item in ogrencilerList)
                {
                    lbNesne.Items.Add(item.Numara + " -" + item.AdSoyad);
                }
            }

        }

        private void txtNumaran_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
        
    
    
