using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace FickoviZadaci
{
    class Program
    {
        static void Main(string[] args)
        {

            // zadatak 2

            Console.WriteLine("Unesite zeljeni broj za stepenovanje, veci od nule: ");
            int x, y, z;

            while ((x = Convert.ToInt32(Console.ReadLine())) <= 0)
            {
                Console.WriteLine("Uneli ste broj manji od nule ili jednak nuli, unesite novi broj za stepenovanje: ");
            }
            Console.WriteLine("Unesite zeljeni stepen, takodje veci od nule: ");

            while ((y = Convert.ToInt32(Console.ReadLine())) <= 0)
            {
                Console.WriteLine("Uneli ste broj manji od nule ili jednak nuli, unesite novi stepen: ");
            }

            z = Convert.ToInt16(Pow(x, y));

            Console.WriteLine("\nStepenih unetih brojeva je: {0}\n", z);
            Console.ReadLine();


            // zadatak 3

            int[] A = new int[10];


            for (int i = 0; i < 10; i++)
            {
                A[i] = i * i;
            }

            foreach (int j in A)
            {
                int i = j * j;
                Console.WriteLine("Kvadrat broja {0} je broj: {1}", j, i);
            }
            Console.ReadLine();
        }
    }
}
