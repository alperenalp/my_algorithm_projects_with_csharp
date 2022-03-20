using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1._0._5_Sınav_Ortalama_Sonuc_Hesaplama_if_komutu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string isim;
            double vize, final , ortalama;
            vize = Convert.ToInt32(textBox2.Text);
            final = Convert.ToInt32(textBox3.Text);

            isim = textBox1.Text;

            ortalama = vize * 0.4 + final * 0.6;

            listBox1.Items.Add(isim);
            listBox2.Items.Add(vize);
            listBox3.Items.Add(final);
            listBox4.Items.Add(ortalama);
            

            if (ortalama>=60 & final>=50)
            {
                
                listBox5.Items.Add("GEÇTİ");
            }
            else
            {
                listBox5.Items.Add("KALDI");
            }

        }
    }
}
