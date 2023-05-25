using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReajusteSalario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            double salario, reajuste, novoSalario;
            for (int i = 0; i < 10; i++)
            {
                Console.Clear();
                Console.WriteLine("---Calcular o reajuste de salario---");

                Console.Write("informe seu salario: ");
                salario = double.Parse(Console.ReadLine());

                if (salario < 1000)
                {
                    reajuste = salario * 0.55;
                    novoSalario = salario + reajuste;
                    Console.WriteLine($"salario atual => {salario.ToString("c2")}");
                    Console.WriteLine($"Reajuste => {reajuste.ToString("c2")}");
                    Console.WriteLine($"Novo salario => {novoSalario.ToString("c2")}");
                }
                else if (salario < 2500)
                {
                    reajuste = salario * 0.30;
                    novoSalario = salario + reajuste;
                    Console.WriteLine($"salario atual => {salario.ToString("c2")}");
                    Console.WriteLine($"Reajuste => {reajuste.ToString("c2")}");
                    Console.WriteLine($"Novo salario => {novoSalario.ToString("c2")}");
                }
                else
                {
                    reajuste = salario * 0.20;
                    novoSalario = salario + reajuste;
                    Console.WriteLine($"salario atual => {salario.ToString("c2")}");
                    Console.WriteLine($"Reajuste => {reajuste.ToString("c2")}");
                    Console.WriteLine($"Novo salario => {novoSalario.ToString("c2")}");
                }
                Console.ReadKey();
            }
        }
    }
}
