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
            this.pasajero = new Pasajero();
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();

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
            Dictionary<ETipoEquipaje, Dictionary<int,int>> dic = new Dictionary<ETipoEquipaje, Dictionary<int, int>>();

            if (!long.TryParse(tBoxDni.Text, out dni))
            {
                MessageBox.Show("El DNI ingresado no es valido", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (!short.TryParse(tBoxEdad.Text, out edad) && edad < 120)
            {
                MessageBox.Show("La edad ingresada no es valida", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
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

            //Al crear el pasajero no tiene equipaje.
            dic[ETipoEquipaje.Mano][0] = 0; //Cantidad
            dic[ETipoEquipaje.Mano][1] = 0; //Peso

            dic[ETipoEquipaje.Bodega][0] = 0; //Cantidad
            dic[ETipoEquipaje.Bodega][1] = 0; //Peso

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

        protected virtual void UpdateUIInfo()
        {
            this.tBoxNombre.Text = this.pasajero.nombre;
            this.tBoxApellido.Text = this.pasajero.apellido;
            this.tBoxEdad.Text = this.pasajero.Edad.ToString();
        }

        #endregion
    }
}
