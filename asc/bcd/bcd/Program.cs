using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Afisare_binar_pe_BCD
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Scrie numarul in baza 10");
            string line = Console.ReadLine();
            a = Convert.ToInt32(line);
            int[] v = new int[10];

            v[0] = 0000;
            v[1] = 0001;
            v[2] = 0010;
            v[3] = 0011;
            v[4] = 0100;
            v[5] = 0101;
            v[6] = 0110;
            v[7] = 0111;
            v[8] = 1000;
            v[9] = 1001;

            if (a < 0)
            {
                a = (9999 - (-a)) + 1;
            }
            int i = Invers(a);
            int c;
            Console.WriteLine("Numarul {0} in BCD este:", a);
            while (i != 0)
            {

                c = i % 10;
                Scrie(v[c]);
                i = i / 10;
            }
            Console.ReadKey();
        }
        private static int Invers(int a)
        {
            int s = 0;
            while (a != 0)
            {
                s = s * 10 + a % 10;
                a = a / 10;
            }
            return s;
        }
        private static void Scrie(int p)
        {
            if (p == 0 || p == 1) Console.Write("000{0} ", p);
            if (p == 10 || p == 11) Console.Write("00{0} ", p);
            if (p == 100 || p == 101 || p == 110 || p == 111) Console.Write("0{0} ", p);
        }
    }
}
