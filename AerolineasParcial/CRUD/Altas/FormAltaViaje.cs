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

namespace AerolineasParcial.CRUD.Altas
{
    public partial class FormAltaViaje : Form
    {
        protected Aeropuerto aeropuerto;
        protected Aeronave aeronave;
        protected Viaje viaje;
        public FormAltaViaje()
        {
            InitializeComponent();
            this.aeropuerto = new Aeropuerto();
            this.aeronave = new Aeronave();
            this.viaje = new Viaje();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public FormAltaViaje(Aeropuerto aeropuerto) : this()
        {
            this.aeropuerto = aeropuerto;
        }

        public Viaje Viaje { get { return this.viaje; } }

        protected virtual void FormAltaViaje_Load(object sender, EventArgs e)
        {
            
            #region FORMULARIO
            this.MaximizeBox = false;
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            #endregion

            #region TEXTOS
            this.Text = "Alta de viaje";
            this.lblTitulo.Text = "Nuevo viaje";
            this.btnOK.Text = "Guardar";
            this.btnCancel.Text = "Cancel";
            this.chbxInternacional.Text = "Internacional";
            this.btnAsignarAeronave.Text = "Buscar";
            #endregion

            #region CONTROLES
            this.dateTimePicker.MinDate = DateTime.Today; //No se puede crear un viaje en el pasado.
            this.chbxInternacional.Checked = false;//Por defecto, el viaje sera con destino nacional.
            this.cBoxDestinos.DataSource = Enum.GetValues(typeof(ENacional));//Por defecto, el comboBox mostrara los destinos nacionales.
            this.tBoxDuracion.Enabled = false;
            this.tBoxAeronave.Enabled = false;
            //this.btnOK.Enabled = false;
            #endregion

            this.tBoxDuracion.Text = Viaje.GenerarDuracion(chbxInternacional.Checked).ToString();
            ActualizarPrecio();
        }

        //Al cambiar el valor de la CheckBox
        private void chbxInternacional_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxInternacional.Checked)//Si es internacional:
            {
                this.cBoxDestinos.DataSource = Enum.GetValues(typeof(EInternacional));//Destinos inter.
                this.tBoxPartida.Text = "Buenos Aires";//Todos los internacionales salen de BsAs.
                this.tBoxPartida.Enabled = false;//Para que el user no pueda cambiarlo.
            }
            else
            {
                this.cBoxDestinos.DataSource = Enum.GetValues(typeof(ENacional));//Destinos nacionales.
                this.tBoxPartida.Text = string.Empty;//Se vacia la tBox de Partida.
                this.tBoxPartida.Enabled = true;//Se permite el ingreso de datos por parte del user.
            }
            this.tBoxDuracion.Text = Viaje.GenerarDuracion(chbxInternacional.Checked).ToString();
            ActualizarPrecio();
        }

        private void btnAsignarAeronave_Click(object sender, EventArgs e)
        {
            int asientosPremium = 0;
            int asientosTurista = 0;
            FrmSelectorAeronaves ventana = new FrmSelectorAeronaves(this.aeropuerto);

            DialogResult res = ventana.ShowDialog();
            if (res == DialogResult.OK)
            {
                this.aeronave = ventana.Aeronave;
                this.tBoxAeronave.Text = this.aeronave.Matricula;

                Viaje.ObtenerAsientos(this.aeronave,
                    out asientosPremium, out asientosTurista);

                this.lblCantPremium.Text = asientosPremium.ToString();
                this.lblCantTurista.Text = asientosTurista.ToString();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Seguro que desea cancelar la operacion?\n" +
                "Los cambios no se guardaran.", "Confirmar", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning);
            if (res == DialogResult.OK)
            {
                this.Close();
            }
        }

        protected virtual void btnOK_Click(object sender, EventArgs e)
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

            if (!Aeronave.ValidarMatricula(this.tBoxAeronave.Text))
            {
                MessageBox.Show("La aeronave no es valida!.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (this.aeronave == this.dateTimePicker.Value.Date)
            {
                MessageBox.Show("La aeronave ya tiene un viaje en la fecha indicada!.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //this.aeronave.Disponible = false;
            this.aeronave.Agenda.Add(this.dateTimePicker.Value.Date);
            this.aeronave.HorasDeVuelo += int.Parse(this.tBoxDuracion.Text);
            this.viaje = new Viaje(this.chbxInternacional.Checked, this.tBoxPartida.Text,
                this.cBoxDestinos.SelectedValue.ToString(), this.dateTimePicker.Value.Date,
                this.aeronave.Matricula, int.Parse(this.lblCantPremium.Text), int.Parse(this.lblCantTurista.Text),
                float.Parse(this.lblPrecioPremium.Text), float.Parse(this.lblPrecioTurista.Text),
                int.Parse(this.tBoxDuracion.Text), new List<Pasajero>(), EEstadoDeVuelo.Pendiente);

            this.DialogResult = DialogResult.OK;

        }

        protected void ActualizarPrecio()
        {
            int horas = int.Parse(this.tBoxDuracion.Text);
            float precioTurista;
            float precioPremium;

            Viaje.ObtenerPrecios(chbxInternacional.Checked, horas, out precioTurista, out precioPremium);
            this.lblPrecioTurista.Text = precioTurista.ToString();
            this.lblPrecioPremium.Text = precioPremium.ToString();

        }

        /// <summary>
        /// Esta funcion cambia la propiedad enabled de los controles principales de este formulario.
        /// </summary>
        /// <param name="estado">
        /// True para activarlos, False para desactivarlos.
        /// </param>
        protected void EstadoControles(bool estado)
        {
            this.cBoxDestinos.Enabled = estado;
            this.tBoxPartida.Enabled = estado;
            this.dateTimePicker.Enabled = estado;
            this.btnAsignarAeronave.Enabled = estado;
            this.chbxInternacional.Enabled = estado;
            this.btnOK.Enabled = estado;
        }

        /// <summary>
        /// Esta funcion actualiza los datos de los controladores.
        /// 
        /// </summary>
        protected void ActualizarElementos()
        {
            int asientosP;
            int asientosT;


            this.chbxInternacional.Checked = this.viaje.EsInternacional;
            if (chbxInternacional.Checked)
            {
                this.cBoxDestinos.SelectedIndex = (int)Enum.Parse(typeof(EInternacional), this.viaje.Destino);
            }
            else
            {
                this.cBoxDestinos.SelectedIndex = (int)Enum.Parse(typeof(ENacional), this.viaje.Destino);
            }
            this.tBoxPartida.Text = this.viaje.Partida;
            this.tBoxPartida.Enabled = !this.chbxInternacional.Checked;
            this.dateTimePicker.Value = this.viaje.FechaDeVuelo.Date;//.value?
            this.tBoxAeronave.Text = this.viaje.AvionAsignado;
            this.tBoxDuracion.Text = this.viaje.Duracion.ToString();
            //No valido la busqueda porque si o si va a estar bien, ya que no se puede modificar.
            this.aeropuerto.BuscarAeronave(this.viaje.AvionAsignado, out this.aeronave);
            Viaje.ObtenerAsientos(this.aeronave, out asientosP, out asientosT);
            this.lblCantPremium.Text = asientosP.ToString();
            this.lblCantTurista.Text = asientosT.ToString();
            this.ActualizarPrecio();
        }

    }
}
