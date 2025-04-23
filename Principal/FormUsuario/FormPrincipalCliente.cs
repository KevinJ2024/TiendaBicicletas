using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica.Controllers;

namespace Principal
{
    public partial class FormPrincipalCliente : FormBase
    {

        private string resultado;
        private int ID_cliente;
        private string tipo;

        public FormPrincipalCliente(int ID_cliente, string tipo)
        {

            InitializeComponent();
            btnGlobal.Visible = false;
            this.ID_cliente = ID_cliente;
            this.tipo = tipo;
            ModificarPrincipal();
            PresentarProductos();
        }

        private void ModificarPrincipal()
        {
            if (tipo == "Administrador")
            {
                Button btnBackOffice = new Button();
                btnBackOffice.Location = new Point(1200, 100);
                btnBackOffice.Text = "BackOffice";
                btnBackOffice.Size = new Size(100, 50);
                btnBackOffice.Click += btnBackOffice_Click;

                this.Controls.Add(btnBackOffice);
            }
        }

        private void btnBackOffice_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormBackOffice us = new FormBackOffice();
            us.ShowDialog();
            this.Show();
        }

        private void PresentarProductos()
        {
            List<byte[]> listaDeImagenes = new List<byte[]>();
            ProductoController ProductoController = new ProductoController();
            var productos = ProductoController.MostrarProductos();
            resultado = "";

            int yOffset = 0;

            foreach (var productoActual in productos)
            {
                Label lbl = new Label();
                lbl.Text = $"ID: {productoActual.ID_producto}\nNombre: {productoActual.Nombre_producto}\nPrecio: {productoActual.Precio_producto}\nStock: {productoActual.Stock}\nDescripción: {productoActual.Descripcion}";
                lbl.AutoSize = true;
                lbl.Location = new Point(800, 200 + yOffset);
                this.Controls.Add(lbl);

                Button btn = new Button();
                btn.Text = "Agregar producto";
                btn.AutoSize = true;
                btn.Location = new Point(800, lbl.Location.Y + lbl.Height + 5); 
                btn.Tag = productoActual.ID_producto;
                btn.Click += (s, e) =>
                {
                    int ID_producto = (int)((Button)s).Tag;
                    HistorialController HistorialController = new HistorialController();
                    HistorialController.IngresarProducto(ID_cliente, ID_producto);
                };
                this.Controls.Add(btn);

                listaDeImagenes.Add(productoActual.Imagen);
                yOffset += 150;
            }

            MostrarImagenesPrincipal(listaDeImagenes); 
        }
    }
}
