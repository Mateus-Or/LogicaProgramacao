using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double vPres, qtdPres, presPgs, saldo, vPagar;

            Console.WriteLine("Quantidade das prestações:");
            qtdPres = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Valor das prestações:");
            vPres = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Quantidade de prestações pagas:");
            presPgs = Convert.ToDouble(Console.ReadLine());

            vPagar = (qtdPres - presPgs)* vPres;
            saldo = qtdPres * vPres - vPagar;
            Console.WriteLine($"O valor que ja foi pago é {saldo} e o que ainda resta a pagar é {vPagar}");
            Console.ReadKey();
        }
    }
}
