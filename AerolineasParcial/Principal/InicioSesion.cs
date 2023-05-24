using BibliotecaEntidades;
using System.Reflection.Metadata;
using System.Text.Json;
using System.IO;
using System.Text.Json.Serialization;

namespace AerolineasParcial
{
    public partial class FrmInicioSesion : Form
    {
        private List<Usuario> listaUsers;
        private Usuario usuario;

        public FrmInicioSesion()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;//Para que aparezca en el centro.
            this.listaUsers = new List<Usuario>();
            this.usuario = new Usuario();
        }

        #region PROPIEDADES

        public Usuario Usuario { get { return this.usuario; } }

        #endregion

        #region METODOS_FORM
        private void InicioSesion_Load(object sender, EventArgs e)
        {
            tBoxUser.PlaceholderText = "empleado@mail.com";
            tBoxPswrd.PlaceholderText = "Ingrese aqui su contrasena";
            tBoxPswrd.PasswordChar = 'x';

            btnAceptar.Text = "Iniciar sesion";
            btnSalir.Text = "Salir";

            this.FormBorderStyle = FormBorderStyle.FixedSingle; //Para que no se pueda reescalar.
            this.MaximizeBox = false;

            if (!Archivos.DeserealizarUsuarios("MOCK_DATA.json", out this.listaUsers))
            {
                btnAceptar.Enabled = false;
                MessageBox.Show("Hubo un error al intentar deserealizar el archivo de users.",
                    "No puede continuar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Usuario.ValidarCredenciales(tBoxUser.Text, tBoxPswrd.Text,
                this.listaUsers, out this.usuario))
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("El usuario o contraseña ingresados son incorrectos o no existen.",
                    "Fallo al iniciar sesion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();//Es correcto su uso?
        }

        #endregion

    }
}