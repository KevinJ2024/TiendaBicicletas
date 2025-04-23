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
            tbID.Location = new Point(800, 400);
            tbID.Name = "tbID";
            tbID.PlaceholderText = "ID ";
            tbID.Size = new Size(195, 23);
            tbID.TabIndex = 6;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(800, 450);
            tbNombre.Name = "tbNombre";
            tbNombre.PlaceholderText = "Nombre ";
            tbNombre.Size = new Size(195, 23);
            tbNombre.TabIndex = 5;
            // 
            // tbTelefono
            // 
            tbTelefono.Location = new Point(800, 550);
            tbTelefono.Name = "tbTelefono";
            tbTelefono.PlaceholderText = "Telefono";
            tbTelefono.Size = new Size(195, 23);
            tbTelefono.TabIndex = 4;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(800, 500);
            tbEmail.Name = "tbEmail";
            tbEmail.PlaceholderText = "Email";
            tbEmail.Size = new Size(195, 23);
            tbEmail.TabIndex = 3;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(950, 650);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(112, 48);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(750, 650);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(112, 48);
            btnConfirmar.TabIndex = 1;
            btnConfirmar.Text = "Actualizar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Segoe UI", 20F);
            lbTitle.Location = new Point(780, 300);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(140, 37);
            lbTitle.TabIndex = 0;
            lbTitle.Text = "Actualizar ";
            // 
            // btnBuscarEntidad
            // 
            btnBuscarEntidad.Location = new Point(720, 400);
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
            lbResultado.Location = new Point(840, 720);
            lbResultado.Name = "lbResultado";
            lbResultado.Size = new Size(0, 15);
            lbResultado.TabIndex = 7;
            // 
            // tbContraseña
            // 
            tbContraseña.Location = new Point(800, 600);
            tbContraseña.Name = "tbContraseña";
            tbContraseña.PlaceholderText = "Contraseña";
            tbContraseña.Size = new Size(195, 23);
            tbContraseña.TabIndex = 8;
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
            Load += FormActualizar_Load;
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