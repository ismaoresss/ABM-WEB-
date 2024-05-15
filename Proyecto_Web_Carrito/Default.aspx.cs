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
                listaFiltrada = ListaArticulos.FindAll(X => X.Nombre.ToLower().Contains(filtro));
            }
            else
            {
                listaFiltrada = ListaArticulos;
            }

            if (Session["listaArticulos"] != null)
            {
                Session.Add("listaArticulos", listaFiltrada);
            }
            else
            {
                if(txtBuscar.Text == "")
                {
                    Session.Add("listaArticulos", ListaArticulos);
                }
            }
            
            
        }
    }
}