using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_Inventario.Interfaces
{
    public interface IUsuario
    {
        string _labelUserInactive { get; set; }
        string _labelUserIncorrect { get; set; }

        bool validacion(string usernameRecibido, string passwordRecibido);

        List<Usuarios> LeerUsuarios();
        void Activar(string usuario);
        void Desactivar(string usuario);

        void RegistrarInicioSesion(string usuario);
        void RegistrarCierreSesion(string usuario);
        void Activar(string fila, string usuario);
        void Desactivar(string fila, string usuario);
    }
}