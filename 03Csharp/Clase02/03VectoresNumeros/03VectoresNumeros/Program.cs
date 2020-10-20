
using System;

namespace _03VectoresNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de numeros que quiere procesar: ");
            int cantidadNumeros = Convert.ToInt32(Console.ReadLine());
            /*
             Equivalente a
             string cantidadNumerosString = Console.ReadLine();
             int cantidadNumeros = Convert.ToInt32(cantidadNumerosString);
             */

            int[] numeros = new int[cantidadNumeros];

            for (int k = 0; k < cantidadNumeros; k++)
            {
                Console.Write("Ingrese un numero: ");
                int nuevoNumero = Convert.ToInt32(Console.ReadLine());
                numeros[k] = nuevoNumero;
            }

            // agrego un elemento
            int[] nuevoArray = new int[numeros.Length + 1];
            for (int i = 0; i < numeros.Length; i++)
            {
                nuevoArray[i] = numeros[i];
            }
            nuevoArray[numeros.Length] = 99999;
            numeros = nuevoArray;
            // fin de agregar un elemento

            Console.WriteLine("Datos ingresados:");
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write(numeros[i] + " ");
            }

            //Busco el maximo
            int valorMaximo = numeros[0];

            for (int i = 1; i < numeros.Length; i++)
            {
                if(numeros[i] > valorMaximo)
                {
                    valorMaximo = numeros[i];
                }
            }
            Console.WriteLine(Environment.NewLine + "Maximo " + valorMaximo);

            Console.ReadKey();
        }
    }
}
