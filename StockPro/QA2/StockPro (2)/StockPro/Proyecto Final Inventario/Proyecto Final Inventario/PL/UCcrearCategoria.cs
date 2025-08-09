using System;
using System.Linq;
using System.Windows.Forms;
using Proyecto_Final_Inventario.Logica;

namespace Proyecto_Final_Inventario.PL
{
    public partial class UCcrearCategoria : UserControl
    {
        private ManejoCategoria manejoCategoria;

        public UCcrearCategoria()
        {
            InitializeComponent();
            manejoCategoria = new ManejoCategoria();
        }

        private void UCcrearCategoria_Load(object sender, EventArgs e)
        {
            ActualizarDGV();
            LimpiarCampos();
            BtnCrear.Visible = true;
        }

        private void ActualizarDGV()
        {
            var categorias = manejoCategoria.CargarCategorias();

            DGVCategoria.DataSource = categorias.Select(c => new
            {
                c.Nombre,
                c.Descripcion,
                Estado = c.Estado == "T" ? "Activo" : "Inactivo",
                FechaCreacion = c.FechaCreacion?.ToShortDateString() ?? ""
            }).ToList();

            // Ajuste de encabezados
            DGVCategoria.Columns["Nombre"].HeaderText = "Nombre";
            DGVCategoria.Columns["Descripcion"].HeaderText = "Descripción";
            DGVCategoria.Columns["Estado"].HeaderText = "Estado";
            DGVCategoria.Columns["FechaCreacion"].HeaderText = "Fecha Creación";

            BtnActivar.Visible = false;
            BtnDesactivar.Visible = false;
        }

        private void LimpiarCampos()
        {
            TxtNombreCate.Clear();
            TxtDescripcion.Clear();
            CbActivo.Checked = true;
            DTPFechaCreacion.Value = DateTime.Now;

            BtnCrear.Visible = true;

            DGVCategoria.ClearSelection();
        }

        private void DGVCategoria_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void ActualizarBotonesEstado()
        {
            if (DGVCategoria.CurrentRow == null)
            {
                BtnActivar.Visible = false;
                BtnDesactivar.Visible = false;
                return;
            }

            string estado = DGVCategoria.CurrentRow.Cells[3].Value.ToString();

            if (estado == "Activo")
            {
                BtnActivar.Visible = false;
                BtnDesactivar.Visible = true;
            }
            else
            {
                BtnActivar.Visible = true;
                BtnDesactivar.Visible = false;
            }
        }

        private void BtnCrear_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            var nuevaCategoria = new Categorias
            {
                Nombre = TxtNombreCate.Text.Trim(),
                Descripcion = TxtDescripcion.Text.Trim(),
                Estado = CbActivo.Checked ? "T" : "F",
                FechaCreacion = DTPFechaCreacion.Value.Date
            };

            manejoCategoria.CrearCategoria(nuevaCategoria);

            ActualizarDGV();
            LimpiarCampos();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            // Obtener la categoría original para editar (por nombre)
            string nombreOriginal = DGVCategoria.CurrentRow?.Cells["Nombre"].Value.ToString();
            if (string.IsNullOrEmpty(nombreOriginal))
            {
                MessageBox.Show("No se ha seleccionado una categoría para editar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var categoriaEditada = new Categorias
            {
                Nombre = TxtNombreCate.Text.Trim(),
                Descripcion = TxtDescripcion.Text.Trim(),
                Estado = CbActivo.Checked ? "T" : "F",
                FechaCreacion = DTPFechaCreacion.Value.Date
            };

            manejoCategoria.EditarCategoria(nombreOriginal, categoriaEditada);

            ActualizarDGV();
            LimpiarCampos();
        }

        private void BtnActivar_Click(object sender, EventArgs e)
        {
            if (DGVCategoria.CurrentRow == null) return;

            string nombre = DGVCategoria.CurrentRow.Cells["Nombre"].Value.ToString();
            manejoCategoria.Activar(nombre);

            ActualizarDGV();
            LimpiarCampos();
        }

        private void BtnDesactivar_Click(object sender, EventArgs e)
        {
            if (DGVCategoria.CurrentRow == null) return;

            string nombre = DGVCategoria.CurrentRow.Cells["Nombre"].Value.ToString();
            manejoCategoria.Desactivar(nombre);

            ActualizarDGV();
            LimpiarCampos();
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(TxtNombreCate.Text) ||
                string.IsNullOrWhiteSpace(TxtDescripcion.Text))
            {
                MessageBox.Show("Por favor complete todos los campos.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void TxtNombreCate_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo letras, números, control y espacio
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void DGVCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGVCategoria.CurrentRow == null)
            {
                LimpiarCampos();
                return;
            }

            string nombreSeleccionado = DGVCategoria.CurrentRow.Cells["Nombre"].Value.ToString();

            var categoria = manejoCategoria.CargarCategorias()
                .FirstOrDefault(c => c.Nombre == nombreSeleccionado);

            if (categoria != null)
            {
                TxtNombreCate.Text = categoria.Nombre;
                TxtDescripcion.Text = categoria.Descripcion;
                CbActivo.Checked = categoria.Estado == "T";
                DTPFechaCreacion.Value = categoria.FechaCreacion ?? DateTime.Now;

                BtnCrear.Visible = false;

                ActualizarBotonesEstado();
            }
        }

        private void DGVCategoria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGVCategoria.CurrentRow == null)
            {
                LimpiarCampos();
                return;
            }

            string nombreSeleccionado = DGVCategoria.CurrentRow.Cells["Nombre"].Value.ToString();

            var categoria = manejoCategoria.CargarCategorias()
                .FirstOrDefault(c => c.Nombre == nombreSeleccionado);

            if (categoria != null)
            {
                TxtNombreCate.Text = categoria.Nombre;
                TxtDescripcion.Text = categoria.Descripcion;
                CbActivo.Checked = categoria.Estado == "T";
                DTPFechaCreacion.Value = categoria.FechaCreacion ?? DateTime.Now;

                BtnCrear.Visible = false;

                ActualizarBotonesEstado();
            }
        }
    }
}
