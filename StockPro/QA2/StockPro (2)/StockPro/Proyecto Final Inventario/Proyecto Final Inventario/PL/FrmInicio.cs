using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Proyecto_Final_Inventario.Logica;

namespace Proyecto_Final_Inventario.PL
{
    public partial class FrmInicio : Form
    {

        public FrmInicio()
        {
            InitializeComponent();
    

        }
        UCInicio ucInicio = new UCInicio();

        private void FrmInicio_Load(object sender, EventArgs e)
        {
          
            Usuarios user = new Usuarios();
            UserManager userm = new UserManager();
            PanelInico.Controls.Add(ucInicio);
            ucInicio.Dock = DockStyle.Fill;

        }

        //Codigo para habilitar mover el formulario a traves de la pantalla, debido a que se removio los controles de la pestaña
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


       


        private void IconoCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void IconoMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
           // IconoRestaurar.Visible = true;
            //IconoMaximizar.Visible = false;
        }

        private void IconoRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            //IconoRestaurar.Visible = false;
            //IconoMaximizar.Visible = true;
        }

        private void IconoMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle,0x112,0xf012,0);

        }


        private void PanelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LblSaludoUser_Click(object sender, EventArgs e)
        {

        }
        UserManager userManager = new UserManager();
        private void guna2CirclePictureBox5_Click(object sender, EventArgs e)
        {
            
            this.Hide();// Oculta el frm principal
            userManager.RegistrarCierreSesion(UserManager.UsuarioActual);

            FrmLogin login = new FrmLogin();

            if (login.ShowDialog() == DialogResult.OK) // Si el login es exitoso, reabre FrmInicio

            {
                this.Show(); // Vuelve a mostrar FrmInicio si el login fue exitoso
            }
            else
            {
                // Si el usuario cierra el login o no inicia sesión, cierra todo
                Application.Exit();
            }
        }
       

        private void BtnCrear_Click(object sender, EventArgs e)
        {
            PanelInico.Controls.Clear();
            UCCrear ucCrea = new UCCrear(PanelInico); 
            ucCrea.Dock = DockStyle.Fill;
            PanelInico.Controls.Add(ucCrea);
        }

        private void PBinicio(object sender, EventArgs e)
        {

         


        }

        private void PanelCrearProducto_Producto_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelCrearCategoria_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelCrearProducto_Paint(object sender, PaintEventArgs e)
        {

        }

        public void PanelInico_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PBInicio_Click(object sender, EventArgs e)
        {
            PanelInico.Controls.Clear();
            PanelInico.Controls.Add(ucInicio);
            ucInicio.Dock = DockStyle.Fill;
            
        }

        private void BtnInventario_Click(object sender, EventArgs e)
        {
            UCInventario ucinventario = new UCInventario();
            ucinventario.Dock = DockStyle.Fill;
            PanelInico.Controls.Clear();
            PanelInico.Controls.Add(ucinventario);
        }

     

        private void BtnConfiUsuario_Click(object sender, EventArgs e)
        {
            UCCrearUsuario ucrearusuario = new UCCrearUsuario();
            ucrearusuario.Dock = DockStyle.Fill;
            PanelInico.Controls.Clear();
            PanelInico.Controls.Add(ucrearusuario);
        }

        private void BtnReportes_Click(object sender, EventArgs e)
        {
            UCReporte uCReporte = new UCReporte();
            uCReporte.Dock = DockStyle.Fill;
            PanelInico.Controls.Clear();
            PanelInico.Controls.Add(uCReporte);
        }

        private void guna2CirclePictureBox4_Click(object sender, EventArgs e)
        {
            LblNombreUsuario.Visible = true;
            LblNombreUsuario.Text = UserManager.UsuarioActual;

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            PanelInico.Controls.Clear();
            UCAcerdemi uCAcerdemi = new UCAcerdemi();
            uCAcerdemi.Dock = DockStyle.Fill;
            PanelInico.Controls.Add(uCAcerdemi);
        }
    }
}
