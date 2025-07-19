using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_Inventario.Entidades
{
    internal class Inventario
    {
        public string ID { get; set; }
        public string Nombre { get; set; }
        public string Categoria { get; set; }
        public string Proveedor { get; set; }
        public int Cantidad { get; set; }
        public string PrecioVenta { get; set; }
        public string PrecioCompra { get; set; }
        public bool Activo { get; set; }
        public string UrlImagenes {  get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaActualizacion { get; set; }

    }
}
