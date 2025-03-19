namespace Principal
{
    partial class FormConsultar
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
            tbID = new TextBox();
            btnConfirmar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Segoe UI", 20F);
            lbTitle.Location = new Point(245, 68);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(137, 37);
            lbTitle.TabIndex = 0;
            lbTitle.Text = "Consultar ";
            // 
            // tbID
            // 
            tbID.Location = new Point(264, 151);
            tbID.Name = "tbID";
            tbID.PlaceholderText = "ID del producto";
            tbID.Size = new Size(186, 23);
            tbID.TabIndex = 1;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(245, 194);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(101, 49);
            btnConfirmar.TabIndex = 3;
            btnConfirmar.Text = "Consultar";
            btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(366, 194);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(101, 49);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // FormConsultar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancelar);
            Controls.Add(btnConfirmar);
            Controls.Add(tbID);
            Controls.Add(lbTitle);
            Name = "FormConsultar";
            Text = "FormConsultar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTitle;
        private TextBox tbID;
        private Button btnConfirmar;
        private Button btnCancelar;
    }
}