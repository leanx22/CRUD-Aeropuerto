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
            this.Text = "Detalles del vuelo";
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.Fixed3D;

            this.propGridVuelo.SelectedObject = viaje;
            this.propGridVuelo.Enabled = false;

        }

        private void btnInfoPasajeros_Click(object sender, EventArgs e)
        {
            FrmPasajeros ventana = new FrmPasajeros(this.viaje.ListaPasajeros);
            ventana.Show(this);
        }
    }
}
