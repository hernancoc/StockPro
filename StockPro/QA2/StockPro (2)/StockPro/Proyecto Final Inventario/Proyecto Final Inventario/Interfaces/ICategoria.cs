using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_Final_Inventario.Entidades;

namespace Proyecto_Final_Inventario.Interfaces
{
    internal interface ICategoria
    {

        void CrearCategoria(Categorias categoria);

        List<Categorias> CargarCategorias();

        List<string> CargarCombobox();

        void Activar(string fila, string nombre);

        void Desactivar(string fila, string nombre);
    }
}
