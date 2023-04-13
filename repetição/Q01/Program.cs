using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int op = 1;
            while (op == 1)
            {
                Console.WriteLine("\t\t---Calculadora com While---\n");
                Console.Write("Informe o numero: ");
                int num = int.Parse(Console.ReadLine());

                int cont = 0;
                while (cont <= 10)
                {
                    Console.WriteLine($"{num} x {cont} = {num * cont}");
                    cont++;
                }
                Console.WriteLine("deseja realizar outra operação?\n|1|Sim\n|2|Não");
                Console.WriteLine("escolha uma opção:");
                op = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            }
        }
    }
}
