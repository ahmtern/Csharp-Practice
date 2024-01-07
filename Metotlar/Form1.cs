using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metotlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string ad="Ahmet", soyad="Eren", sehir="Bursa";
        int yas=25;
        
        private void bilgiler()
        {
            textBox1.Text= ad;
            textBox2.Text= soyad;
            textBox3.Text= sehir;
            textBox4.Text= Convert.ToString(yas);
            textBox1.Focus();
       
        }
        private void renklendir()
        {
            textBox1.BackColor= Color.Green;
            textBox2.BackColor= Color.Blue;
            textBox3.BackColor= Color.Red;
            textBox4.BackColor= Color.Turquoise;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            bilgiler();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            renklendir();
        }
    }
}
