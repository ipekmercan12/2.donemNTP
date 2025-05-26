using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ikiBoyutluSozluDiziUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] isimler = new string[3];
            int[,] notlar = new int[3, 4];
            int index = 0;

            isimler[index] = txtAdSoyad.Text;
            notlar[index, 0] = Convert.ToInt32(txtsozlu1.Text);
            notlar[index, 1] = Convert.ToInt32(txtsozlu2.Text);
            notlar[index, 2] = Convert.ToInt32(txtsozlu3.Text);
            notlar[index, 3] = Convert.ToInt32(txtsozlu4.Text);
            index++;

            for (int i = 0; i < index; i++)
            {
                listBox1.Items.Add("Ad Soyad :" + isimler[i]);
                for (int j = 0; j <4; j++)
                {
                    listBox1.Items.Add(notlar[i, j]);
                }
            }
            


        }
    }
}
