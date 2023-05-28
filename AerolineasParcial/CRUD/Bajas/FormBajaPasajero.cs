using AerolineasParcial.CRUD.Modificacion;
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
    public partial class FormBajaPasajero : FormAltaPasajero
    {
        Aeropuerto aeropuerto;
        public FormBajaPasajero(Aeropuerto aeropuerto):base()
        {
            InitializeComponent();
            this.aeropuerto = aeropuerto;
        }
        protected override void FormAltaPasajero_Load(object sender, EventArgs e)
        {
            base.FormAltaPasajero_Load(sender, e);
            this.Text = "Baja de pasajero";
            base.lblTitle.Text = "Pedido de baja";
            base.btnGuardar.Text = "Dar de baja";
            base.btnGuardar.Enabled = false;
            this.btnBuscar.Text = "Buscar";

            base.tBoxNombre.Enabled = false;
            base.tBoxEdad.Enabled = false;
            base.tBoxApellido.Enabled = false;

        }

        protected override void btnGuardar_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Esta seguro de ELIMINAR al pasajero?\n" +
                "DNI: "+base.Pasajero.DNI.ToString(),
                "Confirmar",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
            if (res == DialogResult.OK)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.DialogResult = DialogResult.Cancel;
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            long dni;
            if (!(tBoxDni.Text != string.Empty && long.TryParse(tBoxDni.Text, out dni)))
            {
                MessageBox.Show("Dni no valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!this.aeropuerto.BuscarPasajero(dni, out base.pasajero))
            {
                MessageBox.Show("No existe pasajero registrado con ese DNI.",
                    "El pasajero no existe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            base.btnGuardar.Enabled = true;
            //base.UpdateUIInfo();
        }

    }
}
