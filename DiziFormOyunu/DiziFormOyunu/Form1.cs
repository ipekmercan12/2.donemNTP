using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiziFormOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        byte[,] dizi = new byte[4, 4];
        private void btnYeni_Click(object sender, EventArgs e)
        {
            Random rastgele = new Random(); // rastgele isminde bir Random nesnesi oluşturdu.           
            int satirRastgele = rastgele.Next(4);// 0-4 arası (4 dâhil değil) üretilen sayıdır.                         
            int sutunRastgele = rastgele.Next(4); // 0-4 arası (4 dâhil değil) üretilen sayıdır.                         
            dizi[satirRastgele, sutunRastgele] = 1; // Dizi içinde rastgele bir konuma 1 değeri aktarıldı.
        
        }

        private void tnGonder_Click(object sender, EventArgs e)
        {
            byte satir = byte.Parse(txtSatir.Text);
            byte sutun = byte.Parse(txtSutun.Text);
            PictureBox kutu = this.Controls.Find("P"+satir + sutun, true)[0] as PictureBox;
            // Controls.Find fonksiyonu name değerlerine göre  form içindeki kontrolleri bulmak için kullanılır. 
            // Bulunan kontroller as operatörü ile  PictureBox nesnelerine dönüştürülür.
            byte durum = dizi[satir, sutun];
            if (durum == 0)
            { kutu.BackColor = Color.Green; }
            else
            { kutu.BackColor = Color.Red; }
        }

    }
  }

