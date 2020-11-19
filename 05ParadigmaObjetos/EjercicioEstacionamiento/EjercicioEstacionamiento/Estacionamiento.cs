using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEstacionamiento
{
    class Estacionamiento
    {
        private decimal precioDeUso = 0;

        private decimal totalFacturado = 0;

        private Cochera[] cocheras;

        public Estacionamiento(decimal elPrecio, int cantidadDeCocheras)
        {
            precioDeUso = elPrecio;

            cocheras = new Cochera[cantidadDeCocheras];
            for (int i = 0; i < cantidadDeCocheras; i++)
            {
                Cochera nuevaCochera = new Cochera();
                cocheras[i] = nuevaCochera;
            }
        }

        public Estacionamiento(decimal elPrecio, int cantidadDeCocheras, decimal cajaInicial)
            :this(elPrecio,cantidadDeCocheras)
        {
            totalFacturado = cajaInicial;
        }

        public bool EstaLleno()
        {
            bool resultado = true;

            for (int i = 0; i < cocheras.Length; i++)
            {
                if (cocheras[i].EstaDisponible() == true)
                {
                    resultado = false;
                    break;
                }
            }

            /*
            while (control < cocheras.Length)
            {
                if (cocheras[control].EstaDisponible() == true)
                {
                    resultado = false;
                    break;
                }
                control++;
            }
            */

            return resultado;
        }

        public Cochera BuscarCocheraDisponible()
        {
            Cochera resultado = null;

            for (int i = 0; i < cocheras.Length; i++)
            {
                if (cocheras[i].EstaDisponible() == true)
                {
                    resultado = cocheras[i];
                    break;
                }
            }

            return resultado;
        }

    }
}
