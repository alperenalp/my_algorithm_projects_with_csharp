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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //şifreyi textbox nin özelliklerinden passwordchar true yaparak etkinleştirdik.
            // int id, sifre; yapıp if yerindeki textbox1 le değiştirirsek ne olur?
            

            
            if (textBox1.Text=="admin" && textBox2.Text=="1234")
            {
                
                Form2 yeni = new Form2();
                yeni.Show();
                this.Hide(); // this.Hide(); ile eski formu gizleriz.
                

            }
            else
            {
                MessageBox.Show("HATALI GİRİŞ YAPTINIZ");
            }
        }

        private void button2_Click(object sender, EventArgs e)  // diger forma hızlı giriş butonu şifresiz korsan giriş.
        {
            Form2 hile = new Form2(); 
            hile.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
