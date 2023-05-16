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
        Aeropuerto aeropuerto;
        Aeronave aeronave;
        Viaje viaje;
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

        private void FormAltaViaje_Load(object sender, EventArgs e)
        {
            #region FORMULARIO
            this.MaximizeBox = false;
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            #endregion

            #region TEXTOS
            this.Text = "Alta de viaje";
            this.lblTitulo.Text = "Destino";
            this.btnOK.Text = "Guardar";
            this.btnCancel.Text = "Cancel";
            this.chbxInternacional.Text = "Internacional";
            this.btnAsignarAeronave.Text = "Buscar";
            #endregion

            #region CONTROLES
            this.dateTimePicker.MinDate = DateTime.Now; //No se puede crear un viaje en el pasado.
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

        private void btnOK_Click(object sender, EventArgs e)
        {
            //OJO, LA AERONAVE SELECCIONADA DEBE CAMBIAR A NO DISPONIBLE!
            if (cBoxDestinos.SelectedItem==null)
            {
                MessageBox.Show("Se debe seleccionar un destino","Error",
                    MessageBoxButtons.OK,MessageBoxIcon.Error);
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

            this.aeronave.Disponible = false;
            this.viaje = new Viaje(this.chbxInternacional.Checked,this.tBoxPartida.Text,
                this.cBoxDestinos.SelectedValue.ToString(),this.dateTimePicker.Value,
                this.aeronave.Matricula,int.Parse(this.lblCantPremium.Text),int.Parse(this.lblCantTurista.Text),
                float.Parse(this.lblPrecioPremium.Text),float.Parse(this.lblPrecioTurista.Text),
                int.Parse(this.tBoxDuracion.Text),new List<Pasajero>(),EEstadoDeVuelo.Pendiente);

            this.DialogResult = DialogResult.OK;

        }

        private void ActualizarPrecio()
        {
            int horas = int.Parse(this.tBoxDuracion.Text);
            float precioTurista;
            float precioPremium;

            Viaje.ObtenerPrecios(chbxInternacional.Checked, horas, out precioTurista, out precioPremium);
            this.lblPrecioTurista.Text = precioTurista.ToString();
            this.lblPrecioPremium.Text = precioPremium.ToString();

        }
    }
}
