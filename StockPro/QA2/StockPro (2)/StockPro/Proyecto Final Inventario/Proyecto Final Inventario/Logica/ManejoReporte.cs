//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace Proyecto_Final_Inventario.Logica
//{
//    internal class ManejoReporte
//    {
//        // Ruta donde se guardarán por defecto los reportes dentro de la carpeta del proyecto
//        private string CarpetaReportes = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Reportes");

//        //genera un archivo .csv con todos los productos del inventario
//        public void GenerarReporteInventario(List<Inventario> productos)
//        {
//            try
//            {
//                // Verifica si la carpeta "Reportes" existe, si no la crea
//                if (!Directory.Exists(CarpetaReportes))
//                {
//                    Directory.CreateDirectory(CarpetaReportes);
//                }

//                // Crea el contenido del archivo en formato CSV
//                StringBuilder contenido = new StringBuilder();

//                // Agrega los títulos de las columnas
//                contenido.AppendLine("ID,Nombre,Categoria,Proveedor,Cantidad,PrecioVenta,PrecioCompra,Activo,UrlImagen,FechaCreacion,FechaActualizacion");

//                // Recorre la lista y agrega cada producto
//                foreach (var p in productos)
//                {
//                    contenido.AppendLine($"{p.ID},{p.Nombre},{p.Categoria},{p.Proveedor},{p.Cantidad},{p.PrecioVenta},{p.PrecioCompra},{p.Activo},{p.UrlImagenes},{p.FechaCreacion:yyyy-MM-dd HH:mm:ss},{p.FechaActualizacion:yyyy-MM-dd HH:mm:ss}");
//                }

//                // Muestra el diálogo para que el usuario elija dónde guardar el archivo
//                using (SaveFileDialog guardar = new SaveFileDialog())
//                {
//                    guardar.Title = "Guardar Reporte de Inventario";
//                    guardar.Filter = "Archivo CSV (*.csv)|*.csv";
//                    guardar.InitialDirectory = CarpetaReportes;
//                    guardar.FileName = $"ReporteInventario_{DateTime.Now:yyyyMMdd_HHmmss}.csv";

//                    if (guardar.ShowDialog() == DialogResult.OK)
//                    {
//                        File.WriteAllText(guardar.FileName, contenido.ToString(), Encoding.UTF8);
//                        MessageBox.Show("Reporte generado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
//                    }
//                }
//            }
//            catch (Exception ex)
//            {
//                Log.EscribirLog(ex);
//                MessageBox.Show("Ocurrió un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }

//        }
//        public void GenerarReportePorFecha(List<Inventario> productos, DateTime desde, DateTime hasta)
//        {
//            try
//            {
//                // Verifica si la carpeta "Reportes" existe, si no la crea
//                if (!Directory.Exists(CarpetaReportes))
//                {
//                    Directory.CreateDirectory(CarpetaReportes);
//                }

//                // Filtra los productos por la fecha de creación
//                var filtrados = productos
//                .Where(p => p.FechaActualizacion.Date >= desde.Date && p.FechaActualizacion.Date <= hasta.Date)
//                .ToList();

//                // Crea el contenido del archivo en formato CSV
//                StringBuilder contenido = new StringBuilder();

//                // Agrega los títulos de las columnas
//                contenido.AppendLine("ID,Nombre,Categoria,Proveedor,Cantidad,PrecioVenta,PrecioCompra,Activo,UrlImagen,FechaCreacion,FechaActualizacion");

//                // Recorre los productos filtrados y los agrega
//                foreach (var p in filtrados)
//                {
//                    contenido.AppendLine($"{p.ID},{p.Nombre},{p.Categoria},{p.Proveedor},{p.Cantidad},{p.PrecioVenta},{p.PrecioCompra},{p.Activo},{p.UrlImagenes},{p.FechaCreacion:yyyy-MM-dd HH:mm:ss},{p.FechaActualizacion:yyyy-MM-dd HH:mm:ss}");
//                }

//                // Muestra el diálogo para que el usuario elija dónde guardar el archivo
//                using (SaveFileDialog guardar = new SaveFileDialog())
//                {
//                    guardar.Title = "Guardar Reporte por Rango de Fecha";
//                    guardar.Filter = "Archivo CSV (*.csv)|*.csv";
//                    guardar.InitialDirectory = CarpetaReportes;
//                    guardar.FileName = $"ReportePorFecha_{DateTime.Now:yyyyMMdd_HHmmss}.csv";

//                    if (guardar.ShowDialog() == DialogResult.OK)
//                    {
//                        File.WriteAllText(guardar.FileName, contenido.ToString(), Encoding.UTF8);
//                        MessageBox.Show("Reporte por fecha generado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
//                    }

//                }
//            }catch (Exception ex){
//                Log.EscribirLog(ex);
//                MessageBox.Show("Ocurrió un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }
        
//        }

//        internal void GenerarReporteInventario(List<Productos> productos)
//        {
//            throw new NotImplementedException();
//        }

//        internal void GenerarReportePorFecha(List<Productos> productos, DateTime desde, DateTime hasta)
//        {
//            throw new NotImplementedException();
//        }
//    }
//}
