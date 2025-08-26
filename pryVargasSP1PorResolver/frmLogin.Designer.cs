namespace pryVargasSP1PorResolver
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
            lblBienvenido = new Label();
            btnCancelar = new Button();
            btnAceptar = new Button();
            lstModulo = new ComboBox();
            txtContraseña = new TextBox();
            txtUsuario = new TextBox();
            lblModulo = new Label();
            lblContraseña = new Label();
            lblUsuario = new Label();
            SuspendLayout();
            // 
            // lblBienvenido
            // 
            lblBienvenido.AutoSize = true;
            lblBienvenido.Font = new Font("Segoe UI", 12F);
            lblBienvenido.Location = new Point(329, 110);
            lblBienvenido.Name = "lblBienvenido";
            lblBienvenido.Size = new Size(0, 21);
            lblBienvenido.TabIndex = 0;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 12F);
            btnCancelar.Location = new Point(335, 88);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(88, 31);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Enabled = false;
            btnAceptar.Font = new Font("Segoe UI", 12F);
            btnAceptar.Location = new Point(336, 31);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(87, 35);
            btnAceptar.TabIndex = 14;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // lstModulo
            // 
            lstModulo.DropDownStyle = ComboBoxStyle.DropDownList;
            lstModulo.Enabled = false;
            lstModulo.Font = new Font("Segoe UI", 12F);
            lstModulo.FormattingEnabled = true;
            lstModulo.Items.AddRange(new object[] { "Administración", "Sistemas", "Compras", "Ventas" });
            lstModulo.Location = new Point(125, 116);
            lstModulo.Name = "lstModulo";
            lstModulo.Size = new Size(145, 29);
            lstModulo.TabIndex = 13;
            lstModulo.SelectedIndexChanged += lstModulo_SelectedIndexChanged;
            // 
            // txtContraseña
            // 
            txtContraseña.Enabled = false;
            txtContraseña.Font = new Font("Segoe UI", 12F);
            txtContraseña.Location = new Point(125, 74);
            txtContraseña.MaxLength = 10;
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '#';
            txtContraseña.Size = new Size(145, 29);
            txtContraseña.TabIndex = 12;
            txtContraseña.TextChanged += txtContraseña_TextChanged;
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 12F);
            txtUsuario.ForeColor = Color.Blue;
            txtUsuario.Location = new Point(125, 31);
            txtUsuario.MaxLength = 10;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(145, 29);
            txtUsuario.TabIndex = 11;
            txtUsuario.TextChanged += txtUsuario_TextChanged;
            // 
            // lblModulo
            // 
            lblModulo.AutoSize = true;
            lblModulo.Font = new Font("Segoe UI", 12F);
            lblModulo.Location = new Point(30, 116);
            lblModulo.Name = "lblModulo";
            lblModulo.Size = new Size(64, 21);
            lblModulo.TabIndex = 10;
            lblModulo.Text = "Módulo";
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Font = new Font("Segoe UI", 12F);
            lblContraseña.Location = new Point(30, 74);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(89, 21);
            lblContraseña.TabIndex = 9;
            lblContraseña.Text = "Contraseña";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 12F);
            lblUsuario.Location = new Point(30, 31);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(64, 21);
            lblUsuario.TabIndex = 8;
            lblUsuario.Text = "Usuario";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(476, 201);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(lstModulo);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Controls.Add(lblModulo);
            Controls.Add(lblContraseña);
            Controls.Add(lblUsuario);
            Controls.Add(lblBienvenido);
            Name = "frmLogin";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBienvenido;
        private Button btnCancelar;
        private Button btnAceptar;
        private ComboBox lstModulo;
        private TextBox txtContraseña;
        private TextBox txtUsuario;
        private Label lblModulo;
        private Label lblContraseña;
        private Label lblUsuario;
    }
}