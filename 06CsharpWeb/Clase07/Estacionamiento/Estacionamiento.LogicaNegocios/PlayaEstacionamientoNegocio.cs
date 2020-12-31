using Estacionamiento.AccesoDatos;
using Estacionamiento.ClasesDeNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamiento.LogicaNegocios
{
    public class PlayaEstacionamientoNegocio
    {
        private PlayaEstacionamientoDatos datos = new PlayaEstacionamientoDatos();

        public List<PlayaEstacionamiento> ObtenerTodosLosEstacionamientos()
        {  
            return datos.ObtenerTodosLosEstacionamientos();
        }
    }
}
