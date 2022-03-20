using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1._0._6_Formlar_Arasi_Gecis
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text=="MAVİ")
            {
                label4.Text = textBox1.Text+ "" + ", " + comboBox1.Text + " rengi=" + " Mutluluğun ve pozitifliğin rengidir";
                button2.BackColor = Color.Blue;
            }
            if (comboBox1.Text == "SARI")
            {
                label4.Text = textBox1.Text + ", " + comboBox1.Text + " rengi=" + " Mutluluğun ve pozitifliğin rengidir";
                button2.BackColor = Color.Yellow;
            }
            if (comboBox1.Text == "SİYAH")
            {
                label4.Text = textBox1.Text + ", " + comboBox1.Text + " rengi=" + " Mutluluğun ve pozitifliğin rengidir";
                button2.BackColor = Color.Black;
            }
            if (comboBox1.Text == "YEŞİL")
            {
                label4.Text = textBox1.Text + ", " + comboBox1.Text + " rengi=" + " Mutluluğun ve pozitifliğin rengidir";
                button2.BackColor = Color.Green;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
