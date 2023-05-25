using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci

{
    internal class Program

    {
        static void Main(string[] args)
        {
            int n1 = 0, n2 = 1, soma = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("\n" + n2);
                soma = n1 + n2;
                n1 = n2;
                n2 = soma;
            }
            Console.ReadKey();
        }
    }
}
