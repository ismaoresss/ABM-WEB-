using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using TP2_WinForm.Negocio;

namespace Proyecto_Web_Carrito
{
    public partial class Carrito1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


            if (Session["Seleccionados"] != null)
            {
                List<Articulos> seleccionados = (List<Articulos>)Session["Seleccionados"];

                if (!IsPostBack)
                {
                    lblTotal.Text = "Total: $" + seleccionados.Sum(x => x.Precio).ToString();
                    repListado.DataSource = seleccionados;
                    repListado.DataBind();

                }
            }

            //if (Session["Seleccionados"] != null)
            //{
            //    List<Articulos> seleccionados = (List<Articulos>)Session["Seleccionados"];
            //    try
            //    {
            //        if (!IsPostBack)
            //        {
            //            List<Articulos> carrito;
            //            carrito = Session["carrito"] != null ? (List<Articulos>)Session["carrito"] : new List<Articulos>();
            //            Session.Add("carrito", carrito);

            //            int id = int.Parse(Request.QueryString["id"]);

            //            List<Articulos> listaOriginal = (List<Articulos>)Session["listaArticulos"];
            //            Articulos seleccionado = listaOriginal.Find(x => x.IdArticulo == id);
            //            carrito.Add(seleccionado);

            //            dgvCarrito.DataSource = carrito;
            //            dgvCarrito.DataBind();
            //        }

            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.ToString());
            //    }

            //}
        }

        protected void FinalizarCompra_Click(object sender, EventArgs e)
        {
            Session["Seleccionados"] = null;

            MessageBox.Show("Que disfrutes tu compra :)");
            Response.Redirect("Default.aspx");
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            System.Web.UI.WebControls.Button btn = (System.Web.UI.WebControls.Button)sender;
            int id = Convert.ToInt32(btn.CommandArgument);

            List<Articulos> arti = new List<Articulos>();
            //if (Session["Seleccionados"] != null) 
            //{
            arti = (List<Articulos>)Session["Seleccionados"];
            //}
            //else
            //{
            //    arti = new List<Articulos>();
            //}

            List<Articulos> nuloLista = new List<Articulos>();
            foreach (var articulos in arti)
            {
                if (articulos.IdArticulo != id)
                {
                    nuloLista.Add(articulos);
                }

                Session["Seleccionados"] = nuloLista;
                repListado.DataSource = nuloLista;
                repListado.DataBind();
            };
        }
    }
}