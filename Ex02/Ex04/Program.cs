using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int altura, largura, comprimento, vol;
            Console.Write("Informe a altura:");
            altura = Convert.ToInt32(Console.ReadLine());
            Console.Write("Informe a largura:");
            largura = Convert.ToInt32(Console.ReadLine());
            Console.Write("Informe o comprimento:");
            comprimento = Convert.ToInt32(Console.ReadLine());

            vol = altura * largura * comprimento;

            Console.Write($"O volume desse objeto é {vol}m²");
            Console.ReadKey();
        }
    }
}
