using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inserção
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nuns = new int[5];

            for (int i = 0; i < nuns.Length; i++)
            {
                Console.Write($"Digite o {i+1}° valor(de 10 a 50): ");
                nuns[i] = int.Parse(Console.ReadLine());
                
                if (nuns[i] > 50 || nuns[i] < 10)
                {
                    Console.WriteLine("tente novamente!!");
               
                    i--;
                    continue;
                }
            }
            for (int i = 0; i < nuns.Length; i++)
            {
                Console.WriteLine(nuns[i]);
            }
            Console.ReadKey();
        }
    }
}
