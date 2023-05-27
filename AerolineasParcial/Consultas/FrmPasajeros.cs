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
    public partial class FrmPasajeros : Form
    {
        private List<Pasajero> listaPasajeros;
        private List<Pasajero> listaFiltrada; //Se usa cuando hago una busqueda.
        //private Pasajero pasajero; //Aca se guarda el pasajero seleccionado.

        public FrmPasajeros(List<Pasajero> listaPasajeros)
        {
            InitializeComponent();
            this.listaPasajeros = listaPasajeros;
            this.listaFiltrada = new List<Pasajero>();
            //this.pasajero = new Pasajero();
        }

        public FrmPasajeros()
        {
            InitializeComponent();
            this.listaPasajeros = new List<Pasajero>();
            this.listaFiltrada = new List<Pasajero>();
            //this.pasajero = new Pasajero();
        }

        //public Pasajero Pasajero { get { return this.pasajero; } }

        private void FrmPasajeros_Load(object sender, EventArgs e)
        {
            this.tBoxDNI.PlaceholderText = "Buscar D.N.I";
            this.tBoxNombre.PlaceholderText = "Buscar Nombre";
            this.tBoxApellido.PlaceholderText = "Buscar Apellido";

            this.gridPasajeros.DataSource = this.listaPasajeros;
            this.gridPasajeros.ReadOnly = true;
            this.gridPasajeros.MultiSelect = false;
            this.gridPasajeros.AllowUserToResizeColumns = false;
            this.gridPasajeros.AllowUserToResizeRows = false;
            this.gridPasajeros.Anchor = AnchorStyles.Top | AnchorStyles.Bottom |
                AnchorStyles.Right | AnchorStyles.Left;
            this.gridPasajeros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.gridPasajeros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            long dni = 0;

            if (tBoxDNI.Text != string.Empty && !Pasajero.ValidarDNI(tBoxDNI.Text))
            {
                MessageBox.Show("El DNI ingresado no es valido.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (tBoxDNI.Text != string.Empty)
            {
                dni = long.Parse(tBoxDNI.Text);
            }

            this.listaFiltrada = Pasajero.BuscarPasajero(this.listaPasajeros, dni, this.tBoxNombre.Text, this.tBoxApellido.Text);
            this.gridPasajeros.DataSource = listaFiltrada;
        }

        //Al pulsar el boton LIMPIAR se borra la busqueda y se vuelven a mostrar todos los pasajeros.
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.gridPasajeros.DataSource = this.listaPasajeros;
            this.tBoxNombre.Text = string.Empty;
            this.tBoxApellido.Text = string.Empty;
            this.tBoxDNI.Text = string.Empty;
        }

        protected virtual void btnSalir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
