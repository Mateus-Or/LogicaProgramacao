using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfnityTrigo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t---Trigos kkkk---\n");
            decimal totalT = 0;

            for (int i = 0; i < 64; i++)
            {
                totalT += totalT;
                if (i == 0)
                {
                    totalT++;
                }
                Console.WriteLine($"{totalT:n2}");
            }
            Console.ReadKey();
        }
    }
}
