using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

            ArticulosNegocio negocio = new ArticulosNegocio();
            ListaArticulos = negocio.listaParaImagenes();

            Session["Listado"] = ListaArticulos;

            if (!IsPostBack)
            {
                idRep.DataSource = ListaArticulos;
                idRep.DataBind();
            }

        }

        protected void txtBuscar_TextChanged(object sender, EventArgs e)
        {

            List<Articulos> listaFiltrada;
            string filtro = txtBuscar.Text.ToLower();
            
            if (filtro.Length >= 2)
            {
                listaFiltrada = ListaArticulos.FindAll(X => X.Nombre.ToLower().Contains(filtro));
            }
            else
            {
                listaFiltrada = ListaArticulos;
            }


            idRep.DataSource = listaFiltrada;
            idRep.DataBind();
        }

        protected void btnAgregarAlCarrito_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int articuloId = Convert.ToInt32(btn.CommandArgument);

            ArticulosNegocio negocio = new ArticulosNegocio();
            ListaArticulos = negocio.listaParaImagenes();


            List<Articulos> seleccionados;
            if (Session["Seleccionados"] == null)
            {
                seleccionados = new List<Articulos>();
            }
            else
            {
                seleccionados = (List<Articulos>)Session["Seleccionados"];
            }

            foreach (Articulos item in ListaArticulos)
            {
                if (articuloId == item.IdArticulo)
                {
                    seleccionados.Add(item);
                }
            }


            Session["Seleccionados"] = seleccionados;
            Response.Redirect(Request.RawUrl);
        }
    }
}