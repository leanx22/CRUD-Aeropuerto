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
    public partial class FormAltaAeronave : Form
    {
        protected Aeronave aeronave;
        public FormAltaAeronave()
        {
            InitializeComponent();
            aeronave = new Aeronave();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public Aeronave Aeronave { get { return this.aeronave; } }

        protected virtual void FormAltaAeronave_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            this.Text = "Nueva Alta";
            this.lblTitulo.Text = "Alta de Aeronave";
            this.btnOK.Text = "Guardar";
            this.btnCancel.Text = "Cancelar";

            this.chbxComida.Text = "Comida.";
            this.chbxInternet.Text = "Internet.";

            this.numBodega.Maximum = 15000; //Google:Capacidad promedio en kg de la bodega de un avion.
            this.numAsientos.Minimum = 2;
            this.numAsientos.Maximum = 800; //Google: Promedio de asientos de un boeing:600 - 700, le pongo un poco mas.
            this.numBanios.Minimum = 1;
            this.numBanios.Maximum = 8; // Mayor cantidad que pueden tener segun Google.
        }

        protected virtual void btnOK_Click(object sender, EventArgs e)
        {
            if (!Aeronave.ValidarMatricula(tBoxMatricula.Text))
            {
                MessageBox.Show("La matricula no es valida. La misma debe contener:" +
                    "\n-Exactamente 8(ocho) caracteres." +
                    "\n-Al menos 1(un) numero." +
                    "\n-Al menos 1(una) letra." +
                    "\n-SIN caracteres especiales.",
                    "Error al asignar matricula.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (Control c in this.Controls)
            {
                if (c is TextBox && c.Text == string.Empty)
                {
                    MessageBox.Show("Uno de los campos esta vacio.", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }
            }

            //Los asientos, banios y bodega ya se validan con las propiedades minimum y max en el load.
            this.aeronave = new Aeronave(tBoxMatricula.Text.ToUpper(), (int)numAsientos.Value, (int)numBanios.Value,
                chbxInternet.Checked, chbxComida.Checked, (int)numBodega.Value,true);
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Seguro que desea cancelar?\nLos cambios no se guardaran",
                "Cancelar operacion.", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (res == DialogResult.OK)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }
        protected void UpdateUIInfo()
        {
            this.numAsientos.Value = this.aeronave.Asientos;
            this.numBanios.Value = this.aeronave.Banios;
            this.numBodega.Value = this.aeronave.bodega;
            this.chbxComida.Checked = this.aeronave.Comida;
            this.chbxInternet.Checked = this.aeronave.Internet;
        }
    }
}
