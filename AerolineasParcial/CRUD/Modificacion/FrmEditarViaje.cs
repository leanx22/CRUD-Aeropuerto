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

            base.EstadoControles(false);
        }

        private void btnBuscarViaje_Click(object sender, EventArgs e)
        {
            FormViajes ventana = new FormViajes(base.aeropuerto);
            DialogResult res = ventana.ShowDialog();
            if (res == DialogResult.OK)
            {
                base.viaje = ventana.Viaje;
                base.EstadoControles(true);
                this.bufferFecha = base.viaje.FechaDeVuelo.Date;
                base.ActualizarElementos();
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
