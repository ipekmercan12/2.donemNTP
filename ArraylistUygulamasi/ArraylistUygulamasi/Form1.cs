using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArraylistUygulamasi
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

        
        ArrayList sehirler = new ArrayList();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            sehirler.Add(textBox1.Text);
            //textbox'a girilen değeri ArrayList'e ekler.
            listele(); //listele metodu çağırıldı.

        }
        private void listele()
        {
            listBox1.Items.Clear();
            {
                foreach (string sehir in sehirler)
                {
                    listBox1.Items.Add(sehir);
                }
              }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int indexNo = listBox1.SelectedIndex;
            sehirler.Insert(indexNo, textBox1.Text);
            listele();

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int indexNo = listBox1.SelectedIndex;
            sehirler[indexNo] = textBox1.Text;
            listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int indexNo = listBox1.SelectedIndex;
            sehirler.RemoveAt(indexNo);
            listele();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (sehirler.Contains(textBox1.Text))
            
            {
                label2.Text = " Aranan Değer Bulundu";
                listBox1.SelectedIndex = sehirler.IndexOf(textBox1.Text);
            }
            else
            {
                label2.Text = "Aranan Değer Bulunmadı";
            }
        }

        private void btnTersineCevir_Click(object sender, EventArgs e)
        {
            sehirler.Reverse();
            listele();
        }

        private void btnKucuktenBuyuge_Click(object sender, EventArgs e)
        {
            sehirler.Sort();
            listele();
        }
    }
}
