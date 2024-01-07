using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetotÖdev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int Toplam(int s1,int s2) 
        {
           
            int s3 = s1 + s2;
            return s3;
        }
        int Cikarma(int s1,int s2) 
        {
            int s3 = s1 - s2;
            return s3;
        }
        private void Temizle()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox1.Focus();
            label3.Text = "0";

        }
        private void button1_Click(object sender, EventArgs e)
        {
            int tb1 = Convert.ToInt16(textBox1.Text);
            int tb2 = Convert.ToInt16(textBox2.Text);
            label3.Text=Toplam(tb1, tb2).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int tb1 = Convert.ToInt16(textBox1.Text);
            int tb2 = Convert.ToInt16(textBox2.Text);
            label3.Text = Cikarma(tb1, tb2).ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Temizle();
        }
    }
}
