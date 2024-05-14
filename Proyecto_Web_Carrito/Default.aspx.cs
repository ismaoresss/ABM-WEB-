using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TP2_WinForm.Negocio;

namespace Proyecto_Web_Carrito
{
    public partial class Default : System.Web.UI.Page
    {
        public List<Articulos> ListaArticulos;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["listaArticulos"] != null)
            {
                ListaArticulos = (List<Articulos>)Session["listaArticulos"];
            }
            else
            {
                ArticulosNegocio negocio = new ArticulosNegocio();
                ListaArticulos = negocio.ListarArticulosConProcedimiento();
                Session.Add("listaArticulos", ListaArticulos);
            }


        }
    }
}