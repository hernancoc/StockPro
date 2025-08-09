namespace Proyecto_Final_Inventario.PL
{
    partial class UCReporte
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.OFDReporte = new System.Windows.Forms.OpenFileDialog();
            this.DGVReporte = new Guna.UI2.WinForms.Guna2DataGridView();
            this.fecha2text = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.fecha1text = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.LblFecha1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LblFecha2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.BtnGenerarReporteFecha = new Guna.UI2.WinForms.Guna2Button();
            this.LblTituloCrearProducto = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.BtnGenerarRepor = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVReporte)).BeginInit();
            this.SuspendLayout();
            // 
            // OFDReporte
            // 
            this.OFDReporte.FileName = "openFileDialog1";
            // 
            // DGVReporte
            // 
            this.DGVReporte.AllowUserToAddRows = false;
            this.DGVReporte.AllowUserToDeleteRows = false;
            this.DGVReporte.AllowUserToResizeColumns = false;
            this.DGVReporte.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            this.DGVReporte.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVReporte.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVReporte.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVReporte.ColumnHeadersHeight = 40;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(201)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVReporte.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVReporte.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(200)))));
            this.DGVReporte.Location = new System.Drawing.Point(9, 274);
            this.DGVReporte.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DGVReporte.MultiSelect = false;
            this.DGVReporte.Name = "DGVReporte";
            this.DGVReporte.ReadOnly = true;
            this.DGVReporte.RowHeadersVisible = false;
            this.DGVReporte.RowHeadersWidth = 62;
            this.DGVReporte.RowTemplate.Height = 30;
            this.DGVReporte.Size = new System.Drawing.Size(1554, 615);
            this.DGVReporte.TabIndex = 95;
            this.DGVReporte.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DGVReporte.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DGVReporte.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DGVReporte.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DGVReporte.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DGVReporte.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DGVReporte.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(200)))));
            this.DGVReporte.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.DGVReporte.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGVReporte.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVReporte.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DGVReporte.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGVReporte.ThemeStyle.HeaderStyle.Height = 40;
            this.DGVReporte.ThemeStyle.ReadOnly = true;
            this.DGVReporte.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVReporte.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVReporte.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVReporte.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DGVReporte.ThemeStyle.RowsStyle.Height = 30;
            this.DGVReporte.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(201)))));
            this.DGVReporte.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // fecha2text
            // 
            this.fecha2text.Checked = true;
            this.fecha2text.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(156)))), ((int)(((byte)(61)))));
            this.fecha2text.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.fecha2text.ForeColor = System.Drawing.Color.White;
            this.fecha2text.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fecha2text.Location = new System.Drawing.Point(1350, 74);
            this.fecha2text.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fecha2text.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.fecha2text.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.fecha2text.Name = "fecha2text";
            this.fecha2text.Size = new System.Drawing.Size(200, 65);
            this.fecha2text.TabIndex = 97;
            this.fecha2text.Value = new System.DateTime(2025, 7, 8, 13, 43, 33, 424);
            // 
            // fecha1text
            // 
            this.fecha1text.Checked = true;
            this.fecha1text.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(156)))), ((int)(((byte)(61)))));
            this.fecha1text.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.fecha1text.ForeColor = System.Drawing.Color.White;
            this.fecha1text.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fecha1text.Location = new System.Drawing.Point(1350, 186);
            this.fecha1text.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fecha1text.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.fecha1text.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.fecha1text.Name = "fecha1text";
            this.fecha1text.Size = new System.Drawing.Size(200, 65);
            this.fecha1text.TabIndex = 98;
            this.fecha1text.Value = new System.DateTime(2025, 7, 8, 0, 25, 43, 762);
            // 
            // LblFecha1
            // 
            this.LblFecha1.BackColor = System.Drawing.Color.Transparent;
            this.LblFecha1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.LblFecha1.Location = new System.Drawing.Point(1350, 31);
            this.LblFecha1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LblFecha1.Name = "LblFecha1";
            this.LblFecha1.Size = new System.Drawing.Size(98, 23);
            this.LblFecha1.TabIndex = 99;
            this.LblFecha1.Text = "Fecha Desde";
            // 
            // LblFecha2
            // 
            this.LblFecha2.BackColor = System.Drawing.Color.Transparent;
            this.LblFecha2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFecha2.Location = new System.Drawing.Point(1350, 148);
            this.LblFecha2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LblFecha2.Name = "LblFecha2";
            this.LblFecha2.Size = new System.Drawing.Size(94, 23);
            this.LblFecha2.TabIndex = 100;
            this.LblFecha2.Text = "Fecha Hasta";
            this.LblFecha2.Click += new System.EventHandler(this.LblFecha2_Click);
            // 
            // BtnGenerarReporteFecha
            // 
            this.BtnGenerarReporteFecha.BorderColor = System.Drawing.Color.White;
            this.BtnGenerarReporteFecha.BorderRadius = 8;
            this.BtnGenerarReporteFecha.BorderThickness = 1;
            this.BtnGenerarReporteFecha.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnGenerarReporteFecha.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnGenerarReporteFecha.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnGenerarReporteFecha.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnGenerarReporteFecha.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(156)))), ((int)(((byte)(61)))));
            this.BtnGenerarReporteFecha.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnGenerarReporteFecha.ForeColor = System.Drawing.Color.White;
            this.BtnGenerarReporteFecha.Image = global::Proyecto_Final_Inventario.Properties.Resources.icons8_print_50;
            this.BtnGenerarReporteFecha.Location = new System.Drawing.Point(1014, 132);
            this.BtnGenerarReporteFecha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnGenerarReporteFecha.Name = "BtnGenerarReporteFecha";
            this.BtnGenerarReporteFecha.Size = new System.Drawing.Size(270, 91);
            this.BtnGenerarReporteFecha.TabIndex = 107;
            this.BtnGenerarReporteFecha.Text = "Generar por fecha";
            // 
            // LblTituloCrearProducto
            // 
            this.LblTituloCrearProducto.BackColor = System.Drawing.Color.Transparent;
            this.LblTituloCrearProducto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTituloCrearProducto.Location = new System.Drawing.Point(662, 31);
            this.LblTituloCrearProducto.Name = "LblTituloCrearProducto";
            this.LblTituloCrearProducto.Size = new System.Drawing.Size(183, 48);
            this.LblTituloCrearProducto.TabIndex = 108;
            this.LblTituloCrearProducto.Text = "Reportes";
            // 
            // BtnGenerarRepor
            // 
            this.BtnGenerarRepor.BorderColor = System.Drawing.Color.White;
            this.BtnGenerarRepor.BorderRadius = 8;
            this.BtnGenerarRepor.BorderThickness = 1;
            this.BtnGenerarRepor.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnGenerarRepor.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnGenerarRepor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnGenerarRepor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnGenerarRepor.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(156)))), ((int)(((byte)(61)))));
            this.BtnGenerarRepor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnGenerarRepor.ForeColor = System.Drawing.Color.White;
            this.BtnGenerarRepor.Image = global::Proyecto_Final_Inventario.Properties.Resources.icons8_print_50;
            this.BtnGenerarRepor.Location = new System.Drawing.Point(106, 132);
            this.BtnGenerarRepor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnGenerarRepor.Name = "BtnGenerarRepor";
            this.BtnGenerarRepor.Size = new System.Drawing.Size(297, 91);
            this.BtnGenerarRepor.TabIndex = 106;
            this.BtnGenerarRepor.Text = "Generar Reporte";
            this.BtnGenerarRepor.Click += new System.EventHandler(this.BtnGenerarRepor_Click);
            // 
            // UCReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.LblTituloCrearProducto);
            this.Controls.Add(this.BtnGenerarReporteFecha);
            this.Controls.Add(this.BtnGenerarRepor);
            this.Controls.Add(this.LblFecha2);
            this.Controls.Add(this.LblFecha1);
            this.Controls.Add(this.fecha1text);
            this.Controls.Add(this.fecha2text);
            this.Controls.Add(this.DGVReporte);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UCReporte";
            this.Size = new System.Drawing.Size(1575, 923);
            this.Load += new System.EventHandler(this.UCReporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVReporte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog OFDReporte;
        private Guna.UI2.WinForms.Guna2DataGridView DGVReporte;
        private Guna.UI2.WinForms.Guna2DateTimePicker fecha2text;
        private Guna.UI2.WinForms.Guna2DateTimePicker fecha1text;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblFecha1;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblFecha2;
        private Guna.UI2.WinForms.Guna2Button BtnGenerarRepor;
        private Guna.UI2.WinForms.Guna2Button BtnGenerarReporteFecha;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblTituloCrearProducto;
    }
}
