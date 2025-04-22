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
            tbContraseña = new TextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            lbResultado = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.BackColor = SystemColors.ControlLightLight;
            lbTitle.Font = new Font("Old English Text MT", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTitle.Location = new Point(40, 32);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(280, 77);
            lbTitle.TabIndex = 0;
            lbTitle.Text = "Registro ";
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(140, 312);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(112, 48);
            btnConfirmar.TabIndex = 1;
            btnConfirmar.Text = "Registrar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(271, 312);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(112, 48);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(165, 170);
            tbEmail.Name = "tbEmail";
            tbEmail.PlaceholderText = "Email";
            tbEmail.Size = new Size(195, 23);
            tbEmail.TabIndex = 3;
            // 
            // tbTelefono
            // 
            tbTelefono.Location = new Point(165, 217);
            tbTelefono.Name = "tbTelefono";
            tbTelefono.PlaceholderText = "Telefono";
            tbTelefono.Size = new Size(195, 23);
            tbTelefono.TabIndex = 4;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(165, 123);
            tbNombre.Name = "tbNombre";
            tbNombre.PlaceholderText = "Nombre ";
            tbNombre.Size = new Size(195, 23);
            tbNombre.TabIndex = 5;
            // 
            // tbID
            // 
            tbID.Location = new Point(165, 79);
            tbID.Name = "tbID";
            tbID.PlaceholderText = "ID ";
            tbID.Size = new Size(195, 23);
            tbID.TabIndex = 6;
            // 
            // tbContraseña
            // 
            tbContraseña.Location = new Point(165, 263);
            tbContraseña.Name = "tbContraseña";
            tbContraseña.PlaceholderText = "Contraseña";
            tbContraseña.Size = new Size(195, 23);
            tbContraseña.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(lbResultado);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(lbTitle);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1888, 1096);
            panel1.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLightLight;
            panel2.Controls.Add(btnConfirmar);
            panel2.Controls.Add(tbTelefono);
            panel2.Controls.Add(tbContraseña);
            panel2.Controls.Add(tbEmail);
            panel2.Controls.Add(tbNombre);
            panel2.Controls.Add(tbID);
            panel2.Controls.Add(btnCancelar);
            panel2.Location = new Point(593, 240);
            panel2.Name = "panel2";
            panel2.Size = new Size(525, 422);
            panel2.TabIndex = 10;
            // 
            // lbResultado
            // 
            lbResultado.AutoSize = true;
            lbResultado.Location = new Point(176, 228);
            lbResultado.Name = "lbResultado";
            lbResultado.Size = new Size(38, 15);
            lbResultado.TabIndex = 9;
            lbResultado.Text = "label1";
            // 
            // FormRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1879, 1014);
            Controls.Add(panel1);
            Name = "FormRegistro";
            Text = "FormRegistrar";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lbTitle;
        private Button btnConfirmar;
        private Button btnCancelar;
        private TextBox tbEmail;
        private TextBox tbTelefono;
        private TextBox tbNombre;
        private TextBox tbID;
        private TextBox tbContraseña;
        private Panel panel1;
        private Panel panel2;
        private Label lbResultado;
    }
}