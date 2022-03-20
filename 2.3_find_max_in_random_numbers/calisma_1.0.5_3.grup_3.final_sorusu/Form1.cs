using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calisma_1._0._5_3.grup_3.final_sorusu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //500 ÜRÜN VAR FİYATIMIZ 100 HER SEFERİNDE ÜRÜNÜ 10 AZALTIP FİYATI 5 ARTTIRIRSAK MAX KAR IMIZ EN FAZLA KAÇ OLUR??
            int ürün = 500;
            int fiyat = 100;
            int max = 0;
            int öncekimax= 0;
            for (int i = 1; i < 51; i++)
            {
                ürün -= 10;
                fiyat += 5;
                max = fiyat * ürün;
                if (max>öncekimax)
                {
                    öncekimax = max;
                    label1.Text = "maksimum kar= " + max.ToString();
                }
                
                listBox1.Items.Add(i+". " + max);
            }
            
        }
    }
}
