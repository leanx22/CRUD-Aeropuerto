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
    public partial class FrmBajaAeronave : FormAltaAeronave
    {
        Aeropuerto aeropuerto;
        public FrmBajaAeronave(Aeropuerto aeropuerto)
        {
            InitializeComponent();
            this.aeropuerto = aeropuerto;
        }

        protected override void FormAltaAeronave_Load(object sender, EventArgs e)
        {
            base.FormAltaAeronave_Load(sender, e);
            base.Text = "Nueva baja";
            base.lblTitulo.Text = "Baja de aeronave";

            base.numAsientos.Enabled = false;
            base.numBanios.Enabled = false;
            base.numBodega.Enabled = false;
            base.chbxComida.Enabled = false;
            base.chbxInternet.Enabled = false;
            base.btnOK.Enabled = false;
        }

        protected override void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Seguro que desea eliminar la siguiente aeronave?:\n" +
                "Matricula: " + base.aeronave.Matricula, "Confirmar", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning);
            if (res == DialogResult.OK)
            {
                base.DialogResult = res;
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!Aeronave.ValidarMatricula(tBoxMatricula.Text))
            {
                MessageBox.Show("Matricula no valida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!this.aeropuerto.BuscarAeronave(tBoxMatricula.Text, out base.aeronave))
            {
                MessageBox.Show("No existe aeronave registrada con esa matricula.",
                    "La aeronave no existe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            base.btnOK.Enabled = true;
            base.UpdateUIInfo();
            btnOK.Enabled = true;
        }
    }
}
