using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calisma_1._0._1_1.grup_4.final_sorusu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, c;
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                a = Convert.ToInt32(textBox1.Text);
                b = Convert.ToInt32(textBox2.Text);
                c = Convert.ToInt32(textBox3.Text);

                if ((a % 5 == 0 || a == 12 || a == 13) && (b == 5 || b == 12 || b == 13) && (c == 5 || c == 12 || c == 13))
                {
                    MessageBox.Show("ÜÇGEN 5-12-13 ÜÇGENİDİR");
                }

                else
                {
                    MessageBox.Show("ÜÇGEN 5-12-13 ÜÇGENİ DEĞİLDİR");
                }
            }
            else
            {
                MessageBox.Show("BOŞ BIRAKILMAZ");
            }
        }
    }
}
