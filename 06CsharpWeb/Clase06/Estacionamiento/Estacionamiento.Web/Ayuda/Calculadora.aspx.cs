using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Estacionamiento.Web.Ayuda
{
    public partial class Calculadora : System.Web.UI.Page
    {
        private decimal resultado = Decimal.Zero;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                resultado = (decimal)ViewState["resultado"];
            }
            else
            {
                ViewState["resultado"] = Decimal.Zero;
            }
        }


        protected void btnSumar_Click(object sender, EventArgs e)
        {
            /*
             * Debería verificar antes de sumar si el valor ingresado es valido respecto al separador
             * decimal, ya que puede ser que el navegador tenga un separador decimal distinto al del
             * servidor. Se podría verificar si se resuelve con: 
             * Convert.ToDecimal(valueResult.AttemptedValue, 
                CultureInfo.CurrentCulture);
             */
            decimal resultadoParseo;
            bool resultadoConversion = Decimal.TryParse(txtIngresoNumero.Text, out resultadoParseo);

            if (resultadoConversion == true)
            {
                resultado += resultadoParseo;
                lblResultado.Text = resultado.ToString();
                ViewState["resultado"] = resultado;
            }
        }
    }
}