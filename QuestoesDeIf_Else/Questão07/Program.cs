using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lado1, lado2, lado3;

            Console.WriteLine("insira o lado do triangulo: ");
            lado1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("insira o lado do triangulo: ");
            lado2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("insira o lado do triangulo: ");
            lado3 = Convert.ToInt32(Console.ReadLine());

            if ((lado1 + lado2) > lado3 && (lado2 + lado3) > lado1 && (lado3 + lado1) > lado2)
            {
                Console.WriteLine("Isso é um triangulo!!");

                if (lado1 == lado2 && lado1 == lado3)
                {
                    Console.WriteLine("Um triangulo equilatero");
                }

                else if (lado1 == lado2 && lado1 != lado3)
                {
                    Console.WriteLine("Um triangulo Isócele");
                }

                else
                {
                    Console.WriteLine("Um tiangulo Escaleno");
                }
            }
            else
            {
                Console.WriteLine("Isso NÃO é um triangulo");
            }
        }
    }
}
