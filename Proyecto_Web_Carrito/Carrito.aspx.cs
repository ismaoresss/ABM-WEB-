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
           
            arti = (List<Articulos>)Session["Seleccionados"];
            
            List<Articulos> nuloLista = new List<Articulos>();
            foreach (var articulos in arti)
            {
                if (articulos.IdArticulo != id)
                {
                    nuloLista.Add(articulos);
                }
                else
                {
                    nuloLista.Remove(articulos);
                }
            };

            Session["Seleccionados"] = nuloLista;
            Response.Redirect(Request.RawUrl);
            repListado.DataSource = nuloLista;
            repListado.DataBind();
        }
    }
}