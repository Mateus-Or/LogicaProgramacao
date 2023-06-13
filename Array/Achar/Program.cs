using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Achar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[10];

            for (int i = 0; i < A.Length; i++)
            {
                Console.Write($"Informe o {i + 1}° valor: ");
                A[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Informe o valor que deseja achar na lista: ");
            int x = int.Parse(Console.ReadLine());

            if (A.Contains(x))
            {
                Console.WriteLine($"ACHEI");
            }
            else
            {
                Console.WriteLine("NÃO ACHEI!!");
            }
            Console.ReadKey();
        }
    }
}
