using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repNome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("digite seu nome:");
            string nome = Console.ReadLine();

            for (int i = 0; i < nome.Trim().Length; i++)
            {
                Console.WriteLine(nome);
            }
            Console.ReadKey();
        }
    }
}
