using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamiento.ClasesDeNegocio
{
    public class Camioneta : Vehiculo
    {
        public override decimal Precio => 200;

        public Camioneta(string patente)
        {
            Patente = patente;
        }
    }
}
