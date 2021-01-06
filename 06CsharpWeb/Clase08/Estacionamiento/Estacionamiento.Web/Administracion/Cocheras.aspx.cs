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
    }
}