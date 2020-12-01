using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEstacionamiento
{
    abstract class Vehiculo
    {
        /*private string patente;

        public string Patente
        {
            get
            {
                return patente;
            }
            set
            {
                patente = value;
            }
        }*/

        public string Patente { get; set; }

        public Vehiculo(string patente)
        {
            //this.patente = patente;
            Patente = patente;
        }

        public string MetodoEjemplo()
        {
            return "Este es un metodo de ejemplo";
        }

        public Vehiculo()
        {

        }
    }
}
