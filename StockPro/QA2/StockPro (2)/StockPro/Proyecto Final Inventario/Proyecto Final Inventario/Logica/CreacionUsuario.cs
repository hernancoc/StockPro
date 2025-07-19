using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_Final_Inventario.Entidades;
using System.Windows.Forms;
using System.IO;

namespace Proyecto_Final_Inventario.Logica
{
    internal class CreacionUsuario: Usuarios
    {
        string ArchvioClaves = @"DLL\User.txt";

        public void CrearUsuario(string usuario,string clave,string clave2,bool active)
        {
            try
            {
                if (!string.IsNullOrEmpty(clave) && clave.Length > 5)
                {
                        if (clave == clave2)
                        {

                            foreach (var line in File.ReadAllLines(ArchvioClaves))
                            {
                              var dividir = line.Split('|');
                             if (dividir[0] == usuario) 
                             {
                                MessageBox.Show("Usuario ya existe", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                             }
                                _UserName = usuario.ToLower().Trim();
                                _Password = clave;
                                _UserActive = active;
                            }

                        }

                    else
                    {
                        MessageBox.Show("No coinciden las contraseñas", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Su contraseñas debe ser mayor a 5 caractres", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;

                }

                string linea = Environment.NewLine + $"{_UserName}|{_Password}|{_UserActive.ToString()}";

                File.AppendAllText(ArchvioClaves, linea);
                MessageBox.Show("Usuario creado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                Log.EscribirLog(ex);
                MessageBox.Show("Ocurrió un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
