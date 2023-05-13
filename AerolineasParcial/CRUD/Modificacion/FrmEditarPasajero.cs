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
    public partial class FrmEditarPasajero : FormAltaPasajero
    {
        Aeropuerto aeropuerto;
        //Pasajero pasajero;
        
        public FrmEditarPasajero(Aeropuerto aeropuerto) : base()
        {
            InitializeComponent();
            this.aeropuerto = aeropuerto;
            //this.pasajero = new Pasajero();
        }


        protected override void FormAltaPasajero_Load(object sender, EventArgs e)
        {
            base.FormAltaPasajero_Load(sender, e);
            base.lblTitle.Text = "Editar Pasajero";
            this.btnBuscar.Text = "Buscar";
            this.Text = "Editar Informacion";

            base.tBoxNombre.Enabled = false;
            base.tBoxApellido.Enabled = false;
            base.tBoxEdad.Enabled = false;
            base.btnGuardar.Enabled = false;
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

            tBoxDni.Enabled = false;
            UpdateUIInfo();
            base.btnGuardar.Enabled = true;
            base.tBoxNombre.Enabled = true;
            base.tBoxApellido.Enabled = true;
            base.tBoxEdad.Enabled = true;
            this.btnBuscar.Enabled = false;

        }

        private void UpdateUIInfo()
        {
            base.tBoxNombre.Text = this.pasajero.nombre;
            base.tBoxApellido.Text = this.pasajero.apellido;
            base.tBoxEdad.Text = this.pasajero.Edad.ToString();
        }
       
    }
}
