using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dtAtual = DateTime.Now.ToShortDateString();
            string hrAtual = DateTime.Now.ToShortTimeString();
            Console.WriteLine($"Hoje é dia {dtAtual}" +
                $"\nHoras: {hrAtual}");
            Console.ReadKey();
        }

    }
}
