using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FaktoriyelHesaplamaUygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int faktoriyel = Convert.ToUInt16(textBox1.Text);
            int sonuc = 1;
            for (int i = 1; i <= faktoriyel; i++)
            {
                sonuc = sonuc * i;
            }
            label2.Text = sonuc.ToString();
        }
    }
}
