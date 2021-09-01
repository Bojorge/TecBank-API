using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TecBank_API.Models
{
    public class Rol
    {
        public Rol(){}

        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public override string ToString()
        {
            return "||" + this.Nombre + "   || " + this.Descripcion;
        }
    }
}
