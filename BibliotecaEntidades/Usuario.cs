using System.Text;
using System.Text.Json.Serialization;

namespace BibliotecaEntidades
{   
    public class Usuario
    {
        private string Apellido;
        private string Nombre;
        private int Legajo;
        private string Correo;
        private string Clave;
        //private string Perfil;
        private EPerfil Perfil;

        public Usuario()
        {
            this.Apellido = "Sin apellido";
            this.Nombre = "Sin nombre";
            this.Legajo = -1;
            this.Correo = "Sin correo";
            this.Clave = "Sin clave";
            //this.Perfil = "No asignado";
            this.Perfil = EPerfil.vendedor;
            //this.eperfil = EPerfiles.NA;
        }

        public Usuario(string apellido, string nombre, int legajo, string correo, string clave, EPerfil perfil) : this()
        {
            this.Apellido = apellido;
            this.Nombre = nombre;
            this.Legajo = legajo;
            this.Correo = correo;
            this.Clave = clave;
            this.Perfil = perfil;
        }

        public string apellido { get { return Apellido; } set { Apellido = value; } }
        public string nombre { get { return Nombre; } set { Nombre = value; } }
        public int legajo { get { return Legajo; } set { Legajo = value; } }
        public string correo { get { return Correo; } set { Correo = value; } }
        public string clave { get { return Clave; } set { Clave = value; } }
        public EPerfil perfil { get { return Perfil; } set { Perfil = value; } }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.Apellido);
            sb.AppendLine(this.Nombre);
            sb.AppendLine(this.Legajo.ToString());
            sb.AppendLine(this.Correo);
            sb.AppendLine(this.Clave);
            sb.AppendLine(this.Perfil.ToString());
            return sb.ToString();
        }
    }
}