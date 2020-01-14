using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace convertorbiti
{
    class Program
    {


        private static void Conversie(float nr)
        {
            Console.WriteLine("In 32 de biti:" + nr);

            Stack st = new Stack();
            byte[] rez = BitConverter.GetBytes(nr);
            for (int i = 0; i < rez.Length; i++)
            {
                string s = Convert.ToString(rez[i], 2).PadLeft(8, '0');
                st.Push(s);
            }

            Console.Write("Rezultat: ");
            foreach (string obj in st)
            {
                Console.Write(obj + " ");
            }

            Console.WriteLine();
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Console.Write("Introduceti numar: ");
            float nr = float.Parse(Console.ReadLine());
            Conversie(nr);
        }
    }
}
