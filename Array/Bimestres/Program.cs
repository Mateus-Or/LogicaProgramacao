using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bimestres
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] notas = new int[3 , 4];

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Informe as notas do {i+1}° aluno:");
                for (int j = 0; j < 4; j++)
                {
                    Console.Write($"Informe a nota do {j+1}° bimestre: ");
                    notas[i, j] = int.Parse(Console.ReadLine());
                }
            }

            double[] notaFinal = new double[3];

            for (int i = 0; i < 3; i++)
            {
                notaFinal[i] = (notas[i, 1] + notas[i, 2] + notas[i, 3] + notas[i, 4]) / 4;
                Console.WriteLine($"A media do {i+1}° aluno é: {notaFinal[i]}");
            }
            Console.ReadKey();
        }
    }
}
