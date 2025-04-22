namespace Principal
{
    partial class FormFactura
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
            lbCliente = new Label();
            lbVendedor = new Label();
            lbFecha = new Label();
            lbProductos = new Label();
            lbTotal = new Label();
            SuspendLayout();
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Segoe UI", 20F);
            lbTitle.Location = new Point(297, 45);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(205, 37);
            lbTitle.TabIndex = 0;
            lbTitle.Text = "TIendaBicicletas";
            // 
            // lbCliente
            // 
            lbCliente.AutoSize = true;
            lbCliente.Location = new Point(373, 140);
            lbCliente.Name = "lbCliente";
            lbCliente.Size = new Size(44, 15);
            lbCliente.TabIndex = 1;
            lbCliente.Text = "Cliente";
            // 
            // lbVendedor
            // 
            lbVendedor.AutoSize = true;
            lbVendedor.Location = new Point(369, 187);
            lbVendedor.Name = "lbVendedor";
            lbVendedor.Size = new Size(57, 15);
            lbVendedor.TabIndex = 2;
            lbVendedor.Text = "Vendedor";
            // 
            // lbFecha
            // 
            lbFecha.AutoSize = true;
            lbFecha.Location = new Point(379, 237);
            lbFecha.Name = "lbFecha";
            lbFecha.Size = new Size(38, 15);
            lbFecha.TabIndex = 3;
            lbFecha.Text = "Fecha";
            // 
            // lbProductos
            // 
            lbProductos.AutoSize = true;
            lbProductos.Location = new Point(369, 287);
            lbProductos.Name = "lbProductos";
            lbProductos.Size = new Size(61, 15);
            lbProductos.TabIndex = 4;
            lbProductos.Text = "Productos";
            // 
            // lbTotal
            // 
            lbTotal.AutoSize = true;
            lbTotal.Location = new Point(379, 340);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new Size(32, 15);
            lbTotal.TabIndex = 5;
            lbTotal.Text = "Total";
            // 
            // FormFactura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbTotal);
            Controls.Add(lbProductos);
            Controls.Add(lbFecha);
            Controls.Add(lbVendedor);
            Controls.Add(lbCliente);
            Controls.Add(lbTitle);
            Name = "FormFactura";
            Text = "FormFactura";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTitle;
        private Label lbCliente;
        private Label lbVendedor;
        private Label lbFecha;
        private Label lbProductos;
        private Label lbTotal;
    }
}