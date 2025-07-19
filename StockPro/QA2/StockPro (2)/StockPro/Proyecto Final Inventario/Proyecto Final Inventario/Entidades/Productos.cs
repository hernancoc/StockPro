using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_Inventario.Entidades
{
    public class Productos
    {
        public int _Id { get; set; }
        public string  _Nombre { get; set; }
        public string _Categoria { get; set; }
        public string _Proveedor { get; set; }
        public int _Cantidad { get; set; }
        public double _PrecioVenta { get; set; }
        public double _PrecioCompra { get; set; }
        public bool _Activo {  get; set; }
        public string _UrlImagen {  get; set; }
        public DateTime _FechaCreacion { get; set; }
        public DateTime _FechaActualizacion { get; set; }

    }
}
