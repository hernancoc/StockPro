using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Proyecto_Final_Inventario.Entidades;
using Proyecto_Final_Inventario.Logica;

namespace Proyecto_Final_Inventario.PL
{
    public partial class UCCrearProducto : UserControl
    {
        public UCCrearProducto()
        {
            InitializeComponent();
        }
        FrmInicio frmInicio = new FrmInicio();

        private void UCCrearProducto_Load(object sender, EventArgs e)
        {
            TxtCantidad.Maximum = 10000;
            ManejoCategoria manejoCategoria = new ManejoCategoria();
            TxtCategoriaDeProducto.Items.AddRange(manejoCategoria.CargarCombobox().ToArray());
        }

        private void guna2HtmlLabel7_Click(object sender, EventArgs e)
        {

        }


        private void TxtCategoriaDeProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
           // TxtCategoriaDeProducto.Controls.Add();
        }

        private void TxtId_KeyPress(object sender, KeyPressEventArgs e) //se dispoara cuando el usuario ingresa una tecla
        {
            // Verifica si la tecla NO es una tecla de control como Backspace. verifica que no sea un signo de exclamacion ej
            // y tampoco es un número del 0 al 9
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) // solo entran al if las teclas que no son numericas y que son de control. 
            {
                e.Handled = true;
            }
            // como deben de cumplirse ambas verifica que si es una letra que es diferente a una letra de control y diferente a un digito entra y se bloquea
            // Si la tecla no es válida, se cancela su escritura
        }

        //se dispara al salir del evento
        private void TxtPrecioCompra_Leave(object sender, EventArgs e)
        {
            // Convierto el sender(hace referencia al control en especifico) al tipo Guna2TextBox para trabajar con sus propiedades
              var txt = (Guna.UI2.WinForms.Guna2TextBox)sender;

            // Intento convertir el texto a decimal para ver si es un número válido
            if (decimal.TryParse(txt.Text, out decimal valor))
            {
                // Si es número, formateo el texto para que tenga dos decimales y separadores de miles
                txt.Text = valor.ToString("N2");
            }
        }

        private void TxtPrecioVenta_Leave(object sender, EventArgs e)
        {
            // Convierto el sender(hace referencia al control en especifico) al tipo Guna2TextBox para trabajar con sus propiedades
            var txt = (Guna.UI2.WinForms.Guna2TextBox)sender;

            // Intento convertir el texto a decimal para ver si es un número válido
            if (decimal.TryParse(txt.Text, out decimal valor))
            {
                // Si es número, formateo el texto para que tenga dos decimales y separadores de miles
                txt.Text = valor.ToString("N2");
            }
        }

        private void TxtPrecioCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla NO es una tecla de control como Backspace. verifica que no sea un signo de exclamacion ej
            // y tampoco es un número del 0 al 9
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) // solo entran al if las teclas que no son numericas y que son de control. 
            {
                e.Handled = true;
            }
            // como deben de cumplirse ambas verifica que si es una letra que es diferente a una letra de control y diferente a un digito entra y se bloquea
            // Si la tecla no es válida, se cancela su escritura
        }

        private void TxtPrecioVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla NO es una tecla de control como Backspace. verifica que no sea un signo de exclamacion ej
            // y tampoco es un número del 0 al 9
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) // solo entran al if las teclas que no son numericas y que son de control. 
            {
                e.Handled = true;
            }
            // como deben de cumplirse ambas verifica que si es una letra que es diferente a una letra de control y diferente a un digito entra y se bloquea
            // Si la tecla no es válida, se cancela su escritura
        }

        private void PBImgProductos_Click(object sender, EventArgs e)
        {
            //ruta de carpeta de imagenes para que cuando se abra el filedialog esta sea la que este pordefault
            string rutaimagen = Path.Combine(Application.StartupPath, "C:\\Users\\corom\\OneDrive\\Escritorio\\Aprendiendo C#\\Proyecto Final Inventario\\Proyecto Final Inventario\\ImagenesProductos");
            OFDImgProduct.InitialDirectory = rutaimagen; // lo lleva la carpet que defini
            OFDImgProduct.Filter = "Archivos de imagen (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";
            OFDImgProduct.Title = "Selecciona una imagen";

            if (OFDImgProduct.ShowDialog() == DialogResult.OK) //si el usuario selecciona la imagen y da en ok
            {
                // Cargar la imagen en el PictureBox
                PBImgProductos.Image = Image.FromFile(OFDImgProduct.FileName);
                PBImgProductos.SizeMode = PictureBoxSizeMode.Zoom; // Ajusta la imagen al tamaño del control

                //txt que guarda la ruta de la imagen
                TxtRutaImg.Text = OFDImgProduct.FileName.ToString();
            }

        }

        private void BtnImagen_Click(object sender, EventArgs e)
        {
            //ruta de carpeta de imagenes para que cuando se abra el filedialog esta sea la que este pordefault
            string rutaimagen = Path.Combine(Application.StartupPath, "C:\\Users\\corom\\OneDrive\\Escritorio\\Aprendiendo C#\\Proyecto Final Inventario\\Proyecto Final Inventario\\ImagenesProductos");
            OFDImgProduct.InitialDirectory = rutaimagen; // lo lleva la carpet que defini
            OFDImgProduct.Filter = "Archivos de imagen (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";
            OFDImgProduct.Title = "Selecciona una imagen";

            if (OFDImgProduct.ShowDialog() == DialogResult.OK) //si el usuario selecciona la imagen y da en ok
            {
                // Cargar la imagen en el PictureBox
                PBImgProductos.Image = Image.FromFile(OFDImgProduct.FileName);
                PBImgProductos.SizeMode = PictureBoxSizeMode.Zoom; // Ajusta la imagen al tamaño del control
                TxtRutaImg.Text = OFDImgProduct.FileName.ToString();
            }
        }
        
        public void TxtId_TextChanged(object sender, EventArgs e)
        {
            try
            {
                BtnEditar.Visible = CrearProducto.ValidarEditar(TxtId.Text);
                BtnCrearProducto.Visible = !CrearProducto.ValidarEditar(TxtId.Text);

                if (BtnEditar.Visible == true)
                {
                    CrearProducto crear = new CrearProducto();
                    var producto = crear.BuscarProducto(TxtId.Text);

                    if (producto != null)
                    {
                        TxtNombreProd.Text = producto._Nombre;
                        TxtCategoriaDeProducto.Text = producto._Categoria;
                        TxtProveedor.Text = producto._Proveedor;
                        TxtCantidad.Value = producto._Cantidad;
                        TxtPrecioVenta.Text = producto._PrecioVenta.ToString("N2");
                        TxtPrecioCompra.Text = producto._PrecioCompra.ToString("N2");
                        CbActivoEntrada_Salida.Checked = producto._Activo;
                        TxtRutaImg.Text = producto._UrlImagen;
                    }
                    else
                    {
                        limpiarTXT();

                    }
                }
                else
                {
                    limpiarTXT();
                }
            }
            catch (Exception ex)
            {
                Log.EscribirLog(ex);
                MessageBox.Show("Ocurrió un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            // Validación de campos vacíos
            if (string.IsNullOrWhiteSpace(TxtId.Text) ||
                string.IsNullOrWhiteSpace(TxtNombreProd.Text) ||
                string.IsNullOrWhiteSpace(TxtCategoriaDeProducto.Text) ||
                string.IsNullOrWhiteSpace(TxtProveedor.Text) ||
                TxtCantidad.Value == 0 ||
                string.IsNullOrWhiteSpace(TxtPrecioVenta.Text) ||
                string.IsNullOrWhiteSpace(TxtPrecioCompra.Text) ||
                string.IsNullOrWhiteSpace(TxtRutaImg.Text))
            {
                MessageBox.Show("favor complete todos los campos antes de continuar.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                CrearProducto crearProducto = new CrearProducto
                {
                    _Id = int.Parse(TxtId.Text),
                    _Nombre = TxtNombreProd.Text.ToLower(),
                    _Categoria = TxtCategoriaDeProducto.Text.ToLower(),
                    _Proveedor = TxtProveedor.Text.ToLower(),
                    _Cantidad = (int)TxtCantidad.Value,
                    _PrecioVenta = double.Parse(TxtPrecioVenta.Text),
                    _PrecioCompra = double.Parse(TxtPrecioCompra.Text),
                    _Activo = Convert.ToBoolean(CbActivoEntrada_Salida.CheckState),
                    _UrlImagen = TxtRutaImg.Text,
                    _FechaActualizacion = DateTime.Now
                };

                crearProducto.EditarProducto(crearProducto);
                limpiarTXT();
                TxtId.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al editar el producto.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BtnCrearProducto_Click(object sender, EventArgs e)
        {
            // Validar que los campos estén completos
            if (string.IsNullOrWhiteSpace(TxtId.Text) ||
                string.IsNullOrWhiteSpace(TxtNombreProd.Text) ||
                string.IsNullOrWhiteSpace(TxtCategoriaDeProducto.Text) ||
                string.IsNullOrWhiteSpace(TxtProveedor.Text) ||
                TxtCantidad.Value == 0 ||
                string.IsNullOrWhiteSpace(TxtPrecioVenta.Text) ||
                string.IsNullOrWhiteSpace(TxtPrecioCompra.Text) ||
                string.IsNullOrWhiteSpace(TxtRutaImg.Text))
            {
                MessageBox.Show("Favor complete todos los campos", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                CrearProducto crearProducto = new CrearProducto
                {
                    _Id = int.Parse(TxtId.Text),
                    _Nombre = TxtNombreProd.Text.ToLower(),
                    _Categoria = TxtCategoriaDeProducto.Text.ToLower(),
                    _Proveedor = TxtProveedor.Text.ToLower(),
                    _Cantidad = (int)TxtCantidad.Value,
                    _PrecioVenta = double.Parse(TxtPrecioVenta.Text),
                    _PrecioCompra = double.Parse(TxtPrecioCompra.Text),
                    _Activo = Convert.ToBoolean(CbActivoEntrada_Salida.CheckState),
                    _UrlImagen = TxtRutaImg.Text,
                    _FechaCreacion = DateTime.Now,
                    _FechaActualizacion = DateTime.Now,
                };

                crearProducto.CreacionProducto(crearProducto);
                limpiarTXT();
                TxtId.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al crear el producto.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void limpiarTXT()
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

      
    }
}
