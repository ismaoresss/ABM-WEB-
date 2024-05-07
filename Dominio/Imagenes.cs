using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    
    public class Imagenes
    {
        public Imagenes() 
        {
            Idimagenes = 0;
            IdArticulo = 0;
            ImagenUrl = "";
        }  
        public int Idimagenes { get; set; }
        public int IdArticulo { get; set; }
        public string ImagenUrl { get; set; }
    }
}
