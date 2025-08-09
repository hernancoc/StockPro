using Proyecto_Final_Inventario.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Proyecto_Final_Inventario.Logica
{
    internal class ManejarInventario : Iinventario
    {
        public void Entrada(int idProducto, int nuevaCantidad)
        {
            try
            {
                var db = new STOCKPROEntities();
                var producto = db.Productos.FirstOrDefault(p => p.IDProductos == idProducto);
                if (producto == null)
                {
                    MessageBox.Show("Producto no encontrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                producto.Cantidad_Inicial = (producto.Cantidad_Inicial ?? 0) + nuevaCantidad;
                producto.FechaActualizacion = DateTime.Now;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al actualizar la entrada: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Salida(int idProducto, int cantidadSalida)
        {
            try
            {
                var db = new STOCKPROEntities();
                var producto = db.Productos.FirstOrDefault(p => p.IDProductos == idProducto);
                if (producto == null)
                {
                    MessageBox.Show("Producto no encontrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int cantidadActual = producto.Cantidad_Inicial ?? 0;
                if (cantidadActual < cantidadSalida)
                {
                    MessageBox.Show("El valor de salida no puede ser mayor a la cantidad del artículo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                producto.Cantidad_Inicial = cantidadActual - cantidadSalida;
                producto.FechaActualizacion = DateTime.Now;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al actualizar la salida: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public List<Productos> LeerProductos()
        {
           

            try
            {

                var db = new STOCKPROEntities();


                return db.Productos.Include("Categorias").ToList();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al cargar productos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<Productos>();
            }

        }

        public void Activar(int idProducto)
        {
            try
            {
                var db = new STOCKPROEntities();
                var producto = db.Productos.FirstOrDefault(p => p.IDProductos == idProducto);
                if (producto == null)
                {
                    MessageBox.Show("Producto no encontrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                producto.Estado = "T";
                producto.FechaActualizacion = DateTime.Now;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al activar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Desactivar(int idProducto)
        {
            try
            {   
                var db = new STOCKPROEntities();
                var producto = db.Productos.FirstOrDefault(p => p.IDProductos == idProducto);
                if (producto == null)
                {
                    MessageBox.Show("Producto no encontrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                producto.Estado = "F";
                producto.FechaActualizacion = DateTime.Now;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al desactivar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public List<Productos> Filtrar(string texto)
        {
            try
            {
                texto = texto?.Trim().ToLower() ?? "";

                 var db = new STOCKPROEntities();

                var listaFiltrada = db.Productos.Where(p =>
                    (p.Nombre != null && p.Nombre.ToLower().Contains(texto)) ||
                    (p.Proveedor != null && p.Proveedor.ToLower().Contains(texto)) ||
                    (p.Categorias != null && p.Categorias.Nombre != null && p.Categorias.Nombre.ToLower().Contains(texto)) ||
                    p.Precio_Compra.ToString().Contains(texto) ||
                    p.Precio_Venta.ToString().Contains(texto) ||
                    p.IDProductos.ToString().Contains(texto)
                ).ToList();

                return listaFiltrada;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al filtrar productos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<Productos>();
            }
        }

        public List<Productos> FiltroCategoria(string texto)
        {
            try
            {
                texto = texto?.Trim().ToLower() ?? "";

                 var db = new STOCKPROEntities();

                var listaFiltrada = db.Productos
                    .Where(p => p.Categorias != null && p.Categorias.Nombre != null && p.Categorias.Nombre.ToLower().Contains(texto))
                    .ToList();

                return listaFiltrada;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al filtrar por categoría: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<Productos>();
            }
        }
    }
}
