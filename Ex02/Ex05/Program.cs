using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double km, gas, mediaL;

            Console.WriteLine("Quantos litros foram gastos?");
            gas = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Quantos quilometros foram percorridos?");
            km = Convert.ToDouble(Console.ReadLine());
            mediaL = gas / km;
            Console.WriteLine($"A media gasta por km é {mediaL} Litros");
            Console.ReadKey();
        }
    }
}
