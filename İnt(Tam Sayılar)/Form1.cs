using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İnt_Tam_Sayılar_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //DİKDÖRTGEN ALAN VE ÇEVRE HESAPLAMA

            int kisakenar, uzunkenar, cevre, alan;
            kisakenar = 10;
            uzunkenar = 20;
            cevre = 2 * (kisakenar + uzunkenar);
            alan = kisakenar * uzunkenar;
            label1.Text = "Alan: " + alan + " Çevre: " + cevre;




        }
    }
}
