using BibliotecaEntidades;
using System.Reflection.Metadata;
using System.Text.Json;
using System.IO;
using System.Text.Json.Serialization;

namespace AerolineasParcial
{
    public partial class FrmInicioSesion : Form
    {
        private string path;
        private List<Usuario> listaUsers;
        private JsonSerializerOptions jSonOptions;
        public Usuario usuario;
        public FrmInicioSesion()
        {
            this.StartPosition = FormStartPosition.CenterScreen;//Para que aparezca en el centro.
            this.FormBorderStyle = FormBorderStyle.FixedSingle; //Para que no se pueda reescalar.
            this.MaximizeBox = false; //Para evitar que se maximice.

            path = Environment.CurrentDirectory;
            listaUsers = new List<Usuario>();
            jSonOptions = new JsonSerializerOptions();
            usuario = new Usuario();

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tBoxUser.PlaceholderText = "empleado@mail.com";
            tBoxPswrd.PlaceholderText = "1234";

            btnAceptar.Text = "Iniciar sesion";
            btnSalir.Text = "Salir";

            string jsonText;
            if (!File.Exists(path + @"\MOCK_DATA.json"))
            {
                MessageBox.Show("No se pudo encontrar el json de Usuarios!\n" +
                    "Se lo esta buscando en: " + (path + @"\MOCK_DATA.json"), "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                using (StreamReader reader = new StreamReader(path + @"\MOCK_DATA.json"))
                {
                    jsonText = reader.ReadToEnd();

                    //Nueva opcion para que pueda deserealizar los strings como enum.
                    jSonOptions.Converters.Add(new JsonStringEnumConverter());
                    this.listaUsers = (List<Usuario>)JsonSerializer.Deserialize(jsonText, typeof(List<Usuario>), jSonOptions);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error al intentar DESerializar: " + ex.Message,
                            "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string usuario;
            string contrasena;
            usuario = tBoxUser.Text;
            contrasena = tBoxPswrd.Text;

            foreach (Usuario us in listaUsers)
            {
                if (us.correo == usuario && us.clave == contrasena)
                {
                    MessageBox.Show("Inicio de sesion correcto!");
                    this.usuario = us;
                    this.DialogResult = DialogResult.OK;
                    return;
                }
            }

            MessageBox.Show("El usuario o contraseña son incorrectos", "No se pudo iniciar sesion",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

        }
    }
}