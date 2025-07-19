using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_Final_Inventario.Entidades;
using Proyecto_Final_Inventario.Interfaces;

namespace Proyecto_Final_Inventario.Logica
{
    internal class ManejarInventario : Inventario, Iinventario
    {
        string RutaProductos = @"DLL\Products.txt";
    
        public void Entrada(string IDActual, int NuevaCantidad)
        {
            try
            {
                List<string> ListaModificada = new List<string>();

                foreach (var linea in File.ReadLines(RutaProductos))
                {
                    var dividir = linea.Split('|'); // separo la línea por el delimitador |

                    if (dividir[0] == IDActual) // si el ID coincide
                    {
                        int CantidadActual = int.Parse(dividir[4]); // obtengo la cantidad actual
                        int nuevacantidad = CantidadActual + NuevaCantidad; // sumo la nueva cantidad
                        dividir[4] = nuevacantidad.ToString(); // actualizo la cantidad en el arreglo

                        dividir[10] = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"); // actualizo la fecha de modificación
                    }

                    // Luego de recorrer el txt completo solo modifica la parte de cantidad y fecha y lo cierra con |
                    ListaModificada.Add(string.Join("|", dividir));
                }

                File.WriteAllLines(RutaProductos, ListaModificada); // sobreescribo el archivo con la nueva info

            }
            catch (Exception ex)
            {
                Log.EscribirLog(ex);
                MessageBox.Show("Ocurrió un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Salida(string IDActual, int NuevaCantidad)
        {
            try
            {
                List<string> ListaModificada = new List<string>();
                bool valido = false;

                foreach (var linea in File.ReadLines(RutaProductos))
                {
                    var dividir = linea.Split('|');

                    if (dividir[0] == IDActual)
                    {
                        int CantidadActual = int.Parse(dividir[4]);
                        if (CantidadActual >= NuevaCantidad)
                        {
                            int nuevacantidad = CantidadActual - NuevaCantidad;
                            dividir[4] = nuevacantidad.ToString();

                            // Actualiza la fecha de actualización a hoy
                            dividir[10] = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                            valido = true;
                        }
                        else
                        {
                            MessageBox.Show("El valor de salida no puede ser mayor a la cantidad del artículo", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return; // Salir sin modificar archivo
                        }
                    }
                    ListaModificada.Add(string.Join("|", dividir));
                }

                if (valido)
                    File.WriteAllLines(RutaProductos, ListaModificada);
            }
            catch (Exception ex)
            {
                Log.EscribirLog(ex);
                MessageBox.Show("Ocurrió un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        


        public List<Inventario> LeerProductos()
        {
           
                List<Inventario> lista = new List<Inventario>();

                foreach (var linea in File.ReadLines(RutaProductos))
                {

                    var dividir = linea.Split('|');

                    Inventario inven = new Inventario
                    {

                        ID = dividir[0],
                        Nombre = dividir[1],
                        Categoria = dividir[2],
                        Proveedor = dividir[3],
                        Cantidad = int.Parse(dividir[4]),
                        PrecioVenta = dividir[5],
                        PrecioCompra = dividir[6],
                        Activo = Convert.ToBoolean(dividir[7]),
                        UrlImagenes = dividir[8],
                        FechaCreacion = DateTime.Parse(dividir[9]),
                        FechaActualizacion = DateTime.Parse(dividir[10])
                    };
                    lista.Add(inven);
                }
                return lista;
            
        }

        public void Activar(string Row, string id)
        {
            List<string> ListaModificada = new List<string>();

            foreach (var linea in File.ReadLines(RutaProductos))
            {

                var dividir = linea.Split('|');

                if (dividir[0] == id)
                {
                    dividir[7] = "True";
                }
                ListaModificada.Add(string.Join("|", dividir));
            }
            File.WriteAllLines(RutaProductos, ListaModificada);
        }

        public void Desactivar(string Row, string id)
        {
            List<string> ListaModificada = new List<string>();

            foreach (var linea in File.ReadLines(RutaProductos))
            {

                var dividir = linea.Split('|');

                if (dividir[0] == id)
                {
                    dividir[7] = "False";
                }
                ListaModificada.Add(string.Join("|", dividir));
            }
            File.WriteAllLines(RutaProductos, ListaModificada);
        }

        public List<Inventario> filtrar(string texto)
        {

            texto.Trim().ToLower();

            var listafiltrada = LeerProductos().Where(c => c.Nombre.ToLower().Contains(texto)
            || c.Proveedor.ToLower().Contains(texto) || c.PrecioCompra.Contains(texto) ||
             c.Categoria.ToLower().Contains(texto) || c.PrecioVenta.Contains(texto) ||
             c.ID.Contains(texto)).ToList();

            return listafiltrada;
        }

        public List<Inventario> filtroCategoria(string texto)
        {


            texto = texto.Trim().ToLower();

            var listafiltrada = LeerProductos().Where(c =>
                c.Categoria != null && c.Categoria.ToLower().Contains(texto)).ToList();

            return listafiltrada;
        }

    }
}
