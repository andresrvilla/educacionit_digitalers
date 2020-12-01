using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEstacionamiento
{
    class Camioneta: Vehiculo
    {
        public override decimal PrecioDeUso { get; set; } = 200;

        public static string Tipo = "Camioneta";

        public Camioneta(string patente):base(patente)
        {

        }

        public override string ObtenerDescripcion()
        {
            return "Camioneta patente "+Patente;
        }

        public static string ObtenerTipoVehiculo()
        {
            return Tipo;
        }
    }
}
