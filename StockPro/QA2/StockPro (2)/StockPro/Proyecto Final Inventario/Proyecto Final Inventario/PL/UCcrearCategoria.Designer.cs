namespace Proyecto_Final_Inventario.PL
{
    partial class UCcrearCategoria
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LblNombreCategoria = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.TxtNombreCate = new Guna.UI2.WinForms.Guna2TextBox();
            this.LblEstado = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LblDescripcionCate = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LblTituloCrearCategoria = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.DTPFechaCreacion = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.LblFechaCreacionCate = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.BtnDesactivar = new Guna.UI2.WinForms.Guna2Button();
            this.CbActivo = new System.Windows.Forms.CheckBox();
            this.BtnActivar = new Guna.UI2.WinForms.Guna2Button();
            this.TxtDescripcion = new System.Windows.Forms.RichTextBox();
            this.DGVCategoria = new Guna.UI2.WinForms.Guna2DataGridView();
            this.BtnCrear = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // LblNombreCategoria
            // 
            this.LblNombreCategoria.BackColor = System.Drawing.Color.Transparent;
            this.LblNombreCategoria.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombreCategoria.ForeColor = System.Drawing.Color.Green;
            this.LblNombreCategoria.Location = new System.Drawing.Point(165, 100);
            this.LblNombreCategoria.Name = "LblNombreCategoria";
            this.LblNombreCategoria.Size = new System.Drawing.Size(216, 25);
            this.LblNombreCategoria.TabIndex = 81;
            this.LblNombreCategoria.Text = "Nombre De Categoria";
            // 
            // TxtNombreCate
            // 
            this.TxtNombreCate.BorderColor = System.Drawing.Color.LightGray;
            this.TxtNombreCate.BorderRadius = 8;
            this.TxtNombreCate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtNombreCate.DefaultText = "";
            this.TxtNombreCate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtNombreCate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtNombreCate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtNombreCate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtNombreCate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtNombreCate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombreCate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtNombreCate.Location = new System.Drawing.Point(140, 151);
            this.TxtNombreCate.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.TxtNombreCate.MaxLength = 30;
            this.TxtNombreCate.Name = "TxtNombreCate";
            this.TxtNombreCate.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.TxtNombreCate.PlaceholderText = "";
            this.TxtNombreCate.SelectedText = "";
            this.TxtNombreCate.Size = new System.Drawing.Size(376, 49);
            this.TxtNombreCate.TabIndex = 80;
            this.TxtNombreCate.TextOffset = new System.Drawing.Point(10, 0);
            this.TxtNombreCate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombreCate_KeyPress);
            // 
            // LblEstado
            // 
            this.LblEstado.AutoSize = false;
            this.LblEstado.BackColor = System.Drawing.Color.Transparent;
            this.LblEstado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEstado.ForeColor = System.Drawing.Color.Green;
            this.LblEstado.Location = new System.Drawing.Point(170, 734);
            this.LblEstado.Name = "LblEstado";
            this.LblEstado.Size = new System.Drawing.Size(156, 60);
            this.LblEstado.TabIndex = 69;
            this.LblEstado.Text = "Estado";
            // 
            // LblDescripcionCate
            // 
            this.LblDescripcionCate.BackColor = System.Drawing.Color.Transparent;
            this.LblDescripcionCate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescripcionCate.ForeColor = System.Drawing.Color.Green;
            this.LblDescripcionCate.Location = new System.Drawing.Point(220, 251);
            this.LblDescripcionCate.Name = "LblDescripcionCate";
            this.LblDescripcionCate.Size = new System.Drawing.Size(121, 25);
            this.LblDescripcionCate.TabIndex = 68;
            this.LblDescripcionCate.Text = "Descripcion";
            // 
            // LblTituloCrearCategoria
            // 
            this.LblTituloCrearCategoria.BackColor = System.Drawing.Color.Transparent;
            this.LblTituloCrearCategoria.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTituloCrearCategoria.Location = new System.Drawing.Point(556, 20);
            this.LblTituloCrearCategoria.Name = "LblTituloCrearCategoria";
            this.LblTituloCrearCategoria.Size = new System.Drawing.Size(321, 48);
            this.LblTituloCrearCategoria.TabIndex = 62;
            this.LblTituloCrearCategoria.Text = "Crear Categoria";
            // 
            // DTPFechaCreacion
            // 
            this.DTPFechaCreacion.AutoRoundedCorners = true;
            this.DTPFechaCreacion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DTPFechaCreacion.BorderColor = System.Drawing.Color.Green;
            this.DTPFechaCreacion.BorderThickness = 2;
            this.DTPFechaCreacion.Checked = true;
            this.DTPFechaCreacion.FillColor = System.Drawing.Color.White;
            this.DTPFechaCreacion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DTPFechaCreacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPFechaCreacion.Location = new System.Drawing.Point(117, 646);
            this.DTPFechaCreacion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DTPFechaCreacion.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DTPFechaCreacion.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DTPFechaCreacion.Name = "DTPFechaCreacion";
            this.DTPFechaCreacion.Size = new System.Drawing.Size(399, 55);
            this.DTPFechaCreacion.TabIndex = 85;
            this.DTPFechaCreacion.Value = new System.DateTime(2025, 7, 5, 14, 46, 34, 593);
            // 
            // LblFechaCreacionCate
            // 
            this.LblFechaCreacionCate.BackColor = System.Drawing.Color.Transparent;
            this.LblFechaCreacionCate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFechaCreacionCate.ForeColor = System.Drawing.Color.Green;
            this.LblFechaCreacionCate.Location = new System.Drawing.Point(198, 600);
            this.LblFechaCreacionCate.Name = "LblFechaCreacionCate";
            this.LblFechaCreacionCate.Size = new System.Drawing.Size(157, 25);
            this.LblFechaCreacionCate.TabIndex = 86;
            this.LblFechaCreacionCate.Text = "Fecha Creacion";
            // 
            // BtnDesactivar
            // 
            this.BtnDesactivar.BorderRadius = 5;
            this.BtnDesactivar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnDesactivar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnDesactivar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnDesactivar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnDesactivar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(156)))), ((int)(((byte)(61)))));
            this.BtnDesactivar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnDesactivar.ForeColor = System.Drawing.Color.White;
            this.BtnDesactivar.Location = new System.Drawing.Point(907, 719);
            this.BtnDesactivar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnDesactivar.Name = "BtnDesactivar";
            this.BtnDesactivar.Size = new System.Drawing.Size(210, 55);
            this.BtnDesactivar.TabIndex = 88;
            this.BtnDesactivar.Text = "Desactivar";
            this.BtnDesactivar.Visible = false;
            this.BtnDesactivar.Click += new System.EventHandler(this.BtnDesactivar_Click);
            // 
            // CbActivo
            // 
            this.CbActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbActivo.ForeColor = System.Drawing.Color.Green;
            this.CbActivo.Location = new System.Drawing.Point(340, 734);
            this.CbActivo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CbActivo.Name = "CbActivo";
            this.CbActivo.Size = new System.Drawing.Size(123, 52);
            this.CbActivo.TabIndex = 89;
            this.CbActivo.Text = "Activo";
            this.CbActivo.UseVisualStyleBackColor = true;
            // 
            // BtnActivar
            // 
            this.BtnActivar.BorderRadius = 5;
            this.BtnActivar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnActivar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnActivar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnActivar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnActivar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(156)))), ((int)(((byte)(61)))));
            this.BtnActivar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnActivar.ForeColor = System.Drawing.Color.White;
            this.BtnActivar.Location = new System.Drawing.Point(1240, 719);
            this.BtnActivar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnActivar.Name = "BtnActivar";
            this.BtnActivar.Size = new System.Drawing.Size(210, 55);
            this.BtnActivar.TabIndex = 91;
            this.BtnActivar.Text = "Activar";
            this.BtnActivar.Visible = false;
            this.BtnActivar.Click += new System.EventHandler(this.BtnActivar_Click);
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtDescripcion.Location = new System.Drawing.Point(132, 297);
            this.TxtDescripcion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtDescripcion.MaxLength = 150;
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(382, 258);
            this.TxtDescripcion.TabIndex = 92;
            this.TxtDescripcion.Text = "";
            // 
            // DGVCategoria
            // 
            this.DGVCategoria.AllowUserToAddRows = false;
            this.DGVCategoria.AllowUserToDeleteRows = false;
            this.DGVCategoria.AllowUserToResizeColumns = false;
            this.DGVCategoria.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            this.DGVCategoria.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVCategoria.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVCategoria.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(201)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVCategoria.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVCategoria.GridColor = System.Drawing.Color.Gainsboro;
            this.DGVCategoria.Location = new System.Drawing.Point(804, 100);
            this.DGVCategoria.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DGVCategoria.Name = "DGVCategoria";
            this.DGVCategoria.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVCategoria.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DGVCategoria.RowHeadersVisible = false;
            this.DGVCategoria.RowHeadersWidth = 62;
            this.DGVCategoria.RowTemplate.Height = 28;
            this.DGVCategoria.Size = new System.Drawing.Size(734, 580);
            this.DGVCategoria.TabIndex = 93;
            this.DGVCategoria.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DGVCategoria.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DGVCategoria.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DGVCategoria.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DGVCategoria.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DGVCategoria.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DGVCategoria.ThemeStyle.GridColor = System.Drawing.Color.Gainsboro;
            this.DGVCategoria.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.DGVCategoria.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGVCategoria.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVCategoria.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DGVCategoria.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGVCategoria.ThemeStyle.HeaderStyle.Height = 30;
            this.DGVCategoria.ThemeStyle.ReadOnly = true;
            this.DGVCategoria.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVCategoria.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVCategoria.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVCategoria.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DGVCategoria.ThemeStyle.RowsStyle.Height = 28;
            this.DGVCategoria.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(201)))));
            this.DGVCategoria.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.DGVCategoria.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVCategoria_CellClick);
            this.DGVCategoria.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVCategoria_CellContentClick);
            // 
            // BtnCrear
            // 
            this.BtnCrear.BorderColor = System.Drawing.Color.White;
            this.BtnCrear.BorderRadius = 8;
            this.BtnCrear.BorderThickness = 1;
            this.BtnCrear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnCrear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnCrear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnCrear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnCrear.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(156)))), ((int)(((byte)(61)))));
            this.BtnCrear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnCrear.ForeColor = System.Drawing.Color.White;
            this.BtnCrear.Image = global::Proyecto_Final_Inventario.Properties.Resources.icons8_product_50;
            this.BtnCrear.ImageOffset = new System.Drawing.Point(-4, 0);
            this.BtnCrear.Location = new System.Drawing.Point(170, 805);
            this.BtnCrear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnCrear.Name = "BtnCrear";
            this.BtnCrear.Size = new System.Drawing.Size(300, 95);
            this.BtnCrear.TabIndex = 106;
            this.BtnCrear.Text = "Crear";
            this.BtnCrear.Click += new System.EventHandler(this.BtnCrear_Click);
            // 
            // UCcrearCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.BtnCrear);
            this.Controls.Add(this.DGVCategoria);
            this.Controls.Add(this.TxtDescripcion);
            this.Controls.Add(this.BtnActivar);
            this.Controls.Add(this.CbActivo);
            this.Controls.Add(this.BtnDesactivar);
            this.Controls.Add(this.LblFechaCreacionCate);
            this.Controls.Add(this.DTPFechaCreacion);
            this.Controls.Add(this.LblNombreCategoria);
            this.Controls.Add(this.TxtNombreCate);
            this.Controls.Add(this.LblEstado);
            this.Controls.Add(this.LblDescripcionCate);
            this.Controls.Add(this.LblTituloCrearCategoria);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UCcrearCategoria";
            this.Size = new System.Drawing.Size(1570, 917);
            this.Load += new System.EventHandler(this.UCcrearCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVCategoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel LblNombreCategoria;
        private Guna.UI2.WinForms.Guna2TextBox TxtNombreCate;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblEstado;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblDescripcionCate;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblTituloCrearCategoria;
        private Guna.UI2.WinForms.Guna2DateTimePicker DTPFechaCreacion;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblFechaCreacionCate;
        private Guna.UI2.WinForms.Guna2Button BtnDesactivar;
        private System.Windows.Forms.CheckBox CbActivo;
        private Guna.UI2.WinForms.Guna2Button BtnActivar;
        private System.Windows.Forms.RichTextBox TxtDescripcion;
        private Guna.UI2.WinForms.Guna2DataGridView DGVCategoria;
        private Guna.UI2.WinForms.Guna2Button BtnCrear;
    }
}
