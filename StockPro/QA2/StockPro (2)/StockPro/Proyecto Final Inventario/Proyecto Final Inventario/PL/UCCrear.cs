using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final_Inventario.PL
{
    public partial class UCCrear : UserControl
    {
        private Panel panelprincipal;
        public UCCrear(Panel panel)
        {
            InitializeComponent();
            this.panelprincipal = panel;
        }
        private void PanelCrearProducto_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void PanelCrearProducto_Producto_Paint(object sender, PaintEventArgs e)
        {
       
        }

        public static void AbrirCrearProducto() { 
        
            
        
        }

        private void UCCrear_Load(object sender, EventArgs e)
        {

        }

        private void ImagenCrearProducto_Click(object sender, EventArgs e)
        {
            panelprincipal.Controls.Clear();
            UCCrearProducto uCCrearProducto = new UCCrearProducto();
            uCCrearProducto.Dock = DockStyle.Fill;
            panelprincipal.Controls.Add(uCCrearProducto);

        }



        private void PanelCrearProducto_Paint_1(object sender, PaintEventArgs e)
        {

        }

        internal void MostrarCrearProducto()
        {
            
        }

        private void PanelCrear_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LblCrearProdu_Click(object sender, EventArgs e)
        {
            panelprincipal.Controls.Clear();
            UCCrearProducto uCCrearProducto = new UCCrearProducto();
            uCCrearProducto.Dock = DockStyle.Fill;
            panelprincipal.Controls.Add(uCCrearProducto);

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            panelprincipal.Controls.Clear();
            UCcrearCategoria uCcrearCategoria = new UCcrearCategoria();
            uCcrearCategoria.Dock = DockStyle.Fill;
            panelprincipal.Controls.Add(uCcrearCategoria);
        }

        private void PanelCrearCategoria_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblCategoria_Click(object sender, EventArgs e)
        {
            panelprincipal.Controls.Clear();
            UCcrearCategoria uCcrearCategoria = new UCcrearCategoria();
            uCcrearCategoria.Dock = DockStyle.Fill;
            panelprincipal.Controls.Add(uCcrearCategoria);
        }
    }
}
