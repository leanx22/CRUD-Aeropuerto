﻿using System.IO;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace BibliotecaEntidades
{   
    public class Usuario:Persona
    {
        //private string Apellido;
        //private string Nombre;
        private int Legajo;
        private string Correo;
        private string Clave;
        private EPerfil Perfil;

        public Usuario():base()
        {
            //this.Apellido = "Sin apellido";
            //this.Nombre = "Sin nombre";
            this.Legajo = -1;
            this.Correo = "Sin correo";
            this.Clave = "Sin clave";
            //this.Perfil = "No asignado";
            this.Perfil = EPerfil.vendedor;
            //this.eperfil = EPerfiles.NA;
        }

        public Usuario(string apellido, string nombre, int legajo, string correo,
            string clave, EPerfil perfil) : base(nombre,apellido)
        {
            //this.Apellido = apellido;
            //this.Nombre = nombre;
            this.Legajo = legajo;
            this.Correo = correo;
            this.Clave = clave;
            this.Perfil = perfil;
        }

        #region PROPIEDADES
        //public string apellido { get { return Apellido; } set { Apellido = value; } }
        //public string nombre { get { return Nombre; } set { Nombre = value; } }
        public int legajo { get { return Legajo; } set { Legajo = value; } }
        public string correo { get { return Correo; } set { Correo = value; } }
        public string clave { get { return Clave; } set { Clave = value; } }
        public EPerfil perfil { get { return Perfil; } set { Perfil = value; } }
        #endregion

        #region METODOS        
        /// <summary>
        /// Deserealiza el jSon de usuarios en la lista que se le pase por parametro y la inicializa.
        /// </summary>
        /// <param name="filename">Nombre del archivo a deserealizar.</param>
        /// <param name="lista">Salida de la lista deserealizada.</param>
        /// <returns>Retorna true o false dependiendo del exito de la operacion.</returns>
        public static bool Deserealizar(string filename,out List<Usuario> lista)
        {
            JsonSerializerOptions jSonOptions = new JsonSerializerOptions();
            lista = new List<Usuario>();
            string jsonText;
            bool ret = false;

            if (File.Exists(filename))
            {
                try
                {
                    using (StreamReader reader = new StreamReader(filename))
                    {
                        jsonText = reader.ReadToEnd();

                        //Nueva opcion para que pueda deserealizar los strings como enum.
                        jSonOptions.Converters.Add(new JsonStringEnumConverter());
                        lista = (List<Usuario>)JsonSerializer.Deserialize(jsonText, typeof(List<Usuario>), jSonOptions);
                        ret = true;
                    }
                }
                catch
                {
                    ret = false;
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