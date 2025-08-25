namespace pryVargasSP1PorResolver
{
    partial class frmBienvenido
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblUsuario = new Label();
            lblContraseña = new Label();
            lblModulo = new Label();
            txtUsuario = new TextBox();
            txtContraseña = new TextBox();
            lstModulo = new ComboBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(29, 38);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(47, 15);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuario";
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Location = new Point(29, 81);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(67, 15);
            lblContraseña.TabIndex = 1;
            lblContraseña.Text = "Contraseña";
            // 
            // lblModulo
            // 
            lblModulo.AutoSize = true;
            lblModulo.Location = new Point(29, 123);
            lblModulo.Name = "lblModulo";
            lblModulo.Size = new Size(49, 15);
            lblModulo.TabIndex = 2;
            lblModulo.Text = "Módulo";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(124, 38);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(121, 23);
            txtUsuario.TabIndex = 3;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(124, 81);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(121, 23);
            txtContraseña.TabIndex = 4;
            // 
            // lstModulo
            // 
            lstModulo.FormattingEnabled = true;
            lstModulo.Location = new Point(124, 123);
            lstModulo.Name = "lstModulo";
            lstModulo.Size = new Size(121, 23);
            lstModulo.TabIndex = 5;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(335, 38);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 6;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(335, 81);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // frmBienvenido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(503, 228);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(lstModulo);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Controls.Add(lblModulo);
            Controls.Add(lblContraseña);
            Controls.Add(lblUsuario);
            Name = "frmBienvenido";
            Text = "Bienvenido al sistema";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsuario;
        private Label lblContraseña;
        private Label lblModulo;
        private TextBox txtUsuario;
        private TextBox txtContraseña;
        private ComboBox lstModulo;
        private Button btnAceptar;
        private Button btnCancelar;
    }
}
