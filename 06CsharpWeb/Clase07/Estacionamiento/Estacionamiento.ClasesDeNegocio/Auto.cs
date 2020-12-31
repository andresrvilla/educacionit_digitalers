using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamiento.ClasesDeNegocio
{
    public class Auto : Vehiculo
    {
        //public override decimal Precio { get; } = 150;
        //otra sintaxis
        public override decimal Precio => 150;

        public Auto(string patente)
        {
            Patente = patente;
        }
    }
}
