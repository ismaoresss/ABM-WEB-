using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
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
            if (!IsPostBack)
            {
                ArticulosNegocio negocio = new ArticulosNegocio();
                ListaArticulos = negocio.listaParaImagenes();
                Session["Listado"] = ListaArticulos;
                idRep.DataSource = ListaArticulos;
                idRep.DataBind();
            }
        }

        protected void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            List<Articulos> listaFiltrada;
            string filtro = txtBuscar.Text.ToLower();


            if (filtro.Length > 2)
            {
                List<Articulos> lista = (List<Articulos>)Session["Listado"];
                listaFiltrada = lista.FindAll(k => k.Nombre.ToLower().Contains(filtro) || k.Descripcion.ToLower().Contains(filtro));
            }
            else
            {
                listaFiltrada = (List<Articulos>)Session["Listado"];
            }   

            idRep.DataSource = listaFiltrada;
            idRep.DataBind();
        }

        protected void btnIncrementar_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int articuloId = Convert.ToInt32(btn.CommandArgument);
            RepeaterItem item = (RepeaterItem)btn.NamingContainer;
            Label lblCantidad = (Label)item.FindControl("lblCantidad");
            int cantidad = Convert.ToInt32(lblCantidad.Text);
            cantidad++;
            lblCantidad.Text = cantidad.ToString();
        }

        protected void btnDecrementar_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int articuloId = Convert.ToInt32(btn.CommandArgument);
            RepeaterItem item = (RepeaterItem)btn.NamingContainer;
            Label lblCantidad = (Label)item.FindControl("lblCantidad");
            int cantidad = Convert.ToInt32(lblCantidad.Text);
            if (cantidad > 1)
            {
                cantidad--;
                lblCantidad.Text = cantidad.ToString();
            }
        }

        protected void btnAgregarAlCarrito_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int articuloId = Convert.ToInt32(btn.CommandArgument);
            RepeaterItem item = (RepeaterItem)btn.NamingContainer;
            Label lblCantidad = (Label)item.FindControl("lblCantidad");
            int cantidad = Convert.ToInt32(lblCantidad.Text);

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

            Articulos articuloSeleccionado = ListaArticulos.FirstOrDefault(a => a.IdArticulo == articuloId);
            if (articuloSeleccionado != null)
            {
                for (int i = 0; i < cantidad; i++)
                {
                    seleccionados.Add(articuloSeleccionado);
                }
            }

            Session["Seleccionados"] = seleccionados;
            Response.Redirect(Request.RawUrl);
        }
    }
}