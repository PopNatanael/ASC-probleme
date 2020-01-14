using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bazele
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            Console.Write("Introduceti numarul in baza 10:");
            int b = Convert.ToInt32(Console.ReadLine());
            int n = b;
            Console.Write("Numarul in baza 16 este: ");
            int[] v = new int[64];
            char[] a = { 'A', 'B', 'C', 'D', 'E', 'F' };
           
            if (n == 0)
            {
                v[0] = 0;
                i++;
            }
            while (n > 0)
            {
                v[i] = n % 16;
                n /= 16;
                i++;
            }
            for (int j = i - 1; j >= 0; j--)
            {
                if (v[j] < 10)
                    Console.Write(v[j]);
                else
                    Console.Write(a[v[j] - 10]);

            }
            Console.WriteLine();
           
            int x = b;
            i = 0;
            Console.WriteLine();
            Console.Write("Numarul in baza 2 este: ");
            if (x == 0)
            {
                v[0] = 0;
                i++;
            }
            while (x > 0)
            {
                v[i] = x % 2;
                x /= 2;
                i++;
            }
            for (int j = i - 1; j >= 0; j--)
            {
                Console.Write("{0}", v[j]);
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
