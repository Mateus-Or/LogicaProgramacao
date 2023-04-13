using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int mediaAluno, mediaTurma = 0;

            Console.WriteLine("Digite o numero de alunos da turma:");
            int qtdAlu = int.Parse(Console.ReadLine());


            int i = 1;
            int x = 1;
            while (i <= qtdAlu)
            {
                mediaAluno = 0;
                Console.WriteLine($"Informe as informações do {i}° Aluno");

                while (x <= 4)
                {
                    Console.Write($"Digite a nota do {x}° bimetre: ");
                    mediaAluno += int.Parse(Console.ReadLine());

                    if (x == 4)
                    {
                        Console.WriteLine($"A media do aluno é de {mediaAluno / x}\n");
                        mediaTurma += mediaAluno / x;
                    }
                    x++;
                }

                i++;
                x = 1;
            }
            Console.WriteLine($"Media turma é {mediaTurma / qtdAlu}");
            Console.ReadKey();
        }
    }
}
