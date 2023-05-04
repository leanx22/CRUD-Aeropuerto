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

namespace AerolineasParcial
{
    public partial class BuscadorPasajero : Form
    {
        private long dni;
        private string nombre;
        private string apellido;
        private List<Pasajero> listaPasajeros;
        private List<Pasajero> resultados;
        public BuscadorPasajero()
        {
            InitializeComponent();
            dni = 0;
            nombre = "Sin nombre";
            apellido = "Sin apellido";
            listaPasajeros = new List<Pasajero>();
            resultados = new List<Pasajero>();
        }

        #region PROPIEDADES

        public long Dni { get { return dni; } }
        public string Nombre { get { return nombre; } }
        public string Apellido { get {  return apellido; } }
        public List<Pasajero> Resultados { get { return resultados; } }

        #endregion

        private void BuscadorPasajero_Load(object sender, EventArgs e)
        {
            btnBuscar.Text = "Buscar";
            btnCancelar.Text = "Cancelar";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //hardcode de testeo
            listaPasajeros.Add(new Pasajero("Leandro","Guia",44338249,20,new Dictionary<string, int> { { "sas", 1 } }));
            listaPasajeros.Add(new Pasajero("Leandro", "Emanuel", 55449350, 19, new Dictionary<string, int> { { "sas", 1 } }));
            listaPasajeros.Add(new Pasajero("Sett", "Capo", 11223344, 30, new Dictionary<string, int> { { "sas", 1 } }));
            listaPasajeros.Add(new Pasajero("Darius", "Gil", 55667788, 40, new Dictionary<string, int> { { "sas", 1 } }));

            if (tBoxDni.Text!=string.Empty && !long.TryParse(tBoxDni.Text, out this.dni))
            {
                MessageBox.Show("El DNI ingresado no es valido.","Error",
                    MessageBoxButtons.OK,MessageBoxIcon.Error);       
                return;
            }
            resultados.Clear();
            resultados = Pasajero.BuscarPasajero(dni,tBoxNombre.Text,tBoxApellido.Text,listaPasajeros);
            this.DialogResult = DialogResult.OK;
        }


    }
}
