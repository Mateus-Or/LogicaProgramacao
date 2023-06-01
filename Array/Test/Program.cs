using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] x = new int[] { 1, 2, 3 };
            int[] y = new int[x.Length];
            x.CopyTo(y, 0);
            Array.Reverse(x);
            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine(x[i]);
            }
            Console.ReadKey();
        }
    }
}
