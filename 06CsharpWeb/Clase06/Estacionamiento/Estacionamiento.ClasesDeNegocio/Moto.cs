using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamiento.ClasesDeNegocio
{
    public class Moto : Vehiculo
    {
        public override decimal Precio => 100;

        public Moto(string patente)
        {
            Patente = patente;
        }
    }
}
