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
        Aeropuerto aeropuerto;
        public FormAltaPasajero(Aeropuerto aeropuerto)
        {
            this.aeropuerto = aeropuerto;
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();

        }

        private void FormAltaPasajero_Load(object sender, EventArgs e)
        {
            this.Text = "Nueva alta de pasajero";
            lblTitle.Text = "Alta de pasajero";
            btnGuardar.Text = "Guardar";
            btnSalir.Text = "Cancelar";

            cBoxEquipaje.DataSource = Enum.GetValues(typeof(ETipoEquipaje));
            cBoxEquipaje.SelectedIndex = 0;

            this.MaximizeBox = false;
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            long dni;
            short edad;
            Pasajero pasajero;
            Dictionary<ETipoEquipaje, int> dic = new Dictionary<ETipoEquipaje, int>();

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

            foreach (Control c in this.pnlMain.Controls)
            {
                if (c is TextBox && c.Text == string.Empty)
                {
                    MessageBox.Show("Uno de los campos esta vacio.", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }
            }

            if (numCantidad.Value == 0)
            {
                MessageBox.Show("El pasajero no puede viajar sin equipaje!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dic.Add((ETipoEquipaje)cBoxEquipaje.SelectedValue, (int)numCantidad.Value);
            pasajero = new Pasajero(tBoxNombre.Text, tBoxApellido.Text, dni, edad, dic);

            if (this.aeropuerto + pasajero)
            {
                MessageBox.Show("Pasajero dado de alta correctamente!", "Exito!", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("El pasajero que se trata de agregar ya se ha" +
                    "dado de alta con anterioridad!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Hand);
                DialogResult = DialogResult.Abort;
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Seguro que desea cancelar?\nNo se guardara" +
                " la informacion del pasajero y el formulario se cerrara.","Salir sin guardar",
                MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
            if (res == DialogResult.OK)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }
    }
}
