using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salario, salarioFin;

            Console.WriteLine("insira seu salario atual");
            salario = Convert.ToDouble(Console.ReadLine());

            if (salario > 1500)
            {
                salarioFin = salario + salario * 0.18;
                Console.WriteLine($"Seu salario sera reajustado para {salarioFin:c2}");
            }

            else
            {
                salarioFin = salario + salario * 0.23;

                Console.WriteLine($"Seu salario sera reajustado para {salarioFin:c2}");
            }
            Console.ReadLine();
        }
    }
}
