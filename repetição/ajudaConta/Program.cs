using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ajudaConta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t---Ajuda nas Compras---");

            Console.Write("Informe o valor disponivel: ");
            double saldo = double.Parse(Console.ReadLine());

            double compra = 0;
            double somaCompra = 0;
            int cont = 0;
            bool podeComprar = true;

            do
	        {
                Console.Write("Valor da compra: ");
                compra = double.Parse(Console.ReadLine());

                if (compra > 0)
	            {
                    if (compra <= saldo)
	                {
                        saldo = saldo - compra;
                        somaCompra += compra;
                        cont++;
                        Console.WriteLine($"\nCompra Registrada!" +
                            $"\n\nValor restante do saldo {saldo:c2}");

	                }
                    else
                    {
                        podeComprar = false;
                        Console.WriteLine("Valor do saldo insuficiente!");
                    }
	            }
                else
                {
                    Console.WriteLine("Saldo insuficiente!");
                    Console.ReadLine();
                }

	        } while (podeComprar);
            Console.Clear();
            Console.WriteLine("\t\t---Resultado das compras");
            Console.WriteLine($"Numero de compras {cont}" +
                $"\nTotal gasto {somaCompra:c2}" +
                $"\nSaldo restante {saldo:c2}");
            Console.ReadLine();
        }
    }
}
