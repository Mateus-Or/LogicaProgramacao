using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int media = 0;
            char conceito = ' ';
            string situacao;

            Console.Write("Favor digite tu nombre: ");
            string nome = Console.ReadLine();

            Console.Write("Digite a nota do 1° Bimentre: ");
            int nota1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a nota do 2° Bimentre: ");
            int nota2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a nota do 3° Bimentre: ");
            int nota3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a nota do 4° Bimentre: ");
            int nota4 = Convert.ToInt32(Console.ReadLine());

            media = (int)(nota1 + nota2 + nota3 + nota4)/4;

            if (media >= 90)
            {
                conceito = 'A';
            }
            else if (media >= 80)
            {
                conceito = 'B';
            }
            else if (media >= 60)
            {
                conceito = 'C';
            }
            else if (media >= 40)
            {
                conceito = 'D';
            }
            else if (media >= 20)
            {
                conceito = 'E';
            }


            switch (conceito)
            {
                case 'A':
                    situacao = "Aprovado";
                    break;
                case 'B':
                    situacao = "Aprovado";
                    break;
                case 'C':
                    situacao = "Aprovado";
                    break;
                case 'D':
                    situacao = "Recuperação";
                    break;
                case 'E':
                    situacao = "Exame";
                    break;
                default:
                    situacao = "Reprovado";
                    break;
            }

            Console.WriteLine($"\t\t---Informações---\n" +
                $"Nome: {nome}\n" +
                $"Conseito: {conceito}\n" +
                $"Situação: {situacao}\n");

            Console.ReadKey();
        }
    }
}
