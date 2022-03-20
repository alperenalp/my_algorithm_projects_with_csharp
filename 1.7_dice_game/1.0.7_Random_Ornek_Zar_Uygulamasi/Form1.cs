using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1._0._7_Random_Ornek_Zar_Uygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            int zar1, zar2,toplam;
            zar1 = rnd.Next(1, 7);
            zar2 = rnd.Next(1, 7);
            label1.Text = zar1.ToString();
            label2.Text = zar2.ToString();
            toplam = zar1 + zar2;
            label4.Text = toplam.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
