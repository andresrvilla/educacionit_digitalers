using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02ListadoPersonas
{
    class Program
    {
        static void Main(string[] args)
        {
            string listado = "";

            bool sigue;

            do
            {
                Console.Write("Ingrese un nombre: ");
                listado += Console.ReadLine() + Environment.NewLine; //Equivalente a listado = listado + Console.ReadLine();

                Console.Write("¿Desea continuar? (S/n)");
                string continua = Console.ReadLine();
                sigue = continua.ToUpper() == "S" ? true : false;
            } while (sigue == true);

            Console.WriteLine(listado);

            Console.ReadKey();
        }
    }
}
