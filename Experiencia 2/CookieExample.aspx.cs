using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication6
{
    public partial class CookieExample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //-------------- Creando Cookie --------------------------//
            // Creando una instancia de HttpCookie con el nombre especifico de "estudiante"
            HttpCookie cokie = new HttpCookie("estudiante");
            // Asignando un valor para el cookie creado
            cokie.Value = "Juan Peréz";
            // Agregando Cookie a la instancia response
            Response.Cookies.Add(cokie);
            //--------------- Obteniendo cookie -------------------------//
            var co_val = Response.Cookies["estudiante"].Value;
            Label1.Text = co_val;
        }
    }
}