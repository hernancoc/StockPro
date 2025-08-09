using Proyecto_Final_Inventario.Logica;
using System;
using System.Linq;
using System.Windows.Forms;

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
            ActualizarDGV();
        }

        private void BtnCrearUsuario_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtNombreUsuario.Text) ||
                string.IsNullOrWhiteSpace(TxtContraseña.Text) ||
                string.IsNullOrWhiteSpace(TxtContraseña2.Text))
            {
                MessageBox.Show("Favor complete todos los campos antes de continuar.",
                                "Campos incompletos",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            if (TxtContraseña.Text != TxtContraseña2.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            try
            {
                CreacionUsuario creacionUsuario = new CreacionUsuario();
                bool estado = CbActivar.Checked;

                creacionUsuario.CrearUsuario(
                    TxtNombreUsuario.Text.Trim(),
                    TxtContraseña.Text,
                    TxtContraseña2.Text,
                    estado
                );

                MessageBox.Show("Usuario creado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                TxtNombreUsuario.Clear();
                TxtContraseña.Clear();
                TxtContraseña2.Clear();

                ActualizarDGV();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnActivar_Click(object sender, EventArgs e)
        {
            if (DGVUsuario.CurrentRow == null)
                return;

            string usuario = DGVUsuario.CurrentRow.Cells["Usuario"].Value.ToString();

            UserManager userManager = new UserManager();
            userManager.Activar(usuario);

            ActualizarDGV();
        }

        private void BtnDesactivar_Click(object sender, EventArgs e)
        {
            if (DGVUsuario.CurrentRow == null)
                return;

            string usuario = DGVUsuario.CurrentRow.Cells["Usuario"].Value.ToString();

            UserManager userManager = new UserManager();
            userManager.Desactivar(usuario);

            ActualizarDGV();
        }

        private void ActualizarDGV()
        {
            UserManager userManager = new UserManager();
            var usuarios = userManager.LeerUsuarios();

            DGVUsuario.DataSource = usuarios.Select(u => new
            {
                Usuario = u.Usuario,
                Estado = u.Estado == "T" ? "Activo" : "Inactivo"
            }).ToList();

            BtnDesactivar.Visible = false;
            BtnActivar.Visible = false;

            DGVUsuario.EnableHeadersVisualStyles = false;
            DGVUsuario.ColumnHeadersDefaultCellStyle.SelectionBackColor = DGVUsuario.ColumnHeadersDefaultCellStyle.BackColor;
        }

        private void DGVUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGVUsuario.CurrentRow == null) return;

            string estado = DGVUsuario.CurrentRow.Cells["Estado"].Value.ToString();

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

        // Mostrar/ocultar contraseña con mouse down/up
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

        private void DGVUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGVUsuario.CurrentRow == null) return;

            string estado = DGVUsuario.CurrentRow.Cells["Estado"].Value.ToString();

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
    }
}
