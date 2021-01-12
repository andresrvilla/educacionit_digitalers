using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamiento.ClasesDeNegocio
{
    public class Cuatriciclo : Vehiculo
    {
        public override decimal Precio => 75;

        public Cuatriciclo(string patente)
        {
            Patente = patente;
        }
    }
}
