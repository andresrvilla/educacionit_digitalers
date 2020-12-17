using Estacionamiento.ClasesDeNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamiento.Consola
{
    class Program
    {
        const int CANTIDADCOCHERAS = 10;

        static void Main(string[] args)
        {
            PlayaEstacionamiento playa = new PlayaEstacionamiento(CANTIDADCOCHERAS);

            Console.Write("Ingrese el tipo de vehiculo (1 moto, 2 auto, 3 camioneta): ");
            string tipo = Console.ReadLine();

            Console.Write("Ingrese la patente del vehiculo: ");
            string patente = Console.ReadLine();

            int tipoInt = Convert.ToInt32(tipo); //int.Parse(tipo)


            Vehiculo nuevo = null;

            switch (tipoInt)
            {
                case (byte)TipoVehiculo.Moto:
                    nuevo = new Moto(patente);
                    break;
                case (byte)TipoVehiculo.Auto:
                    nuevo = new Auto(patente);
                    break;
                case (byte)TipoVehiculo.Camioneta:
                    nuevo = new Camioneta(patente);
                    break;
            }

            playa.Agregar(nuevo);

            
            Console.ReadKey();
        }
    }
}
