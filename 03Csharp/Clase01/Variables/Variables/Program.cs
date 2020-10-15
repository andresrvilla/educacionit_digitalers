using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            const string saludo = "HOLA {0} {1}";
            int miNumero = 10;
            string nombre;
            Console.Write("Ingrese su nombre:");
            nombre = Console.ReadLine();
            Console.Write("Ingrese su apellido:");
            string apellido = Console.ReadLine();
            Console.WriteLine(saludo, nombre, apellido);
            // Tambien puede ser Console.WriteLine("Hola "+nombre);
            Console.ReadKey();
        }
    }
}
