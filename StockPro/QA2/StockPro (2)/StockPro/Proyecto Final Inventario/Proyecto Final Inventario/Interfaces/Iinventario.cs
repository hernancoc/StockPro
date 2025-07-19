using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_Final_Inventario.Entidades;

namespace Proyecto_Final_Inventario.Interfaces
{
    internal interface Iinventario
    {
        void Entrada(string IDActual, int NuevaCantidad);
        void Salida(string IDActual, int NuevaCantidad);
        List<Inventario> LeerProductos();
        void Activar(string row, string id);
        void Desactivar(string row, string id);
        List<Inventario> filtrar(string texto);

    }
}
