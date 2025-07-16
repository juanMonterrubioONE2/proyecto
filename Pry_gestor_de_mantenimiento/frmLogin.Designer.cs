namespace Pry_gestor_de_mantenimiento
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.PbLogo = new System.Windows.Forms.PictureBox();
            this.btnAceptaar = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblContrasenia = new System.Windows.Forms.Label();
            this.lblUsuarios = new System.Windows.Forms.Label();
            this.lblTituloVentana = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PbMinimizar = new System.Windows.Forms.PictureBox();
            this.pbCerrar = new System.Windows.Forms.PictureBox();
            this.LblTituloEmpresa = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PbLogo)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(236, 130);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsuario.Multiline = true;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(250, 30);
            this.txtUsuario.TabIndex = 38;
            // 
            // PbLogo
            // 
            this.PbLogo.Image = ((System.Drawing.Image)(resources.GetObject("PbLogo.Image")));
            this.PbLogo.Location = new System.Drawing.Point(1, 0);
            this.PbLogo.MinimumSize = new System.Drawing.Size(55, 50);
            this.PbLogo.Name = "PbLogo";
            this.PbLogo.Size = new System.Drawing.Size(55, 50);
            this.PbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbLogo.TabIndex = 37;
            this.PbLogo.TabStop = false;
            // 
            // btnAceptaar
            // 
            this.btnAceptaar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(183)))), ((int)(((byte)(190)))));
            this.btnAceptaar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptaar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAceptaar.Location = new System.Drawing.Point(238, 243);
            this.btnAceptaar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAceptaar.Name = "btnAceptaar";
            this.btnAceptaar.Size = new System.Drawing.Size(112, 30);
            this.btnAceptaar.TabIndex = 36;
            this.btnAceptaar.Text = "Aceptar";
            this.btnAceptaar.UseVisualStyleBackColor = false;
            this.btnAceptaar.Click += new System.EventHandler(this.btnAceptaar_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(238, 183);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(250, 30);
            this.txtPassword.TabIndex = 35;
            // 
            // lblContrasenia
            // 
            this.lblContrasenia.AutoSize = true;
            this.lblContrasenia.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContrasenia.ForeColor = System.Drawing.Color.Black;
            this.lblContrasenia.Location = new System.Drawing.Point(121, 183);
            this.lblContrasenia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblContrasenia.Name = "lblContrasenia";
            this.lblContrasenia.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblContrasenia.Size = new System.Drawing.Size(97, 23);
            this.lblContrasenia.TabIndex = 34;
            this.lblContrasenia.Text = "Contraseña";
            // 
            // lblUsuarios
            // 
            this.lblUsuarios.AutoSize = true;
            this.lblUsuarios.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarios.ForeColor = System.Drawing.Color.Black;
            this.lblUsuarios.Location = new System.Drawing.Point(121, 130);
            this.lblUsuarios.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsuarios.Name = "lblUsuarios";
            this.lblUsuarios.Size = new System.Drawing.Size(75, 23);
            this.lblUsuarios.TabIndex = 33;
            this.lblUsuarios.Text = "Usuarios";
            // 
            // lblTituloVentana
            // 
            this.lblTituloVentana.AutoSize = true;
            this.lblTituloVentana.Font = new System.Drawing.Font("Segoe UI Black", 16F, System.Drawing.FontStyle.Bold);
            this.lblTituloVentana.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(133)))), ((int)(((byte)(139)))));
            this.lblTituloVentana.Location = new System.Drawing.Point(231, 60);
            this.lblTituloVentana.Name = "lblTituloVentana";
            this.lblTituloVentana.Size = new System.Drawing.Size(74, 30);
            this.lblTituloVentana.TabIndex = 32;
            this.lblTituloVentana.Text = "Login";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(133)))), ((int)(((byte)(139)))));
            this.panel1.Controls.Add(this.PbMinimizar);
            this.panel1.Controls.Add(this.pbCerrar);
            this.panel1.Controls.Add(this.LblTituloEmpresa);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 50);
            this.panel1.TabIndex = 31;
            // 
            // PbMinimizar
            // 
            this.PbMinimizar.BackColor = System.Drawing.Color.White;
            this.PbMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("PbMinimizar.Image")));
            this.PbMinimizar.Location = new System.Drawing.Point(622, 5);
            this.PbMinimizar.Margin = new System.Windows.Forms.Padding(2);
            this.PbMinimizar.Name = "PbMinimizar";
            this.PbMinimizar.Size = new System.Drawing.Size(34, 34);
            this.PbMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbMinimizar.TabIndex = 22;
            this.PbMinimizar.TabStop = false;
            // 
            // pbCerrar
            // 
            this.pbCerrar.BackColor = System.Drawing.Color.White;
            this.pbCerrar.Image = ((System.Drawing.Image)(resources.GetObject("pbCerrar.Image")));
            this.pbCerrar.Location = new System.Drawing.Point(661, 5);
            this.pbCerrar.Margin = new System.Windows.Forms.Padding(2);
            this.pbCerrar.Name = "pbCerrar";
            this.pbCerrar.Size = new System.Drawing.Size(34, 34);
            this.pbCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCerrar.TabIndex = 21;
            this.pbCerrar.TabStop = false;
            this.pbCerrar.Click += new System.EventHandler(this.pbCerrar_Click);
            // 
            // LblTituloEmpresa
            // 
            this.LblTituloEmpresa.AutoSize = true;
            this.LblTituloEmpresa.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTituloEmpresa.ForeColor = System.Drawing.Color.White;
            this.LblTituloEmpresa.Location = new System.Drawing.Point(250, 5);
            this.LblTituloEmpresa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblTituloEmpresa.Name = "LblTituloEmpresa";
            this.LblTituloEmpresa.Size = new System.Drawing.Size(124, 40);
            this.LblTituloEmpresa.TabIndex = 21;
            this.LblTituloEmpresa.Text = "TecCom";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(183)))), ((int)(((byte)(190)))));
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancelar.Location = new System.Drawing.Point(376, 243);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(112, 30);
            this.btnCancelar.TabIndex = 39;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 350);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.PbLogo);
            this.Controls.Add(this.btnAceptaar);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblContrasenia);
            this.Controls.Add(this.lblUsuarios);
            this.Controls.Add(this.lblTituloVentana);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PbLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.PictureBox PbLogo;
        private System.Windows.Forms.Button btnAceptaar;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblContrasenia;
        private System.Windows.Forms.Label lblUsuarios;
        private System.Windows.Forms.Label lblTituloVentana;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox PbMinimizar;
        private System.Windows.Forms.PictureBox pbCerrar;
        private System.Windows.Forms.Label LblTituloEmpresa;
        private System.Windows.Forms.Button btnCancelar;
    }
}