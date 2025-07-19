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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();

        }
        //Codigo para habilitar mover el formulario a traves de la pantalla, debido a que se removio los controles de la pestaña
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        private void Frm_Load(object sender, EventArgs e)
        {
            
        }
        public string nombreUsuario {  get; set; }
        
        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TxtUsuario_Enter(object sender, EventArgs e)
        {


        }

        private void TxtUsuario_Leave(object sender, EventArgs e)
        {

        }

        private void TxtContraseña_Enter(object sender, EventArgs e)
        {
            
        }

        private void TxtContraseña_Leave(object sender, EventArgs e)
        {

        }

        private void TxtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

 
        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            UserManager usermanager = new UserManager();
            
            string  usernameRecibido = TxtUsuario.Text;
            string passwordRecibido = TxtContraseña.Text;

            if (usermanager.validacion(usernameRecibido,passwordRecibido) == true)
            {
               this.DialogResult = DialogResult.OK;
               this.Close();
               usermanager.RegistrarInicioSesion(usernameRecibido);
            }
            LblUsuarioInactivo.Text = usermanager._labelUserInactive;
            LblUserIncorrect.Text = usermanager._labelUserIncorrect;

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton1_MouseDown(object sender, MouseEventArgs e)
        {
            TxtContraseña.UseSystemPasswordChar = false;
        }

        private void guna2ImageButton1_MouseUp(object sender, MouseEventArgs e)
        {
            TxtContraseña.UseSystemPasswordChar = true;

        }


        private void guna2PictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void LblUser_MouseDown(object sender, MouseEventArgs e)
        {
            //llamando los metodos para mover el formulario
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            //llamando los metodos para mover el formulario
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

     
    }
}
