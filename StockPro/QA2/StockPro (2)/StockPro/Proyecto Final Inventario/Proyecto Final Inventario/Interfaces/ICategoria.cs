using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Proyecto_Final_Inventario.Interfaces
{
    public interface ICategoria
    {
        void CrearCategoria(Categorias categoria);
        List<Categorias> CargarCategorias();
        List<string> CargarCombobox();
        void Activar(string nombre);
        void Desactivar(string nombre);
    }
}