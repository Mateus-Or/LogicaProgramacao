using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImporstoRenda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Digite seu nome: ");
                string nome = Console.ReadLine();

                Console.Write("\nDigite seu salario: ");
                double salario = double.Parse(Console.ReadLine());

                if (salario < 1000)
                {
                    Console.WriteLine("\nInsento\n");
                }

                else if (salario < 1500)
                {
                    Console.WriteLine($"\nO imposto a ser pago sera de 7,5%, que equivale a: {salario*0.075:c2}\n");
                }
                else
                {
                    Console.WriteLine($"\nO imposto a ser pago sera de 15%, que equivale a: {salario * 0.15:c2}\n");
                }
                Console.WriteLine("----------------------------------------------------------------------------------------------------6466");
            }
            Console.ReadKey();
        }
    }
}
