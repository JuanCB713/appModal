using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace appModal.Entidades
{
    public class clProductoE
    {
        public int idProducto { get; set; }
        public string  referencia { get; set; }
        public string nombreProducto { get; set; }
        public string cantidad { get; set; }
        public float precio { get; set; }
        public string descripcion { get; set; }
    }
}