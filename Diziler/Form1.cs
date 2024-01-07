using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diziler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] elemanlar = { 22, 30, 5, 2, 20, 40, 55, 9, 35, 60 };
            for (int i = 0; i < elemanlar.Length; i++)
            {
                if (elemanlar[i] >10)
                {
                    if (elemanlar[i] % 2 == 0)
                    {
                        listBox1.Items.Add(elemanlar[i]);
                    }
                }
            }
        }
    }
}
