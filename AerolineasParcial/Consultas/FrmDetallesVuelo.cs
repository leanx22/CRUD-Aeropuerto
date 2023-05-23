using BibliotecaEntidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineasParcial.Consultas
{
    public partial class FrmDetallesVuelo : Form
    {
        private Viaje viaje;
        public FrmDetallesVuelo(Viaje viaje)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.viaje = viaje;
        }

        private void FrmDetallesVuelo_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.propertyGrid1.SelectedObject = viaje;
            this.propertyGrid1.Enabled = false;
        }
    }
}
