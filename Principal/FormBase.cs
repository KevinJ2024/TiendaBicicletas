using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal
{
    public partial class FormBase : Form
    {

        public byte[] imagenSeleccionada;
        public Button btnGlobal;

        public FormBase()
        {
            InitializeButton();
        }

        private void InitializeButton()
        {
            btnGlobal = new Button();
            btnGlobal.Text = "Atras";
            btnGlobal.Location = new Point(5, 950); 
            btnGlobal.Size = new Size(100, 50);    

            btnGlobal.Click += BtnGlobal_Click;

            this.Controls.Add(btnGlobal);
        }

        private void BtnGlobal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void btnSeleccionar_Imagen_Click(object sender, EventArgs e)
        {
            EliminarTodosLosPictureBox();
            PictureBox pbImagen = this.Controls["pbImagen"] as PictureBox;
            if (pbImagen == null)
            {
                pbImagen = new PictureBox();
                pbImagen.Location = new Point(1100, 400);
                pbImagen.Name = "pbImagen";
                pbImagen.Size = new Size(195, 195);
                pbImagen.SizeMode = PictureBoxSizeMode.StretchImage;
                pbImagen.TabIndex = 6;
                this.Controls.Add(pbImagen);
            }

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            openFileDialog.Title = "Seleccionar Imagen";


            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string rutaImagen = openFileDialog.FileName;
                pbImagen.Image = Image.FromFile(rutaImagen);

                imagenSeleccionada = File.ReadAllBytes(rutaImagen);
            }
        }

        public void MostrarImagenes(List<byte[]> imagenes)
        {
            int yOffset = 0;

            foreach (var imagen in imagenes)
            {
     
                PictureBox pbImagen = new PictureBox();
                pbImagen.Location = new Point(1000, 310 + yOffset);  
                pbImagen.Size = new Size(100, 100);
                pbImagen.Name = "pbImagen";
                pbImagen.SizeMode = PictureBoxSizeMode.StretchImage;
                pbImagen.TabIndex = 6;

                if (imagen != null && imagen.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(imagen))
                    {
                        try
                        {
                            pbImagen.Image = Image.FromStream(ms);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al cargar la imagen: " + ex.Message);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No hay imagen disponible para mostrar.");
                    pbImagen.Image = null;
                }

                this.Controls.Add(pbImagen);

                yOffset += pbImagen.Height + 70;  
            }
        }


        public void MostrarImagenesFactura(List<byte[]> imagenes)
        {
            int yOffset = 0;

            foreach (var imagen in imagenes)
            {

                PictureBox pbImagen = new PictureBox();
                pbImagen.Location = new Point(1000, 540 + yOffset);
                pbImagen.Size = new Size(100, 100);
                pbImagen.Name = "pbImagen";
                pbImagen.SizeMode = PictureBoxSizeMode.StretchImage;
                pbImagen.TabIndex = 6;

                if (imagen != null && imagen.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(imagen))
                    {
                        try
                        {
                            pbImagen.Image = Image.FromStream(ms);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al cargar la imagen: " + ex.Message);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No hay imagen disponible para mostrar.");
                    pbImagen.Image = null;
                }

                this.Controls.Add(pbImagen);

                yOffset += pbImagen.Height + 35;
            }
        }

        public void MostrarImagenesPrincipal(List<byte[]> imagenes)
        {
            int yOffset = 0;

            foreach (var imagen in imagenes)
            {
                PictureBox pbImagen = new PictureBox();
                pbImagen.Location = new Point(1000, 200 + yOffset);
                pbImagen.Size = new Size(100, 100);
                pbImagen.Name = "pbImagen";
                pbImagen.SizeMode = PictureBoxSizeMode.StretchImage;
                pbImagen.TabIndex = 6;

                if (imagen != null && imagen.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(imagen))
                    {
                        try
                        {
                            pbImagen.Image = Image.FromStream(ms);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al cargar la imagen: " + ex.Message);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No hay imagen disponible para mostrar.");
                    pbImagen.Image = null;
                }

                this.Controls.Add(pbImagen);
                yOffset += 150;
            }
        }

        public void MostrarImagen(byte[] Imagen)
        {
                PictureBox pbImagen = new PictureBox();
                pbImagen.Location = new Point(1100, 400);
                pbImagen.Name = "pbImagen";
                pbImagen.Size = new Size(100, 100);
                pbImagen.SizeMode = PictureBoxSizeMode.StretchImage;
                pbImagen.TabIndex = 6;

                if (Imagen != null && Imagen.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(Imagen))
                    {
                        try
                        {
                            pbImagen.Image = Image.FromStream(ms);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al cargar la imagen: " + ex.Message);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No hay imagen disponible para mostrar.");
                    pbImagen.Image = null;
                }

                this.Controls.Add(pbImagen);
        }

        public void EliminarTodosLosPictureBox()
        {
            List<Control> pictureBoxesAEliminar = new List<Control>();

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is PictureBox && ctrl.Name.StartsWith("pbImagen"))
                {
                    pictureBoxesAEliminar.Add(ctrl);
                }
            }

            foreach (PictureBox pb in pictureBoxesAEliminar)
            {
                pb.Image?.Dispose();
                pb.Dispose();
                this.Controls.Remove(pb);
            }
        }

    }
}
