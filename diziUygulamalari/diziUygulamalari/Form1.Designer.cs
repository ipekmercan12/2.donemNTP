namespace diziUygulamalari
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtDersNotu = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtEnYuksek = new System.Windows.Forms.TextBox();
            this.txtEnDusuk = new System.Windows.Forms.TextBox();
            this.btnEnYuksek = new System.Windows.Forms.Button();
            this.btnEnDusuk = new System.Windows.Forms.Button();
            this.btnOrtalama = new System.Windows.Forms.Button();
            this.txtOrtalama = new System.Windows.Forms.TextBox();
            this.lbListe = new System.Windows.Forms.ListBox();
            this.btnListe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(46, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad Soyad";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(46, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ders Notu";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdSoyad.Location = new System.Drawing.Point(159, 32);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(126, 29);
            this.txtAdSoyad.TabIndex = 3;
            // 
            // txtDersNotu
            // 
            this.txtDersNotu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDersNotu.Location = new System.Drawing.Point(159, 81);
            this.txtDersNotu.Name = "txtDersNotu";
            this.txtDersNotu.Size = new System.Drawing.Size(126, 29);
            this.txtDersNotu.TabIndex = 4;
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(122, 194);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(126, 41);
            this.btnEkle.TabIndex = 5;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtEnYuksek
            // 
            this.txtEnYuksek.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEnYuksek.Location = new System.Drawing.Point(289, 263);
            this.txtEnYuksek.Name = "txtEnYuksek";
            this.txtEnYuksek.Size = new System.Drawing.Size(126, 29);
            this.txtEnYuksek.TabIndex = 6;
            // 
            // txtEnDusuk
            // 
            this.txtEnDusuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEnDusuk.Location = new System.Drawing.Point(289, 318);
            this.txtEnDusuk.Name = "txtEnDusuk";
            this.txtEnDusuk.Size = new System.Drawing.Size(126, 29);
            this.txtEnDusuk.TabIndex = 7;
            // 
            // btnEnYuksek
            // 
            this.btnEnYuksek.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEnYuksek.Location = new System.Drawing.Point(122, 252);
            this.btnEnYuksek.Name = "btnEnYuksek";
            this.btnEnYuksek.Size = new System.Drawing.Size(126, 40);
            this.btnEnYuksek.TabIndex = 8;
            this.btnEnYuksek.Text = "En Yüksek";
            this.btnEnYuksek.UseVisualStyleBackColor = true;
            this.btnEnYuksek.Click += new System.EventHandler(this.btnEnYuksek_Click);
            // 
            // btnEnDusuk
            // 
            this.btnEnDusuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEnDusuk.Location = new System.Drawing.Point(122, 318);
            this.btnEnDusuk.Name = "btnEnDusuk";
            this.btnEnDusuk.Size = new System.Drawing.Size(126, 38);
            this.btnEnDusuk.TabIndex = 9;
            this.btnEnDusuk.Text = "En Düşük";
            this.btnEnDusuk.UseVisualStyleBackColor = true;
            this.btnEnDusuk.Click += new System.EventHandler(this.btnEnDusuk_Click);
            // 
            // btnOrtalama
            // 
            this.btnOrtalama.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOrtalama.Location = new System.Drawing.Point(122, 363);
            this.btnOrtalama.Name = "btnOrtalama";
            this.btnOrtalama.Size = new System.Drawing.Size(126, 42);
            this.btnOrtalama.TabIndex = 10;
            this.btnOrtalama.Text = "Ortalama";
            this.btnOrtalama.UseVisualStyleBackColor = true;
            this.btnOrtalama.Click += new System.EventHandler(this.btnOrtalama_Click);
            // 
            // txtOrtalama
            // 
            this.txtOrtalama.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOrtalama.Location = new System.Drawing.Point(289, 376);
            this.txtOrtalama.Name = "txtOrtalama";
            this.txtOrtalama.Size = new System.Drawing.Size(126, 29);
            this.txtOrtalama.TabIndex = 12;
            // 
            // lbListe
            // 
            this.lbListe.FormattingEnabled = true;
            this.lbListe.Location = new System.Drawing.Point(368, 32);
            this.lbListe.Name = "lbListe";
            this.lbListe.Size = new System.Drawing.Size(250, 199);
            this.lbListe.TabIndex = 13;
            this.lbListe.SelectedIndexChanged += new System.EventHandler(this.lbListe_SelectedIndexChanged);
            // 
            // btnListe
            // 
            this.btnListe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListe.Location = new System.Drawing.Point(703, 38);
            this.btnListe.Name = "btnListe";
            this.btnListe.Size = new System.Drawing.Size(75, 57);
            this.btnListe.TabIndex = 14;
            this.btnListe.Text = "Listele";
            this.btnListe.UseVisualStyleBackColor = true;
            this.btnListe.Click += new System.EventHandler(this.btnListe_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnListe);
            this.Controls.Add(this.lbListe);
            this.Controls.Add(this.txtOrtalama);
            this.Controls.Add(this.btnOrtalama);
            this.Controls.Add(this.btnEnDusuk);
            this.Controls.Add(this.btnEnYuksek);
            this.Controls.Add(this.txtEnDusuk);
            this.Controls.Add(this.txtEnYuksek);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtDersNotu);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Bir Boyutlu Diziler Uygulama ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.TextBox txtDersNotu;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtEnYuksek;
        private System.Windows.Forms.TextBox txtEnDusuk;
        private System.Windows.Forms.Button btnEnYuksek;
        private System.Windows.Forms.Button btnEnDusuk;
        private System.Windows.Forms.Button btnOrtalama;
        private System.Windows.Forms.TextBox txtOrtalama;
        private System.Windows.Forms.ListBox lbListe;
        private System.Windows.Forms.Button btnListe;
    }
}

