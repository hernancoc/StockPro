using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_Final_Inventario.Logica;

namespace Proyecto_Final_Inventario.PL
{
    public partial class UCcrearCategoria : UserControl
    {
        public UCcrearCategoria()
        {
            InitializeComponent();
        }

        private void UCcrearCategoria_Load(object sender, EventArgs e)
        {
            ActualizarDGV();
        }

        public void ActualizarDGV()
        {
            ManejoCategoria manejoCategoria = new ManejoCategoria();
            DGVCategoria.DataSource = manejoCategoria.CargarCategorias();
            DGVCategoria.Columns["_Descripcion"].Visible = false;
            DGVCategoria.Columns["_NombreCateg"].HeaderText = "Nombre";
            DGVCategoria.Columns["_EstadoCateg"].HeaderText = "Estado";
            DGVCategoria.Columns["_FechaCrea"].HeaderText = "Fecha Creacion";
            BtnDesactivar.Visible = false;
            BtnActivar.Visible = false;
        }

        private void BtnCrear_Click(object sender, EventArgs e)
        {
            // Validar que los campos estén completos
            if (string.IsNullOrWhiteSpace(TxtNombreCate.Text) ||
                string.IsNullOrWhiteSpace(TxtDescripcion.Text))
            {
                MessageBox.Show("Favor complete todos los campos antes de continuar.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                ManejoCategoria manejo = new ManejoCategoria
                {
                    _NombreCateg = TxtNombreCate.Text.Trim(),
                    _Descripcion = TxtDescripcion.Text.Trim(),
                    _EstadoCateg = CbActivo.Checked,  // Mejor usar .Checked para booleano
                    _FechaCrea = DTPFechaCreacion.Value.Date // Toma solo la fecha sin hora
                };

                manejo.CrearCategoria(manejo);
                ActualizarDGV();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al crear la categoría.\n\n" + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DGVCategoria_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            var x = DGVCategoria.CurrentRow.Cells[2].Value.ToString();

            if (x == "True")
            {
                BtnActivar.Visible = false;
                BtnDesactivar.Visible = true;
            }
            else if (x == "False")
            {
                BtnActivar.Visible = true;
                BtnDesactivar.Visible = false;
            }
            DGVCategoria.Refresh();
        }

        private void DGVCategoria_Click(object sender, EventArgs e)
        {
            var x = DGVCategoria.CurrentRow.Cells[2].Value.ToString();

            if (x == "True")
            {
                BtnActivar.Visible = false;
                BtnDesactivar.Visible = true;
            }
            else if (x == "False")
            {
                BtnActivar.Visible = true;
                BtnDesactivar.Visible = false;
            }
            DGVCategoria.Refresh();
        }

        private void BtnActivar_Click(object sender, EventArgs e)
        {
            ManejoCategoria manejo = new ManejoCategoria();
            string fila = DGVCategoria.CurrentRow.Cells[2].Value.ToString();
            string nombre = DGVCategoria.CurrentRow.Cells[0].Value.ToString();

            manejo.Activar(fila, nombre);

            ActualizarDGV();
        }

        private void BtnDesactivar_Click(object sender, EventArgs e)
        {
            ManejoCategoria manejo = new ManejoCategoria();
            string fila = DGVCategoria.CurrentRow.Cells[2].Value.ToString();
            string nombre = DGVCategoria.CurrentRow.Cells[0].Value.ToString();

            manejo.Desactivar(fila, nombre);

            ActualizarDGV();
        }

        private void DGVCategoria_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DGVCategoria.ClearSelection();
        }

        private void TxtNombreCate_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo letras, números, control y espacio
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void DTPFechaCreacion_ValueChanged(object sender, EventArgs e)
        {
            // No necesitas hacer nada aquí si solo quieres tomar la fecha actual del control
        }
    }
}
