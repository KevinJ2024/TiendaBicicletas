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
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Segoe UI", 20F);
            lbTitle.Location = new Point(820, 70);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(137, 37);
            lbTitle.TabIndex = 0;
            lbTitle.Text = "Eliminar ";
            // 
            // tbID
            // 
            tbID.Location = new Point(820, 150);
            tbID.Name = "tbID";
            tbID.PlaceholderText = "ID ";
            tbID.Size = new Size(186, 23);
            tbID.TabIndex = 1;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(800, 200);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(101, 49);
            btnConfirmar.TabIndex = 3;
            btnConfirmar.Text = "Eliminar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(950, 200);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(101, 49);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lbResultado
            // 
            lbResultado.AutoSize = true;
            lbResultado.Location = new Point(700, 320);
            lbResultado.Name = "lbResultado";
            lbResultado.Size = new Size(56, 15);
            lbResultado.TabIndex = 5;
            lbResultado.Text = "";
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