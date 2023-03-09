using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n, n2;

            Console.WriteLine("Informe o primeiro valor:");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe o segundo valor:");
            n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{n} + {n2} = " + (n + n2));
            Console.WriteLine($"{n} - {n2} = " + (n - n2));
            Console.WriteLine($"{n} / {n2} = " + (n / n2));
            Console.WriteLine($"{n} * {n2} = " + (n * n2));

            Console.ReadKey();
        }
    }
}
