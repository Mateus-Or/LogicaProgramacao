using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome, nome2;

            Console.WriteLine("Insira seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Insira seu nome: ");
            nome2 = Console.ReadLine();

            if (nome.Length > nome2.Length)
            {
                Console.WriteLine(nome);
            }

            else
            {
                Console.WriteLine(nome2);
            }
            Console.ReadKey();
        }
    }
}
