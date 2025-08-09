namespace Proyecto_Final_Inventario.PL
{
    partial class UCCrearProducto
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
            this.LblTituloCrearProducto = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.TxtId = new Guna.UI2.WinForms.Guna2TextBox();
            this.TxtCategoriaDeProducto = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.TxtCantidad = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.CbActivoEntrada_Salida = new System.Windows.Forms.CheckBox();
            this.TxtProveedor = new Guna.UI2.WinForms.Guna2TextBox();
            this.TxtPrecioCompra = new Guna.UI2.WinForms.Guna2TextBox();
            this.TxtPrecioVenta = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel8 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.TxtNombreProd = new Guna.UI2.WinForms.Guna2TextBox();
            this.OFDImgProduct = new System.Windows.Forms.OpenFileDialog();
            this.TxtRutaImg = new Guna.UI2.WinForms.Guna2TextBox();
            this.BtnEditar = new Guna.UI2.WinForms.Guna2Button();
            this.BtnCrearProducto = new Guna.UI2.WinForms.Guna2Button();
            this.BtnImagen = new Guna.UI2.WinForms.Guna2Button();
            this.PBImgProductos = new Guna.UI2.WinForms.Guna2PictureBox();
            this.picIconoProducto = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBImgProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIconoProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTituloCrearProducto
            // 
            this.LblTituloCrearProducto.BackColor = System.Drawing.Color.Transparent;
            this.LblTituloCrearProducto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTituloCrearProducto.Location = new System.Drawing.Point(538, 20);
            this.LblTituloCrearProducto.Name = "LblTituloCrearProducto";
            this.LblTituloCrearProducto.Size = new System.Drawing.Size(408, 48);
            this.LblTituloCrearProducto.TabIndex = 39;
            this.LblTituloCrearProducto.Text = "Gestionar Productos";
            // 
            // TxtId
            // 
            this.TxtId.BorderColor = System.Drawing.Color.LightGray;
            this.TxtId.BorderRadius = 8;
            this.TxtId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtId.DefaultText = "";
            this.TxtId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtId.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtId.Location = new System.Drawing.Point(471, 113);
            this.TxtId.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.TxtId.MaxLength = 15;
            this.TxtId.Name = "TxtId";
            this.TxtId.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.TxtId.PlaceholderText = "";
            this.TxtId.SelectedText = "";
            this.TxtId.Size = new System.Drawing.Size(134, 49);
            this.TxtId.TabIndex = 41;
            this.TxtId.TextOffset = new System.Drawing.Point(10, 0);
            this.TxtId.Visible = false;
            this.TxtId.TextChanged += new System.EventHandler(this.TxtId_TextChanged);
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
            this.TxtCategoriaDeProducto.Location = new System.Drawing.Point(471, 394);
            this.TxtCategoriaDeProducto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtCategoriaDeProducto.Name = "TxtCategoriaDeProducto";
            this.TxtCategoriaDeProducto.Size = new System.Drawing.Size(338, 36);
            this.TxtCategoriaDeProducto.TabIndex = 42;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Green;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(471, 89);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(151, 25);
            this.guna2HtmlLabel1.TabIndex = 45;
            this.guna2HtmlLabel1.Text = "ID De Producto";
            this.guna2HtmlLabel1.Visible = false;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.Green;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(471, 331);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(227, 25);
            this.guna2HtmlLabel2.TabIndex = 46;
            this.guna2HtmlLabel2.Text = "Categoria De Producto";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.Green;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(471, 452);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(106, 25);
            this.guna2HtmlLabel3.TabIndex = 48;
            this.guna2HtmlLabel3.Text = "Proveedor";
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.Green;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(908, 219);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(150, 25);
            this.guna2HtmlLabel4.TabIndex = 50;
            this.guna2HtmlLabel4.Text = "Precio Compra";
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.Green;
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(908, 352);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(128, 25);
            this.guna2HtmlLabel5.TabIndex = 52;
            this.guna2HtmlLabel5.Text = "Precio Venta";
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.BackColor = System.Drawing.Color.Transparent;
            this.TxtCantidad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtCantidad.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TxtCantidad.Location = new System.Drawing.Point(958, 520);
            this.TxtCantidad.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(118, 65);
            this.TxtCantidad.TabIndex = 53;
            this.TxtCantidad.UpDownButtonFillColor = System.Drawing.Color.Green;
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.ForeColor = System.Drawing.Color.Green;
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(908, 477);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(154, 25);
            this.guna2HtmlLabel6.TabIndex = 54;
            this.guna2HtmlLabel6.Text = "Cantidad Inicial";
            // 
            // CbActivoEntrada_Salida
            // 
            this.CbActivoEntrada_Salida.AutoSize = true;
            this.CbActivoEntrada_Salida.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbActivoEntrada_Salida.ForeColor = System.Drawing.Color.Green;
            this.CbActivoEntrada_Salida.Location = new System.Drawing.Point(592, 612);
            this.CbActivoEntrada_Salida.Name = "CbActivoEntrada_Salida";
            this.CbActivoEntrada_Salida.Size = new System.Drawing.Size(323, 29);
            this.CbActivoEntrada_Salida.TabIndex = 55;
            this.CbActivoEntrada_Salida.Text = "Producto Activo Para Entrada/Salida";
            this.CbActivoEntrada_Salida.UseVisualStyleBackColor = true;
            // 
            // TxtProveedor
            // 
            this.TxtProveedor.BorderColor = System.Drawing.Color.LightGray;
            this.TxtProveedor.BorderRadius = 8;
            this.TxtProveedor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtProveedor.DefaultText = "";
            this.TxtProveedor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtProveedor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtProveedor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtProveedor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtProveedor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtProveedor.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtProveedor.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtProveedor.Location = new System.Drawing.Point(471, 520);
            this.TxtProveedor.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.TxtProveedor.MaxLength = 30;
            this.TxtProveedor.Name = "TxtProveedor";
            this.TxtProveedor.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.TxtProveedor.PlaceholderText = "";
            this.TxtProveedor.SelectedText = "";
            this.TxtProveedor.Size = new System.Drawing.Size(340, 49);
            this.TxtProveedor.TabIndex = 42;
            this.TxtProveedor.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // TxtPrecioCompra
            // 
            this.TxtPrecioCompra.BorderColor = System.Drawing.Color.LightGray;
            this.TxtPrecioCompra.BorderRadius = 8;
            this.TxtPrecioCompra.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtPrecioCompra.DefaultText = "";
            this.TxtPrecioCompra.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtPrecioCompra.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtPrecioCompra.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtPrecioCompra.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtPrecioCompra.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtPrecioCompra.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrecioCompra.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtPrecioCompra.Location = new System.Drawing.Point(908, 254);
            this.TxtPrecioCompra.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.TxtPrecioCompra.MaxLength = 9999999;
            this.TxtPrecioCompra.Name = "TxtPrecioCompra";
            this.TxtPrecioCompra.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.TxtPrecioCompra.PlaceholderText = "RD$";
            this.TxtPrecioCompra.SelectedText = "";
            this.TxtPrecioCompra.Size = new System.Drawing.Size(206, 46);
            this.TxtPrecioCompra.TabIndex = 49;
            this.TxtPrecioCompra.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // TxtPrecioVenta
            // 
            this.TxtPrecioVenta.BorderColor = System.Drawing.Color.LightGray;
            this.TxtPrecioVenta.BorderRadius = 8;
            this.TxtPrecioVenta.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtPrecioVenta.DefaultText = "";
            this.TxtPrecioVenta.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtPrecioVenta.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtPrecioVenta.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtPrecioVenta.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtPrecioVenta.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtPrecioVenta.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrecioVenta.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtPrecioVenta.Location = new System.Drawing.Point(908, 384);
            this.TxtPrecioVenta.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.TxtPrecioVenta.MaxLength = 9999999;
            this.TxtPrecioVenta.Name = "TxtPrecioVenta";
            this.TxtPrecioVenta.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.TxtPrecioVenta.PlaceholderText = "RD$";
            this.TxtPrecioVenta.SelectedText = "";
            this.TxtPrecioVenta.Size = new System.Drawing.Size(206, 46);
            this.TxtPrecioVenta.TabIndex = 57;
            this.TxtPrecioVenta.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // guna2HtmlLabel8
            // 
            this.guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel8.ForeColor = System.Drawing.Color.Green;
            this.guna2HtmlLabel8.Location = new System.Drawing.Point(471, 197);
            this.guna2HtmlLabel8.Name = "guna2HtmlLabel8";
            this.guna2HtmlLabel8.Size = new System.Drawing.Size(82, 25);
            this.guna2HtmlLabel8.TabIndex = 61;
            this.guna2HtmlLabel8.Text = "Nombre";
            // 
            // TxtNombreProd
            // 
            this.TxtNombreProd.BorderColor = System.Drawing.Color.LightGray;
            this.TxtNombreProd.BorderRadius = 8;
            this.TxtNombreProd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtNombreProd.DefaultText = "";
            this.TxtNombreProd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtNombreProd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtNombreProd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtNombreProd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtNombreProd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtNombreProd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombreProd.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtNombreProd.Location = new System.Drawing.Point(471, 251);
            this.TxtNombreProd.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.TxtNombreProd.MaxLength = 50;
            this.TxtNombreProd.Name = "TxtNombreProd";
            this.TxtNombreProd.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.TxtNombreProd.PlaceholderText = "";
            this.TxtNombreProd.SelectedText = "";
            this.TxtNombreProd.Size = new System.Drawing.Size(340, 49);
            this.TxtNombreProd.TabIndex = 60;
            this.TxtNombreProd.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // OFDImgProduct
            // 
            this.OFDImgProduct.FileName = "openFileDialog1";
            // 
            // TxtRutaImg
            // 
            this.TxtRutaImg.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtRutaImg.DefaultText = "";
            this.TxtRutaImg.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtRutaImg.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtRutaImg.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtRutaImg.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtRutaImg.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtRutaImg.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtRutaImg.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtRutaImg.Location = new System.Drawing.Point(114, 612);
            this.TxtRutaImg.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.TxtRutaImg.Name = "TxtRutaImg";
            this.TxtRutaImg.PlaceholderText = "";
            this.TxtRutaImg.SelectedText = "";
            this.TxtRutaImg.Size = new System.Drawing.Size(116, 35);
            this.TxtRutaImg.TabIndex = 102;
            this.TxtRutaImg.Visible = false;
            // 
            // BtnEditar
            // 
            this.BtnEditar.BorderColor = System.Drawing.Color.White;
            this.BtnEditar.BorderRadius = 8;
            this.BtnEditar.BorderThickness = 1;
            this.BtnEditar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnEditar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnEditar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnEditar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnEditar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(156)))), ((int)(((byte)(61)))));
            this.BtnEditar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnEditar.ForeColor = System.Drawing.Color.White;
            this.BtnEditar.Location = new System.Drawing.Point(708, 734);
            this.BtnEditar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(270, 69);
            this.BtnEditar.TabIndex = 104;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.Visible = false;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnCrearProducto
            // 
            this.BtnCrearProducto.BorderColor = System.Drawing.Color.White;
            this.BtnCrearProducto.BorderRadius = 8;
            this.BtnCrearProducto.BorderThickness = 1;
            this.BtnCrearProducto.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnCrearProducto.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnCrearProducto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnCrearProducto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnCrearProducto.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(156)))), ((int)(((byte)(61)))));
            this.BtnCrearProducto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnCrearProducto.ForeColor = System.Drawing.Color.White;
            this.BtnCrearProducto.Image = global::Proyecto_Final_Inventario.Properties.Resources.icons8_product_50;
            this.BtnCrearProducto.Location = new System.Drawing.Point(690, 734);
            this.BtnCrearProducto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnCrearProducto.Name = "BtnCrearProducto";
            this.BtnCrearProducto.Size = new System.Drawing.Size(288, 103);
            this.BtnCrearProducto.TabIndex = 105;
            this.BtnCrearProducto.Text = " Crear Producto";
            this.BtnCrearProducto.Click += new System.EventHandler(this.BtnCrearProducto_Click);
            // 
            // BtnImagen
            // 
            this.BtnImagen.BorderRadius = 20;
            this.BtnImagen.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnImagen.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnImagen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnImagen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnImagen.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(156)))), ((int)(((byte)(61)))));
            this.BtnImagen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnImagen.ForeColor = System.Drawing.Color.White;
            this.BtnImagen.Image = global::Proyecto_Final_Inventario.Properties.Resources.icons8_image_50;
            this.BtnImagen.Location = new System.Drawing.Point(1210, 403);
            this.BtnImagen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnImagen.Name = "BtnImagen";
            this.BtnImagen.Size = new System.Drawing.Size(330, 74);
            this.BtnImagen.TabIndex = 101;
            this.BtnImagen.Text = " Seleccionar imagen";
            this.BtnImagen.Click += new System.EventHandler(this.BtnImagen_Click);
            // 
            // PBImgProductos
            // 
            this.PBImgProductos.BackColor = System.Drawing.Color.Green;
            this.PBImgProductos.BorderRadius = 3;
            this.PBImgProductos.ImageRotate = 0F;
            this.PBImgProductos.Location = new System.Drawing.Point(1230, 178);
            this.PBImgProductos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PBImgProductos.Name = "PBImgProductos";
            this.PBImgProductos.Size = new System.Drawing.Size(284, 212);
            this.PBImgProductos.TabIndex = 1;
            this.PBImgProductos.TabStop = false;
            // 
            // picIconoProducto
            // 
            this.picIconoProducto.Image = global::Proyecto_Final_Inventario.Properties.Resources.WhatsApp_Image_2025_07_02_at_10_24_30_PM;
            this.picIconoProducto.ImageRotate = 0F;
            this.picIconoProducto.Location = new System.Drawing.Point(20, 188);
            this.picIconoProducto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picIconoProducto.Name = "picIconoProducto";
            this.picIconoProducto.Size = new System.Drawing.Size(412, 382);
            this.picIconoProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIconoProducto.TabIndex = 40;
            this.picIconoProducto.TabStop = false;
            // 
            // UCCrearProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.BtnCrearProducto);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.TxtRutaImg);
            this.Controls.Add(this.BtnImagen);
            this.Controls.Add(this.PBImgProductos);
            this.Controls.Add(this.guna2HtmlLabel8);
            this.Controls.Add(this.TxtNombreProd);
            this.Controls.Add(this.TxtPrecioVenta);
            this.Controls.Add(this.TxtProveedor);
            this.Controls.Add(this.CbActivoEntrada_Salida);
            this.Controls.Add(this.guna2HtmlLabel6);
            this.Controls.Add(this.TxtCantidad);
            this.Controls.Add(this.guna2HtmlLabel5);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.TxtPrecioCompra);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.TxtCategoriaDeProducto);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.picIconoProducto);
            this.Controls.Add(this.LblTituloCrearProducto);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UCCrearProducto";
            this.Size = new System.Drawing.Size(1570, 917);
            this.Load += new System.EventHandler(this.UCCrearProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TxtCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBImgProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIconoProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel LblTituloCrearProducto;
        private Guna.UI2.WinForms.Guna2PictureBox picIconoProducto;
        private Guna.UI2.WinForms.Guna2TextBox TxtId;
        private Guna.UI2.WinForms.Guna2ComboBox TxtCategoriaDeProducto;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2NumericUpDown TxtCantidad;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private System.Windows.Forms.CheckBox CbActivoEntrada_Salida;
        private Guna.UI2.WinForms.Guna2TextBox TxtProveedor;
        private Guna.UI2.WinForms.Guna2TextBox TxtPrecioCompra;
        private Guna.UI2.WinForms.Guna2TextBox TxtPrecioVenta;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel8;
        private Guna.UI2.WinForms.Guna2TextBox TxtNombreProd;
        private System.Windows.Forms.OpenFileDialog OFDImgProduct;
        private Guna.UI2.WinForms.Guna2PictureBox PBImgProductos;
        private Guna.UI2.WinForms.Guna2Button BtnImagen;
        private Guna.UI2.WinForms.Guna2TextBox TxtRutaImg;
        private Guna.UI2.WinForms.Guna2Button BtnEditar;
        private Guna.UI2.WinForms.Guna2Button BtnCrearProducto;
    }
}
