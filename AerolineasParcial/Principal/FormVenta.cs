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

namespace AerolineasParcial.Principal
{
    public partial class FormVenta : Form
    {
        private Aeropuerto aeropuerto;
        private Viaje viaje;
        private Pasajero pasajero;
        private Aeronave aeronave;
        private bool flagViaje;
        private bool flagPasajero;
        public FormVenta(Aeropuerto aeropuerto)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            this.aeropuerto = aeropuerto;

            this.viaje = new Viaje();
            this.pasajero = new Pasajero();
            this.aeronave = new Aeronave();

            this.flagViaje = false;
            this.flagPasajero = false;
        }

        private void FormVenta_Load(object sender, EventArgs e)
        {
            #region FORM
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.ControlBox = false;
            this.lblTitulo.Text = "NUEVA VENTA";
            #endregion

            #region ANCHORS
            this.btnAceptar.Anchor = AnchorStyles.Right;
            this.btnCancelar.Anchor = AnchorStyles.Right;
            #endregion

            #region CONTROLES

            this.tBoxFecha.Enabled = false;
            this.tBoxDestino.Enabled = false;
            this.tBoxSalida.Enabled = false;
            this.tBoxDuracion.Enabled = false;

            this.tBoxNombre.Enabled = false;
            this.tBoxApellido.Enabled = false;
            this.tBoxEdad.Enabled = false;

            this.pnlPasaje.Enabled = false;
            this.lblUSDbase.Text = "0";
            this.lblUSDfinal.Text = "0";

            #endregion
        }

        private void btnSelectViaje_Click(object sender, EventArgs e)
        {
            FormViajes ventana = new FormViajes(this.aeropuerto);
            DialogResult res = ventana.ShowDialog();
            if (res == DialogResult.OK)
            {
                this.viaje = ventana.Viaje;
                this.pnlPasaje.Enabled = true;
                this.ActualizarInfoViaje();
                //No valido la busqueda, ya que si o si es correcta.
                this.aeropuerto.BuscarAeronave(this.viaje.AvionAsignado, out this.aeronave);
                this.flagViaje = true;
            }
        }

        private void btnBuscarPasajero_Click(object sender, EventArgs e)
        {
            long dni;
            if (!(tBoxDNI.Text != string.Empty && long.TryParse(tBoxDNI.Text, out dni)))
            {
                MessageBox.Show("Dni no valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!this.aeropuerto.BuscarPasajero(dni, out this.pasajero))
            {
                MessageBox.Show("No existe pasajero registrado con ese DNI.\n" +
                    "Debe DARLO DE ALTA primero!.",
                    "El pasajero no existe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.ActualizarInfoPasajero();
            this.flagPasajero = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        /// <summary>
        /// Esta funcion actualiza los controles con los datos de la variable VIAJE en la clase.
        /// </summary>
        private void ActualizarInfoViaje()
        {
            this.tBoxFecha.Text = this.viaje.FechaDeVuelo.ToShortDateString();
            this.tBoxDestino.Text = this.viaje.Destino;
            this.tBoxSalida.Text = this.viaje.Partida;
            this.tBoxDuracion.Text = this.viaje.Duracion + " hs.";
            this.ActualizarExtras();
        }

        /// <summary>
        /// Esta funcion actualiza los controles con los datos del pasajero en la variable PASAJERO
        /// </summary>
        private void ActualizarInfoPasajero()
        {
            this.tBoxNombre.Text = this.pasajero.nombre;
            this.tBoxApellido.Text = this.pasajero.apellido;
            this.tBoxEdad.Text = this.pasajero.Edad.ToString();
        }

        private void ActualizarExtras()
        {
            if (!chbxEsPremium.Checked)
            {
                this.lblValija2.Enabled = false;
                this.numValija2.Enabled = false;
                this.numValija1.Maximum = 25;

                this.lblUSDbase.Text = viaje.CostoTurista.ToString();
                this.lblUSDfinal.Text = Aeropuerto.CalcularIVA(this.viaje.CostoTurista).ToString();
            }
            else
            {
                this.lblValija2.Enabled = true;
                this.numValija2.Enabled = true;

                this.numValija1.Maximum = 21;
                this.numValija2.Maximum = 21;

                this.lblUSDbase.Text = viaje.CostoPremium.ToString();
                this.lblUSDfinal.Text = Aeropuerto.CalcularIVA(this.viaje.CostoPremium).ToString();
            }
        }

        private void chbxEsPremium_CheckedChanged(object sender, EventArgs e)
        {
            this.ActualizarExtras();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!(flagPasajero && flagViaje))
            {
                MessageBox.Show("Hay datos sin completar!","Error",
                    MessageBoxButtons.OK,MessageBoxIcon.Hand);
                return;
            }

            if (this.viaje == this.pasajero)
            {
                MessageBox.Show("Este pasajero ya esta en este mismo viaje!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }

            this.viaje += this.pasajero;
            //ESTADISTICAS
            this.DialogResult = DialogResult.OK;
        }
    }
}
