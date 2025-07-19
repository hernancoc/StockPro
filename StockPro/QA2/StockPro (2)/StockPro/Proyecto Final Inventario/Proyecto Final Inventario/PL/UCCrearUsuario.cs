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
    public partial class UCCrearUsuario : UserControl
    {
        public UCCrearUsuario()
        {
            InitializeComponent();
        }

        

        private void UCCrearUsuario_Load(object sender, EventArgs e)
        {
            actualizarDGV();
        }

        private void BtnCrearUsuario_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtNombreUsuario.Text) ||
                 string.IsNullOrWhiteSpace(TxtContraseña.Text) || string.IsNullOrWhiteSpace(TxtContraseña2.Text))
            {
                MessageBox.Show("Favor complete todos los campos antes de continuar.",
                                "Campos incompletos",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            CreacionUsuario creacionusuario = new CreacionUsuario();
            creacionusuario.CrearUsuario(TxtNombreUsuario.Text,TxtContraseña.Text, TxtContraseña2.Text,Convert.ToBoolean(CbActivar.CheckState));
            TxtNombreUsuario.Clear();
            TxtContraseña.Clear();
            TxtContraseña2.Clear();
        }

        private void BtnVerclave1_MouseDown(object sender, MouseEventArgs e)
        {
            TxtContraseña.UseSystemPasswordChar = false;
        }

        private void BtnVerclave1_MouseUp(object sender, MouseEventArgs e)
        {
            TxtContraseña.UseSystemPasswordChar = true;

        }

        private void BtnVerclave2_MouseDown(object sender, MouseEventArgs e)
        {
            TxtContraseña2.UseSystemPasswordChar = false;

        }

        private void BtnVerclave2_MouseUp(object sender, MouseEventArgs e)
        {
            TxtContraseña2.UseSystemPasswordChar = true;

        }

        private void BtnActivar_Click(object sender, EventArgs e)
        {
            UserManager userManager = new UserManager();
            string fila = DGVUsuario.CurrentRow.Cells[2].Value.ToString();
            string usuario = DGVUsuario.CurrentRow.Cells[0].Value.ToString();

            userManager.Activar(fila, usuario);
            actualizarDGV();
        }

        private void actualizarDGV()
        {
            UserManager userManager = new UserManager();
            DGVUsuario.DataSource = userManager.LeerUsuarios();
            DGVUsuario.Columns["_Password"].Visible = false;
            DGVUsuario.Columns["_UserName"].HeaderText = "Usuario";
            DGVUsuario.Columns["_UserActive"].HeaderText = "Estado";
            BtnDesactivar.Visible = false;
            BtnActivar.Visible = false;
            DGVUsuario.EnableHeadersVisualStyles = false;
            DGVUsuario.ColumnHeadersDefaultCellStyle.SelectionBackColor = DGVUsuario.ColumnHeadersDefaultCellStyle.BackColor;            // El encabezado encabezado seleccionado de columna quiero que su color de fondo seleccionado (SelectionBackColor) sea igual al color de fondo normal (BackColor)
        }

        private void BtnDesactivar_Click(object sender, EventArgs e)
        {
            UserManager userManager = new UserManager();
            string fila = DGVUsuario.CurrentRow.Cells[2].Value.ToString();
            string usuario = DGVUsuario.CurrentRow.Cells[0].Value.ToString();

            userManager.Desactivar(fila, usuario);
            actualizarDGV();
        }

        private void DGVUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var x = DGVUsuario.CurrentRow.Cells[2].Value.ToString();

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
            DGVUsuario.Refresh();
        }

        private void DGVUsuario_Click(object sender, EventArgs e)
        {
            var x = DGVUsuario.CurrentRow.Cells[2].Value.ToString();

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
            DGVUsuario.Refresh();
        }
    }
}
