﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QueueUtgulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Queue kuyruk = new Queue();
        int sira = 0;
        private void listele()
        {
            listBox1.Items.Clear();
            foreach (int sira in kuyruk)
            {
                listBox1.Items.Add(sira);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sira++;
            kuyruk.Enqueue(sira);
            listele();
           
        } 

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            kuyruk.Dequeue();
            listele();
        }
    }
}
