namespace Proyecto_Final_Inventario.PL
{
    partial class UCInicio
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
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblbienvenido = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(318, 553);
            this.guna2HtmlLabel2.Margin = new System.Windows.Forms.Padding(2);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(604, 25);
            this.guna2HtmlLabel2.TabIndex = 37;
            this.guna2HtmlLabel2.Text = "© 2025 StockPro - Desarollada por Hernan Corominas Corona";
            this.guna2HtmlLabel2.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblbienvenido
            // 
            this.lblbienvenido.BackColor = System.Drawing.Color.Transparent;
            this.lblbienvenido.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbienvenido.Location = new System.Drawing.Point(277, 41);
            this.lblbienvenido.Margin = new System.Windows.Forms.Padding(2);
            this.lblbienvenido.Name = "lblbienvenido";
            this.lblbienvenido.Size = new System.Drawing.Size(265, 57);
            this.lblbienvenido.TabIndex = 42;
            this.lblbienvenido.Text = "Bienvenido";
            this.lblbienvenido.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.lblbienvenido.Click += new System.EventHandler(this.lblbienvenido_Click);
            // 
            // guna2PictureBox3
            // 
            this.guna2PictureBox3.Image = global::Proyecto_Final_Inventario.Properties.Resources.WhatsApp_Image_2025_06_29_at_6_35_46_PM;
            this.guna2PictureBox3.ImageRotate = 0F;
            this.guna2PictureBox3.Location = new System.Drawing.Point(216, 143);
            this.guna2PictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.guna2PictureBox3.Name = "guna2PictureBox3";
            this.guna2PictureBox3.Size = new System.Drawing.Size(595, 406);
            this.guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox3.TabIndex = 36;
            this.guna2PictureBox3.TabStop = false;
            // 
            // UCInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblbienvenido);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.guna2PictureBox3);
            this.Name = "UCInicio";
            this.Size = new System.Drawing.Size(1047, 596);
            this.Load += new System.EventHandler(this.UCInicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox3;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblbienvenido;
    }
}
