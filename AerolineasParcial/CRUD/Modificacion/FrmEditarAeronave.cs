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
    public partial class FrmEditarAeronave : FormAltaAeronave
    {
        Aeropuerto aeropuerto;
        public FrmEditarAeronave(Aeropuerto aeropuerto)
        {
            InitializeComponent();
            this.aeropuerto = aeropuerto;
        }

        protected override void FormAltaAeronave_Load(object sender, EventArgs e)
        {
            base.FormAltaAeronave_Load(sender, e);
            base.Text = "Nueva edicion";
            base.lblTitulo.Text = "Editar aeronave";

            base.numAsientos.Enabled = false;
            base.numBanios.Enabled = false;
            base.numBodega.Enabled = false;
            base.chbxComida.Enabled = false;
            base.chbxInternet.Enabled = false;
            base.btnOK.Enabled = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!Aeronave.ValidarMatricula(tBoxMatricula.Text))
            {
                MessageBox.Show("Matricula no valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!this.aeropuerto.BuscarAeronave(tBoxMatricula.Text, out base.aeronave))
            {
                MessageBox.Show("No existe aeronave registrada con esa matricula.",
                    "La aeronave no existe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            tBoxMatricula.Enabled = false;
            base.UpdateUIInfo();
            base.btnOK.Enabled = true;
            base.numAsientos.Enabled = true;
            base.numBanios.Enabled = true;
            base.numBodega.Enabled = true;
            base.chbxComida.Enabled = true;
            base.chbxInternet.Enabled = true;
            this.btnBuscar.Enabled = false;
        }
    }
}
