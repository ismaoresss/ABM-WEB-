﻿using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto_Web_Carrito
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["Seleccionados"] != null)
                {
                    List<Articulos> seleccionados = (List<Articulos>)Session["Seleccionados"];
                    int cantidadArticulos = seleccionados.Count;

                    contadorCarrito.Text = cantidadArticulos.ToString();

                }
            }
        }

    }
}