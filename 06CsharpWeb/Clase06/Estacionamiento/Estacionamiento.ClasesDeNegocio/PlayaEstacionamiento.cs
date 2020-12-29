using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamiento.ClasesDeNegocio
{
    public class PlayaEstacionamiento
    {
        public List<Cochera> cocheras { get; } = new List<Cochera>();

        public PlayaEstacionamiento(int cantidadCocheras)
        {
            for (int i = 1; i <= cantidadCocheras; i++)
            {
                Cochera cochera = new Cochera(i);
                cocheras.Add(cochera);
            }
        }

        public int Agregar(Vehiculo vehiculo)
        {
            int numeroCocheraAsignado = 0;

            //for (int i = 0; i < cocheras.Count; i++)
            //{
            //    Cochera laCochera = cocheras[i];
            //    if (laCochera.EstaVacia)
            //    {

            //    }
            //}

            //Bucle Foreach
            foreach(Cochera laCochera in cocheras)
            {
                if (laCochera.EstaVacia)
                {
                    laCochera.Ingresar(vehiculo);
                    numeroCocheraAsignado = laCochera.NumeroCochera;
                    break;
                }
            }
            return numeroCocheraAsignado;
        }

        public void QuitarCochera(int numeroCochera)
        {
            Cochera cocheraAQuitar = new Cochera(numeroCochera);
            cocheras.Remove(cocheraAQuitar);
        }

        public void Saludar()
        {
            Console.WriteLine("Hola Mundo");
        }
    }
}
