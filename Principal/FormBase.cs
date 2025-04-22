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
        public FormBase()
        {

        }

        

        public void MostrarImagen(List<byte[]> imagenes)
        {
            int yOffset = 0;

            foreach (var imagen in imagenes)
            {
     
                PictureBox pbImagen = new PictureBox();
                pbImagen.Location = new Point(1200, 280 + yOffset);  
                pbImagen.Size = new Size(100, 100);
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

                yOffset += pbImagen.Height + 20;  
            }
        }
    }
}
