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
        protected void Page_Load(object sender, EventArgs e)
        {
            lblIntMaximo.Text = Int32.MaxValue.ToString();
            lblIntMinimo.Text = Int32.MinValue.ToString();
            
        }
    }
}