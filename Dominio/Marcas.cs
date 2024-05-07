﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Marcas
    {
        public Marcas() 
        {
            IdMarca = 0;
            Descripcion = "";
        }
        public Marcas(int IdMarca = 0,string descripcion = "")
        {
            this.IdMarca = IdMarca;
            this.Descripcion = descripcion; 
        }
        public int IdMarca { get; set; }
        public string Descripcion { get; set; }

        
        public override string ToString()
        {
            return Descripcion;
        }
        
    
    }
}
