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
            //Vehiculo miVehiculo = new Vehiculo();
            //miVehiculo.Patente = "AA123BB";
            //Console.WriteLine(miVehiculo.Patente);
            //Console.WriteLine(miVehiculo.MetodoEjemplo());

            Auto auto = new Auto();
            auto.Patente = "CCC801";
            Console.WriteLine(auto.Patente);
            Console.WriteLine(auto.MetodoEjemplo());

            Vehiculo miVehiculo = new VehiculoTerrestre();

            Auto autoExtraido = miVehiculo as Auto;

            if(autoExtraido == null)
            {
                Console.WriteLine("No era un auto");
            }
            else
            {
                Console.WriteLine("Es un auto");
            }

            Console.ReadKey();
        }
    }
}
