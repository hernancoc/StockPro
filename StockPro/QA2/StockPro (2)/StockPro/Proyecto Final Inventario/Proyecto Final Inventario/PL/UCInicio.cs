using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_Final_Inventario.Entidades;
using Proyecto_Final_Inventario.Logica;

namespace Proyecto_Final_Inventario.PL
{
    public partial class UCInicio : UserControl
    {
        public UCInicio()
        {
            InitializeComponent();
        }

        private void UCInicio_Load(object sender, EventArgs e)
        {
            lblbienvenido.Text = $"Bienvenido: {UserManager.UsuarioActual.ToString().ToUpper()}";
        }

        private void lblbienvenido_Click(object sender, EventArgs e)
        {

        }
    }
}
