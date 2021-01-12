using Estacionamiento.AccesoDatos;
using Estacionamiento.ClasesDeNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamiento.LogicaNegocios
{
    public class CocheraNegocio
    {
        private CocheraDatos cocheraDatos = new CocheraDatos();

        public List<Cochera> ObtenerCocherasEstacionamiento(int idEstacionamiento)
        {
            return cocheraDatos.ObtenerCocherasEstacionamiento(idEstacionamiento);
        }

        public void AsignarCochera(int idCochera, string patente, TipoVehiculo moto)
        {
            throw new NotImplementedException();
        }
    }
}
