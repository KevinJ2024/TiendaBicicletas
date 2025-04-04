namespace Principal
{
    partial class FormActualizar
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
            tbID = new TextBox();
            tbNombre = new TextBox();
            tbTelefono = new TextBox();
            tbEmail = new TextBox();
            btnCancelar = new Button();
            btnConfirmar = new Button();
            lbTitle = new Label();
            btnBuscarEntidad = new Button();
            lbResultado = new Label();
            tbContraseña = new TextBox();
            SuspendLayout();
            // 
            // tbID
            // 
            tbID.Location = new Point(304, 112);
            tbID.Name = "tbID";
            tbID.PlaceholderText = "ID ";
            tbID.Size = new Size(195, 23);
            tbID.TabIndex = 13;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(304, 156);
            tbNombre.Name = "tbNombre";
            tbNombre.PlaceholderText = "Nombre ";
            tbNombre.Size = new Size(195, 23);
            tbNombre.TabIndex = 12;
            // 
            // tbTelefono
            // 
            tbTelefono.Location = new Point(304, 250);
            tbTelefono.Name = "tbTelefono";
            tbTelefono.PlaceholderText = "Telefono";
            tbTelefono.Size = new Size(195, 23);
            tbTelefono.TabIndex = 11;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(304, 203);
            tbEmail.Name = "tbEmail";
            tbEmail.PlaceholderText = "Email";
            tbEmail.Size = new Size(195, 23);
            tbEmail.TabIndex = 10;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(410, 345);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(112, 48);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(279, 345);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(112, 48);
            btnConfirmar.TabIndex = 8;
            btnConfirmar.Text = "Actualizar ";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Segoe UI", 20F);
            lbTitle.Location = new Point(293, 57);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(140, 37);
            lbTitle.TabIndex = 7;
            lbTitle.Text = "Actualizar ";
            // 
            // btnBuscarEntidad
            // 
            btnBuscarEntidad.Location = new Point(223, 112);
            btnBuscarEntidad.Name = "btnBuscarEntidad";
            btnBuscarEntidad.Size = new Size(75, 23);
            btnBuscarEntidad.TabIndex = 14;
            btnBuscarEntidad.Text = "Buscar";
            btnBuscarEntidad.UseVisualStyleBackColor = true;
            btnBuscarEntidad.Click += btnBuscarEntidad_Click;
            // 
            // lbResultado
            // 
            lbResultado.AutoSize = true;
            lbResultado.Location = new Point(636, 112);
            lbResultado.Name = "lbResultado";
            lbResultado.Size = new Size(56, 15);
            lbResultado.TabIndex = 15;
            lbResultado.Text = "resultado";
            // 
            // tbContraseña
            // 
            tbContraseña.Location = new Point(304, 299);
            tbContraseña.Name = "tbContraseña";
            tbContraseña.PlaceholderText = "Contraseña";
            tbContraseña.Size = new Size(195, 23);
            tbContraseña.TabIndex = 16;
            // 
            // FormActualizar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbContraseña);
            Controls.Add(lbResultado);
            Controls.Add(btnBuscarEntidad);
            Controls.Add(tbID);
            Controls.Add(tbNombre);
            Controls.Add(tbTelefono);
            Controls.Add(tbEmail);
            Controls.Add(btnCancelar);
            Controls.Add(btnConfirmar);
            Controls.Add(lbTitle);
            Name = "FormActualizar";
            Text = "FormActuallizar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbID;
        private TextBox tbNombre;
        private TextBox tbTelefono;
        private TextBox tbEmail;
        private Button btnCancelar;
        private Button btnConfirmar;
        private Label lbTitle;
        private Button btnBuscarEntidad;
        private Label lbResultado;
        private TextBox tbContraseña;
    }
}