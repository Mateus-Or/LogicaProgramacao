using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t---Calcula Aumento Salarial---");
            Console.WriteLine("\nCargos: \n\t[1] Gerente \n\t[2] Engenheiro \n\t[3] Técnico");
            Console.Write("Informe o seu cargo:");
            int cargo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Informe seu salario: ");
            double salario = Convert.ToDouble(Console.ReadLine());

            double novoSalar = 0;
            switch (cargo)
            {
                case 1:
                    novoSalar = salario * 1.1;
                    break;
                case 2:
                    novoSalar = (salario * 1.2);
                    break;
                case 3:
                    novoSalar = salario * 1.3;
                    break;
                default:
                    novoSalar = salario * 1.4;
                    break;
            }

            Console.WriteLine($"O salario era de {salario:c2}, mas passara a ser {novoSalar:c2}" +
                $"\nA diferença é de {novoSalar-salario:c2}");
            Console.ReadKey();
        }
    }
}
