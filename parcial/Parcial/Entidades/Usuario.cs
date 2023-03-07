using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial.Entidades
{
    public class Usuario
    {
        public string Nombre { get; set; }
        public string Contra { get; set; }
    }

    public class Venta
    {
        public int IdentificadorDeProducto { get; set; }
        public string NombreDelProducto { get; set; }
        public string DescripcionDelProducto { get; set; }
        public decimal PrecioDelProducto { get; set; }
        public int CantidadDeProducto { get; set; }
    }

}
