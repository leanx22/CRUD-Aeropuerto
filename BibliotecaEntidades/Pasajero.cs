using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Threading.Tasks;

namespace BibliotecaEntidades
{
    public class Pasajero:Persona
    {
        //nombre (h)
        //apellido (h)
        private long dni;
        private short edad;
        //Diccionario anidado para el equipaje (Tipo/Cantidad,Peso)
        private Dictionary<ETipoEquipaje, Equipaje> equipaje;

        public Pasajero() : base()
        {
            //nombre (base)
            //apellido (base)
            this.dni = 00112233;
            this.edad = 0;
            this.equipaje = new Dictionary<ETipoEquipaje, Equipaje>();
        }

        public Pasajero(string nombre, string apellido, long dni,
            short edad,Dictionary<ETipoEquipaje, Equipaje> equipaje)
            :base(nombre,apellido)
        {
            //nombre (base)
            //apellido (base)
            this.dni = dni;
            this.edad = edad;
            this.equipaje = equipaje;
        }

        #region PROPIEDADES
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
        public Dictionary<ETipoEquipaje, Equipaje> Equipaje
        {
            get { return equipaje; }
            set { equipaje = value; }
        }
        #endregion

        #region METODOS

        /// <summary>
        /// Esta funcion valida si la cadena dada como parametro es valida como DNI.
        ///  Un DNI valido tiene:
        ///  Minimo 7 caracteres, Solo caracteres numericos.
        /// </summary>
        /// <param name="dni">
        /// Cadena que se quiera verificar
        /// </param>
        /// <returns> Retorna TRUE si la cadena es valida, caso contrario retorna FALSE</returns>
        public static bool ValidarDNI(string dni)
        {
            bool res = true;
            int caracteres = 0;
            foreach (char c in dni)
            {
                if (!char.IsDigit(c)) //En caso de no ser un numero break y false.
                {
                    res = false;
                    break;
                }
                caracteres++; //Sumo cada caracter.
            }
            //Si solo son digitos, y si caracteres es igual o mayor a 7.
            return  res && caracteres >= 7;
        }

        /// <summary>
        /// Esta funcion valida si la cadena otorgada por parametro contiene solo caracteres
        /// alfabeticos.
        /// </summary>
        /// <param name="cadena">
        /// Cadena que se quiera validar.
        /// </param>
        /// <param name="permiteEspacios">
        /// Si se permiten o no espacios en la cadena.
        /// </param>>
        /// <returns>
        /// Retorna VERDADERO si la cadena es valida, caso contrario retorna FALSE.
        /// </returns>
        public static bool ValidarSoloCaracteres(string cadena, bool permiteEspacios)
        {
            bool ret = true;

            foreach (char c in cadena)
            {
                if (!char.IsLetter(c))
                {
                    if (permiteEspacios && char.IsWhiteSpace(c))
                    {
                        continue;
                    }
                    ret = false;
                    break;
                }
            }
            return ret;
        }

        /// <summary>
        /// Busca uno o varios pasajeros en la lista que coincidan con al menos uno de los parametros.
        /// </summary>
        /// <param name="lista">Lista donde se realizara la busqueda</param>>
        /// <param name="dni">DNI del pasajero que se desee encontrar</param>
        /// <param name="nombre">Nombre del pasajero que se desea buscar</param>
        /// <param name="apellido">Apellido del pasajero que se desea buscar</param>
        /// <returns>Retorna una lista con los pasajeros que coincidan.</returns>
        public static List<Pasajero> BuscarPasajero(List<Pasajero> lista, long dni, string nombre, string apellido)
        {
            List<Pasajero> resultados = new List<Pasajero>();
            foreach (Pasajero p in lista)
            {
                if ((dni == 0 || p.DNI == dni) &&
                    (nombre == string.Empty || p.nombre == nombre) &&
                    apellido == string.Empty || p.apellido == apellido)
                {
                    resultados.Add(p);
                }
            }
            return resultados;
        }


        public override string ObtenerDatos()
        {
            throw new NotImplementedException();
        }
        
        #endregion
        
        #region SOBRECARGA DE OPERADORES
        public static bool operator ==(Pasajero p1, Pasajero p2)
        {
            bool ret = false;
            
            if (p1.dni == p2.dni)
            {
                ret = true;
            }
            return ret;
        }
        public static bool operator !=(Pasajero p1, Pasajero p2)
        {
            bool ret = false;
            if (!(p1 == p2))
            { ret = true; }
            return ret;
        }
        #endregion
        
        public override bool Equals(object? obj)
        {
            Pasajero pasajero = (Pasajero)obj;
            return pasajero is not null && this == pasajero;
        }
        public override int GetHashCode() //ojo
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            string cadena;
            sb.Append("Nombre: "+this.nombre);
            sb.AppendLine("Apellido: "+this.apellido);
            sb.AppendLine("DNI: "+this.DNI);
            if (this.equipaje.ContainsKey(ETipoEquipaje.Mano))//prueba
            {
                sb.AppendLine(this.equipaje[ETipoEquipaje.Mano].ToString());
            }
            cadena = sb.ToString();
            return cadena;
        }

    }
}
