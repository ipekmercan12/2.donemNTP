﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiziyeDegerAtama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double[,] notlar = new double[3, 4];
            notlar[0, 0] = 45;
            notlar[0, 1] = 55;
            notlar[0, 2] = 60;
            notlar[0, 3] = 65;

            notlar[1, 0] = 75;
            notlar[1, 1] = 80;
            notlar[1, 2] = 85;
            notlar[1, 3] = 90;

            notlar[2, 0] = 10;
            notlar[2, 1] = 20;
            notlar[2, 2] = 30;
            notlar[2, 3] = 40;
            double secilendeger = notlar[1, 1];
            MessageBox.Show("secilen deger : " + secilendeger, "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
               



        }
    }
}
