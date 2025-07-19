using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_Final_Inventario.Entidades;

namespace Proyecto_Final_Inventario.Interfaces
{
    internal interface IUsuario
    {
        bool validacion(string usernameRecibido, string passwordRecibido);
        List<Usuarios> LeerUsuarios();
        void Activar(string fila, string usuario);
        void Desactivar(string fila, string usuario);
        void RegistrarInicioSesion(string usuario);

        void RegistrarCierreSesion(string usuario);
    }
}
