using Estacionamiento.ClasesDeNegocio;
using Estacionamiento.ClasesDeNegocio.Excepciones;
using Estacionamiento.LogicaNegocios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Estacionamiento.Web.Administracion
{
    public partial class Cocheras : System.Web.UI.Page
    {
        private CocheraNegocio cocheraNegocio = new CocheraNegocio();

        protected void Page_Load(object sender, EventArgs e)
        {
            string identificador = Request.QueryString["Id"];
            lstCocheras.DataSource = cocheraNegocio.ObtenerCocherasEstacionamiento(Convert.ToInt32(identificador));
            lstCocheras.DataBind();
            //Convert.ToInt32(identificador)
        }

        protected void AsignarCochera(object sender, EventArgs e)
        {
            try
            {
                cocheraNegocio.AsignarCochera(10, "AAA123", TipoVehiculo.Moto);
            }
            catch (AccesoDatosException ex)
            {
                // Reaccionar al error de acceso a datos
            }
            catch(SinLugarException sle)
            {
                // reaccionar al error de que no hay lugar en el estacionamiento
            }
            catch (Exception)
            {
                //trato todos los demas errores
            }
        }

        private void Page_Error(object sender, EventArgs e)
        {

        }
    }
}