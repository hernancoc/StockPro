using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Proyecto_Final_Inventario;
using Proyecto_Final_Inventario.Logica;

namespace Proyecto_Final_Inventario.PL
{
    public partial class UCCrearProducto : UserControl
    {
        private CrearProducto logicaProducto = new CrearProducto();
        private ManejoCategoria logicaCategoria = new ManejoCategoria();

        private readonly string carpetaImagenes = Path.Combine(Application.StartupPath, "ImagenesProductos");

        public UCCrearProducto()
        {
            InitializeComponent();
            Load += UCCrearProducto_Load;
        }

        private void UCCrearProducto_Load(object sender, EventArgs e)
        {
            CargarCategoriasCombo();
            if (!Directory.Exists(carpetaImagenes))
                Directory.CreateDirectory(carpetaImagenes);
        }

        private void CargarCategoriasCombo()
        {
            try
            {
                var categorias = logicaCategoria.CargarCategorias()
                    .Where(c => c.Estado == "T")
                    .ToList();

                TxtCategoriaDeProducto.DataSource = categorias;
                TxtCategoriaDeProducto.DisplayMember = "Nombre";
                TxtCategoriaDeProducto.ValueMember = "IDCategorias";
                TxtCategoriaDeProducto.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar categorías: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtId_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(TxtId.Text))
                {
                    LimpiarCampos();
                    BtnCrearProducto.Visible = true;
                    BtnEditar.Visible = false;
                    return;
                }

                if (!int.TryParse(TxtId.Text, out int id))
                {
                    MessageBox.Show("El ID debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TxtId.Clear();
                    return;
                }

                BtnEditar.Visible = logicaProducto.ValidarEditar(TxtId.Text);
                BtnCrearProducto.Visible = !BtnEditar.Visible;

                if (BtnEditar.Visible)
                {
                    Productos producto = logicaProducto.BuscarProductoConCategoria(TxtId.Text);
                    if (producto != null)
                    {
                        TxtNombreProd.Text = producto.Nombre;
                        TxtProveedor.Text = producto.Proveedor;
                        TxtCantidad.Value = producto.Cantidad_Inicial ?? 0;
                        TxtPrecioVenta.Text = producto.Precio_Venta.ToString("N2");
                        TxtPrecioCompra.Text = producto.Precio_Compra.ToString("N2");
                        CbActivoEntrada_Salida.Checked = producto.Estado == "T";

                        if (!string.IsNullOrEmpty(producto.RutaImagenes))
                        {
                            TxtRutaImg.Text = producto.RutaImagenes;
                            CargarImagenProducto(producto.RutaImagenes);
                        }
                        else
                        {
                            TxtRutaImg.Clear();
                            PBImgProductos.Image = null;
                        }

                        if (producto.IDCategorias > 0)
                            TxtCategoriaDeProducto.SelectedValue = producto.IDCategorias;
                        else
                            TxtCategoriaDeProducto.SelectedIndex = -1;
                    }
                    else
                    {
                        LimpiarCampos();
                    }
                }
                else
                {
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarImagenProducto(string rutaRelativa)
        {
            try
            {
                string rutaCompleta = Path.Combine(carpetaImagenes, rutaRelativa);
                if (File.Exists(rutaCompleta))
                {
                    using (var bmpTemp = new Bitmap(rutaCompleta))
                    {
                        PBImgProductos.Image = new Bitmap(bmpTemp);
                    }
                    PBImgProductos.SizeMode = PictureBoxSizeMode.Zoom;
                }
                else
                {
                    PBImgProductos.Image = null;
                }
            }
            catch
            {
                PBImgProductos.Image = null;
            }
        }

        private void BtnSeleccionarImagen_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    ofd.Filter = "Archivos de Imagen|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                    ofd.Title = "Seleccione una imagen para el producto";

                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        string nombreArchivo = Path.GetFileName(ofd.FileName);
                        string destino = Path.Combine(carpetaImagenes, nombreArchivo);

                        if (File.Exists(destino))
                        {
                            string nombreSinExt = Path.GetFileNameWithoutExtension(nombreArchivo);
                            string ext = Path.GetExtension(nombreArchivo);
                            int contador = 1;
                            do
                            {
                                nombreArchivo = $"{nombreSinExt}_{contador}{ext}";
                                destino = Path.Combine(carpetaImagenes, nombreArchivo);
                                contador++;
                            } while (File.Exists(destino));
                        }

                        File.Copy(ofd.FileName, destino);

                        TxtRutaImg.Text = nombreArchivo;
                        CargarImagenProducto(nombreArchivo);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar la imagen: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCrearProducto_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;

            try
            {
                if (TxtCategoriaDeProducto.SelectedIndex == -1)
                {
                    MessageBox.Show("Seleccione una categoría válida.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!decimal.TryParse(TxtPrecioVenta.Text, out decimal precioVenta) ||
                    !decimal.TryParse(TxtPrecioCompra.Text, out decimal precioCompra))
                {
                    MessageBox.Show("Los precios deben ser números válidos.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Productos producto = new Productos
                {
                    Nombre = TxtNombreProd.Text.Trim(),
                    Proveedor = TxtProveedor.Text.Trim(),
                    Cantidad_Inicial = (int)TxtCantidad.Value,
                    Precio_Venta = precioVenta,
                    Precio_Compra = precioCompra,
                    Estado = CbActivoEntrada_Salida.Checked ? "T" : "F",
                    RutaImagenes = TxtRutaImg.Text.Trim(),
                    FechaCreacion = DateTime.Now,
                    FechaActualizacion = DateTime.Now,
                    IDCategorias = (int)TxtCategoriaDeProducto.SelectedValue
                };

                logicaProducto.CreacionProducto(producto);
                MessageBox.Show("Producto creado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                TxtId.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;

            try
            {
                if (TxtCategoriaDeProducto.SelectedIndex == -1)
                {
                    MessageBox.Show("Seleccione una categoría válida.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!decimal.TryParse(TxtPrecioVenta.Text, out decimal precioVenta) ||
                    !decimal.TryParse(TxtPrecioCompra.Text, out decimal precioCompra))
                {
                    MessageBox.Show("Los precios deben ser números válidos.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Productos producto = new Productos
                {
                    IDProductos = int.Parse(TxtId.Text),
                    Nombre = TxtNombreProd.Text.Trim(),
                    Proveedor = TxtProveedor.Text.Trim(),
                    Cantidad_Inicial = (int)TxtCantidad.Value,
                    Precio_Venta = precioVenta,
                    Precio_Compra = precioCompra,
                    Estado = CbActivoEntrada_Salida.Checked ? "T" : "F",
                    RutaImagenes = TxtRutaImg.Text.Trim(),
                    FechaActualizacion = DateTime.Now,
                    IDCategorias = (int)TxtCategoriaDeProducto.SelectedValue
                };

                logicaProducto.EditarProducto(producto);
                MessageBox.Show("Producto actualizado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                TxtId.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(TxtNombreProd.Text) ||
                TxtCategoriaDeProducto.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(TxtProveedor.Text) ||
                TxtCantidad.Value <= 0 ||
                string.IsNullOrWhiteSpace(TxtPrecioVenta.Text) ||
                string.IsNullOrWhiteSpace(TxtPrecioCompra.Text) ||
                string.IsNullOrWhiteSpace(TxtRutaImg.Text))
            {
                MessageBox.Show("Favor complete todos los campos.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void LimpiarCampos()
        {
            TxtNombreProd.Clear();
            TxtCategoriaDeProducto.SelectedIndex = -1;
            TxtProveedor.Clear();
            TxtCantidad.Value = 0;
            TxtPrecioVenta.Clear();
            TxtPrecioCompra.Clear();
            CbActivoEntrada_Salida.Checked = false;
            TxtRutaImg.Clear();
            PBImgProductos.Image = null;
        }

        private void BtnImagen_Click(object sender, EventArgs e)
        {
        
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    ofd.Filter = "Archivos de Imagen|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                    ofd.Title = "Seleccione una imagen para el producto";

                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        string nombreArchivo = Path.GetFileName(ofd.FileName);
                        string destino = Path.Combine(carpetaImagenes, nombreArchivo);

                        if (File.Exists(destino))
                        {
                            string nombreSinExt = Path.GetFileNameWithoutExtension(nombreArchivo);
                            string ext = Path.GetExtension(nombreArchivo);
                            int contador = 1;
                            do
                            {
                                nombreArchivo = $"{nombreSinExt}_{contador}{ext}";
                                destino = Path.Combine(carpetaImagenes, nombreArchivo);
                                contador++;
                            } while (File.Exists(destino));
                        }

                        File.Copy(ofd.FileName, destino);

                        TxtRutaImg.Text = nombreArchivo;
                        CargarImagenProducto(nombreArchivo);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar la imagen: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    
    }
}
