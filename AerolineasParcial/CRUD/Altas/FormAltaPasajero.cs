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

namespace AerolineasParcial.CRUD
{
    public partial class FormAltaPasajero : Form
    {
        protected Pasajero pasajero;
        public FormAltaPasajero()
        {
            InitializeComponent();
            this.pasajero = new Pasajero();
            this.StartPosition = FormStartPosition.CenterScreen;            
        }

        protected virtual void FormAltaPasajero_Load(object sender, EventArgs e)
        {
            this.Text = "Nueva alta de pasajero";
            lblTitle.Text = "Alta de pasajero";
            btnGuardar.Text = "Guardar";
            btnSalir.Text = "Cancelar";

            this.MaximizeBox = false;
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;

        }
        
        #region PROPIEDADES

        public Pasajero Pasajero { get { return this.pasajero; } set { this.pasajero = value; } }

        #endregion

        #region METODOS
        
        protected virtual void btnGuardar_Click(object sender, EventArgs e)
        {
            long dni;
            short edad;
            
            Dictionary<ETipoEquipaje, Equipaje> dic = new Dictionary<ETipoEquipaje, Equipaje>();

            dic.Add(ETipoEquipaje.Mano, new Equipaje(0,0f));
            dic.Add(ETipoEquipaje.Bodega, new Equipaje(0,0f));

            if (!Pasajero.ValidarDNI(tBoxDni.Text))
            {
                MessageBox.Show("El DNI ingresado no es valido:\n" +
                    "-DNI debe tener minimo 7 caracteres (solo numericos)", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (!Pasajero.ValidarSoloCaracteres(tBoxNombre.Text,true) ||
                !Pasajero.ValidarSoloCaracteres(tBoxApellido.Text,true))
            {
                MessageBox.Show("El NOMBRE o APELLIDO no son validos:\n" +
                    "-Admite espacios pero NO caracteres numericos", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (!short.TryParse(tBoxEdad.Text, out edad) || edad <0 || edad > 120)
            {
                MessageBox.Show("La edad ingresada no es valida (se admite de 0 a 120)",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            dni = long.Parse(tBoxDni.Text);//Uso .Parse porque ya valide antes.
            this.pasajero = new Pasajero(tBoxNombre.Text, tBoxApellido.Text, dni, edad, dic);
            this.DialogResult = DialogResult.OK;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Seguro que desea cancelar?\nNo se guardara" +
                " ningun cambio y el formulario se cerrara.", "Salir sin guardar",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (res == DialogResult.OK)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        #endregion
    }
}
