using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DizilerdeKullanilanMetotlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            MessageBox.Show("Dizinin eleman sayısı:" + numbers.Length  );
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[,] matrix = {
                {1,2 },
                {3,4 }
            };
            MessageBox.Show("dizinin boyut sayısı (Rank) :" +matrix.Rank);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            MessageBox.Show("dizinin en büyük elemanı : " + numbers.Max());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            MessageBox.Show("dizilerin en küçük elemanı :" + numbers.Min());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            MessageBox.Show("dizinin elemanlarının toplamı:" + numbers.Sum());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            MessageBox.Show("dizinin elamanlarının ortalaması:"+numbers. Average());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            MessageBox.Show("dizinin ilk elemanı :" + numbers. First());

        }

        private void button8_Click(object sender, EventArgs e)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            MessageBox.Show("dizinin son elemanı: " + numbers.Last ());
        }
    }
}
