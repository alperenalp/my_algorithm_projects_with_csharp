using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calisma_1._0._1_2.grup_1.ve_2.final_sorulari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        Random rnd = new Random();
        int[] sayilar = new int[100];
        int tekrar = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                sayilar[i] = rnd.Next(0, 100);
                listBox1.Items.Add(sayilar[i]);
            }
            label1.Text = "100 adet rastgele sayı üretildi";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            int sayi;
            int sayac = 0;
            if (textBox1.Text != "")
            {
                sayi = Convert.ToInt32(textBox1.Text);
                for (int i = 0; i < 100; i++)
                {

                    if (sayi == sayilar[i])
                    {

                        listBox2.Items.Add(sayi);
                        sayac = sayac + 1;
                    }

                }
                label2.Text = "Sayınızın Adedi= " + sayac;
                if (sayac == 0)
                {
                    MessageBox.Show("ARANAN SAYI LİSTEDE YOKTUR.");
                }

                /*if (listBox2.Items.Count==0)
                {
                    MessageBox.Show("ARANAN SAYI LİSTEDE YOKTUR.");
                }
                */
            }

            if (textBox1.Text == "")
            {
                MessageBox.Show("BOŞ BIRAKILMAZ.......");

            }
        }
    }
}