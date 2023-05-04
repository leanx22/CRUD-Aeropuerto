using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaEntidades
{
    public abstract class Persona
    {
        private string Nombre;
        private string Apellido;

        public Persona()
        {
            Nombre = "Sin nombre";
            Apellido = "sin apellido";
        }

        public Persona(string nombre, string apellido)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
        }

        #region PROPIEDADES
        public string nombre { get { return Nombre; } set { Nombre = value; } }
        public string apellido { get { return Apellido; } set { Apellido = value; } }
        #endregion

        public abstract string ObtenerDatos();

    }
}
