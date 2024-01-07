using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Yapıcı_Metotlar
{
    internal class Ogrenci
    {
        public Ogrenci(string ad,string soyad,int yas,string meslek)
        {
            Console.WriteLine("Kişi: " + ad + " " + soyad);
            Console.WriteLine("Yaşı: " + yas + " " + "Mesleği: " + meslek);
        }
    }
}
