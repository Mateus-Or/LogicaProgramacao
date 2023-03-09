using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string id;
            double salario, vendaT, percentoalGn, salarioTotal;

            Console.WriteLine("Nome:");
            id = Console.ReadLine();

            Console.WriteLine("Seu salario:");
            salario = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Total de vendas em R$:");
            vendaT = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Qual seu percentoal ganho:");
            percentoalGn = Convert.ToDouble(Console.ReadLine());

            percentoalGn = percentoalGn / 100;
            salarioTotal = (percentoalGn * vendaT) + salario;

            Console.WriteLine($"Nome: {id}" +
                $"\nSalario: R${salario}" +
                $"\nTotal vendido: R${vendaT}" +
                $"\nPercentoal ganho: {percentoalGn * 100}%" +
                $"\nSalario Total: R${salarioTotal}");
            Console.WriteLine();
            Console.ReadKey();

        }
    }
}
