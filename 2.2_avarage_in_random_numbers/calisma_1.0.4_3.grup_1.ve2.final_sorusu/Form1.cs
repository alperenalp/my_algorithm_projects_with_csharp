using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calisma_1._0._4_3.grup_1.ve2.final_sorusu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        int[] sayilar = new int[10];
        Random rnd = new Random();
        int ortalama = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            listBox1.Items.Clear();
            for (int i = 0; i < sayilar.Length; i++)
            {
                sayilar[i] = rnd.Next(0, 100);
                toplam += sayilar[i];
                listBox1.Items.Add(sayilar[i]);
            }
            ortalama = toplam / 10;
            this.Text = ortalama.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sonuc = 999;
            int enyakin = 0;
            for (int i = 0; i < 10; i++)
            {
                enyakin = Math.Abs(sayilar[i]-ortalama);

                if (enyakin<=sonuc)
                {
                    sonuc=enyakin;
                    label1.Text = sayilar[i].ToString();
                }                
            }       
        }
    }
}
