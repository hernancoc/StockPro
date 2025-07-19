namespace Proyecto_Final_Inventario.PL
{
    partial class UCInventario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.NUDEntrada_Salida = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.CBDesactivar = new System.Windows.Forms.CheckBox();
            this.DGVInventario = new Guna.UI2.WinForms.Guna2DataGridView();
            this.CbActivar = new System.Windows.Forms.CheckBox();
            this.TxtFiltrar = new Guna.UI2.WinForms.Guna2TextBox();
            this.RBrojo = new System.Windows.Forms.RadioButton();
            this.RBAmarillo = new System.Windows.Forms.RadioButton();
            this.RBverde = new System.Windows.Forms.RadioButton();
            this.RbTodos = new System.Windows.Forms.RadioButton();
            this.RbActivos = new System.Windows.Forms.CheckBox();
            this.RbDesactivos = new System.Windows.Forms.CheckBox();
            this.pbimagen = new Guna.UI2.WinForms.Guna2PictureBox();
            this.BtnGuardar = new Guna.UI2.WinForms.Guna2Button();
            this.BtnSalida = new Guna.UI2.WinForms.Guna2Button();
            this.BtnEntrada = new Guna.UI2.WinForms.Guna2Button();
            this.TxtCategoriaDeProducto = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.NUDEntrada_Salida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVInventario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbimagen)).BeginInit();
            this.SuspendLayout();
            // 
            // NUDEntrada_Salida
            // 
            this.NUDEntrada_Salida.BackColor = System.Drawing.Color.White;
            this.NUDEntrada_Salida.BorderColor = System.Drawing.Color.ForestGreen;
            this.NUDEntrada_Salida.BorderRadius = 5;
            this.NUDEntrada_Salida.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NUDEntrada_Salida.FocusedState.BorderColor = System.Drawing.Color.DarkGreen;
            this.NUDEntrada_Salida.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUDEntrada_Salida.ForeColor = System.Drawing.Color.ForestGreen;
            this.NUDEntrada_Salida.Location = new System.Drawing.Point(550, 29);
            this.NUDEntrada_Salida.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NUDEntrada_Salida.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.NUDEntrada_Salida.Name = "NUDEntrada_Salida";
            this.NUDEntrada_Salida.Size = new System.Drawing.Size(70, 36);
            this.NUDEntrada_Salida.TabIndex = 54;
            this.NUDEntrada_Salida.UpDownButtonFillColor = System.Drawing.Color.ForestGreen;
            this.NUDEntrada_Salida.UpDownButtonForeColor = System.Drawing.Color.White;
            this.NUDEntrada_Salida.Visible = false;
            // 
            // CBDesactivar
            // 
            this.CBDesactivar.AutoSize = true;
            this.CBDesactivar.BackColor = System.Drawing.Color.White;
            this.CBDesactivar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBDesactivar.ForeColor = System.Drawing.Color.DarkGreen;
            this.CBDesactivar.Location = new System.Drawing.Point(20, 29);
            this.CBDesactivar.Name = "CBDesactivar";
            this.CBDesactivar.Size = new System.Drawing.Size(131, 29);
            this.CBDesactivar.TabIndex = 58;
            this.CBDesactivar.Text = "Deshabilitar";
            this.CBDesactivar.UseVisualStyleBackColor = true;
            this.CBDesactivar.Visible = false;
            // 
            // DGVInventario
            // 
            this.DGVInventario.AllowUserToAddRows = false;
            this.DGVInventario.AllowUserToDeleteRows = false;
            this.DGVInventario.AllowUserToResizeColumns = false;
            this.DGVInventario.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            this.DGVInventario.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.DGVInventario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVInventario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.DGVInventario.ColumnHeadersHeight = 40;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(201)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVInventario.DefaultCellStyle = dataGridViewCellStyle12;
            this.DGVInventario.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(200)))));
            this.DGVInventario.Location = new System.Drawing.Point(17, 193);
            this.DGVInventario.MultiSelect = false;
            this.DGVInventario.Name = "DGVInventario";
            this.DGVInventario.ReadOnly = true;
            this.DGVInventario.RowHeadersVisible = false;
            this.DGVInventario.RowHeadersWidth = 62;
            this.DGVInventario.RowTemplate.Height = 30;
            this.DGVInventario.Size = new System.Drawing.Size(1000, 400);
            this.DGVInventario.TabIndex = 94;
            this.DGVInventario.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DGVInventario.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DGVInventario.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DGVInventario.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DGVInventario.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DGVInventario.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DGVInventario.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(200)))));
            this.DGVInventario.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.DGVInventario.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGVInventario.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVInventario.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DGVInventario.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGVInventario.ThemeStyle.HeaderStyle.Height = 40;
            this.DGVInventario.ThemeStyle.ReadOnly = true;
            this.DGVInventario.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVInventario.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVInventario.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVInventario.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DGVInventario.ThemeStyle.RowsStyle.Height = 30;
            this.DGVInventario.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(201)))));
            this.DGVInventario.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.DGVInventario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVInventario_CellContentClick);
            this.DGVInventario.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DGVInventario_DataBindingComplete_1);
            this.DGVInventario.Click += new System.EventHandler(this.DGVInventario_Click_1);
            // 
            // CbActivar
            // 
            this.CbActivar.AutoSize = true;
            this.CbActivar.BackColor = System.Drawing.Color.White;
            this.CbActivar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbActivar.ForeColor = System.Drawing.Color.DarkGreen;
            this.CbActivar.Location = new System.Drawing.Point(20, 29);
            this.CbActivar.Name = "CbActivar";
            this.CbActivar.Size = new System.Drawing.Size(104, 29);
            this.CbActivar.TabIndex = 95;
            this.CbActivar.Text = "Habilitar";
            this.CbActivar.UseVisualStyleBackColor = true;
            this.CbActivar.Visible = false;
            // 
            // TxtFiltrar
            // 
            this.TxtFiltrar.BackColor = System.Drawing.Color.Green;
            this.TxtFiltrar.BorderRadius = 8;
            this.TxtFiltrar.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.TxtFiltrar.BorderThickness = 2;
            this.TxtFiltrar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtFiltrar.DefaultText = "";
            this.TxtFiltrar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtFiltrar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtFiltrar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtFiltrar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtFiltrar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtFiltrar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtFiltrar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtFiltrar.Location = new System.Drawing.Point(467, 104);
            this.TxtFiltrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtFiltrar.Name = "TxtFiltrar";
            this.TxtFiltrar.PlaceholderText = "Filtrar";
            this.TxtFiltrar.SelectedText = "";
            this.TxtFiltrar.Size = new System.Drawing.Size(328, 60);
            this.TxtFiltrar.TabIndex = 98;
            this.TxtFiltrar.TextChanged += new System.EventHandler(this.TxtFiltrar_TextChanged);
            // 
            // RBrojo
            // 
            this.RBrojo.AutoSize = true;
            this.RBrojo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RBrojo.ForeColor = System.Drawing.Color.Red;
            this.RBrojo.Location = new System.Drawing.Point(17, 89);
            this.RBrojo.Name = "RBrojo";
            this.RBrojo.Size = new System.Drawing.Size(73, 29);
            this.RBrojo.TabIndex = 100;
            this.RBrojo.TabStop = true;
            this.RBrojo.Text = "Rojo";
            this.RBrojo.UseVisualStyleBackColor = true;
            this.RBrojo.CheckedChanged += new System.EventHandler(this.RBrojo_CheckedChanged);
            // 
            // RBAmarillo
            // 
            this.RBAmarillo.AutoSize = true;
            this.RBAmarillo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RBAmarillo.ForeColor = System.Drawing.Color.Gold;
            this.RBAmarillo.Location = new System.Drawing.Point(96, 89);
            this.RBAmarillo.Name = "RBAmarillo";
            this.RBAmarillo.Size = new System.Drawing.Size(103, 29);
            this.RBAmarillo.TabIndex = 101;
            this.RBAmarillo.TabStop = true;
            this.RBAmarillo.Text = "Amarillo";
            this.RBAmarillo.UseVisualStyleBackColor = true;
            this.RBAmarillo.CheckedChanged += new System.EventHandler(this.RBAmarillo_CheckedChanged);
            // 
            // RBverde
            // 
            this.RBverde.AutoSize = true;
            this.RBverde.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RBverde.ForeColor = System.Drawing.Color.Green;
            this.RBverde.Location = new System.Drawing.Point(199, 89);
            this.RBverde.Name = "RBverde";
            this.RBverde.Size = new System.Drawing.Size(82, 29);
            this.RBverde.TabIndex = 102;
            this.RBverde.TabStop = true;
            this.RBverde.Text = "Verde";
            this.RBverde.UseVisualStyleBackColor = true;
            this.RBverde.CheckedChanged += new System.EventHandler(this.RBverde_CheckedChanged);
            // 
            // RbTodos
            // 
            this.RbTodos.AutoSize = true;
            this.RbTodos.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RbTodos.Location = new System.Drawing.Point(287, 89);
            this.RbTodos.Name = "RbTodos";
            this.RbTodos.Size = new System.Drawing.Size(85, 29);
            this.RbTodos.TabIndex = 103;
            this.RbTodos.TabStop = true;
            this.RbTodos.Text = "Todos";
            this.RbTodos.UseVisualStyleBackColor = true;
            this.RbTodos.CheckedChanged += new System.EventHandler(this.RbTodos_CheckedChanged);
            // 
            // RbActivos
            // 
            this.RbActivos.AutoSize = true;
            this.RbActivos.BackColor = System.Drawing.Color.White;
            this.RbActivos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbActivos.ForeColor = System.Drawing.Color.DarkGreen;
            this.RbActivos.Location = new System.Drawing.Point(28, 146);
            this.RbActivos.Name = "RbActivos";
            this.RbActivos.Size = new System.Drawing.Size(96, 29);
            this.RbActivos.TabIndex = 106;
            this.RbActivos.Text = "Activos";
            this.RbActivos.UseVisualStyleBackColor = true;
            this.RbActivos.CheckedChanged += new System.EventHandler(this.RbActivos_CheckedChanged_1);
            // 
            // RbDesactivos
            // 
            this.RbDesactivos.AutoSize = true;
            this.RbDesactivos.BackColor = System.Drawing.Color.White;
            this.RbDesactivos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbDesactivos.ForeColor = System.Drawing.Color.DarkGreen;
            this.RbDesactivos.Location = new System.Drawing.Point(149, 146);
            this.RbDesactivos.Name = "RbDesactivos";
            this.RbDesactivos.Size = new System.Drawing.Size(123, 29);
            this.RbDesactivos.TabIndex = 107;
            this.RbDesactivos.Text = "Desactivos";
            this.RbDesactivos.UseVisualStyleBackColor = true;
            this.RbDesactivos.CheckedChanged += new System.EventHandler(this.RbDesactivos_CheckedChanged_1);
            // 
            // pbimagen
            // 
            this.pbimagen.BackColor = System.Drawing.Color.Transparent;
            this.pbimagen.BorderRadius = 8;
            this.pbimagen.ImageRotate = 0F;
            this.pbimagen.Location = new System.Drawing.Point(815, 3);
            this.pbimagen.Name = "pbimagen";
            this.pbimagen.Size = new System.Drawing.Size(205, 155);
            this.pbimagen.TabIndex = 99;
            this.pbimagen.TabStop = false;
            this.pbimagen.Click += new System.EventHandler(this.pbimagen_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BorderColor = System.Drawing.Color.Transparent;
            this.BtnGuardar.BorderRadius = 8;
            this.BtnGuardar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnGuardar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnGuardar.DisabledState.FillColor = System.Drawing.Color.Gray;
            this.BtnGuardar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnGuardar.FillColor = System.Drawing.Color.Green;
            this.BtnGuardar.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold);
            this.BtnGuardar.ForeColor = System.Drawing.Color.White;
            this.BtnGuardar.HoverState.FillColor = System.Drawing.Color.DarkGreen;
            this.BtnGuardar.Image = global::Proyecto_Final_Inventario.Properties.Resources.icons8_save_50;
            this.BtnGuardar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnGuardar.ImageSize = new System.Drawing.Size(24, 24);
            this.BtnGuardar.Location = new System.Drawing.Point(168, 20);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(63)))));
            this.BtnGuardar.Size = new System.Drawing.Size(135, 45);
            this.BtnGuardar.TabIndex = 97;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.TextOffset = new System.Drawing.Point(18, 0);
            this.BtnGuardar.Visible = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click_1);
            // 
            // BtnSalida
            // 
            this.BtnSalida.BorderColor = System.Drawing.Color.Transparent;
            this.BtnSalida.BorderRadius = 8;
            this.BtnSalida.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnSalida.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnSalida.DisabledState.FillColor = System.Drawing.Color.Gray;
            this.BtnSalida.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnSalida.FillColor = System.Drawing.Color.Green;
            this.BtnSalida.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold);
            this.BtnSalida.ForeColor = System.Drawing.Color.White;
            this.BtnSalida.HoverState.FillColor = System.Drawing.Color.DarkGreen;
            this.BtnSalida.Image = global::Proyecto_Final_Inventario.Properties.Resources.icons8_subtraction_50;
            this.BtnSalida.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnSalida.ImageSize = new System.Drawing.Size(24, 24);
            this.BtnSalida.Location = new System.Drawing.Point(643, 20);
            this.BtnSalida.Name = "BtnSalida";
            this.BtnSalida.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(63)))));
            this.BtnSalida.Size = new System.Drawing.Size(135, 45);
            this.BtnSalida.TabIndex = 96;
            this.BtnSalida.Text = "Salida";
            this.BtnSalida.TextOffset = new System.Drawing.Point(18, 0);
            this.BtnSalida.Visible = false;
            this.BtnSalida.Click += new System.EventHandler(this.BtnSalida_Click_1);
            // 
            // BtnEntrada
            // 
            this.BtnEntrada.BorderColor = System.Drawing.Color.Transparent;
            this.BtnEntrada.BorderRadius = 8;
            this.BtnEntrada.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnEntrada.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnEntrada.DisabledState.FillColor = System.Drawing.Color.Gray;
            this.BtnEntrada.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnEntrada.FillColor = System.Drawing.Color.Green;
            this.BtnEntrada.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold);
            this.BtnEntrada.ForeColor = System.Drawing.Color.White;
            this.BtnEntrada.HoverState.FillColor = System.Drawing.Color.DarkGreen;
            this.BtnEntrada.Image = global::Proyecto_Final_Inventario.Properties.Resources.icons8_plus_32;
            this.BtnEntrada.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnEntrada.ImageSize = new System.Drawing.Size(24, 24);
            this.BtnEntrada.Location = new System.Drawing.Point(398, 20);
            this.BtnEntrada.Name = "BtnEntrada";
            this.BtnEntrada.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(63)))));
            this.BtnEntrada.Size = new System.Drawing.Size(135, 45);
            this.BtnEntrada.TabIndex = 1;
            this.BtnEntrada.Text = "Entrada";
            this.BtnEntrada.TextOffset = new System.Drawing.Point(18, 0);
            this.BtnEntrada.Visible = false;
            this.BtnEntrada.Click += new System.EventHandler(this.BtnEntrada_Click_1);
            // 
            // TxtCategoriaDeProducto
            // 
            this.TxtCategoriaDeProducto.BackColor = System.Drawing.Color.Transparent;
            this.TxtCategoriaDeProducto.BorderColor = System.Drawing.Color.LightGray;
            this.TxtCategoriaDeProducto.BorderRadius = 8;
            this.TxtCategoriaDeProducto.DisplayMember = "kkk";
            this.TxtCategoriaDeProducto.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.TxtCategoriaDeProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TxtCategoriaDeProducto.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtCategoriaDeProducto.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtCategoriaDeProducto.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TxtCategoriaDeProducto.ForeColor = System.Drawing.Color.Black;
            this.TxtCategoriaDeProducto.ItemHeight = 30;
            this.TxtCategoriaDeProducto.Location = new System.Drawing.Point(278, 128);
            this.TxtCategoriaDeProducto.Name = "TxtCategoriaDeProducto";
            this.TxtCategoriaDeProducto.Size = new System.Drawing.Size(176, 36);
            this.TxtCategoriaDeProducto.TabIndex = 108;
            this.TxtCategoriaDeProducto.SelectedIndexChanged += new System.EventHandler(this.TxtCategoriaDeProducto_SelectedIndexChanged);
            this.TxtCategoriaDeProducto.SelectionChangeCommitted += new System.EventHandler(this.TxtCategoriaDeProducto_SelectionChangeCommitted);
            this.TxtCategoriaDeProducto.SelectedValueChanged += new System.EventHandler(this.TxtCategoriaDeProducto_SelectedValueChanged);
            // 
            // UCInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.TxtCategoriaDeProducto);
            this.Controls.Add(this.RbDesactivos);
            this.Controls.Add(this.RbActivos);
            this.Controls.Add(this.RbTodos);
            this.Controls.Add(this.RBverde);
            this.Controls.Add(this.RBAmarillo);
            this.Controls.Add(this.RBrojo);
            this.Controls.Add(this.pbimagen);
            this.Controls.Add(this.TxtFiltrar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.BtnSalida);
            this.Controls.Add(this.CbActivar);
            this.Controls.Add(this.DGVInventario);
            this.Controls.Add(this.CBDesactivar);
            this.Controls.Add(this.NUDEntrada_Salida);
            this.Controls.Add(this.BtnEntrada);
            this.Location = new System.Drawing.Point(280, 80);
            this.Name = "UCInventario";
            this.Size = new System.Drawing.Size(1050, 650);
            this.Load += new System.EventHandler(this.UCInventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NUDEntrada_Salida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVInventario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbimagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button BtnEntrada;
        private Guna.UI2.WinForms.Guna2NumericUpDown NUDEntrada_Salida;
        private System.Windows.Forms.CheckBox CBDesactivar;
        private Guna.UI2.WinForms.Guna2DataGridView DGVInventario;
        private System.Windows.Forms.CheckBox CbActivar;
        private Guna.UI2.WinForms.Guna2Button BtnSalida;
        private Guna.UI2.WinForms.Guna2Button BtnGuardar;
        private Guna.UI2.WinForms.Guna2TextBox TxtFiltrar;
        private Guna.UI2.WinForms.Guna2PictureBox pbimagen;
        private System.Windows.Forms.RadioButton RBrojo;
        private System.Windows.Forms.RadioButton RBAmarillo;
        private System.Windows.Forms.RadioButton RBverde;
        private System.Windows.Forms.RadioButton RbTodos;
        private System.Windows.Forms.CheckBox RbActivos;
        private System.Windows.Forms.CheckBox RbDesactivos;
        private Guna.UI2.WinForms.Guna2ComboBox TxtCategoriaDeProducto;
    }
}
