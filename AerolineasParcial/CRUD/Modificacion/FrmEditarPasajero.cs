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

        public FrmEditarPasajero(Pasajero pasajero) : base()
        {
            InitializeComponent();
            base.Pasajero = pasajero;
        }


        protected override void FormAltaPasajero_Load(object sender, EventArgs e)
        {
            base.FormAltaPasajero_Load(sender, e);
            base.lblTitle.Text = "Editar Pasajero";
            this.Text = "Editar Informacion";

            this.UpdateUIInfo();
        }

        private void UpdateUIInfo()
        {
            base.tBoxDni.Text = base.pasajero.DNI.ToString();
            base.tBoxNombre.Text = base.pasajero.nombre;
            base.tBoxApellido.Text = base.pasajero.apellido;
            base.tBoxEdad.Text = base.pasajero.Edad.ToString();
        }

    }
}
