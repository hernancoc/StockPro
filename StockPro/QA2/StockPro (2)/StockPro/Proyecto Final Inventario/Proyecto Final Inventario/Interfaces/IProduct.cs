using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_Inventario.Interfaces
{
    public interface IProduct
    {
        void CreacionProducto(Productos product);
        void EditarProducto(Productos product);
        Productos BuscarProducto(int id);
    }
}

