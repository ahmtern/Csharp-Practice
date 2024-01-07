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

namespace ReturnMetot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int Toplam(int s1, int s2)
        {
            int s3 = s1 + s2;
            return s3;
        }
        int Carpim(int s1, int s2, int s3) 
        {
            int s4 = s1*s2*s3;
            return s4;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = Toplam(2, 8).ToString();
            label2.Text = Toplam(1, 3).ToString();
            label3.Text = Toplam(5, 4).ToString();
            label4.Text = Carpim(5,2,3).ToString();

        }
    }
}
