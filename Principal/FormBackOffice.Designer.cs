namespace Principal
{
    partial class FormBackOffice
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
            Titulo = new Label();
            btnCliente = new Button();
            btnVendedor = new Button();
            btnProducto = new Button();
            btnFactura = new Button();
            SuspendLayout();
            // 
            // Titulo
            // 
            Titulo.AutoSize = true;
            Titulo.Font = new Font("Segoe UI", 20F);
            Titulo.Location = new Point(202, 47);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(367, 37);
            Titulo.TabIndex = 0;
            Titulo.Text = "Tienda Bicicletas - Back Office";
            // 
            // btnCliente
            // 
            btnCliente.Location = new Point(92, 135);
            btnCliente.Name = "btnCliente";
            btnCliente.Size = new Size(163, 64);
            btnCliente.TabIndex = 1;
            btnCliente.Text = "Cliente";
            btnCliente.UseVisualStyleBackColor = true;
            btnCliente.Click += btnCliente_Click;
            // 
            // btnVendedor
            // 
            btnVendedor.Location = new Point(292, 135);
            btnVendedor.Name = "btnVendedor";
            btnVendedor.Size = new Size(163, 64);
            btnVendedor.TabIndex = 2;
            btnVendedor.Text = "Vendedor";
            btnVendedor.UseVisualStyleBackColor = true;
            btnVendedor.Click += btnVendedor_Click;
            // 
            // btnProducto
            // 
            btnProducto.Location = new Point(492, 135);
            btnProducto.Name = "btnProducto";
            btnProducto.Size = new Size(163, 64);
            btnProducto.TabIndex = 3;
            btnProducto.Text = "Producto";
            btnProducto.UseVisualStyleBackColor = true;
            btnProducto.Click += btnProducto_Click;
            // 
            // btnFactura
            // 
            btnFactura.Location = new Point(292, 261);
            btnFactura.Name = "btnFactura";
            btnFactura.Size = new Size(163, 64);
            btnFactura.TabIndex = 4;
            btnFactura.Text = "Factura";
            btnFactura.UseVisualStyleBackColor = true;
            btnFactura.Click += btnFactura_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnFactura);
            Controls.Add(btnProducto);
            Controls.Add(btnVendedor);
            Controls.Add(btnCliente);
            Controls.Add(Titulo);
            Name = "FormPrincipal";
            Text = "FormPrincipal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Titulo;
        private Button btnCliente;
        private Button btnVendedor;
        private Button btnProducto;
        private Button btnFactura;
    }
}