using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nuns = new int[101];

            for (int i = 0; i < nuns.Length; i++)
            {
                nuns[i] = i;
                Console.WriteLine(nuns[i]);
            }
            Console.ReadKey();
        }
    }
}
