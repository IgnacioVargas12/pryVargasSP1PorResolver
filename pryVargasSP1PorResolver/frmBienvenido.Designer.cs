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
            lblBienvenido = new Label();
            lblSintepartSRL = new Label();
            SuspendLayout();
            // 
            // lblBienvenido
            // 
            lblBienvenido.AutoSize = true;
            lblBienvenido.Font = new Font("Segoe UI", 22F);
            lblBienvenido.Location = new Point(123, 47);
            lblBienvenido.Name = "lblBienvenido";
            lblBienvenido.Size = new Size(183, 41);
            lblBienvenido.TabIndex = 0;
            lblBienvenido.Text = "Bienvenido!!";
            lblBienvenido.Click += lblBienvenido_Click;
            // 
            // lblSintepartSRL
            // 
            lblSintepartSRL.AutoSize = true;
            lblSintepartSRL.BackColor = Color.FromArgb(255, 128, 128);
            lblSintepartSRL.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblSintepartSRL.Location = new Point(103, 104);
            lblSintepartSRL.Name = "lblSintepartSRL";
            lblSintepartSRL.Size = new Size(235, 45);
            lblSintepartSRL.TabIndex = 1;
            lblSintepartSRL.Text = "Sinterpart SRL";
            lblSintepartSRL.Click += lblSintepartSRL_Click;
            // 
            // frmBienvenido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(441, 219);
            Controls.Add(lblSintepartSRL);
            Controls.Add(lblBienvenido);
            Name = "frmBienvenido";
            Text = "Bienvenido al sistema";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBienvenido;
        private Label lblSintepartSRL;
    }
}
