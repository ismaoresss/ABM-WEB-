using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class MarcasNegocio
    {
        AccesoDatos datos = new AccesoDatos();
        public List<Marcas> listarMarcas()
        {
            List<Marcas> lista = new List<Marcas>();


            try
            {
                datos.SetearConsulta("select id, descripcion from MARCAS");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Marcas aux = new Marcas();
                    aux.IdMarca = (int)datos.Lector["id"];
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

        public void agregarMarca(Marcas Marca)
        {

            try
            {
                datos.SetearConsulta("insert into MARCAS VALUES ('" + Marca.Descripcion + "')");
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