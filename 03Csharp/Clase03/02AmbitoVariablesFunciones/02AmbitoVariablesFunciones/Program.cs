using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02AmbitoVariablesFunciones
{
    class Program
    {
        static void Main(string[] args)
        {
            int valorNumerico = 10;
            int otroValorNumerico = 300;
            Console.WriteLine("El valor de valorNumerico es " + valorNumerico);
            ModificarValor(valorNumerico);
            Console.WriteLine("El valor de valorNumerico es " + valorNumerico);
            ModificarValorPorReferencia(ref valorNumerico);
            ModificarValorPorReferencia(ref otroValorNumerico);
            Console.WriteLine("El valor de valorNumerico es " + valorNumerico);
            Console.ReadKey();
        }

        static void ModificarValor(int valor)
        {
            valor = 100;
            Console.WriteLine("El valor de valor es " + valor);
        }

        static void ModificarValorPorReferencia(ref int valor)
        {
            valor = 100;
            Console.WriteLine("El valor de valor es " + valor);
        }
    }
}
