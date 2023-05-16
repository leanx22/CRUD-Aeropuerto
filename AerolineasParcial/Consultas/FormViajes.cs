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
    public partial class FormViajes : Form
    {
        Aeropuerto aeropuerto;
        Viaje viaje;
        public FormViajes(Aeropuerto aeropuerto)
        {
            InitializeComponent();
            this.aeropuerto = aeropuerto; this.viaje = new Viaje();
        }

        public Viaje Viaje { get { return this.viaje; } }

        private void FormViajes_Load(object sender, EventArgs e)
        {
            this.dataGrid.ReadOnly = true;
            this.dataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid.DataSource = this.aeropuerto.Viajes;
            this.dataGrid.MultiSelect = false;
            this.dataGrid.Anchor = AnchorStyles.Left | AnchorStyles.Right |
                AnchorStyles.Top | AnchorStyles.Bottom;

            this.btnModificar.Anchor = AnchorStyles.Right;
            this.btnOK.Anchor = AnchorStyles.Right;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int indice;

            if (!(dataGrid.SelectedRows.Count > 0))
            {
                MessageBox.Show("Primero debe seleccionar un viaje en la lista.",
                     "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //obtengo el indice de la seleccion.            
            indice = dataGrid.SelectedRows[0].Index;
            this.viaje = this.aeropuerto.Viajes[indice];

            if (this.viaje.Estado != EEstadoDeVuelo.Pendiente)
            {
                MessageBox.Show("No se puede editar un viaje en progreso o que ya finalizo.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.DialogResult = DialogResult.OK;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
