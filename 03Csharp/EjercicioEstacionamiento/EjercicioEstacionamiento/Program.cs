using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;

namespace EjercicioEstacionamiento
{
    class Program
    {
        static void Main(string[] args)
        {
            const int CANTIDADCOCHERAS = 10;

            string[] cocheras = new string[CANTIDADCOCHERAS];

            decimal saldoTotal = 0m;

            string opcionIngresada = "";

            while (opcionIngresada != "S")
            {
                opcionIngresada = GenerarMenuPrincipal();
                ProcesarOpcionMenu(opcionIngresada, cocheras, ref saldoTotal);
            }

            Console.WriteLine("Gracias por utilizar el sistema");
            Console.ReadKey();
        }

        static void ProcesarOpcionMenu(string opcionIngresada, string[] lasCocheras, ref decimal saldoTotal)
        {
            switch (opcionIngresada)
            {
                case "S": //Si eligio salir, no hago nada porque lo va a hacer el main
                    break;
                case "1":
                    IngresarVehiculo(lasCocheras);
                    break;
                case "2":
                    EgresarVehiculos(lasCocheras, ref saldoTotal);
                    break;
                case "3":
                    Console.Clear();
                    Console.WriteLine("***********************");
                    Console.WriteLine("***   SALDO TOTAL   ***");
                    Console.WriteLine("***********************");
                    Console.WriteLine("El saldo actual de la cochera es $" + saldoTotal + ". Puse una tecla para continuar");
                    Console.ReadKey();
                    break;
                case "4":
                    ListarVehiculos(lasCocheras);
                    break;
                default:
                    Console.WriteLine("La opción Seleccionada no es correcta. Puse una tecla para volver a intentar");
                    Console.ReadKey();
                    break;
            }
        }

        private static void ListarVehiculos(string[] lasCocheras)
        {
            Console.Clear();
            Console.WriteLine("***********************");
            Console.WriteLine("*** LISTAR VEHICULOS***");
            Console.WriteLine("***********************");
            bool hayVehiculos = false;
            for (int i = 0; i < lasCocheras.Length; i++)
            {
                if (lasCocheras[i] != null)
                {
                    hayVehiculos = true;
                    Console.WriteLine("Posicion " + i + " vehiculo patente " + lasCocheras[i]);
                }
            }
            if (hayVehiculos == false)
            {
                Console.Write("La cochera se encuentra vacia. ");
            }
            Console.WriteLine("Puse una tecla para continuar");
            Console.ReadKey();

        }

        private static void EgresarVehiculos(string[] lasCocheras, ref decimal saldoTotal)
        {
            const decimal COSTOPORVEHICULO = 100;
            int posicion = 0;
            Console.Clear();
            Console.WriteLine("***********************");
            Console.WriteLine("***EGRESAR  VEHICULO***");
            Console.WriteLine("***********************");


            Console.Write("Ingrese la patente del vehiculo:");
            string patente = Console.ReadLine();
            patente = patente.Trim();
            patente = patente.ToUpper();
            bool encontrado = false;

            //TODO: Mejora, se podría cambiar el for por otro bucle mejor en este caso
            for (posicion = 0; posicion < lasCocheras.Length; posicion++)
            {
                if (lasCocheras[posicion] == patente)
                {
                    lasCocheras[posicion] = null;
                    saldoTotal += COSTOPORVEHICULO;
                    encontrado = true;
                    break;
                }
            }

            if (encontrado)
            {
                Console.WriteLine("El saldo actual de la cochera es $" + saldoTotal + ". Puse una tecla para continuar");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("El vehiculo no se encuentra en el estacionamiento. Puse una tecla para continuar");
                Console.ReadKey();
            }
        }

        private static void IngresarVehiculo(string[] lasCocheras)
        {
            Console.Clear();
            Console.WriteLine("***********************");
            Console.WriteLine("***INGRESAR VEHICULO***");
            Console.WriteLine("***********************");
            if (HayLugar(lasCocheras))
            {
                Console.Write("Ingrese la patente del vehiculo:");
                string patente = Console.ReadLine();
                patente = patente.Trim();
                patente = patente.ToUpper();
                int posicion = Agregar(lasCocheras, patente);
                Console.WriteLine("El vehiculo se agrego en la posicion " + posicion + ". Pulse una tecla para continuar.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("El estacionamiento se encuentra completo. Pulse una tecla para continuar.");
                Console.ReadKey();
            }
            Console.Write("Ingrese la pantente:");
        }

        static bool HayLugar(string[] lasCocheras)
        {
            bool hayLugar = false;

            for (int i = 0; i < lasCocheras.Length; i++)
            {
                if (lasCocheras[i] == null)
                {
                    hayLugar = true;
                }
            }

            return hayLugar;
        }

        static int Agregar(string[] lasCocheras, string patente)
        {
            int posicion = 0;

            //TODO: Mejora, se podría cambiar el for por otro bucle mejor en este caso
            for (posicion = 0; posicion < lasCocheras.Length; posicion++)
            {
                if (lasCocheras[posicion] == null)
                {
                    lasCocheras[posicion] = patente;
                    break;
                }
            }

            return posicion;
        }

        static string GenerarMenuPrincipal()
        {
            string opcionIngresada;
            Console.Clear();
            Console.WriteLine("***********************");
            Console.WriteLine("*** ESTACIONAMIENTO ***");
            Console.WriteLine("***********************");
            Console.WriteLine("Ingrese la opción deseada:");
            Console.WriteLine("s - Salir de la aplicación");
            Console.WriteLine("1 - Ingresar un vehiculo");
            Console.WriteLine("2 - Egresar un vehiculo");
            Console.WriteLine("3 - Informar saldo");
            Console.WriteLine("4 - Mostrar todos los vehiculos");
            opcionIngresada = Console.ReadLine();
            opcionIngresada = opcionIngresada.Trim(); //Quito espacios del inicio y fin del string
            opcionIngresada = opcionIngresada.ToUpper(); //convierto a mayusculas para que pueda tomar tanto s como S
            return opcionIngresada;
        }

    }
}
