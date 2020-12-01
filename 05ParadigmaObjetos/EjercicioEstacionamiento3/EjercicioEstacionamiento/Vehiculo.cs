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

        public virtual decimal PrecioDeUso { get; set; }

        public Vehiculo(string patente)
        {
            //this.patente = patente;
            Patente = patente;
        }

        public override string ToString()
        {
            return "Patente: " + Patente + " Precio de Uso " + PrecioDeUso;
        }

        public virtual string ObtenerDescripcion()
        {
            return "Vehiculo Patente " + Patente;
        }
    }
}
