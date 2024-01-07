using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Double
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            string UrunAdi = textBox1.Text;
            double Fiyat = Convert.ToInt16(textBox2.Text);
            double Kdv = (Fiyat * 18) / 100;
            listBox1.Items.Add(UrunAdi+" "+"Fiyatı:"+ Fiyat+" "+" Kdv:"+Kdv+" "+"Vergili Fiyatı:"+(Fiyat+Kdv) );
        }
    }
}
