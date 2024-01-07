using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Yapıcı_Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kişi Bilgilerini Giriniz!!!");
            Console.Write("Ad :");
            string ad = Console.ReadLine();
            Console.Write("Soyad :");
            string soyad = Console.ReadLine();
            Console.Write("Yaşı: ");
            int yası = Convert.ToInt32(Console.ReadLine());
            Console.Write("Mesleği: ");
            string meslek = Console.ReadLine();
            Console.WriteLine("\nKişi Bilgileri\n");
            Ogrenci ogr=new Ogrenci(ad, soyad,yası,meslek);
            Console.ReadLine();
        }
    }
}
