using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calisma_1._0._0_1.grup_1.ve_2.final_sorusu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        Random rnd = new Random();
        int[] sayilar = new int[10];
        int toplam = 0;
        int ortalama = 0;
        
        private void button1_Click(object sender, EventArgs e)
        {
            this.Text = "";
            toplam = 0;
            listBox1.Items.Clear();
            for (int i = 0; i < 10; i++)
            {
                sayilar[i] = rnd.Next(0, 100);
                listBox1.Items.Add(sayilar[i]);
                toplam = toplam + sayilar[i];
            }
            ortalama = toplam / 10;
            this.Text = ortalama.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //SAYILARI ORTALAMADAN ÇIKARIP TERSTEN YAZDIRMA
            listBox2.Items.Clear();
            int ortfark = 0;
            for (int i = 9; i >= 0; i--)
            {
                ortfark = sayilar[i] - ortalama;
                listBox2.Items.Add(ortfark);
            }
        }
    }
}
