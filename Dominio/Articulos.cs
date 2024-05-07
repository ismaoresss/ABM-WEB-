using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Dominio
{
   public class Articulos
     
    {
        public Articulos()
        {
            IdArticulo = 0;
            CodArticulo = "";
            Nombre = "";
            Descripcion = "";
            Marcas = new Marcas();  
            Categorias = new Categorias();
            Imagen = "";
            Precio = 0;

        }
        public Articulos(string codigoArt, string nombreArt, string descripcionArt, Marcas marcaArt, Categorias categoriaArt, string imagenes, decimal precio)
        {
            CodArticulo = codigoArt;
            Nombre = nombreArt;
            Descripcion = descripcionArt;
            Marcas = marcaArt;
            Categorias = categoriaArt;
            Imagen = imagenes;
            Precio = precio;
        }

        public int IdArticulo { get; set; }
        [DisplayName("Cód. Artículo")]
        public string CodArticulo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public List<string> Imagenes { get; set; }
        public string Imagen { get; set; }
        [DisplayName("Marca")]
        public Marcas Marcas { get; set; }
        public Categorias Categorias { get; set; }

    }
}
