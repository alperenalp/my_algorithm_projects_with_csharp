using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1._0._4_Alan_Hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            int kenar1, kenar2, alan, cevre;

            kenar1 = Convert.ToInt32(textBox1.Text);
            kenar2 = Convert.ToInt32(textBox2.Text);

            cevre = kenar1*2 + kenar2*2;
            alan = kenar1 * kenar2;

            label5.Text = cevre.ToString();
            label6.Text = Convert.ToString(alan);

            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
