using BibliotecaEntidades;
using System.Reflection.Metadata;
using System.Text.Json;
using System.IO;

namespace AerolineasParcial
{
    public partial class FrmInicioSesion : Form
    {
        private string path;
        private Usuario usuario;
        private List<Usuario> listaUsers;
        public FrmInicioSesion()
        {
            this.StartPosition = FormStartPosition.CenterScreen;//Para que aparezca en el centro.
            this.FormBorderStyle = FormBorderStyle.FixedSingle; //Para que no se pueda reescalar.
            this.MaximizeBox = false; //Para evitar que se maximice.

            path = Environment.CurrentDirectory;
            this.usuario = new Usuario();
            listaUsers = new List<Usuario>();

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
                    //MessageBox.Show(jsonText);
                    this.listaUsers = (List<Usuario>)JsonSerializer.Deserialize(jsonText, typeof(List<Usuario>));
                    //MessageBox.Show("Deserealizado OK");
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
                    MessageBox.Show("Inicio correcto!");
                    this.usuario = us;
                    //nuevo form principal.
                    FrmPrincipal ventana = new FrmPrincipal(this.usuario);
                    ventana.Show();
                    this.Hide();//No me convence. Creo que sigue ocupando memoria.
                    return;  
                }
            }

            MessageBox.Show("El usuario o contraseña son incorrectos","No se pudo iniciar sesion",
                MessageBoxButtons.OK,MessageBoxIcon.Information);

        }
    }
}