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
        public FormAltaViaje()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

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
            dateTimePicker.MinDate = DateTime.Now; //No se puede crear un viaje en el pasado.
            chbxInternacional.Checked = false;//Por defecto, el viaje sera con destino nacional.
            cBoxDestinos.DataSource = Enum.GetValues(typeof(ENacional));//Por defecto, el comboBox mostrara los destinos nacionales.
            tBoxDuracion.Enabled = false;
            #endregion
        }

        //Al cambiar el valor de la CheckBox
        private void chbxInternacional_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxInternacional.Checked)//Si es internacional:
            {
                cBoxDestinos.DataSource = Enum.GetValues(typeof(EInternacional));//Destinos inter.
                tBoxPartida.Text = "Buenos Aires";//Todos los internacionales salen de BsAs.
                tBoxPartida.Enabled = false;//Para que el user no pueda cambiarlo.
            }
            else
            {
                cBoxDestinos.DataSource = Enum.GetValues(typeof(ENacional));//Destinos nacionales.
                tBoxPartida.Text = string.Empty;//Se vacia la tBox de Partida.
                tBoxPartida.Enabled = true;//Se permite el ingreso de datos por parte del user.
            }
        }
    }
}
