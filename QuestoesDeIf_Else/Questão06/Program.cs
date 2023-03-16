using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double kg, altura;

            Console.WriteLine("Insira seu peso em Kg: ");
            kg = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Isira sua altura em metros: ");
            altura = Convert.ToDouble(Console.ReadLine());

            double imc = kg / (altura * altura);

            Console.WriteLine($"Seu imc é de {imc}");

            if (imc < 17)
            {
                Console.WriteLine($"O seu imc ({imc}) é muito abaixo do peso");
            }

            else if (imc < 18.5)
            {
               Console.WriteLine($"O seu imc ({imc}) é abaixo do peso");
            }

            else if (imc < 25)
            {
                Console.WriteLine($"O seu imc ({imc}) é peso padão");
            }

            else if (imc < 30)
            {
                Console.WriteLine($"O seu imc ({imc}) é acima do peso");
            }

            else if (imc < 35)
            {
                Console.WriteLine($"O seu imc ({imc}) é Obesidade grau I");
            }

            else if (imc < 40)
            {
                Console.WriteLine($"O seu imc ({imc}) é Obesidade grau II");
            }

            else 
            {
                Console.WriteLine($"O seu imc ({imc}) é Obesidade grau III");
            }
            

            Console.ReadKey();
        }
    }
}
