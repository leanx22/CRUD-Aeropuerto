using AerolineasParcial.Consultas;
using AerolineasParcial.CRUD.Altas;
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

namespace AerolineasParcial.CRUD.Modificacion
{
    public partial class FrmEditarViaje : FormAltaViaje
    {
        DateTime bufferFecha;
        Viaje bufferViaje;
        public FrmEditarViaje(Aeropuerto aeropuerto) : base(aeropuerto)
        {
            InitializeComponent();
            bufferFecha = DateTime.Now.Date;
            bufferViaje = new Viaje();
        }

        protected override void FormAltaViaje_Load(object sender, EventArgs e)
        {
            base.FormAltaViaje_Load(sender, e);

            #region TEXTOS
            this.Text = "Editar viaje";
            base.lblTitulo.Text = "Editar viaje";
            #endregion

            EstadoControles(false);
        }

        /// <summary>
        /// Esta funcion cambia la propiedad enabled de los controles principales de este formulario.
        /// </summary>
        /// <param name="estado">
        /// True para activarlos, False para desactivarlos.
        /// </param>
        private void EstadoControles(bool estado)
        {
            base.cBoxDestinos.Enabled = estado;
            base.tBoxPartida.Enabled = estado;
            base.dateTimePicker.Enabled = estado;
            base.btnAsignarAeronave.Enabled = estado;
            base.chbxInternacional.Enabled = estado;
            base.btnOK.Enabled = estado;
        }

        /// <summary>
        /// Esta funcion actualiza los datos de los controladores.
        /// 
        /// </summary>
        private void ActualizarElementos()
        {
            int asientosP;
            int asientosT;

            
            base.chbxInternacional.Checked = base.viaje.EsInternacional;
            if (chbxInternacional.Checked)
            {
                base.cBoxDestinos.SelectedIndex = (int)Enum.Parse(typeof(EInternacional), base.viaje.Destino);
            }
            else
            {
                base.cBoxDestinos.SelectedIndex = (int)Enum.Parse(typeof(ENacional), base.viaje.Destino);
            }
            base.tBoxPartida.Text = base.viaje.Partida;
            base.tBoxPartida.Enabled = !base.chbxInternacional.Checked;
            base.dateTimePicker.Value = base.viaje.FechaDeVuelo.Date;//.value?
            base.tBoxAeronave.Text = base.viaje.AvionAsignado;
            base.tBoxDuracion.Text = base.viaje.Duracion.ToString();
            //No valido la busqueda porque si o si va a estar bien, ya que no se puede modificar.
            base.aeropuerto.BuscarAeronave(base.viaje.AvionAsignado, out base.aeronave);
            Viaje.ObtenerAsientos(base.aeronave, out asientosP, out asientosT);
            base.lblCantPremium.Text = asientosP.ToString();
            base.lblCantTurista.Text = asientosT.ToString();
            base.ActualizarPrecio();
        }

        private void btnBuscarViaje_Click(object sender, EventArgs e)
        {
            FormViajes ventana = new FormViajes(base.aeropuerto);
            DialogResult res = ventana.ShowDialog();
            if (res == DialogResult.OK)
            {
                base.viaje = ventana.Viaje;
                EstadoControles(true);
                this.bufferFecha = base.viaje.FechaDeVuelo.Date;
                ActualizarElementos();
            }
        }

        protected override void btnOK_Click(object sender, EventArgs e)
        {
            if (cBoxDestinos.SelectedItem == null)
            {
                MessageBox.Show("Se debe seleccionar un destino", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (tBoxPartida.Text == string.Empty)
            {
                MessageBox.Show("Asegurese de que el campo de partida este completo.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Si la aeronave ya tiene un viaje en esa fecha Y NO ES la fecha QUE YA TENIA
            if (this.aeronave == this.dateTimePicker.Value.Date && this.aeronave!=this.bufferFecha)
            {
                MessageBox.Show("La aeronave ya tiene un viaje en la fecha indicada!.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            base.aeropuerto -= base.viaje;//Elimino el viaje antiguo
            base.aeronave -= this.bufferFecha.Date;//Elimino la fecha del viaje de la agenda de la aeronave.
            base.aeronave += this.dateTimePicker.Value.Date;//Agrego la nueva fecha a la agenda de la aeronave.
            base.aeronave.HorasDeVuelo += int.Parse(this.tBoxDuracion.Text);//Sumo horas de vuelo(mejorar)
            
            base.viaje = new Viaje(base.chbxInternacional.Checked, base.tBoxPartida.Text,
                base.cBoxDestinos.SelectedValue.ToString(), base.dateTimePicker.Value.Date,
                base.aeronave.Matricula, int.Parse(base.lblCantPremium.Text), int.Parse(base.lblCantTurista.Text),
                float.Parse(base.lblPrecioPremium.Text), float.Parse(base.lblPrecioTurista.Text),
                int.Parse(base.tBoxDuracion.Text), new List<Pasajero>(), EEstadoDeVuelo.Pendiente);

            this.DialogResult = DialogResult.OK;
        }

    }
}
