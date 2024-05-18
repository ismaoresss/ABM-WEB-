using Dominio;
using Negocio;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using TP2_WinForm.Negocio;

namespace Proyecto_Web_Carrito
{
    public partial class DetalleArticulo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ArticulosNegocio articulo = new ArticulosNegocio();
            List<Articulos> listaArt = new List<Articulos>();
            Articulos art = new Articulos();

            try
            {

                if (!IsPostBack)
                {
                    if (Request.QueryString["IdArticulo"] != null)
                    {
                        int id = Convert.ToInt32(Request.QueryString["IdArticulo"]);
                        art = listaArt.Find(x => x.IdArticulo == id);

                        if (art != null)
                        {
                            txtnombre.Text = art.Nombre;
                            txtDescripcion.Text = art.Descripcion;
                            txtPrecio.Text = art.Precio.ToString();

                            repDetalle.DataSource = art.Imagenes;
                            repDetalle.DataBind();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}

