using BibliotecaEntidades;
using System.Reflection.Metadata;
using System.Text.Json;
using System.IO;
using System.Text.Json.Serialization;

namespace AerolineasParcial
{
    public partial class FrmInicioSesion : Form
    {
        public List<Usuario> listaUsers; //pasar a private
        private Usuario usuario;
        public FrmInicioSesion()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;//Para que aparezca en el centro.
            this.listaUsers = new List<Usuario>();
            this.usuario = new Usuario();            
        }

        public Usuario Usuario { get { return this.usuario; } }

        private void Form1_Load(object sender, EventArgs e)
        {
            tBoxUser.PlaceholderText = "empleado@mail.com";
            tBoxPswrd.PlaceholderText = "Ingrese aqui su contrasena";
            tBoxPswrd.PasswordChar = 'x';

            btnAceptar.Text = "Iniciar sesion";
            btnSalir.Text = "Salir";

            this.FormBorderStyle = FormBorderStyle.FixedSingle; //Para que no se pueda reescalar.
            this.MaximizeBox = false;
            this.ControlBox = false;

            if (!Usuario.Deserealizar("MOCK_DATA.json", out this.listaUsers))
            {
                btnAceptar.Enabled = false;
                MessageBox.Show("Hubo un error al intentar deserealizar el archivo de users.",
                    "No puede continuar",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarCredenciales(tBoxUser.Text, tBoxPswrd.Text))
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
        
        private bool ValidarCredenciales(string mail, string contrasena)
        {
            //Recorre la lista y busca coincidencia de correo&clave
            bool ret = false;

            foreach (Usuario us in this.listaUsers)
            {
                if (us.correo == mail && us.clave==contrasena)
                {
                    this.usuario = us;
                    ret = true;
                    break;
                }
            }
            return ret;
        }
    }
}