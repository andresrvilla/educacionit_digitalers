using Estacionamiento.LogicaNegocios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Estacionamiento.Web
{
    public partial class Default : System.Web.UI.Page
    {
        private readonly PlayaEstacionamientoNegocio estacionamientoNegocio = new PlayaEstacionamientoNegocio();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lblIntMaximo.Text = Int32.MaxValue.ToString();
                lblIntMinimo.Text = Int32.MinValue.ToString();

                lstPlayasEstacionamiento.DataSource = estacionamientoNegocio.ObtenerTodosLosEstacionamientos();
                lstPlayasEstacionamiento.DataBind();

            }
            
            
        }
    }
}