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
        public List<Articulos> ListaArticulos;
        protected void Page_Load(object sender, EventArgs e)
        {
            ArticulosNegocio articulo = new ArticulosNegocio();
            List<Articulos> listaArt = new List<Articulos>();
            Articulos art = new Articulos();

            if (Session["Listado"] != null)
            {
                listaArt = (List<Articulos>)Session["Listado"];
            }
            try
            {
                if (Request.QueryString["IdArticulo"] != null)
                {
                    int id = Convert.ToInt32(Request.QueryString["IdArticulo"]);
                    foreach (Articulos item in listaArt)
                    {
                        if (id == item.IdArticulo)
                        {
                            art = item;
                        }
                    }

                    txtnombre.Text = art.Nombre;
                    txtDescripcion.Text = art.Descripcion;
                    txtPrecio.Text = art.Precio.ToString();
                    txtmarca.Text = art.Marcas.ToString();
                    txtCategoria.Text =  art.Categorias.ToString();

                    repDetalle.DataSource = art.Imagenes;
                    repDetalle.DataBind();

                    btnAgregarAlCarrito.CommandArgument = art.IdArticulo.ToString();

                }
            }
            catch (Exception ex)
            {
                Response.Write($"<script>alert('Error: {ex.Message}');</script>");
            }
        }

        protected void btnAgregarAlCarrito_Click(object sender, EventArgs e)
        {
            System.Web.UI.WebControls.Button btn = (System.Web.UI.WebControls.Button)sender;
            string commandArgument = btn.CommandArgument;

            if (int.TryParse(commandArgument, out int articuloId))
            {
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

                Articulos articuloSeleccionado = ListaArticulos.Find(item => item.IdArticulo == articuloId);
                if (articuloSeleccionado != null)
                {
                    seleccionados.Add(articuloSeleccionado);
                }

                Session["Seleccionados"] = seleccionados;
                Response.Redirect(Request.RawUrl);
            }
            else
            {
                // Manejo de error si `commandArgument` no es un entero válido
                Response.Write("<script>alert('Id de Artículo no válido.');</script>");
            }

        }
    }
}

