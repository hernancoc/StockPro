namespace Proyecto_Final_Inventario.PL
{
    partial class UCCrear
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCCrear));
            this.PanelCrearProducto_Producto = new System.Windows.Forms.Panel();
            this.LblCrearProdu = new System.Windows.Forms.Label();
            this.PanelCrearCategoria = new System.Windows.Forms.Panel();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LblCrear = new System.Windows.Forms.Label();
            this.ImagenCrearProducto = new Guna.UI2.WinForms.Guna2ImageButton();
            this.imgCategoria = new Guna.UI2.WinForms.Guna2ImageButton();
            this.PanelCrearProducto_Producto.SuspendLayout();
            this.PanelCrearCategoria.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelCrearProducto_Producto
            // 
            this.PanelCrearProducto_Producto.Controls.Add(this.ImagenCrearProducto);
            this.PanelCrearProducto_Producto.Controls.Add(this.LblCrearProdu);
            this.PanelCrearProducto_Producto.Location = new System.Drawing.Point(97, 81);
            this.PanelCrearProducto_Producto.Name = "PanelCrearProducto_Producto";
            this.PanelCrearProducto_Producto.Size = new System.Drawing.Size(380, 364);
            this.PanelCrearProducto_Producto.TabIndex = 25;
            this.PanelCrearProducto_Producto.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelCrearProducto_Producto_Paint);
            // 
            // LblCrearProdu
            // 
            this.LblCrearProdu.AutoSize = true;
            this.LblCrearProdu.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCrearProdu.ForeColor = System.Drawing.Color.Green;
            this.LblCrearProdu.Location = new System.Drawing.Point(49, 26);
            this.LblCrearProdu.Name = "LblCrearProdu";
            this.LblCrearProdu.Size = new System.Drawing.Size(271, 34);
            this.LblCrearProdu.TabIndex = 17;
            this.LblCrearProdu.Text = "Gestion Producto";
            this.LblCrearProdu.Click += new System.EventHandler(this.LblCrearProdu_Click);
            // 
            // PanelCrearCategoria
            // 
            this.PanelCrearCategoria.Controls.Add(this.imgCategoria);
            this.PanelCrearCategoria.Controls.Add(this.lblCategoria);
            this.PanelCrearCategoria.Location = new System.Drawing.Point(570, 81);
            this.PanelCrearCategoria.Name = "PanelCrearCategoria";
            this.PanelCrearCategoria.Size = new System.Drawing.Size(383, 367);
            this.PanelCrearCategoria.TabIndex = 27;
            this.PanelCrearCategoria.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelCrearCategoria_Paint);
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.ForeColor = System.Drawing.Color.Green;
            this.lblCategoria.Location = new System.Drawing.Point(54, 26);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(281, 34);
            this.lblCategoria.TabIndex = 21;
            this.lblCategoria.Text = "Gestion Categoria";
            this.lblCategoria.Click += new System.EventHandler(this.lblCategoria_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(708, 483);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 18);
            this.label1.TabIndex = 26;
            this.label1.Text = "Productos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(552, 460);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(453, 18);
            this.label2.TabIndex = 24;
            this.label2.Text = "Define y Gestiona categorias para clasificar y gestionar ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Green;
            this.label7.Location = new System.Drawing.Point(177, 483);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(216, 18);
            this.label7.TabIndex = 23;
            this.label7.Text = "en el modulo de inventario";
            // 
            // LblCrear
            // 
            this.LblCrear.AutoSize = true;
            this.LblCrear.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCrear.ForeColor = System.Drawing.Color.Green;
            this.LblCrear.Location = new System.Drawing.Point(73, 460);
            this.LblCrear.Name = "LblCrear";
            this.LblCrear.Size = new System.Drawing.Size(441, 18);
            this.LblCrear.TabIndex = 22;
            this.LblCrear.Text = "Regista y Actualiza productos nuevos para habilitarlos";
            // 
            // ImagenCrearProducto
            // 
            this.ImagenCrearProducto.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.ImagenCrearProducto.HoverState.ImageSize = new System.Drawing.Size(250, 250);
            this.ImagenCrearProducto.Image = ((System.Drawing.Image)(resources.GetObject("ImagenCrearProducto.Image")));
            this.ImagenCrearProducto.ImageOffset = new System.Drawing.Point(0, 0);
            this.ImagenCrearProducto.ImageRotate = 0F;
            this.ImagenCrearProducto.ImageSize = new System.Drawing.Size(300, 300);
            this.ImagenCrearProducto.Location = new System.Drawing.Point(34, 96);
            this.ImagenCrearProducto.Name = "ImagenCrearProducto";
            this.ImagenCrearProducto.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.ImagenCrearProducto.Size = new System.Drawing.Size(301, 237);
            this.ImagenCrearProducto.TabIndex = 18;
            this.ImagenCrearProducto.Click += new System.EventHandler(this.ImagenCrearProducto_Click);
            // 
            // imgCategoria
            // 
            this.imgCategoria.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.imgCategoria.HoverState.ImageSize = new System.Drawing.Size(250, 250);
            this.imgCategoria.Image = global::Proyecto_Final_Inventario.Properties.Resources.WhatsApp_Image_2025_07_01_at_2_47_35_PM__1_;
            this.imgCategoria.ImageOffset = new System.Drawing.Point(0, 0);
            this.imgCategoria.ImageRotate = 0F;
            this.imgCategoria.ImageSize = new System.Drawing.Size(300, 300);
            this.imgCategoria.Location = new System.Drawing.Point(44, 61);
            this.imgCategoria.Name = "imgCategoria";
            this.imgCategoria.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.imgCategoria.Size = new System.Drawing.Size(301, 293);
            this.imgCategoria.TabIndex = 22;
            this.imgCategoria.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // UCCrear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.PanelCrearProducto_Producto);
            this.Controls.Add(this.PanelCrearCategoria);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.LblCrear);
            this.Name = "UCCrear";
            this.Size = new System.Drawing.Size(1047, 596);
            this.Load += new System.EventHandler(this.UCCrear_Load);
            this.PanelCrearProducto_Producto.ResumeLayout(false);
            this.PanelCrearProducto_Producto.PerformLayout();
            this.PanelCrearCategoria.ResumeLayout(false);
            this.PanelCrearCategoria.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelCrearProducto_Producto;
        private Guna.UI2.WinForms.Guna2ImageButton ImagenCrearProducto;
        private System.Windows.Forms.Label LblCrearProdu;
        private System.Windows.Forms.Panel PanelCrearCategoria;
        private Guna.UI2.WinForms.Guna2ImageButton imgCategoria;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LblCrear;
    }
}
