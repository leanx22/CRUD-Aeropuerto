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
            this.aeropuerto = aeropuerto;
            this.viaje = new Viaje();
        }

        public Viaje Viaje { get { return this.viaje; } }

        private void FormViajes_Load(object sender, EventArgs e)
        {
            this.Text = "Vuelos";

            //Propiedades del DataGridView
            this.gridVuelos.DataSource = this.aeropuerto.Viajes;
            this.gridVuelos.ReadOnly = true;
            this.gridVuelos.MultiSelect = false;
            this.gridVuelos.AllowUserToResizeColumns = false;
            this.gridVuelos.AllowUserToResizeRows = false;
            this.gridVuelos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom |
                AnchorStyles.Right | AnchorStyles.Left;
            this.gridVuelos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.gridVuelos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //Deshabilito las columnas que no quiero que se muestren.
            //this.gridVuelos.Columns["EsInternacional"].Visible = false;
            //this.gridVuelos.Columns["AvionAsignado"].Visible = false;
            //this.gridVuelos.Columns["CostoPremium"].Visible = false;
            //this.gridVuelos.Columns["CostoTurista"].Visible = false;

            //Cambio el nombre de algunas columnas.
            this.gridVuelos.Columns["AsientosPremium"].HeaderText = "Asientos premium";
            this.gridVuelos.Columns["AsientosTurista"].HeaderText = "Asientos turista";
            this.gridVuelos.Columns["Duracion"].HeaderText = "Duracion del vuelo";
            this.gridVuelos.Columns["FechaDeVuelo"].HeaderText = "Fecha de salida";

            //Propiedades checkBoxes
            this.chbxComida.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.chbxInternet.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;

            //Propiedades buttons
            this.btnSelect.Anchor = AnchorStyles.Right | AnchorStyles.Bottom;
            this.btnSalir.Anchor = AnchorStyles.Right | AnchorStyles.Bottom;

            //Propiedades lbls
            this.linkDatosCompletos.Anchor = AnchorStyles.Left | AnchorStyles.Right |
                AnchorStyles.Bottom;
        }


        private void btnSelect_Click(object sender, EventArgs e)
        {
            int indice;

            if (!(gridVuelos.SelectedRows.Count > 0))
            {
                MessageBox.Show("Primero debe seleccionar un viaje en la lista.",
                     "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //obtengo el indice de la seleccion.            
            indice = gridVuelos.SelectedRows[0].Index;
            this.viaje = this.aeropuerto.Viajes[indice];

            if (this.viaje.Estado != EEstadoDeVuelo.Pendiente)
            {
                MessageBox.Show("No se puede editar un viaje en progreso o que ya finalizo.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.DialogResult = DialogResult.OK;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
