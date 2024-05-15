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

        protected void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            //Criterio de filtracion: Nombre o Codigo de Articulo con al menos 2 caracteres
            List<Articulos> listaFiltrada;
            string filtro = txtBuscar.Text.ToLower();
            

            if (filtro.Length >= 2)
            {
                listaFiltrada = ListaArticulos.FindAll(X => X.Nombre.ToLower().Contains(filtro) || X.CodArticulo.ToLower().Contains(filtro));
            }
            else
            {
                listaFiltrada = ListaArticulos;
            }
            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = listaFiltrada;

            ////Ocultar columnas
            //dgvArticulos.Columns["IdArticulo"].Visible = false;
            //dgvArticulos.Columns["Imagen"].Visible = false;
        }
    }
}