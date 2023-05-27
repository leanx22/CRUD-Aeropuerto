using AerolineasParcial.Consultas;
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

namespace AerolineasParcial.CRUD
{
    public partial class ABMpasajeros : FrmCRUD
    {
        private List<Pasajero> listaPasajeros;

        public ABMpasajeros(List<Pasajero> listaPasajeros)
        {
            InitializeComponent();
            this.listaPasajeros = listaPasajeros;
        }

        public List<Pasajero> Pasajeros { get { return this.listaPasajeros; } }

        private void ABMpasajeros_Load(object sender, EventArgs e)
        {
            base.FrmCRUD_Load(sender, e);
            base.Text = "C.R.U.D / Pasajeros";
            base.lblTitulo.Text = "Administrar Pasajeros";
            base.btnOK.Text = "GUARDAR";

            base.dGrid.DataSource = null;
            if (listaPasajeros.Count > 0)
            {
                base.dGrid.DataSource = this.listaPasajeros;
                base.dGrid.Columns["Equipaje"].Visible = false;
            }

            this.btnEquipaje.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            this.btnBuscar.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.btnLimpiar.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.tBoxDNI.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.tBoxNombre.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.tBoxApellido.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;

            this.tBoxDNI.PlaceholderText = "Buscar D.N.I";
            this.tBoxNombre.PlaceholderText = "Buscar Nombre";
            this.tBoxApellido.PlaceholderText = "Buscar Apellido";
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Pasajero pasajero;
            FormAltaPasajero ventana = new FormAltaPasajero();
            DialogResult rs = ventana.ShowDialog();
            if (rs == DialogResult.OK && !this.listaPasajeros.Contains(ventana.Pasajero))
            {
                pasajero = ventana.Pasajero;
                this.listaPasajeros.Add(pasajero);

                MessageBox.Show("Pasajero dado de alta correctamente.", "Exito!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Actualizo DataGrid.
                base.dGrid.DataSource = null;
                base.dGrid.DataSource = this.listaPasajeros;
                base.dGrid.ClearSelection();
            }
            else
            {
                MessageBox.Show("El pasajero ya existe.", "Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {

        }

        private void ABMpasajeros_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show("Seguro que desea salir?\n" +
                "Los cambios se van a guardar.", "Confirmar.",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.No)
            {
                e.Cancel = true;
            }
            base.DialogResult = DialogResult.OK;
        }

        private void btnEquipaje_Click(object sender, EventArgs e)
        {
            int indice;
            //Segun lo que tengo seleccionado
            if (dGrid.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Primero debe seleccionar un pasajero para ver su equipaje!.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            indice = dGrid.SelectedRows[0].Index;
            MessageBox.Show("Equipaje de MANO: \n"+this.listaPasajeros[indice].Equipaje[ETipoEquipaje.Mano].ToString() +
                "\nEquipaje de BODEGA: \n" + this.listaPasajeros[indice].Equipaje[ETipoEquipaje.Bodega].ToString());

        }
    }
}
