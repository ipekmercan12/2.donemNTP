﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace konteynerKontrolu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal tabanFiyat = 500;
            // İşlemci fiyat hesaplaması
            decimal cpuFiyat = 0;
            if
         (rbCpul7.Checked)
                cpuFiyat = 300;
            else if (rbCpul5.Checked)
                cpuFiyat = 200;
            else if (rbCpul3.Checked)
                cpuFiyat = 100;
            else if (rbCpuR5.Checked)
                cpuFiyat = 250;
            else if (rbCpuR3.Checked)
                cpuFiyat = 150;
            tabanFiyat += cpuFiyat;
            // Ram bellek fiyat hesaplaması
            decimal ramFiyat = 0;
            if
         (rbRam16.Checked)
                ramFiyat = 125;
            else if (rbRam8.Checked)
                ramFiyat = 75;
            else if (rbRam4.Checked)
                ramFiyat = 45;
            tabanFiyat += ramFiyat;
            MessageBox.Show(string.Format("Toplam Fiyat ={0}", tabanFiyat));
        }
    }
}
