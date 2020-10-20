using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04BreakContinue
{
    class Program
    {
        static void Main(string[] args)
        {
            //break
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Iteracion " + i);
                if (i == 10)
                {
                    break;
                }
            }
            Console.WriteLine("Termino el primer for de ejemplo para el break");

            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                {
                    continue;
                }
                Console.WriteLine("Iteracion " + i);                
            }
            Console.WriteLine("Termino el primer for de ejemplo para el continue");
            Console.ReadKey();
        }
    }
}
