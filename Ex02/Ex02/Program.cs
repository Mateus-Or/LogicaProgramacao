using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, num2;
            Console.WriteLine("Digite um numero:");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero:");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{num} * {num2} = " + (num * num2));
        }
    }
}
