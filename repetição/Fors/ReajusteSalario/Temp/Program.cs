using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t---Converte Temperatura---");

            Console.Write("Informe a maior temperatura em Fahrebheit: ");
            int f1 = int.Parse(Console.ReadLine());

            Console.Write("Informe a menor temperatura em Fahrebheit: ");
            int f2 = int.Parse(Console.ReadLine());

            Console.Write("Informe Informe o valor da escala: ");
            int dec = int.Parse(Console.ReadLine());

            for (; f1 > f2; f1 -= dec)
            {
                int c = 5 * (f1 - 32) / 9;
                Console.WriteLine(c);
            }
            Console.ReadKey();
        }
    }
}
