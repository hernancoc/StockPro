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
    public partial class UCAcerdemi : UserControl
    {
        public UCAcerdemi()
        {
            InitializeComponent();
        }

        private void UCAcerdemi_Load(object sender, EventArgs e)
        {
            panelContenido.Anchor = AnchorStyles.None;
            panelContenido.AutoSize = true;
            panelContenido.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }
    }
}
