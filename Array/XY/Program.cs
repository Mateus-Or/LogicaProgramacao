using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XY
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] x = new int[10];

            for (int i = 0; i < x.Length; i++)
            {
                Console.Write($"Digite o {i+1}° numero: ");
                x[i] = int.Parse(Console.ReadLine());
            }
            int[] y = (int[]) x.Clone();
            Array.Reverse(y);

            for (int i = 0; i < y.Length; i++)
            {
                Console.Write(y[i] + "   ");
            }
            Console.ReadKey();
        }
    }
}
