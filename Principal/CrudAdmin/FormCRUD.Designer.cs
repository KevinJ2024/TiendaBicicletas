namespace Principal
{
    partial class FormCRUD
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
            btnRegistrar = new Button();
            btnConsultar = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            SuspendLayout();
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Segoe UI", 20F);
            lbTitle.Location = new Point(840, 400);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(95, 37);
            lbTitle.TabIndex = 0;
            lbTitle.Text = "CRUD ";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(550, 500);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(174, 71);
            btnRegistrar.TabIndex = 1;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += this.btnRegistrar_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(750, 500);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(174, 71);
            btnConsultar.TabIndex = 2;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += this.btnConsultar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(950, 500);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(174, 71);
            btnActualizar.TabIndex = 3;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += this.btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(1150, 500);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(174, 71);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += this.btnEliminar_Click;
            // 
            // FormCRUD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnConsultar);
            Controls.Add(btnRegistrar);
            Controls.Add(lbTitle);
            Name = "FormCRUD";
            Text = "FormCliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTitle;
        private Button btnRegistrar;
        private Button btnConsultar;
        private Button btnActualizar;
        private Button btnEliminar;
    }
}