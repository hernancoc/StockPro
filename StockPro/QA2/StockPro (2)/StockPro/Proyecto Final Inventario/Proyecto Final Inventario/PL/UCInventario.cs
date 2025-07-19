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
    public partial class UCInventario : UserControl
    {
        public UCInventario()
        {
            InitializeComponent();
        }
        private void UCInventario_Load(object sender, EventArgs e)
        {
            ManejarInventario mane = new ManejarInventario();
            DGVInventario.DataSource = mane.LeerProductos();
            DGVInventario.EnableHeadersVisualStyles = false;
            DGVInventario.ColumnHeadersDefaultCellStyle.SelectionBackColor = DGVInventario.ColumnHeadersDefaultCellStyle.BackColor;            // El encabezado encabezado seleccionado de columna quiero que su color de fondo seleccionado (SelectionBackColor) sea igual al color de fondo normal (BackColor)
            ManejoCategoria manejoCategoria = new ManejoCategoria();
            TxtCategoriaDeProducto.Items.AddRange(manejoCategoria.CargarCombobox().ToArray());
        }
        private void DGVInventario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ManejarInventario mane = new ManejarInventario();
            var x = DGVInventario.CurrentRow.Cells[7].Value.ToString();
            var i = DGVInventario.CurrentRow.Cells[8].Value.ToString();
            BtnGuardar.Visible = true;
            if (x == "True")
            {
                BtnEntrada.Visible = true;
                BtnSalida.Visible = true;
                NUDEntrada_Salida.Visible = true;
                CbActivar.Visible = false;
                CBDesactivar.Visible = true;

            }
            else if (x == "False")
            {
                BtnEntrada.Visible = false;
                BtnSalida.Visible = false;
                NUDEntrada_Salida.Visible = false;
                CbActivar.Visible = true;
                CBDesactivar.Visible = false;
            }

            pbimagen.Image = Image.FromFile(i.ToString());
            pbimagen.SizeMode = PictureBoxSizeMode.Zoom;
            DGVInventario.Refresh();

        }

        private void DGVInventario_Click_1(object sender, EventArgs e)
        {
            var i = DGVInventario.CurrentRow.Cells[8].Value.ToString();

            var fila = DGVInventario.CurrentRow.Cells[7].Value.ToString();
            var x = DGVInventario.CurrentRow.Cells[7].Value.ToString();
            BtnGuardar.Visible = true;
            if (x == "True")
            {
                BtnEntrada.Visible = true;
                BtnSalida.Visible = true;
                NUDEntrada_Salida.Visible = true;
                CBDesactivar.Visible = true;
                CbActivar.Visible = false;

            }
            else if (x == "False")
            {
                BtnEntrada.Visible = false;
                BtnSalida.Visible = false;
                NUDEntrada_Salida.Visible = false;
                CbActivar.Visible = true;
                CBDesactivar.Visible = false;
            }
            DGVInventario.Refresh();
           
            //pbimagen.Image = Image.FromFile(i.ToString());
            //pbimagen.SizeMode = PictureBoxSizeMode.Zoom;
            //DGVInventario.Refresh();
        }

        private void BtnEntrada_Click_1(object sender, EventArgs e)
        {
            var n = DGVInventario.CurrentRow.Cells[0].Value;
            ManejarInventario manejarinvetario = new ManejarInventario();
            manejarinvetario.Entrada(n.ToString(), int.Parse(NUDEntrada_Salida.Text));
            DGVInventario.DataSource = null;
            DGVInventario.DataSource = manejarinvetario.LeerProductos();
            NUDEntrada_Salida.Visible = false;
            NUDEntrada_Salida.Value = 0;
            DGVInventario.DataSource = null;
            DGVInventario.DataSource = manejarinvetario.LeerProductos();
            BtnEntrada.Visible = false;
            BtnSalida.Visible = false;
            CBDesactivar.Visible = false;
            CbActivar.Visible = false;
            BtnGuardar.Visible = false;
            AplicarFiltro();
        }

        private void BtnSalida_Click_1(object sender, EventArgs e)
        {
            var n = DGVInventario.CurrentRow.Cells[0].Value;
            ManejarInventario manejarinvetario = new ManejarInventario();
            manejarinvetario.Salida(n.ToString(), int.Parse(NUDEntrada_Salida.Text));
            DGVInventario.DataSource = null;
            DGVInventario.DataSource = manejarinvetario.LeerProductos();
            NUDEntrada_Salida.Visible = false;
            NUDEntrada_Salida.Value = 0;
            DGVInventario.DataSource = null;
            DGVInventario.DataSource = manejarinvetario.LeerProductos();
            BtnEntrada.Visible = false;
            BtnSalida.Visible = false;
            CBDesactivar.Visible = false;
            CbActivar.Visible = false;
            BtnGuardar.Visible = false;
            AplicarFiltro();

        }


        private void BtnGuardar_Click_1(object sender, EventArgs e)
        {
            ManejarInventario manejar = new ManejarInventario();
            var fila = DGVInventario.CurrentRow.Cells[7].Value.ToString();
            var id = DGVInventario.CurrentRow.Cells[0].Value.ToString();

            if (CbActivar.Checked == true)
            {
                manejar.Activar(fila, id);
            }
            else if (CBDesactivar.Checked == true)
            {
                manejar.Desactivar(fila, id);

            }
            CbActivar.Visible = false;
            CBDesactivar.Visible = false;
            CbActivar.Checked=false;
            CBDesactivar.Checked=false;
            DGVInventario.DataSource = null;
            AplicarFiltro();
            TxtFiltrar.Clear();
            BtnEntrada.Visible = false;
            BtnSalida.Visible = false;
            NUDEntrada_Salida.Visible = false;
            BtnGuardar.Visible = false;
            TxtCategoriaDeProducto.SelectedIndex = -1;
        }

        private void RefrescarDGV()
        {

            DGVInventario.Columns["UrlImagenes"].Visible = false;
            DGVInventario.Columns["FechaCreacion"].Visible= false;
            DGVInventario.Columns["FechaActualizacion"].Visible = false;
            DGVInventario.ClearSelection();
            DGVInventario.Refresh();
            foreach (DataGridViewRow fila in DGVInventario.Rows)
            {
                fila.DefaultCellStyle.BackColor = DGVInventario.DefaultCellStyle.BackColor;
                fila.DefaultCellStyle.ForeColor = DGVInventario.DefaultCellStyle.ForeColor;
            }

        }

        private void DGVInventario_DataBindingComplete_1(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            RefrescarDGV();
        }

        private void TxtFiltrar_TextChanged(object sender, EventArgs e)
        {
            RBAmarillo.Checked = false;
            RBverde.Checked = false;
            RbTodos.Checked = false;
            RBrojo.Checked = false;
            AplicarFiltro();
        }

        private void AplicarFiltro()
        {
            ManejarInventario manejarInventario = new ManejarInventario();
            DGVInventario.ClearSelection();
            DGVInventario.DataSource = manejarInventario.filtrar(TxtFiltrar.Text);
        }

        private void pbimagen_Click(object sender, EventArgs e)
        {

        }

        private void RbTodos_CheckedChanged(object sender, EventArgs e)
        {
            RefrescarDGV();

            foreach (DataGridViewRow fila in DGVInventario.Rows)
            {
                if (int.Parse(fila.Cells[4].Value.ToString()) == 0)
                {
                    fila.DefaultCellStyle.BackColor = Color.Red;
                    fila.DefaultCellStyle.ForeColor = Color.White;
                }
                else if (int.Parse(fila.Cells[4].Value.ToString()) <= 5 && int.Parse(fila.Cells[4].Value.ToString()) >= 1)
                {
                    fila.DefaultCellStyle.BackColor = Color.Yellow;
                    fila.DefaultCellStyle.ForeColor = Color.Black;
                }
                else if (int.Parse(fila.Cells[4].Value.ToString()) >= 5)
                {
                    fila.DefaultCellStyle.BackColor = Color.LightGreen;
                    fila.DefaultCellStyle.ForeColor = Color.Black;
                }
                TxtCategoriaDeProducto.SelectedIndex = -1;

            }
        }

        private void RBrojo_CheckedChanged(object sender, EventArgs e)
        {
            RefrescarDGV();
            TxtCategoriaDeProducto.SelectedIndex = -1;

            foreach (DataGridViewRow fila in DGVInventario.Rows)
            {
                if (int.Parse(fila.Cells[4].Value.ToString()) == 0)
                {
                    fila.DefaultCellStyle.BackColor = Color.Red;
                    fila.DefaultCellStyle.ForeColor = Color.White;
                }

            }
        }

        private void RBAmarillo_CheckedChanged(object sender, EventArgs e)
        {
            RefrescarDGV();
            TxtCategoriaDeProducto.SelectedIndex = -1;

            foreach (DataGridViewRow fila in DGVInventario.Rows)
            {
                
                 if (int.Parse(fila.Cells[4].Value.ToString()) <= 5 && int.Parse(fila.Cells[4].Value.ToString()) >= 1)
                 {
                    fila.DefaultCellStyle.BackColor = Color.Yellow;
                    fila.DefaultCellStyle.ForeColor = Color.Black;
                 }
            }
        }

        private void RBverde_CheckedChanged(object sender, EventArgs e)
        {
            RefrescarDGV();
            TxtCategoriaDeProducto.SelectedIndex = -1;

            foreach (DataGridViewRow fila in DGVInventario.Rows)
            {
                
                if (int.Parse(fila.Cells[4].Value.ToString()) >= 5)
                {
                    fila.DefaultCellStyle.BackColor = Color.LightGreen;
                    fila.DefaultCellStyle.ForeColor = Color.Black;
                }
            }
        }

        private void FiltrarPorEstado()
        {
            // Llamo a la clase que maneja los productos y obtengo la lista completa del inventario
            ManejarInventario manejarInventario = new ManejarInventario();
            var productos = manejarInventario.LeerProductos(); // Trae todos los productos

            // Si el radio button de activos está marcado, solo muestro los productos que están activos
            if (RbActivos.Checked)
            {
                DGVInventario.DataSource = productos.Where(p => p.Activo == true).ToList();
            }
            // Si el radio button de inactivos está marcado, solo muestro los productos que están inactivos
            else if (RbDesactivos.Checked)
            {
                DGVInventario.DataSource = productos.Where(p => p.Activo == false).ToList();
            }
            else
            {
                // Si no hay ningún radio button marcado, muestro todos los productos
                DGVInventario.DataSource = productos;
            }
            RBAmarillo.Checked = false;
            RBverde.Checked = false;
            RbTodos.Checked = false;
            RBrojo.Checked = false;

            RefrescarDGV();
            TxtCategoriaDeProducto.SelectedIndex = -1;

        }


        private void RbActivos_CheckedChanged_1(object sender, EventArgs e)
        {
            RbDesactivos.Checked = false;
           FiltrarPorEstado();

        }

        private void RbDesactivos_CheckedChanged_1(object sender, EventArgs e)
        {
            RbActivos.Checked = false;
            FiltrarPorEstado();
        }

        private void TxtCategoriaDeProducto_SelectedValueChanged(object sender, EventArgs e)
        {
        }

        private void TxtCategoriaDeProducto_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void TxtCategoriaDeProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            RBAmarillo.Checked = false;
            RBverde.Checked = false;
            RbTodos.Checked = false;
            RBrojo.Checked = false;
            RefrescarDGV();
            ManejarInventario manejarInventario = new ManejarInventario();
            DGVInventario.DataSource = manejarInventario.filtroCategoria(TxtCategoriaDeProducto.Text);
        }
    }
}
