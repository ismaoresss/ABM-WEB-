using Dominio;
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
            try
            {
                if (IsPostBack)
                {
                    List<Articulos> carrito;
                    carrito = Session["carrito"] != null ? (List<Articulos>)Session["carrito"] : new List<Articulos>();
                    Session.Add("carrito", carrito);

                    int id = int.Parse(Request.QueryString["id"]);

                    List<Articulos> listaOriginal = (List<Articulos>)Session["listaArticulos"];
                    Articulos seleccionado = listaOriginal.Find(x => x.IdArticulo == id);
                    carrito.Add(seleccionado);

                    dgvCarrito.DataSource = carrito;
                    dgvCarrito.DataBind();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
               
            }
            
            
        }
    }
}