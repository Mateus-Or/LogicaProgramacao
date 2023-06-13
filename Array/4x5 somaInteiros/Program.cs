using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4x5_somaInteiros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] nuns = new int[4, 5];
            int[] soma = new int[5];

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write($"Digite a {i+1}° linha da {j+1}° coluna: ");
                    nuns[i,j] = int.Parse(Console.ReadLine());
                    soma[i] += nuns[i,j];
                }
            }

            for (int i = 0; i < soma.Length; i++)
            {
                Console.WriteLine($"A soma da {i+1}° coluna é de {soma[i]}");
            }
            Console.ReadLine();
        }
    }
}
