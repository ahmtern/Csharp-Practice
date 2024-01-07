using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PastaPişirmeSüreçUygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 10;
            if (progressBar1.Value==100)
            {
                timer1.Stop();
                timer2.Start();
                label1.Text=("Un ve Yumurta Karıştırıldı.") ;
                label1.BackColor= Color.Green;
                
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            progressBar2.Value += 5;
            if (progressBar2.Value==100)
            {
                timer2.Stop();
                timer3.Start();
                label4.Text = "Çırpma İşlemi Yapıldı.";
                label4.BackColor= Color.Green;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            progressBar3.Value += 10;
            if (progressBar3.Value==100)
            {
                timer3.Stop();
                timer4.Start();
                label3.Text = "Malzemeler Eklendi ve Karıştırılırdı.";
                label3.BackColor= Color.Green;
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            progressBar5.Value+= 2;
            if (progressBar5.Value==100)
            {
                timer4.Stop();
                label5.Text = "Pasta Pişirildi.";
                label5.BackColor= Color.Green;
                MessageBox.Show("Pastanız Hazır Afiyet Olsun :) "); 
            }
        }
    }
}
