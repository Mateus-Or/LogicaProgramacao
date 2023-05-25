using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indicie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] x = new int[10];
            
            for (int i = 0; i < x.Length; i++)
            {
                Console.Write($"Informe o {i+1}° valor: ");
                x[i] = int.Parse(Console.ReadLine());
            }

                bool res = true;
            do
            {
                Console.Clear();
                Console.Write("Informe o valor do indice(0-9): ");
                int p = int.Parse(Console.ReadLine());
                if (p < 0 || p > 9)
                {
                    Console.WriteLine("Informe o valor correto!!");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine(x[p]);
                    res = false;
                }
            } while (res);

            Console.ReadKey();
        }
    }
}
