using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calisma_1._0._2_2.grup_3.final_sorusu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int sayilar;
            Random rnd = new Random();
            int toplam = 0;
            int fazlalik = 0;
            int i = 0;
            int cift = 0;
            int tek = 0;
            while (toplam<2020)
            {
                i += 1;
                sayilar = rnd.Next(1, 10);
                toplam = toplam + sayilar;
                listBox1.Items.Add(i+". "+sayilar);                                               
                
                if (toplam>2020)
                {
                    fazlalik = toplam - 2020;
                    toplam = toplam - fazlalik;
                }

                if (sayilar % 2 == 0)
                {
                    cift += 1;
                }

                if (sayilar % 2 == 1)
                {
                    tek += 1;
                }
            }
            label2.Text = "cift sayilar= " + cift.ToString();
            label1.Text = "toplam= " + toplam.ToString();
            label3.Text = "tek sayilar= " + tek.ToString();
        }
    }
}
