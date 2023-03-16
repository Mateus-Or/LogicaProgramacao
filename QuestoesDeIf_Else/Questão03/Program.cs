using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int media = 0;

            Console.WriteLine("Insira seu nome");
            nome = Console.ReadLine();

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"Insira sua {i + 1}º nota:");
                media = media + Convert.ToInt32(Console.ReadLine());
            }

            media = media / 4;

            if (media >= 60)
            {
                Console.WriteLine($"O {nome} Teve a media de {media} e foi aprovado");
            }

            else
            {
                Console.WriteLine($"O {nome} Teve a media de {media} e foi reprovado");
            }
            Console.ReadKey();
        }
    }
}
