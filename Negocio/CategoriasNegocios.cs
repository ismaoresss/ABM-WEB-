using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class CategoriasNegocios
    {
        AccesoDatos datos = new AccesoDatos();
        public List<Categorias> listarCategorias()
        {
            List<Categorias> lista = new List<Categorias>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta("select id, descripcion from CATEGORIAS");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Categorias aux = new Categorias();
                    aux.IdCategoria = (int)datos.Lector["id"];
                    aux.Descripcion = datos.Lector["descripcion"].ToString();

                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }

        public void agregarCategoria(Categorias Categoria)
        {
            try
            {
                datos.SetearConsulta("insert into CATEGORIAS VALUES ('" + Categoria.Descripcion + "')");
                datos.EjecutarConsulta();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }

        }
    }
}