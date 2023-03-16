using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parOuImpar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t----Verificar se o numero é par ou impar----");
            Console.Write("Informe o numero: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num%2 == 0) 
            {
                Console.WriteLine($"Esse numero {num} é par ");           
            
            }
            else
            {
                Console.WriteLine($"Esse numero {num} é impar ");

            }

            
            Console.ReadKey();
        }
    }
}
