using System;
using System.Windows.Forms;
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
            CargarDatosReporte();
        }

        private void CargarDatosReporte()
        {
            try
            {
                var inventario = new ManejarInventario();
                var lista = inventario.LeerProductos();
                DGVReporte.DataSource = lista;

                // Oculta la columna RutaImagenes (índice 8) si existe
                if (DGVReporte.Columns.Count > 8)
                    DGVReporte.Columns[8].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar productos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //private void BtnGenerarRepor_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        var productos = new ManejarInventario().LeerProductos();
        //        var reporte = new ManejoReporte();

        //        reporte.GenerarReporteInventario(productos);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Error al generar el reporte: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        //private void BtnGenerarReporteFecha_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        var inventario = new ManejarInventario();
        //        var productos = inventario.LeerProductos();

        //        DateTime desde = fecha1text.Value.Date;
        //        DateTime hasta = fecha2text.Value.Date;

        //        if (desde > hasta)
        //        {
        //            MessageBox.Show("La fecha 'Desde' no puede ser mayor que la fecha 'Hasta'.", "Fecha inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //            return;
        //        }

        //        var reporte = new ManejoReporte();
                
        //        reporte.GenerarReportePorFecha(productos, desde, hasta);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Error al generar reporte por fecha: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        private void LblFecha2_Click(object sender, EventArgs e)
        {
            // Puedes dejar este evento vacío o eliminarlo si no se usa.
        }

        private void BtnGenerarRepor_Click(object sender, EventArgs e)
        {

        }
    }
}
