using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Estacionamiento.Web.Ayuda
{
    public partial class Calculadora2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSumar_Click(object sender, EventArgs e)
        {
            decimal valor = Decimal.Parse(lblResultado.Text);

            decimal valorParseado;
            bool resultadoParseo = Decimal.TryParse(txtIngresoNumero.Text, out valorParseado);
            if(resultadoParseo == true)
            {
                valor += valorParseado;
                lblResultado.Text = valor.ToString();
            }
        }
    }
}