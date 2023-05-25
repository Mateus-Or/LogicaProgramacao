
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---Imprimir Nomes---");
            string[] nomes = new string[5];

            for (int i = 0; i < nomes.Length; i++)
            {
                Console.Write($"Informe o {i+1}° nome: ");
                nomes[i] = Console.ReadLine();

            }
            for (int i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine($"{i+1}° {nomes[i]} ");
            }
            Console.ReadKey();
        }
    }
}
