using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Break
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t---Instrução Break---");

            int soma = 0;
            Random dado = new Random();

            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine($"{i}º Jogada feita");
                int num = dado.Next(1, 20);
                Console.WriteLine($"Número: {num}");
                soma+= num;
                Console.WriteLine("");
                if (soma >= 20)
                {
                    Console.WriteLine($"Você ganhou com {i} jogadas!");
                    break;
                }
            }

            if (soma < 20)
            {
                Console.WriteLine("vc perdeu!");
            }
            Console.ReadKey();
        }
    }
}
