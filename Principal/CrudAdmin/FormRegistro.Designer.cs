namespace Principal
{
    partial class FormRegistro
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
            lbTitle = new Label();
            btnConfirmar = new Button();
            btnCancelar = new Button();
            tbEmail = new TextBox();
            tbTelefono = new TextBox();
            tbNombre = new TextBox();
            tbID = new TextBox();
<<<<<<< HEAD:Principal/CrudAdmin/FormRegistro.Designer.cs
            lbResultado = new Label();
            tbContraseña = new TextBox();
=======
            tbContraseña = new TextBox();
            label1 = new Label();
            lbResult = new Label();
>>>>>>> Miguel:Principal/FormRegistro.Designer.cs
            SuspendLayout();
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Segoe UI", 20F);
            lbTitle.Location = new Point(282, 9);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(121, 37);
            lbTitle.TabIndex = 0;
            lbTitle.Text = "Registro ";
            lbTitle.Click += lbTitle_Click;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(257, 347);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(112, 48);
            btnConfirmar.TabIndex = 1;
            btnConfirmar.Text = "Registrar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(388, 347);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(112, 48);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(282, 205);
            tbEmail.Name = "tbEmail";
            tbEmail.PlaceholderText = "Email";
            tbEmail.Size = new Size(195, 23);
            tbEmail.TabIndex = 3;
            // 
            // tbTelefono
            // 
            tbTelefono.Location = new Point(282, 252);
            tbTelefono.Name = "tbTelefono";
            tbTelefono.PlaceholderText = "Telefono";
            tbTelefono.Size = new Size(195, 23);
            tbTelefono.TabIndex = 4;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(282, 158);
            tbNombre.Name = "tbNombre";
            tbNombre.PlaceholderText = "Nombre ";
            tbNombre.Size = new Size(195, 23);
            tbNombre.TabIndex = 5;
            // 
            // tbID
            // 
            tbID.Location = new Point(282, 114);
            tbID.Name = "tbID";
            tbID.PlaceholderText = "ID ";
            tbID.Size = new Size(195, 23);
            tbID.TabIndex = 6;
            // 
<<<<<<< HEAD:Principal/CrudAdmin/FormRegistro.Designer.cs
            // lbResultado
            // 
            lbResultado.AutoSize = true;
            lbResultado.Location = new Point(632, 114);
            lbResultado.Name = "lbResultado";
            lbResultado.Size = new Size(56, 15);
            lbResultado.TabIndex = 7;
            lbResultado.Text = "resultado";
            // 
            // tbContraseña
            // 
            tbContraseña.Location = new Point(282, 298);
            tbContraseña.Name = "tbContraseña";
            tbContraseña.PlaceholderText = "Contraseña";
            tbContraseña.Size = new Size(195, 23);
            tbContraseña.TabIndex = 8;
=======
            // tbContraseña
            // 
            tbContraseña.Location = new Point(282, 293);
            tbContraseña.Name = "tbContraseña";
            tbContraseña.PlaceholderText = "contraseña";
            tbContraseña.Size = new Size(195, 23);
            tbContraseña.TabIndex = 7;
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 0;
            // 
            // lbResult
            // 
            lbResult.AutoSize = true;
            lbResult.Location = new Point(593, 114);
            lbResult.Name = "lbResult";
            lbResult.Size = new Size(0, 15);
            lbResult.TabIndex = 8;
>>>>>>> Miguel:Principal/FormRegistro.Designer.cs
            // 
            // FormRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
<<<<<<< HEAD:Principal/CrudAdmin/FormRegistro.Designer.cs
            Controls.Add(tbContraseña);
            Controls.Add(lbResultado);
=======
            Controls.Add(lbResult);
            Controls.Add(label1);
            Controls.Add(tbContraseña);
>>>>>>> Miguel:Principal/FormRegistro.Designer.cs
            Controls.Add(tbID);
            Controls.Add(tbNombre);
            Controls.Add(tbTelefono);
            Controls.Add(tbEmail);
            Controls.Add(btnCancelar);
            Controls.Add(btnConfirmar);
            Controls.Add(lbTitle);
            Name = "FormRegistro";
            Text = "FormRegistrar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTitle;
        private Button btnConfirmar;
        private Button btnCancelar;
        private TextBox tbEmail;
        private TextBox tbTelefono;
        private TextBox tbNombre;
        private TextBox tbID;
<<<<<<< HEAD:Principal/CrudAdmin/FormRegistro.Designer.cs
        private Label lbResultado;
        private TextBox tbContraseña;
=======
        private TextBox tbContraseña;
        private Label label1;
        private Label lbResult;
>>>>>>> Miguel:Principal/FormRegistro.Designer.cs
    }
}