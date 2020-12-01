using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEstacionamiento
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehiculo[] misVehiculos = new Vehiculo[3];
            misVehiculos[0] = new Auto("AAA111", 150);
            misVehiculos[1] = new Camioneta("CCC111");
            misVehiculos[2] = new Moto("MMM111");

            for (int i = 0; i < misVehiculos.Length; i++)
            {
                Vehiculo elVehiculoDelArray = misVehiculos[i];
                Console.WriteLine(elVehiculoDelArray.ObtenerDescripcion());
            }

            //Camioneta c = new Camioneta("XXXXX");
            Console.WriteLine(Camioneta.ObtenerTipoVehiculo());

            Console.ReadKey();
        }
    }
}
