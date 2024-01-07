using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KitapçiProjesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kitapadet;
            double tutar;
            kitapadet = Convert.ToInt16(textBox1.Text);
            if (kitapadet >= 0 && kitapadet<= 20)
            {
                tutar = (kitapadet * 8) - (kitapadet * 8 * 0.20);
                label3.Text= tutar+" TL";
                label5.Text = "%20";
            }
            if (kitapadet>=21 && kitapadet<=40)
            {
                tutar = (kitapadet * 8) - (kitapadet * 8 * 0.40);
                label3.Text = tutar + " TL";
                label5.Text = "%40";
            }
            if (kitapadet>=41)
            {
                tutar = (kitapadet * 8) - (kitapadet * 8 * 0.60);
                label3.Text = tutar + " TL";
                label5.Text = "%60";
            }
            
        }
    }
}
