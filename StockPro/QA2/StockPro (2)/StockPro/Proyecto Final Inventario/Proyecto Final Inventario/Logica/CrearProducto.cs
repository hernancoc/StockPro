using System;
using System.Data.SqlClient;
using Proyecto_Final_Inventario;

namespace Proyecto_Final_Inventario.Logica
{
    public class CrearProducto
    {
        // Cambié el nombre del campo para evitar ambigüedad
        private readonly string _connectionString = @"Server=DESKTOP-8OQ8KG1;Database=STOCKPRO;Trusted_Connection=True;";

        // Crear producto en BD - NO usa IDProductos, se ignora si se manda
        public void CreacionProducto(Productos producto)
        {
            // Validación: el IDProductos debe ser 0 o no asignado en creación
            if (producto.IDProductos > 0)
            {
                throw new ArgumentException("No se debe asignar IDProductos al crear un nuevo producto.");
            }

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                string query = @"
                    INSERT INTO Productos 
                    (Nombre, IDCategorias, Proveedor, Cantidad_Inicial, Precio_Venta, Precio_Compra, Estado, RutaImagenes, FechaCreacion, FechaActualizacion)
                    VALUES
                    (@Nombre, @IDCategorias, @Proveedor, @Cantidad_Inicial, @Precio_Venta, @Precio_Compra, @Estado, @RutaImagenes, @FechaCreacion, @FechaActualizacion)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Nombre", producto.Nombre ?? string.Empty);
                    cmd.Parameters.AddWithValue("@IDCategorias", producto.IDCategorias > 0 ? (object)producto.IDCategorias : DBNull.Value);
                    cmd.Parameters.AddWithValue("@Proveedor", producto.Proveedor ?? string.Empty);
                    cmd.Parameters.AddWithValue("@Cantidad_Inicial", producto.Cantidad_Inicial ?? 0);
                    cmd.Parameters.AddWithValue("@Precio_Venta", producto.Precio_Venta);
                    cmd.Parameters.AddWithValue("@Precio_Compra", producto.Precio_Compra);
                    cmd.Parameters.AddWithValue("@Estado", producto.Estado ?? "F");
                    cmd.Parameters.AddWithValue("@RutaImagenes", producto.RutaImagenes ?? string.Empty);
                    cmd.Parameters.AddWithValue("@FechaCreacion", producto.FechaCreacion ?? DateTime.Now);
                    cmd.Parameters.AddWithValue("@FechaActualizacion", producto.FechaActualizacion ?? DateTime.Now);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Editar producto en BD (usa IDProductos para identificar qué actualizar)
        public void EditarProducto(Productos producto)
        {
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                string query = @"
                    UPDATE Productos SET
                        Nombre = @Nombre,
                        IDCategorias = @IDCategorias,
                        Proveedor = @Proveedor,
                        Cantidad_Inicial = @Cantidad_Inicial,
                        Precio_Venta = @Precio_Venta,
                        Precio_Compra = @Precio_Compra,
                        Estado = @Estado,
                        RutaImagenes = @RutaImagenes,
                        FechaActualizacion = @FechaActualizacion
                    WHERE IDProductos = @IDProductos";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Nombre", producto.Nombre ?? string.Empty);
                    cmd.Parameters.AddWithValue("@IDCategorias", producto.IDCategorias > 0 ? (object)producto.IDCategorias : DBNull.Value);
                    cmd.Parameters.AddWithValue("@Proveedor", producto.Proveedor ?? string.Empty);
                    cmd.Parameters.AddWithValue("@Cantidad_Inicial", producto.Cantidad_Inicial ?? 0);
                    cmd.Parameters.AddWithValue("@Precio_Venta", producto.Precio_Venta);
                    cmd.Parameters.AddWithValue("@Precio_Compra", producto.Precio_Compra);
                    cmd.Parameters.AddWithValue("@Estado", producto.Estado ?? "F");
                    cmd.Parameters.AddWithValue("@RutaImagenes", producto.RutaImagenes ?? string.Empty);
                    cmd.Parameters.AddWithValue("@FechaActualizacion", producto.FechaActualizacion ?? DateTime.Now);
                    cmd.Parameters.AddWithValue("@IDProductos", producto.IDProductos);

                    con.Open();
                    int filasAfectadas = cmd.ExecuteNonQuery();

                    if (filasAfectadas == 0)
                    {
                        throw new Exception("No se encontró el producto para actualizar.");
                    }
                }
            }
        }

        // Buscar producto con JOIN para traer nombre de categoría
        public Productos BuscarProductoConCategoria(string id)
        {
            if (!int.TryParse(id, out int idProd))
                return null;

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                string query = @"
                    SELECT p.*, c.Nombre AS NombreCategoria
                    FROM Productos p
                    LEFT JOIN Categorias c ON p.IDCategorias = c.IDCategorias
                    WHERE p.IDProductos = @IDProductos";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@IDProductos", idProd);
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Productos
                            {
                                IDProductos = (int)reader["IDProductos"],
                                Nombre = reader["Nombre"].ToString(),
                                IDCategorias = reader["IDCategorias"] == DBNull.Value ? 0 : Convert.ToInt32(reader["IDCategorias"]),
                                Categoria = reader["NombreCategoria"]?.ToString() ?? string.Empty,
                                Proveedor = reader["Proveedor"].ToString(),
                                Cantidad_Inicial = reader["Cantidad_Inicial"] == DBNull.Value ? (int?)null : Convert.ToInt32(reader["Cantidad_Inicial"]),
                                Precio_Venta = (decimal)reader["Precio_Venta"],
                                Precio_Compra = (decimal)reader["Precio_Compra"],
                                Estado = reader["Estado"].ToString(),
                                RutaImagenes = reader["RutaImagenes"].ToString(),
                                FechaCreacion = reader["FechaCreacion"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(reader["FechaCreacion"]),
                                FechaActualizacion = reader["FechaActualizacion"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(reader["FechaActualizacion"])
                            };
                        }
                    }
                }
            }
            return null;
        }

        // Validar si existe producto
        public bool ValidarEditar(string id)
        {
            if (!int.TryParse(id, out int idProd))
                return false;

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                string query = "SELECT COUNT(*) FROM Productos WHERE IDProductos = @IDProductos";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@IDProductos", idProd);
                    con.Open();
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }
    }
}
