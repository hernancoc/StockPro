using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_Final_Inventario.PL;

namespace Proyecto_Final_Inventario
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FrmLogin frmlogin = new FrmLogin();
            FrmInicio frminicio = new FrmInicio();
            if (frmlogin.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new FrmInicio());

            }

            //Application.Run(new FrmInicio());


        }
    }
}
