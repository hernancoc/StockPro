using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_Final_Inventario.Entidades;
using Proyecto_Final_Inventario.Interfaces;

namespace Proyecto_Final_Inventario.Logica
{
    internal class UserManager :Usuarios, IUsuario
    {
        
        public  string _labelUserInactive { get; set; }
        public  string _labelUserIncorrect { get; set; }

        string ArchvioClaves = @"DLL\User.txt";

        public static string UsuarioActual { get; private set; }


        public bool validacion(string usernameRecibido, string passwordRecibido )
        {
            try
            {
                _UserName = usernameRecibido.ToLower();
                _Password = passwordRecibido;


                foreach (var line in File.ReadLines(ArchvioClaves))
                {
                    var dividir = line.Split('|');
                    string UsuarioArchivo = dividir[0].Trim();
                    string ContraseñaArchivo = dividir[1].Trim();
                    bool usuarioActivo = Convert.ToBoolean(dividir[2].Trim());
                    if (UsuarioArchivo == _UserName && ContraseñaArchivo == _Password && usuarioActivo == true)
                    {
                        UsuarioActual = _UserName;
                        return true;
                    }
                    else if (UsuarioArchivo == _UserName && ContraseñaArchivo == _Password && usuarioActivo == false)
                    {
                        _labelUserInactive = "Usuario Inactivo, Contacte a su administrador";
                        return false;
                    }

                }
                _labelUserIncorrect = "Usuario o Contraseña invalidos";
            }
            catch (Exception ex)
            {
                Log.EscribirLog(ex);
                MessageBox.Show("Ocurrió un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        public List<Usuarios> LeerUsuarios()
        {
            List<Usuarios> lista = new List<Usuarios>();

            foreach (var linea in File.ReadLines(ArchvioClaves))
            {

                var dividir = linea.Split('|');

                Usuarios usuario = new Usuarios
                {
                    _UserName = dividir[0],
                    _Password = dividir[1],
                    _UserActive = Convert.ToBoolean(dividir[2])
                };

                lista.Add(usuario);
            }
            return lista;
        }

        public void Activar(string fila, string usuario)
        {
            List<string> ListaModificada = new List<string>();

            foreach (var linea in File.ReadLines(ArchvioClaves))
            {

                var dividir = linea.Split('|');

                if (usuario == dividir[0])
                {
                    dividir[2] = "True";
                }
                ListaModificada.Add(string.Join("|", dividir));
            }
            File.WriteAllLines(ArchvioClaves, ListaModificada);
        }

        public void Desactivar(string fila, string usuario)
        {
            List<string> ListaModificada = new List<string>();

            foreach (var linea in File.ReadLines(ArchvioClaves))
            {

                var dividir = linea.Split('|');

                if (usuario == dividir[0])
                {
                    dividir[2] = "False";
                }
                ListaModificada.Add(string.Join("|", dividir));
            }
            File.WriteAllLines(ArchvioClaves, ListaModificada);
        }
        public void RegistrarInicioSesion(string usuario)
        {
            try
            {
                string rutaLoggin = @"C:DLL\ReportesLoggin.txt";
                string texto = $"{usuario} | Inicio sesión | {DateTime.Now:yyyy-MM-dd HH:mm:ss}";
                File.AppendAllText(rutaLoggin, texto + Environment.NewLine);
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
                string rutaLoggin = @"DLL\ReportesLoggin.txt";
                string texto = $"{usuario} | Cerró sesión | {DateTime.Now:yyyy-MM-dd HH:mm:ss}";
                File.AppendAllText(rutaLoggin, texto + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Ocurrió un error al registrar el cierre de sesión.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


    }
}
