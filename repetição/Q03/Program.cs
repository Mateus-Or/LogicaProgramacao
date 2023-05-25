using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double saldo = 1000, valorCorr;
            int op = 1;
            do
            {
                Console.WriteLine("O que você quer fazer?" +
                    "\n1. Depositar" +
                    "\n2. Sacar" +
                    "\n3. Exibir Saldo" +
                    "\n4. Sair\n");

                op = int.Parse(Console.ReadLine());

                while (op < 1 || op > 4)
                {
                    Console.Clear();
                    Console.WriteLine("Insira um valor valido...");

                    Console.WriteLine("O que você quer fazer?" +
                    "\n1. Depositar" +
                    "\n2. Sacar" +
                    "\n3. Exibir Saldo" +
                    "\n4. Sair\n");

                    op = int.Parse(Console.ReadLine());
                }

                switch (op)
                {
                    case 1:
                        Console.Clear();
                        Console.Write("Insira o valor do depósito: ");
                        valorCorr = Double.Parse(Console.ReadLine());

                        if (valorCorr <= 0)
                        {
                            Console.WriteLine("Valor invalido" +
                                $"\nDeposite um valor superior a {0:c2}");
                            break;
                        }

                        saldo += valorCorr;
                        Console.WriteLine($"Saldo atual: {saldo:c2}" +
                            $"\nValor depositado: {valorCorr:c2}");

                        break;
                    case 2:
                        Console.Clear();
                        Console.Write("Insira o valor a ser sacado: ");
                        valorCorr = Double.Parse(Console.ReadLine());
                        if (valorCorr <= 0 || valorCorr > saldo)
                        {
                            Console.WriteLine("Valor inválido" +
                                $"Consulte o seu saldo e não saque valores menor ou igual a {0:c2}");
                            break;
                        }
                        saldo -= valorCorr;
                        Console.WriteLine($"Saldo atual: {saldo:c2}" +
                            $"\nValor sacado: {valorCorr:c2}");
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine($"Valor Saldo: {saldo:c2}");
                        break;
                }
                
            }while (op != 4); 
        }
    }
}
