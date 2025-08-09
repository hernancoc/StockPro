using System;
using System.Linq;
using System.Windows.Forms;

namespace Proyecto_Final_Inventario.Logica
{
    internal class CreacionUsuario
    {
        private STOCKPROEntities db = new STOCKPROEntities();

        public void CrearUsuario(string usuario, string clave, string clave2, bool active)
        {
            try
            {
                if (string.IsNullOrEmpty(clave) || clave.Length <= 5)
                {
                    MessageBox.Show("Su contraseña debe ser mayor a 5 caracteres", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (clave != clave2)
                {
                    MessageBox.Show("No coinciden las contraseñas", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                string usuarioLower = usuario.ToLower().Trim();

                // Verificar si el usuario ya existe
                bool existeUsuario = db.Usuarios.Any(u => u.Usuario.ToLower() == usuarioLower);
                if (existeUsuario)
                {
                    MessageBox.Show("Usuario ya existe", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Crear objeto Usuario
                Usuarios nuevoUsuario = new Usuarios
                {
                    Usuario = usuarioLower,
                    PassWord = clave,
                    Estado = active ? "T" : "F"  // "T" para activo, "F" para inactivo según tu base
                };

                db.Usuarios.Add(nuevoUsuario);
                db.SaveChanges();

                MessageBox.Show("Usuario creado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
