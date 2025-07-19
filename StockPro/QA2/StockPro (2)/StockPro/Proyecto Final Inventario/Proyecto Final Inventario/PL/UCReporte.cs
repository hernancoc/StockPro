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
    public partial class UCReporte : UserControl
    {
        public UCReporte()
        {
            InitializeComponent();
        }

        private void UCReporte_Load(object sender, EventArgs e)
        {
            
            var inventario = new ManejarInventario(); // Creo el manejador de inventario

            var lista = inventario.LeerProductos(); //Leo la lista de productos

            DGVReporte.DataSource = lista; //La asigno al DataGridView
            DGVReporte.Columns[8].Visible = false;

        }

        private void BtnGenerarRepor_Click_1(object sender, EventArgs e)
        {
            var productos = new ManejarInventario().LeerProductos();//Creo el manejador de inventario y obtengo la lista

            var reporte = new ManejoReporte();//Creo el manejador de reportes

            reporte.GenerarReporteInventario(productos);// Le paso la lista de productos para que abra el SaveFileDialog y guarde el CSV
        }

        private void BtnGenerarReporteFecha_Click_1(object sender, EventArgs e)
        {
            ManejoReporte reporte = new ManejoReporte();
            ManejarInventario inventario = new ManejarInventario();

            var productos = inventario.LeerProductos();

            DateTime desde = fecha1text.Value;
            DateTime hasta = fecha2text.Value;

            reporte.GenerarReportePorFecha(productos, desde, hasta);
        }

        private void LblFecha2_Click(object sender, EventArgs e)
        {

        }

        
    }
}
