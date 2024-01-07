using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GeriyeDöndürenSınıflarÖdev
{
    internal class islemler
    {
        public int topla(int s1, int s2) 
        {
            int s3 = s1 + s2;
            Console.WriteLine(s3);
            return s3;
        }
        public int cıkar(int s1, int s2)
        {
            int s3 = s1 - s2;
            Console.WriteLine(s3);
            return s3;
        }
        public int carpma(int s1, int s2)
        {
            int s3 = s1 * s2;
            Console.WriteLine(s3);
            return s3;
        }
        public int bolme(int s1, int s2)
        {
            int s3 = s1 / s2;
            Console.WriteLine(s3);
            return s3;
        }
    }
}
