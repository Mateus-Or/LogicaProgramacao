using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexOf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t---Descobrindo indicie---");

            int[] a = new int[10];

            for (int i = 0; i < a.Length; i++)
            {
                Console.Write($"Informe o {i+1}° valor: ");
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Informe o valor que deseja achar na lista: ");
            int val = int.Parse(Console.ReadLine());

            int ind = Array.IndexOf(a, val);

            if (a.Contains(val))
            {
                Console.WriteLine($"O valor foi encontrado no indicie {ind}");
            }
            else
            {
                Console.WriteLine("O valor não foi encontrado!!");
            }
            Console.ReadKey();
        }
    }
}
