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
    public partial class FormEliminar : Form
    {
        public FormEliminar(string entidad)
        {
            InitializeComponent();
            lbTitle.Text += entidad;
            tbID.PlaceholderText += entidad;
        }
    }
}
