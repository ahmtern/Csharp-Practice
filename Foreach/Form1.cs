using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foreach
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            int toplam = 0;
            int[] sayılar = { 15, 20, 22, 66, 89, 11, 35, 8, 5, 3 };
            foreach (int x in sayılar)
            {
                if (x % 4==0)
                {
                    listBox1.Items.Add(x);
                    toplam = toplam + x;
                }
                label1.Text = toplam.ToString();
            
            }
            label2.Text=listBox1.Items.Count.ToString();
        }
    }
}
