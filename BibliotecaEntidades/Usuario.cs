using System.IO;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace BibliotecaEntidades
{   
    public class Usuario:Persona
    {
        //nombre (h)
        //apellido (h)
        private int Legajo;
        private string Correo;
        private string Clave;
        private EPerfil Perfil;

        public Usuario():base()
        {
            //nombre (base)
            //apellido (base)
            this.Legajo = -1;
            this.Correo = "Sin correo";
            this.Clave = "Sin clave";
            this.Perfil = EPerfil.vendedor;
        }

        public Usuario(string apellido, string nombre, int legajo, string correo,
            string clave, EPerfil perfil) : base(nombre,apellido)
        {
            //nombre (base)
            //apellido (base)
            this.Legajo = legajo;
            this.Correo = correo;
            this.Clave = clave;
            this.Perfil = perfil;
        }

        #region PROPIEDADES
        //Prop de nombre y apellido en base
        public int legajo { get { return Legajo; } set { Legajo = value; } }
        public string correo { get { return Correo; } set { Correo = value; } }
        public string clave { get { return Clave; } set { Clave = value; } }
        public EPerfil perfil { get { return Perfil; } set { Perfil = value; } }
        #endregion

        #region METODOS        

        /// <summary>
        /// Esta funcion se encarga de buscar coincidencias de mail&clave en una lista de usuarios.
        /// Si se encuentra una igualdad se guardara al usuario en la variable de salida.
        /// </summary>
        /// <param name="mail">
        /// Mail a comparar.
        /// </param>
        /// <param name="contrasena">
        /// Clave a comparar.
        /// </param>
        /// <param name="listaUsers">
        /// Lista de usuarios donde se realizara la busqueda.
        /// </param>
        /// <param name="usuario">
        /// Variable de salida donde se exportara al usuario en caso de existir sus credenciales.
        /// </param>
        /// <returns>
        /// Retorna TRUE en caso de encontrar una coincidencia, o FALSE si falla.
        /// </returns>
        public static bool ValidarCredenciales(string mail, string contrasena, List<Usuario> listaUsers,
            out Usuario usuario)
        {
            bool ret = false;
            usuario = new Usuario();

            foreach (Usuario us in listaUsers)
            {
                if (us.correo == mail && us.clave == contrasena)
                {
                    usuario = us;
                    ret = true;
                    break;
                }
            }
            return ret;
        }

        public override string ObtenerDatos() //Override de ToString?
        {
            //base.ObtenerDatos +
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.apellido);
            sb.AppendLine(this.nombre);
            sb.AppendLine(this.Legajo.ToString());
            sb.AppendLine(this.Correo);
            sb.AppendLine(this.Clave);
            sb.AppendLine(this.Perfil.ToString());
            return sb.ToString();
        }
        
        #endregion


    }
}