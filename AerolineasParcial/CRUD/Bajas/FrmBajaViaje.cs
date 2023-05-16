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

namespace AerolineasParcial.CRUD.Bajas
{
    public partial class FrmBajaViaje : FormAltaViaje
    {
        public FrmBajaViaje(Aeropuerto aeropuerto) : base(aeropuerto)
        {
            InitializeComponent();
        }

        private void btnBuscarViaje_Click(object sender, EventArgs e)
        {
            FormViajes ventana = new FormViajes(base.aeropuerto);
            DialogResult res = ventana.ShowDialog();
            if (res == DialogResult.OK)
            {
                base.viaje = ventana.Viaje;
                base.ActualizarElementos();
                base.btnOK.Enabled = true;
            }
        }

        private void FrmBajaViaje_Load(object sender, EventArgs e)
        {
            base.FormAltaViaje_Load(sender, e);
            this.Text = "Operacion de baja";
            base.lblTitulo.Text = "Baja de viaje";
            base.btnOK.Text = "Dar de baja";
            base.EstadoControles(false);
        }

        protected override void btnOK_Click(object sender, EventArgs e)
        {
            base.aeronave -= base.viaje.FechaDeVuelo.Date;//Elimino la fecha del viaje de la agenda de la aeronave.
            base.aeronave.HorasDeVuelo -= int.Parse(this.tBoxDuracion.Text);//Sumo horas de vuelo(mejorar)

            base.viaje = new Viaje(base.chbxInternacional.Checked, base.tBoxPartida.Text,
                base.cBoxDestinos.SelectedValue.ToString(), base.dateTimePicker.Value.Date,
                base.aeronave.Matricula, int.Parse(base.lblCantPremium.Text), int.Parse(base.lblCantTurista.Text),
                float.Parse(base.lblPrecioPremium.Text), float.Parse(base.lblPrecioTurista.Text),
                int.Parse(base.tBoxDuracion.Text), new List<Pasajero>(), EEstadoDeVuelo.Pendiente);

            this.DialogResult = DialogResult.OK;
        }
    }
}
