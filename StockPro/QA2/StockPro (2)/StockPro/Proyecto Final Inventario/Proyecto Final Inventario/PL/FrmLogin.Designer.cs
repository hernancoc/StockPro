namespace Proyecto_Final_Inventario.PL
{
    partial class FrmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.LblUser = new Guna.UI2.WinForms.Guna2Panel();
            this.LblUserIncorrect = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LblUsuarioInactivo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.IBVer = new Guna.UI2.WinForms.Guna2ImageButton();
            this.BtnIngresarLogin = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.TxtContraseña = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.TxtUsuario = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.LblUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // LblUser
            // 
            this.LblUser.BackColor = System.Drawing.Color.White;
            this.LblUser.BorderRadius = 20;
            this.LblUser.Controls.Add(this.LblUserIncorrect);
            this.LblUser.Controls.Add(this.LblUsuarioInactivo);
            this.LblUser.Controls.Add(this.IBVer);
            this.LblUser.Controls.Add(this.BtnIngresarLogin);
            this.LblUser.Controls.Add(this.guna2ControlBox3);
            this.LblUser.Controls.Add(this.TxtContraseña);
            this.LblUser.Controls.Add(this.guna2ControlBox2);
            this.LblUser.Controls.Add(this.guna2ControlBox1);
            this.LblUser.Controls.Add(this.TxtUsuario);
            this.LblUser.Controls.Add(this.label1);
            this.LblUser.Controls.Add(this.guna2CirclePictureBox1);
            this.LblUser.Font = new System.Drawing.Font("Bookman Old Style", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUser.Location = new System.Drawing.Point(407, -66);
            this.LblUser.Name = "LblUser";
            this.LblUser.Size = new System.Drawing.Size(407, 558);
            this.LblUser.TabIndex = 5;
            this.LblUser.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel2_Paint_1);
            this.LblUser.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LblUser_MouseDown);
            // 
            // LblUserIncorrect
            // 
            this.LblUserIncorrect.BackColor = System.Drawing.Color.Transparent;
            this.LblUserIncorrect.Font = new System.Drawing.Font("Bookman Old Style", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUserIncorrect.ForeColor = System.Drawing.Color.Red;
            this.LblUserIncorrect.Location = new System.Drawing.Point(79, 254);
            this.LblUserIncorrect.Margin = new System.Windows.Forms.Padding(2);
            this.LblUserIncorrect.Name = "LblUserIncorrect";
            this.LblUserIncorrect.Size = new System.Drawing.Size(3, 2);
            this.LblUserIncorrect.TabIndex = 9;
            this.LblUserIncorrect.Text = null;
            // 
            // LblUsuarioInactivo
            // 
            this.LblUsuarioInactivo.BackColor = System.Drawing.Color.Transparent;
            this.LblUsuarioInactivo.Font = new System.Drawing.Font("Bookman Old Style", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsuarioInactivo.ForeColor = System.Drawing.Color.Red;
            this.LblUsuarioInactivo.Location = new System.Drawing.Point(27, 244);
            this.LblUsuarioInactivo.Margin = new System.Windows.Forms.Padding(2);
            this.LblUsuarioInactivo.Name = "LblUsuarioInactivo";
            this.LblUsuarioInactivo.Size = new System.Drawing.Size(3, 2);
            this.LblUsuarioInactivo.TabIndex = 8;
            this.LblUsuarioInactivo.Text = null;
            // 
            // IBVer
            // 
            this.IBVer.BackColor = System.Drawing.Color.Transparent;
            this.IBVer.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.IBVer.HoverState.Image = global::Proyecto_Final_Inventario.Properties.Resources._14777;
            this.IBVer.HoverState.ImageSize = new System.Drawing.Size(24, 24);
            this.IBVer.Image = global::Proyecto_Final_Inventario.Properties.Resources._14777;
            this.IBVer.ImageOffset = new System.Drawing.Point(0, 0);
            this.IBVer.ImageRotate = 0F;
            this.IBVer.ImageSize = new System.Drawing.Size(24, 24);
            this.IBVer.Location = new System.Drawing.Point(338, 394);
            this.IBVer.Margin = new System.Windows.Forms.Padding(2);
            this.IBVer.Name = "IBVer";
            this.IBVer.PressedState.Image = global::Proyecto_Final_Inventario.Properties.Resources._14777;
            this.IBVer.PressedState.ImageSize = new System.Drawing.Size(24, 24);
            this.IBVer.Size = new System.Drawing.Size(24, 23);
            this.IBVer.TabIndex = 4;
            this.IBVer.UseTransparentBackground = true;
            this.IBVer.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            this.IBVer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.guna2ImageButton1_MouseDown);
            this.IBVer.MouseUp += new System.Windows.Forms.MouseEventHandler(this.guna2ImageButton1_MouseUp);
            // 
            // BtnIngresarLogin
            // 
            this.BtnIngresarLogin.BorderRadius = 20;
            this.BtnIngresarLogin.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(211)))), ((int)(((byte)(159)))));
            this.BtnIngresarLogin.CheckedState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(192)))), ((int)(((byte)(145)))));
            this.BtnIngresarLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnIngresarLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnIngresarLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnIngresarLogin.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnIngresarLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnIngresarLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(156)))), ((int)(((byte)(61)))));
            this.BtnIngresarLogin.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(154)))), ((int)(((byte)(57)))));
            this.BtnIngresarLogin.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold);
            this.BtnIngresarLogin.ForeColor = System.Drawing.Color.White;
            this.BtnIngresarLogin.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(211)))), ((int)(((byte)(159)))));
            this.BtnIngresarLogin.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(192)))), ((int)(((byte)(145)))));
            this.BtnIngresarLogin.Location = new System.Drawing.Point(73, 476);
            this.BtnIngresarLogin.Margin = new System.Windows.Forms.Padding(2);
            this.BtnIngresarLogin.Name = "BtnIngresarLogin";
            this.BtnIngresarLogin.Size = new System.Drawing.Size(274, 53);
            this.BtnIngresarLogin.TabIndex = 3;
            this.BtnIngresarLogin.Text = "Ingresar";
            this.BtnIngresarLogin.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            // 
            // guna2ControlBox3
            // 
            this.guna2ControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox3.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
            this.guna2ControlBox3.FillColor = System.Drawing.Color.LimeGreen;
            this.guna2ControlBox3.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox3.Location = new System.Drawing.Point(368, 66);
            this.guna2ControlBox3.Name = "guna2ControlBox3";
            this.guna2ControlBox3.Size = new System.Drawing.Size(39, 23);
            this.guna2ControlBox3.TabIndex = 7;
            // 
            // TxtContraseña
            // 
            this.TxtContraseña.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtContraseña.DefaultText = "";
            this.TxtContraseña.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtContraseña.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtContraseña.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtContraseña.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtContraseña.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtContraseña.Font = new System.Drawing.Font("Bookman Old Style", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtContraseña.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtContraseña.IconLeft = global::Proyecto_Final_Inventario.Properties.Resources.computer_icons_password_login_user_padlock;
            this.TxtContraseña.IconRightSize = new System.Drawing.Size(30, 30);
            this.TxtContraseña.Location = new System.Drawing.Point(73, 366);
            this.TxtContraseña.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TxtContraseña.Name = "TxtContraseña";
            this.TxtContraseña.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.TxtContraseña.PlaceholderText = "Ingrese Contraseña";
            this.TxtContraseña.SelectedText = "";
            this.TxtContraseña.Size = new System.Drawing.Size(267, 71);
            this.TxtContraseña.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.TxtContraseña.TabIndex = 2;
            this.TxtContraseña.TextOffset = new System.Drawing.Point(10, 0);
            this.TxtContraseña.UseSystemPasswordChar = true;
            this.TxtContraseña.Enter += new System.EventHandler(this.TxtContraseña_Enter);
            this.TxtContraseña.Leave += new System.EventHandler(this.TxtContraseña_Leave);
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(192)))), ((int)(((byte)(145)))));
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(355, 3);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(52, 32);
            this.guna2ControlBox2.TabIndex = 5;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(636, 6);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 4;
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtUsuario.DefaultText = "";
            this.TxtUsuario.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtUsuario.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtUsuario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtUsuario.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtUsuario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtUsuario.Font = new System.Drawing.Font("Bookman Old Style", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsuario.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtUsuario.IconLeft = global::Proyecto_Final_Inventario.Properties.Resources.user_login_icon_14;
            this.TxtUsuario.Location = new System.Drawing.Point(73, 263);
            this.TxtUsuario.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TxtUsuario.MaxLength = 30;
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.TxtUsuario.PlaceholderText = "Ingrese Usuario";
            this.TxtUsuario.SelectedText = "";
            this.TxtUsuario.Size = new System.Drawing.Size(267, 71);
            this.TxtUsuario.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.TxtUsuario.TabIndex = 1;
            this.TxtUsuario.TextOffset = new System.Drawing.Point(10, 0);
            this.TxtUsuario.TextChanged += new System.EventHandler(this.TxtUsuario_TextChanged);
            this.TxtUsuario.Enter += new System.EventHandler(this.TxtUsuario_Enter);
            this.TxtUsuario.Leave += new System.EventHandler(this.TxtUsuario_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bienvenido";
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = global::Proyecto_Final_Inventario.Properties.Resources._8810110;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(148, 88);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(119, 113);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox1.TabIndex = 1;
            this.guna2CirclePictureBox1.TabStop = false;
            this.guna2CirclePictureBox1.Click += new System.EventHandler(this.guna2CirclePictureBox1_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.LblUser);
            this.guna2Panel1.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel1.Location = new System.Drawing.Point(3, 2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(813, 495);
            this.guna2Panel1.TabIndex = 0;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::Proyecto_Final_Inventario.Properties.Resources.WhatsApp_Image_2025_06_29_at_6_35_46_PM;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(409, 492);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 4;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.Click += new System.EventHandler(this.guna2PictureBox1_Click_1);
            this.guna2PictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.guna2PictureBox1_MouseDown);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 494);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm";
            this.Load += new System.EventHandler(this.Frm_Load);
            this.LblUser.ResumeLayout(false);
            this.LblUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel LblUser;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private Guna.UI2.WinForms.Guna2TextBox TxtContraseña;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2TextBox TxtUsuario;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2GradientButton BtnIngresarLogin;
        private Guna.UI2.WinForms.Guna2ImageButton IBVer;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblUsuarioInactivo;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblUserIncorrect;
    }
}