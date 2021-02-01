using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace PrimeiroEx
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, z;
            double R1, R2, Delta;
            string[] N;

            N = Console.ReadLine().Split(' ');
            x = Convert.ToDouble(N[0]);
            y = Convert.ToDouble(N[1]);
            z = Convert.ToDouble(N[2]);

            Delta = ((y * y) - (4 * x * z));

            if ((Delta < 0) || (x == 0))
            {
                Console.WriteLine("Impossivel Calcular");
            }
            else
            {
                R1 = ((-y + Math.Sqrt(Delta)) / (2 * x));
                R2 = ((-y - Math.Sqrt(Delta)) / (2 * x));

                Console.WriteLine("R1 = " + R1.ToString("F5"));
                Console.WriteLine("R2 = " + R2.ToString("F5"));

            }
        }
    }
}
