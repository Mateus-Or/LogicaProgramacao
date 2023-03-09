using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dias, semanas, meses, anos;

            Console.WriteLine("Informe a quantidade de dias:");
            dias = Convert.ToInt32(Console.ReadLine());

            semanas = dias / 7;
            meses = dias / 30;
            anos = dias / 365;
            Console.WriteLine($"Para {dias} dias são totalizadas {semanas} semanas, {meses} meses, {anos} anos.");
            Console.ReadKey();
        }
    }
}
