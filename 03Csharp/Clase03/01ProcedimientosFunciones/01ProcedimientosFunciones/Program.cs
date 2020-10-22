using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01ProcedimientosFunciones
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroUno = CapturarDato();
            int numeroDos = CapturarDato();
            int resultadoSuma = Sumar(numeroUno, numeroDos);
            InformarResultado(resultadoSuma);
            Console.ReadKey();
        }

        static int CapturarDato()
        {
            Console.Write("Por favor ingrese un numero para sumar: ");
            string datoIngresado = Console.ReadLine();
            int datoConvertido = Convert.ToInt32(datoIngresado);
            return datoConvertido;
        }

        static int Sumar(int numeroUno,int numeroDos)
        {
            int resultado = numeroUno + numeroDos;
            return resultado;
        }

        static void InformarResultado(int resultado)
        {
            Console.WriteLine("El resultado de la suma es " + resultado);
        }
    }
}
