using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, n2, n3;

            Console.WriteLine("Insira um numero: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insira um numero: ");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insira um numero: ");
            n3 = Convert.ToInt32(Console.ReadLine());

            if (n > n2 && n > n3)
            {
                Console.WriteLine(n);
            }
            else if (n2 > n && n2 > n3)
            {
                Console.WriteLine(n2);
            }
            else
            {
                Console.WriteLine(n3);
            }
            Console.ReadKey();
        }
    }
}
