using AerolineasParcial.Consultas;
using AerolineasParcial.CRUD.Modificacion;
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
        //Lista de pasajeros original.
        private List<Pasajero> listaPasajeros;

        //Lista donde se guardan las coincidencias de una busqueda.
        private List<Pasajero> listaFiltrada;

        //Es true cuando el usuario realizo una busqueda y eldataGrid tiene como source la
        //lista filtrada.
        private bool VistaFiltrada;

        public ABMpasajeros(List<Pasajero> listaPasajeros)
        {
            InitializeComponent();
            this.listaPasajeros = listaPasajeros;
            this.listaFiltrada = new List<Pasajero>();
            this.VistaFiltrada = false;
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


        #region OPERACIONES
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Pasajero pasajero;
            FormAltaPasajero ventana = new FormAltaPasajero();
            DialogResult rs = ventana.ShowDialog();
            if (rs == DialogResult.OK)
            {
                if (this.listaPasajeros.Contains(ventana.Pasajero))
                {
                    MessageBox.Show("El pasajero ya existe.", "Error!",
                        MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }

                pasajero = ventana.Pasajero;
                this.listaPasajeros.Add(pasajero);

                MessageBox.Show("Pasajero dado de alta correctamente.", "Exito!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Actualizo DataGrid.
                base.dGrid.DataSource = null;
                base.dGrid.DataSource = this.listaPasajeros;
                base.dGrid.ClearSelection();
            }
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            Pasajero pasajero;
            if (base.dGrid.SelectedRows.Count <= 0)
            {
                MessageBox.Show("No hay ningun pasajero seleccionado!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!VistaFiltrada)
            {
                pasajero = this.listaPasajeros[base.dGrid.SelectedRows[0].Index];
            }
            else
            {
                pasajero = this.listaFiltrada[base.dGrid.SelectedRows[0].Index];
            }

            DialogResult res = MessageBox.Show("Seguro que desea eliminar al pasajero" +
                " permanentemente?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                base.dGrid.DataSource = null;
                this.listaPasajeros.Remove(pasajero);
                
                base.dGrid.DataSource = this.listaPasajeros;
                this.VistaFiltrada = false;
                
                MessageBox.Show("Pasajero eliminado correctamente", "Exito!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Pasajero pasajero;
            if (base.dGrid.SelectedRows.Count <= 0)
            {
                MessageBox.Show("No hay ningun pasajero seleccionado!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!VistaFiltrada)
            {
                pasajero = this.listaPasajeros[base.dGrid.SelectedRows[0].Index];
            }
            else
            {
                pasajero = this.listaFiltrada[base.dGrid.SelectedRows[0].Index];
            }

            FrmEditarPasajero ventana = new FrmEditarPasajero(pasajero);
            DialogResult res = ventana.ShowDialog();
            if (res == DialogResult.OK)
            {
                base.dGrid.DataSource = null;
                this.listaPasajeros.Remove(pasajero);
                this.listaPasajeros.Add(ventana.Pasajero);
                
                base.dGrid.DataSource = this.listaPasajeros;
                this.VistaFiltrada = false;

                MessageBox.Show("Pasajero modificado correctamente", "Exito!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }

        }
        #endregion

        #region METODOS

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ABMpasajeros_FormClosing(object sender, FormClosingEventArgs e)
        {
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
            MessageBox.Show("Equipaje de MANO: \n" + this.listaPasajeros[indice].Equipaje[ETipoEquipaje.Mano].ToString() +
                "\nEquipaje de BODEGA: \n" + this.listaPasajeros[indice].Equipaje[ETipoEquipaje.Bodega].ToString());

        }
        #endregion


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            long dni = 0;
            if (tBoxDNI.Text != string.Empty && !Pasajero.ValidarDNI(tBoxDNI.Text))
            {
                MessageBox.Show("Dni no valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            long.TryParse(tBoxDNI.Text, out dni);

            this.listaFiltrada = Pasajero.BuscarPasajero(this.listaPasajeros, dni,
                this.tBoxNombre.Text, this.tBoxApellido.Text);

            base.dGrid.DataSource = null;
            base.dGrid.DataSource = this.listaFiltrada;
            this.VistaFiltrada = true;

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.tBoxDNI.Text = string.Empty;
            this.tBoxNombre.Text = string.Empty;
            this.tBoxApellido.Text = string.Empty;

            base.dGrid.DataSource = null;
            base.dGrid.DataSource = this.listaPasajeros;
            this.VistaFiltrada = false;
        }
    }
}
