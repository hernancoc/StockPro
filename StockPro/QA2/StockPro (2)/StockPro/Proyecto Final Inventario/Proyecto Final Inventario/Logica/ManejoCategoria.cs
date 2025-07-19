using Proyecto_Final_Inventario.Entidades;
using Proyecto_Final_Inventario.Interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace Proyecto_Final_Inventario.Logica
{
    internal class ManejoCategoria : Categorias, ICategoria
    {
        string RutaArchivo = @"DLL\Categorias.txt";

        public void CrearCategoria(Categorias categoria)
        {
            try
            {
                foreach (var line in File.ReadAllLines(RutaArchivo))
                {
                    var dividir = line.Split('|');

                    // Comparación segura y limpia para evitar duplicados
                    if (categoria._NombreCateg.Trim().Equals(dividir[0].Trim(), StringComparison.OrdinalIgnoreCase))
                    {
                        MessageBox.Show("Esta Categoria ya existe");
                        return;
                    }
                }

                // Guardar la fecha en formato "d/M/yyyy" para compatibilidad con el parseo
                string fechaFormateada = categoria._FechaCrea.ToString("d/M/yyyy");

                string linea = $"{categoria._NombreCateg.Trim()}|{categoria._Descripcion.Trim()}|{categoria._EstadoCateg}|{fechaFormateada}";

                File.AppendAllText(RutaArchivo, linea + Environment.NewLine);
            }
            catch (Exception ex)
            {
                Log.EscribirLog(ex);
                MessageBox.Show("Ocurrió un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public List<Categorias> CargarCategorias()
        {
            List<Categorias> listacategoria = new List<Categorias>();

            try
            {
                CultureInfo cultura = new CultureInfo("es-DO");

                foreach (var linea in File.ReadLines(RutaArchivo))
                {
                    var dividir = linea.Split('|');

                    if (dividir.Length < 4)
                    {
                        Console.WriteLine($"Línea inválida o incompleta: {linea}");
                        continue;
                    }

                    try
                    {
                        Categorias categorias = new Categorias
                        {
                            _NombreCateg = dividir[0].Trim(),
                            _Descripcion = dividir[1].Trim(),
                            _EstadoCateg = Convert.ToBoolean(dividir[2].Trim()),
                            _FechaCrea = DateTime.ParseExact(dividir[3].Trim(), "d/M/yyyy", cultura)
                        };

                        listacategoria.Add(categorias);
                    }
                    catch (FormatException fex)
                    {
                        Console.WriteLine($"Error al parsear fecha en línea: {linea} - {fex.Message}");
                    }
                }
            }
            catch (Exception ex)
            {
                Log.EscribirLog(ex);
                MessageBox.Show("Ocurrió un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listacategoria;
        }

        public List<string> CargarCombobox()
        {
            List<string> listacategoria = new List<string>();
            foreach (var line in File.ReadAllLines(RutaArchivo))
            {
                var dividir = line.Split('|');
                if (dividir.Length >= 3 && dividir[2].Trim().Equals("True", StringComparison.OrdinalIgnoreCase))
                {
                    listacategoria.Add(dividir[0].Trim());
                }
            }

            return listacategoria;
        }

        public void Activar(string fila, string nombre)
        {
            List<string> ListaModificada = new List<string>();

            foreach (var linea in File.ReadLines(RutaArchivo))
            {
                var dividir = linea.Split('|');

                if (dividir.Length >= 1 && nombre.Trim().Equals(dividir[0].Trim(), StringComparison.OrdinalIgnoreCase))
                {
                    dividir[2] = "True";
                }
                ListaModificada.Add(string.Join("|", dividir));
            }
            File.WriteAllLines(RutaArchivo, ListaModificada);
        }

        public void Desactivar(string fila, string nombre)
        {
            List<string> ListaModificada = new List<string>();

            foreach (var linea in File.ReadLines(RutaArchivo))
            {
                var dividir = linea.Split('|');

                if (dividir.Length >= 1 && nombre.Trim().Equals(dividir[0].Trim(), StringComparison.OrdinalIgnoreCase))
                {
                    dividir[2] = "False";
                }
                ListaModificada.Add(string.Join("|", dividir));
            }
            File.WriteAllLines(RutaArchivo, ListaModificada);
        }
    }
}
