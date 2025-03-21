namespace Principal
{
    partial class FormEliminar
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
            btnCancelar = new Button();
            btnConfirmar = new Button();
            tbID = new TextBox();
            lbTitle = new Label();
            lbResultado = new Label();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(410, 245);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(101, 49);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(289, 245);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(101, 49);
            btnConfirmar.TabIndex = 7;
            btnConfirmar.Text = "Eliminar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // tbID
            // 
            tbID.Location = new Point(304, 180);
            tbID.Name = "tbID";
            tbID.PlaceholderText = "ID";
            tbID.Size = new Size(186, 23);
            tbID.TabIndex = 6;
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Segoe UI", 20F);
            lbTitle.Location = new Point(289, 119);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(120, 37);
            lbTitle.TabIndex = 5;
            lbTitle.Text = "Eliminar ";
            // 
            // lbResultado
            // 
            lbResultado.AutoSize = true;
            lbResultado.Location = new Point(369, 332);
            lbResultado.Name = "lbResultado";
            lbResultado.Size = new Size(56, 15);
            lbResultado.TabIndex = 9;
            lbResultado.Text = "resultado";
            // 
            // FormEliminar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbResultado);
            Controls.Add(btnCancelar);
            Controls.Add(btnConfirmar);
            Controls.Add(tbID);
            Controls.Add(lbTitle);
            Name = "FormEliminar";
            Text = "FormEliminar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnConfirmar;
        private TextBox tbID;
        private Label lbTitle;
        private Label lbResultado;
    }
}