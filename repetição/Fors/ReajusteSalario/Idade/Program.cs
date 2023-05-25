using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a sua data de nascimento (dd/MM/yyyy): ");
            DateTime dataN = DateTime.Parse(Console.ReadLine());

            DateTime dataNow = DateTime.Now;
            TimeSpan idade = dataNow - dataN;
            int dif = idade.Year;
            Console.WriteLine(dif);
            Console.ReadKey();
        }
    }
}
