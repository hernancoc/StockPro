using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final_Inventario.Entidades
{
    internal class Log
    {

        // Método para escribir un mensaje en el archivo logs.txt
        private static readonly string rutaLog = @"C:\Users\corom\OneDrive\Escritorio\Aprendiendo C#\Proyecto Final Inventario\Proyecto Final Inventario\DLL\Logs.txt";

        public static void EscribirLog(Exception ex)
        {
            try
            {
                string mensaje = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - ERROR: {ex.Message}\nSTACKTRACE:\n{ex.StackTrace}\n------------------------\n";
                File.AppendAllText(rutaLog, mensaje);
            }
            catch
            {
            }
        }
    }
}
