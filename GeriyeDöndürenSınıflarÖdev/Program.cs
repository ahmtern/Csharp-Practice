using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeriyeDöndürenSınıflarÖdev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            islemler isl = new islemler();
            isl.topla(5, 3);
            isl.cıkar(5, 3);
            isl.carpma(5, 3);
            isl.bolme(10, 5);
            Console.ReadLine();
        }
    }
}
