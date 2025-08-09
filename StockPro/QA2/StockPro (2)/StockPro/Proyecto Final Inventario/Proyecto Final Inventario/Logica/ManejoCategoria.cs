using Proyecto_Final_Inventario.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Proyecto_Final_Inventario.Logica
{
    internal class ManejoCategoria : ICategoria, IDisposable
    {
        private readonly STOCKPROEntities db = new STOCKPROEntities();

        public void CrearCategoria(Categorias categoria)
        {
            if (categoria == null)
            {
                MessageBox.Show("La categoría no puede ser nula");
                return;
            }

            try
            {
                bool existe = db.Categorias
                    .Any(c => c.Nombre.Trim().Equals(categoria.Nombre.Trim(), StringComparison.OrdinalIgnoreCase));

                if (existe)
                {
                    MessageBox.Show("Esta categoría ya existe");
                    return;
                }

                var nuevaCategoria = new Categorias
                {
                    Nombre = categoria.Nombre.Trim(),
                    Descripcion = categoria.Descripcion?.Trim() ?? string.Empty,
                    Estado = string.IsNullOrEmpty(categoria.Estado) ? "T" : categoria.Estado,
                    FechaCreacion = categoria.FechaCreacion ?? DateTime.Now
                };

                db.Categorias.Add(nuevaCategoria);
                db.SaveChanges();

                MessageBox.Show("Categoría creada exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear la categoría: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // NUEVO método para editar categoría
        public void EditarCategoria(string nombreOriginal, Categorias categoriaEditada)
        {
            try
            {
                var categoria = db.Categorias.FirstOrDefault(c => c.Nombre == nombreOriginal);
                if (categoria == null)
                {
                    MessageBox.Show("No se encontró la categoría para editar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validar si el nuevo nombre ya existe (y no es el mismo registro)
                if (!categoria.Nombre.Equals(categoriaEditada.Nombre.Trim(), StringComparison.OrdinalIgnoreCase))
                {
                    bool nombreRepetido = db.Categorias
                        .Any(c => c.Nombre.Trim().Equals(categoriaEditada.Nombre.Trim(), StringComparison.OrdinalIgnoreCase));
                    if (nombreRepetido)
                    {
                        MessageBox.Show("Ya existe una categoría con ese nombre.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                categoria.Nombre = categoriaEditada.Nombre.Trim();
                categoria.Descripcion = categoriaEditada.Descripcion?.Trim() ?? string.Empty;
                categoria.Estado = string.IsNullOrEmpty(categoriaEditada.Estado) ? "T" : categoriaEditada.Estado;
                categoria.FechaCreacion = categoriaEditada.FechaCreacion ?? categoria.FechaCreacion;

                db.SaveChanges();

                MessageBox.Show("Categoría actualizada exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al editar la categoría: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public List<Categorias> CargarCategorias()
        {
            try
            {
                return db.Categorias.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar categorías: " + ex.Message);
                return new List<Categorias>();
            }
        }

        public List<string> CargarCombobox()
        {
            try
            {
                return db.Categorias
                    .Where(c => c.Estado == "T")
                    .Select(c => c.Nombre)
                    .ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar categorías para ComboBox: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<string>();
            }
        }

        public void Activar(string nombre)
        {
            CambiarEstadoCategoria(nombre, "T", "activar");
        }

        public void Desactivar(string nombre)
        {
            CambiarEstadoCategoria(nombre, "F", "desactivar");
        }

        private void CambiarEstadoCategoria(string nombre, string estado, string accion)
        {
            try
            {
                var categoria = db.Categorias.FirstOrDefault(c => c.Nombre == nombre);
                if (categoria == null)
                {
                    MessageBox.Show($"No se encontró la categoría para {accion}", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                categoria.Estado = estado;
                db.SaveChanges();

                MessageBox.Show($"Categoría {accion}da exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al {accion} la categoría: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}
