using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pesoIde;

            Console.WriteLine("Insira o seu sexo de acordo com a tabela abaixo: " +
                "\n Feminino: \t1" +
                "\n Masculino: \t2");
            int sexo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insira sua altura:");
            double altura = Convert.ToDouble(Console.ReadLine());

            if (sexo == 1)
            {
                pesoIde = (72.7 * altura) - 58;
                Console.WriteLine($"seu peso ideal é de {pesoIde}");
            }   

            else if (sexo == 2)
            {
                pesoIde = (62.1 * altura) - 44.7;
                Console.WriteLine($"seu peso ideal é de {pesoIde}");
            }

            else
            {
                Console.WriteLine("Você digitou errado!!");
            }
            Console.ReadKey();
        }
    }
}
