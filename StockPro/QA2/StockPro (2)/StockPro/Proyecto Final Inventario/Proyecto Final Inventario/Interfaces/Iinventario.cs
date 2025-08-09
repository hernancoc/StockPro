using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_Inventario.Interfaces
{
    public interface Iinventario
    {
        void Entrada(int idProducto, int nuevaCantidad);
        void Salida(int idProducto, int cantidadSalida);
        List<Productos> LeerProductos();
        void Activar(int idProducto);
        void Desactivar(int idProducto);
        List<Productos> Filtrar(string texto);
        List<Productos> FiltroCategoria(string texto);
    }
}

