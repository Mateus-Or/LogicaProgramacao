using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int  idade, soma = 0;

            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Digite a {i}° idade:");
                idade = Convert.ToInt32(Console.ReadLine());
                soma += idade;
            }
            Console.WriteLine("A media dos alunos é"+soma/5);
            Console.ReadKey();
        }
    }
}
