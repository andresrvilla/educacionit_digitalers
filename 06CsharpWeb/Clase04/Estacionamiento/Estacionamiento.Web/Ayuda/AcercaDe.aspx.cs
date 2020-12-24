using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Estacionamiento.Web.Ayuda
{
    public partial class AcercaDe : System.Web.UI.Page
    {
        private int contador = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            //if(!IsPostBack)
            if (IsPostBack == false)
            {
                contador = 0;
                ViewState["contador"] = 0;
            }
            else
            {
                contador = (int)ViewState["contador"];
            }   
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            //Redirige a la pagina que le paso por parametro
            //Response.Redirect("~/Default.aspx");
            Server.Transfer("~/Default.aspx");
        }

        protected void btnIncrementar_Click(object sender, EventArgs e)
        {
            contador++;
            ViewState["contador"] = contador;
            lblContador.Text = contador.ToString();
        }
    }
}