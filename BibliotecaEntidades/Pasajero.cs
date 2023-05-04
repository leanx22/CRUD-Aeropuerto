using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaEntidades
{
    public class Pasajero:Persona
    {
        //private string apellido;
        //private string nombre;
        private long dni;
        private short edad;
        private Dictionary<string, int> equipaje;

        public Pasajero() : base()
        {
            //this.apellido = "Sin apellido";
            //this.nombre = "Sin nombre";
            this.dni = 00112233;
            this.edad = 0;
            this.equipaje = new Dictionary<string, int>();
        }

        public Pasajero(string nombre, string apellido, long dni,
            short edad, Dictionary<string,int> equipaje):base(nombre,apellido)
        {
            //this.nombre = nombre;
            //this.apellido = apellido;
            this.dni = dni;
            this.edad = edad;
            this.equipaje = equipaje;
        }

        #region PROPIEDADES
        /*
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
       */
        public long DNI
        {
            get { return dni; }
            set { dni = value; }
        }
        public short Edad
        {
            get { return edad; }
            set { edad = value; }
        }
        public Dictionary<string, int> Equipaje
        {
            get { return equipaje; }
            set { equipaje = value; }
        }
        #endregion

        public override string ObtenerDatos()
        {
            throw new NotImplementedException();
        }

        public static  List<Pasajero> CargarJson() { return null; }

        public static bool GuardarJson(List<Pasajero> lista) { return false; }

        public static List<Pasajero> BuscarPasajero(long dni,string nombre, string apellido, List<Pasajero> lista)
        {
            List<Pasajero> resultados = new List<Pasajero>();
            foreach (Pasajero p in lista)
            {
                if ((dni == 0 || p.dni == dni) &&
                    (nombre==string.Empty || p.nombre == nombre) &&
                    apellido==string.Empty || p.apellido == apellido)
                {
                    resultados.Add(p);
                }
            }
            return resultados;
        }

    }
}
