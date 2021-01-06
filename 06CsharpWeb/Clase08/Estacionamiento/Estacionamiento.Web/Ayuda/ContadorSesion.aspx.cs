using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Estacionamiento.Web.Ayuda
{
    public partial class ContadorSesion : System.Web.UI.Page
    {
        private int contador;

        private int contadorVS;

        private int contadorAplicacion;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ViewState["contador"] = 0;
            }
            else
            {
                contadorVS = (int)ViewState["contador"];
            }

            if (Session["contadorSesion"] == null)
            {
                Session["contadorSesion"] = 0;
            }
            else
            {
                contador = (int)Session["contadorSesion"];
            }

            if(Application["contadorAplicacion"] == null)
            {
                Application["contadorAplicacion"] = 0;
            }
            else
            {
                contadorAplicacion = (int)Application["contadorAplicacion"];
            }
        }

        protected void btnIncrementar_Click(object sender, EventArgs e)
        {
            contador++;
            Session["contadorSesion"] = contador;
            lblContador.Text = contador.ToString();
        }

        protected void btnIncrementarViewState_Click(object sender, EventArgs e)
        {
            contadorVS++;
            ViewState["contador"] = contadorVS;
            lblContadorViewState.Text = contadorVS.ToString();
        }

        protected void btnIncrementarAplicacion_Click(object sender, EventArgs e)
        {
            contadorAplicacion++;
            Application["contadorAplicacion"] = contadorAplicacion;
            lblContadorAplicacion.Text = contadorAplicacion.ToString();
        }
    }
}