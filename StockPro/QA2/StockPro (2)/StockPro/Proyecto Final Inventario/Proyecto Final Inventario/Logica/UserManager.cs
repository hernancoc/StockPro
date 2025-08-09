using Proyecto_Final_Inventario.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Proyecto_Final_Inventario
{
    internal class UserManager : IUsuario
    {
        public string _labelUserInactive { get; set; }
        public string _labelUserIncorrect { get; set; }

        public static string UsuarioActual { get; private set; }

        private STOCKPROEntities db = new STOCKPROEntities();

        public bool validacion(string usernameRecibido, string passwordRecibido)
        {
            try
            {
                string usernameLower = usernameRecibido.ToLower();

                var usuario = db.Usuarios
                                .FirstOrDefault(u => u.Usuario.ToLower() == usernameLower && u.PassWord == passwordRecibido);

                if (usuario != null)
                {
                    if (usuario.Estado != null && usuario.Estado.ToUpper() == "T")
                    {
                        UsuarioActual = usuario.Usuario;
                        return true;
                    }
                    else
                    {
                        _labelUserInactive = "Usuario Inactivo, Contacte a su administrador";
                        return false;
                    }
                }
                else
                {
                    _labelUserIncorrect = "Usuario o Contraseña inválidos";
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public List<Usuarios> LeerUsuarios()
        {
            try
            {
                return db.Usuarios.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al leer usuarios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<Usuarios>();
            }
        }

        public void Activar(string usuario)
        {
            try
            {
                var user = db.Usuarios.FirstOrDefault(u => u.Usuario == usuario);
                if (user != null)
                {
                    user.Estado = "T";
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al activar usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Desactivar(string usuario)
        {
            try
            {
                var user = db.Usuarios.FirstOrDefault(u => u.Usuario == usuario);
                if (user != null)
                {
                    user.Estado = "F";
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al desactivar usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void RegistrarInicioSesion(string usuario)
        {
            try
            {
                string rutaLoggin = System.IO.Path.Combine(Application.StartupPath, "ReportesLoggin.txt");
                string texto = $"{usuario} | Inicio sesión | {DateTime.Now:yyyy-MM-dd HH:mm:ss}";
                System.IO.File.AppendAllText(rutaLoggin, texto + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Ocurrió un error al registrar el inicio de sesión.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void RegistrarCierreSesion(string usuario)
        {
            try
            {
                string rutaLoggin = System.IO.Path.Combine(Application.StartupPath, "ReportesLoggin.txt");
                string texto = $"{usuario} | Cerró sesión | {DateTime.Now:yyyy-MM-dd HH:mm:ss}";
                System.IO.File.AppendAllText(rutaLoggin, texto + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Ocurrió un error al registrar el cierre de sesión.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Métodos no implementados, según tu interfaz
        public void Activar(string fila, string usuario)
        {
            throw new NotImplementedException();
        }

        public void Desactivar(string fila, string usuario)
        {
            throw new NotImplementedException();
        }
    }
}
