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
    public class CrearProducto: Productos, IProduct
    {
    

        string RutaProducts = @"DLL\Products.txt"; // ruta donde se alojaran los productos creados

        public void CreacionProducto(Productos product)
        {
            try {

                int IdUnico = product._Id;
                foreach (var line in File.ReadAllLines(RutaProducts)) {

                    var dividir = line.Split('|');

                    if (IdUnico == int.Parse(dividir[0]))
                    {

                        MessageBox.Show("El ID ingresado ya esta en uso ", "ID Existente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (_Nombre == (dividir[1]))
                    {

                        MessageBox.Show("El Producto ya existe", "Producto duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    product._FechaCreacion = DateTime.Now;
                    product._FechaActualizacion = DateTime.Now;
                }

                product._FechaCreacion = DateTime.Now;
                product._FechaActualizacion = DateTime.Now;
                string fmt = "yyyy-MM-dd HH:mm:ss";
                //crea la linea con los valores separados por |
                string linea = $"{product._Id.ToString().Trim().ToLower()}|{product._Nombre.Trim().ToLower()}|{product._Categoria.Trim().ToLower()}|{product._Proveedor.ToString().Trim().ToLower()}|" +
                               $"{product._Cantidad.ToString().Trim()}|{product._PrecioVenta.ToString().Trim()}|{product._PrecioCompra.ToString().Trim()}|{product._Activo.ToString().Trim()}|{product._UrlImagen.ToString()}|" +
                               $"{product._FechaCreacion.ToString(fmt)}|{product._FechaActualizacion.ToString(fmt)}";

                if (product._PrecioVenta < 0 || product._PrecioCompra < 0)
                {
                    MessageBox.Show("Los precios de venta y compra deben ser mayores o iguales a cero.", "Error de Precio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //A la ruta especificada agrega el producto + en una nueva linea
                string todo = File.ReadAllText(RutaProducts);
                if (!todo.EndsWith(Environment.NewLine))
                {
                    File.AppendAllText(RutaProducts, Environment.NewLine);
                }

                File.AppendAllText(RutaProducts, linea + Environment.NewLine);

                MessageBox.Show("Producto creado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                Log.EscribirLog(ex);
                MessageBox.Show("Ocurrió un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void EditarProducto(Productos product)
        {
            try
            {
                List<string> lineasModificadas = new List<string>();

                foreach (var line in File.ReadAllLines(RutaProducts))
                {
                    var dividir = line.Split('|');

                    if (product._PrecioVenta < 0 || product._PrecioCompra < 0)
                    {
                        MessageBox.Show("Los precios de venta y compra deben ser mayores o iguales a cero.", "Error de Precio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    _FechaActualizacion = DateTime.Now;
                    string fmt = "yyyy-MM-dd HH:mm:ss";
                    if (product._Id == int.Parse(dividir[0]))// Verifica si el ID coincide (es el producto que quiero editar)
                    {
                        string fechaCreacionOriginal = dividir[9];
                        product._FechaActualizacion = DateTime.Now;
                        // Si coincide, creo una nueva línea con los datos actualizados
                        string nuevaLinea = $"{product._Id.ToString().Trim().ToLower()}|{product._Nombre.Trim().ToLower()}|{product._Categoria.Trim().ToLower()}|{product._Proveedor.ToString().Trim().ToLower()}|" +
                                            $"{product._Cantidad.ToString().Trim()}|{product._PrecioVenta.ToString().Trim()}|{product._PrecioCompra.ToString().Trim()}|{product._Activo.ToString().Trim()}|{product._UrlImagen.ToString()}|" +
                                            $"{fechaCreacionOriginal}|{product._FechaActualizacion.ToString(fmt)}";

                        lineasModificadas.Add(nuevaLinea);// Agrego la línea nueva (editada)
                    }
                    else
                    {
                        // Esta línea no se edita, así que se conserva tal cual
                        lineasModificadas.Add(line);
                    }
                }


                string todo = File.ReadAllText(RutaProducts);
                if (!todo.EndsWith(Environment.NewLine)) // si todo no acaba con en \n lo fuerza
                {
                    File.AppendAllText(RutaProducts, Environment.NewLine);
                }
                // Escribe todas las líneas (con la modificada) en el archivo
                File.WriteAllLines(RutaProducts, lineasModificadas);
                MessageBox.Show("Producto Editado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                Log.EscribirLog(ex);
                MessageBox.Show("Ocurrió un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    


        public static bool ValidarEditar(string ID)
        {
            string RutaProducts = @"DLL\Products.txt"; // ruta donde se alojaran los productos creados

            bool x = false;
            foreach (var linea in File.ReadLines(RutaProducts))
            {

                var dividir = linea.Split('|');

                if (dividir[0] == ID)
                {
                    x= true;
                    break;
                }
            }

            return x;
        }
        
        // Este método busca un producto en el archivo por su ID
        public Productos BuscarProducto(string id)
        {
            try
            {
                // Recorro todas las líneas del archivo de productos
                foreach (var linea in File.ReadLines(RutaProducts))
                {
                    var dividir = linea.Split('|'); // separo los campos por el |

                    if (dividir[0] == id) // si el ID coincide con el que busco
                    {
                        // retorno un objeto Productos con todos los valores llenos
                        return new Productos
                        {
                            _Id = int.Parse(dividir[0]),
                            _Nombre = dividir[1],
                            _Categoria = dividir[2],
                            _Proveedor = dividir[3],
                            _Cantidad = int.Parse(dividir[4]),
                            _PrecioVenta = double.Parse(dividir[5]),
                            _PrecioCompra = double.Parse(dividir[6]),
                            _Activo = bool.Parse(dividir[7]),
                            _UrlImagen = dividir[8],
                            _FechaCreacion = DateTime.Parse(dividir[9]),
                            _FechaActualizacion = DateTime.Parse(dividir[10])
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                Log.EscribirLog(ex);
                MessageBox.Show("Ocurrió un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

    }       
}
