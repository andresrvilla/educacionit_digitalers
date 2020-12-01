using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEstacionamiento
{
    class Auto: Vehiculo
    {
        public Auto(string patente, decimal precioDeUso): base(patente)
        {
            PrecioDeUso = precioDeUso;
        }

        public override string ObtenerDescripcion()
        {
            return "Auto patente " + Patente;
        }
    }
}
