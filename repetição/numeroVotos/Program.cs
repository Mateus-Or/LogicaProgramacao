using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numeroVotos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nvcand1 = 0,
                nvcand2 = 0,
                nvcand3 = 0,
                nvbrancos = 0,
                nvnulos = 0,
                neleitores = 0, 
                op;
            string resposta = "SIM";

            do
            {
                Console.Write("Data: " + DateTime.Now.ToString("dd-mm-aaaa"));

                Console.WriteLine("\t---Qual a melhor serie de todos os tempos?---");
                Console.WriteLine("[1]Todo Mundo odeia o Cris" +
                    "\n[2]Eu a Patroa e as crianças" +
                    "\n[3]Um maluco no pedaço" +
                    "\n[4]Num sei" +
                    "\n[5]Outro");
                Console.Write("Informe a opção:");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        nvcand1 ++;
                        break;
                    case 2:
                        nvcand2 ++;
                    break;
                    case 3:
                        nvcand3 ++;
                        break;
                    case 4:
                        nvbrancos++;
                        break;
                    case 5:
                        nvnulos++;
                        break;

                    default:
                        Console.WriteLine("Opção invalida");
                        break;

                }
                Console.WriteLine("Voto realizado com sucesso!");
                Console.Write("Deseja registrar outro voto? ");
                Console.Write("Digite [S] ou [SIM] para prosseguir: ");
                resposta = Console.ReadLine().ToUpper();

            } while (resposta == "SIM" || resposta == "S");


        }
    }
}
