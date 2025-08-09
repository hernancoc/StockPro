using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Proyecto_Final_Inventario.Logica;

namespace Proyecto_Final_Inventario.PL
{
    public partial class UCInventario : UserControl
    {
        // Carpeta base donde se almacenan las imágenes (puedes cambiarla)
        private readonly string carpetaImagenes = Path.Combine(Application.StartupPath, "ImagenesProductos");

        public UCInventario()
        {
            InitializeComponent();
        }

        private void UCInventario_Load(object sender, EventArgs e)
        {
            CargarDatosIniciales();
        }

        private void CargarDatosIniciales()
        {
            ManejarInventario inventarioManager = new ManejarInventario();
            DGVInventario.DataSource = inventarioManager.LeerProductos();

            DGVInventario.EnableHeadersVisualStyles = false;
            DGVInventario.ColumnHeadersDefaultCellStyle.SelectionBackColor = DGVInventario.ColumnHeadersDefaultCellStyle.BackColor;

            ManejoCategoria manejoCategoria = new ManejoCategoria();
            TxtCategoriaDeProducto.Items.Clear();
            TxtCategoriaDeProducto.Items.AddRange(manejoCategoria.CargarCombobox().ToArray());

            OcultarBotonesYControles();
            RefrescarDGV();
        }

        private void OcultarBotonesYControles()
        {
            BtnEntrada.Visible = false;
            BtnSalida.Visible = false;
            BtnGuardar.Visible = false;
            CbActivar.Visible = false;
            CBDesactivar.Visible = false;
            NUDEntrada_Salida.Visible = false;

            BtnEntrada.Enabled = true;
            BtnSalida.Enabled = true;
            CbActivar.Checked = false;
            CBDesactivar.Checked = false;
            TxtFiltrar.Clear();
            TxtCategoriaDeProducto.SelectedIndex = -1;

            // Liberar imagen y evitar bloqueo del archivo
            if (pbimagen.Image != null)
            {
                pbimagen.Image.Dispose();
                pbimagen.Image = null;
            }
        }

        private void DGVInventario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MostrarControlesSegunEstado();
        }

        private void DGVInventario_Click(object sender, EventArgs e)
        {
            MostrarControlesSegunEstado();
        }

        private void MostrarControlesSegunEstado()
        {
            if (DGVInventario.CurrentRow == null) return;

            var estado = DGVInventario.CurrentRow.Cells["Estado"].Value?.ToString();
            var rutaImagen = DGVInventario.CurrentRow.Cells["RutaImagenes"].Value?.ToString();

            BtnGuardar.Visible = true;
            NUDEntrada_Salida.Visible = true;

            if (estado == "T" || estado == "True")
            {
                BtnEntrada.Visible = true;
                BtnSalida.Visible = true;
                CbActivar.Visible = false;
                CBDesactivar.Visible = true;
            }
            else
            {
                BtnEntrada.Visible = false;
                BtnSalida.Visible = false;
                NUDEntrada_Salida.Visible = false;
                CbActivar.Visible = true;
                CBDesactivar.Visible = false;
            }

            // Cargar imagen desde la ruta completa: carpeta base + nombre archivo (rutaImagen)
            if (!string.IsNullOrEmpty(rutaImagen))
            {
                string rutaCompleta = Path.Combine(carpetaImagenes, rutaImagen);

                if (File.Exists(rutaCompleta))
                {
                    try
                    {
                        // Liberar imagen anterior para evitar bloqueo de archivo
                        if (pbimagen.Image != null)
                        {
                            pbimagen.Image.Dispose();
                            pbimagen.Image = null;
                        }

                        using (var bmpTemp = new Bitmap(rutaCompleta))
                        {
                            pbimagen.Image = new Bitmap(bmpTemp);
                        }
                        pbimagen.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                    catch
                    {
                        pbimagen.Image = null;
                    }
                }
                else
                {
                    pbimagen.Image = null;
                }
            }
            else
            {
                pbimagen.Image = null;
            }

            DGVInventario.Refresh();
        }

        private void BtnEntrada_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnSalida_Click(object sender, EventArgs e)
        {
       
        }

        private void ActualizarInventarioYResetUI(ManejarInventario inventarioManager)
        {
            var productos = inventarioManager.LeerProductos();

            DGVInventario.DataSource = inventarioManager.LeerProductos();

            RefrescarDGV();
            OcultarBotonesYControles();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
     
        }

        private void RefrescarDGV()
        {
            ManejarInventario ManejarInventario = new ManejarInventario();

            var productos = ManejarInventario.LeerProductos();

            var productosParaMostrar = productos.Select(p => new
            {
                IDProductos = p.IDProductos,
                Nombre = p.Nombre,
                Categoria = p.Categorias != null ? p.Categorias.Nombre : "Sin categoría",
                Proveedor = p.Proveedor,
                Cantidad = p.Cantidad_Inicial,
                PrecioVenta = p.Precio_Venta,
                PrecioCompra = p.Precio_Compra,
                Estado = p.Estado,
                RutaImagenes = p.RutaImagenes
            }).ToList();

            DGVInventario.DataSource = productosParaMostrar;

            if (DGVInventario.Columns.Contains("RutaImagenes"))
                DGVInventario.Columns["RutaImagenes"].Visible = false;
            if (DGVInventario.Columns.Contains("FechaCreacion"))
                DGVInventario.Columns["FechaCreacion"].Visible = false;
            if (DGVInventario.Columns.Contains("FechaActualizacion"))
                DGVInventario.Columns["FechaActualizacion"].Visible = false;

            DGVInventario.ClearSelection();
            DGVInventario.Refresh();

           // AplicarColoresPorCantidad();
        }

        private void AplicarColoresPorCantidad()
        {
            foreach (DataGridViewRow fila in DGVInventario.Rows)
            {
                if (int.TryParse(fila.Cells["Cantidad_Inicial"].Value?.ToString(), out int cantidad))
                {
                    if (cantidad == 0)
                    {
                        fila.DefaultCellStyle.BackColor = Color.Red;
                        fila.DefaultCellStyle.ForeColor = Color.White;
                    }
                    else if (cantidad > 0 && cantidad <= 5)
                    {
                        fila.DefaultCellStyle.BackColor = Color.Yellow;
                        fila.DefaultCellStyle.ForeColor = Color.Black;
                    }
                    else if (cantidad > 5)
                    {
                        fila.DefaultCellStyle.BackColor = Color.LightGreen;
                        fila.DefaultCellStyle.ForeColor = Color.Black;
                    }
                }
            }
        }

        private void TxtFiltrar_TextChanged(object sender, EventArgs e)
        {
            ResetearFiltrosColor();
            AplicarFiltro();
        }

        private void AplicarFiltro()
        {
            ManejarInventario inventarioManager = new ManejarInventario();
            var productosFiltrados = inventarioManager.Filtrar(TxtFiltrar.Text.Trim());
            DGVInventario.DataSource = productosFiltrados;
            RefrescarDGV();
        }

        private void ResetearFiltrosColor()
        {
            RBAmarillo.Checked = false;
            RBverde.Checked = false;
            RbTodos.Checked = false;
            RBrojo.Checked = false;
            TxtCategoriaDeProducto.SelectedIndex = -1;
        }

        private void RbTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (RbTodos.Checked)
            {
                RefrescarDGV();
            }
        }

        private void RBrojo_CheckedChanged(object sender, EventArgs e)
        {
            if (RBrojo.Checked)
            {
                RefrescarDGV();

                foreach (DataGridViewRow fila in DGVInventario.Rows)
                {
                    if (int.TryParse(fila.Cells["Cantidad_Inicial"].Value?.ToString(), out int cantidad))
                    {
                        if (cantidad != 0)
                        {
                            fila.DefaultCellStyle.BackColor = DGVInventario.DefaultCellStyle.BackColor;
                            fila.DefaultCellStyle.ForeColor = DGVInventario.DefaultCellStyle.ForeColor;
                        }
                    }
                }
            }
        }

        private void RBAmarillo_CheckedChanged(object sender, EventArgs e)
        {
            if (RBAmarillo.Checked)
            {
                RefrescarDGV();

                foreach (DataGridViewRow fila in DGVInventario.Rows)
                {
                    if (int.TryParse(fila.Cells["Cantidad_Inicial"].Value?.ToString(), out int cantidad))
                    {
                        if (cantidad == 0 || cantidad > 5)
                        {
                            fila.DefaultCellStyle.BackColor = DGVInventario.DefaultCellStyle.BackColor;
                            fila.DefaultCellStyle.ForeColor = DGVInventario.DefaultCellStyle.ForeColor;
                        }
                        else if (cantidad > 0 && cantidad <= 5)
                        {
                            fila.DefaultCellStyle.BackColor = Color.Yellow;
                            fila.DefaultCellStyle.ForeColor = Color.Black;
                        }
                    }
                }
            }
        }

        private void RBverde_CheckedChanged(object sender, EventArgs e)
        {
            if (RBverde.Checked)
            {
                RefrescarDGV();

                foreach (DataGridViewRow fila in DGVInventario.Rows)
                {
                    if (int.TryParse(fila.Cells["Cantidad_Inicial"].Value?.ToString(), out int cantidad))
                    {
                        if (cantidad <= 5)
                        {
                            fila.DefaultCellStyle.BackColor = DGVInventario.DefaultCellStyle.BackColor;
                            fila.DefaultCellStyle.ForeColor = DGVInventario.DefaultCellStyle.ForeColor;
                        }
                        else if (cantidad > 5)
                        {
                            fila.DefaultCellStyle.BackColor = Color.LightGreen;
                            fila.DefaultCellStyle.ForeColor = Color.Black;
                        }
                    }
                }
            }
        }

   

  

        private void FiltrarPorEstado(bool activos)
        {
            ManejarInventario inventarioManager = new ManejarInventario();
            var productos = inventarioManager.LeerProductos();

            var filtrados = productos.Where(p =>
                (p.Estado == "T" || p.Estado == "True") == activos
            ).ToList();

            DGVInventario.DataSource = filtrados;

            ResetearFiltrosColor();
            RefrescarDGV();
            TxtCategoriaDeProducto.SelectedIndex = -1;
        }

        private void TxtCategoriaDeProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetearFiltrosColor();

            if (TxtCategoriaDeProducto.SelectedIndex < 0)
            {
                AplicarFiltro();
                return;
            }

            ManejarInventario inventarioManager = new ManejarInventario();
            var filtrados = inventarioManager.FiltroCategoria(TxtCategoriaDeProducto.Text.Trim());

            DGVInventario.DataSource = filtrados;
            RefrescarDGV();
        }

        private void DGVInventario_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MostrarControlesSegunEstado();
        }

        private void BtnGuardar_Click_1(object sender, EventArgs e)
        {
            if (DGVInventario.CurrentRow == null) return;

            int idProducto = Convert.ToInt32(DGVInventario.CurrentRow.Cells["IDProductos"].Value);

            ManejarInventario inventarioManager = new ManejarInventario();

            if (CbActivar.Checked)
                inventarioManager.Activar(idProducto);
            else if (CBDesactivar.Checked)
                inventarioManager.Desactivar(idProducto);
            else
            {
                MessageBox.Show("Seleccione una opción para activar o desactivar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DGVInventario.DataSource = inventarioManager.LeerProductos();
            RefrescarDGV();
            OcultarBotonesYControles();
        }

        private void BtnSalida_Click_1(object sender, EventArgs e)
        {
             if (DGVInventario.CurrentRow == null) return;

            int idProducto = Convert.ToInt32(DGVInventario.CurrentRow.Cells["IDProductos"].Value);
            int cantidad = Convert.ToInt32(NUDEntrada_Salida.Value);

            if (cantidad <= 0)
            {
                MessageBox.Show("Ingrese una cantidad mayor a cero.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ManejarInventario inventarioManager = new ManejarInventario();
            inventarioManager.Salida(idProducto, cantidad);

            ActualizarInventarioYResetUI(inventarioManager);
        }

        private void BtnEntrada_Click_1(object sender, EventArgs e)
        {
            if (DGVInventario.CurrentRow == null) return;

            int idProducto = Convert.ToInt32(DGVInventario.CurrentRow.Cells["IDProductos"].Value);
            int cantidad = Convert.ToInt32(NUDEntrada_Salida.Value);

            if (cantidad <= 0)
            {
                MessageBox.Show("Ingrese una cantidad mayor a cero.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ManejarInventario inventarioManager = new ManejarInventario();
            inventarioManager.Entrada(idProducto, cantidad);

            ActualizarInventarioYResetUI(inventarioManager);
        }

        private void CbActivar_CheckedChanged(object sender, EventArgs e)
        {
            if (RbActivos.Checked)
            {
                RbDesactivos.Checked = false;
                FiltrarPorEstado(true);
            }

        }

        private void RbDesactivos_CheckedChanged_1(object sender, EventArgs e)
        {
            if (RbDesactivos.Checked)
            {
                RbActivos.Checked = false;
                FiltrarPorEstado(false);
            }
        }
    }
}
