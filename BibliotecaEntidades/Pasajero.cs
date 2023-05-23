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
        private Dictionary<ETipoEquipaje, Dictionary<int,int>> equipaje;
        

        public Pasajero() : base()
        {
            //nombre (base)
            //apellido (base)
            this.dni = 00112233;
            this.edad = 0;
            this.equipaje = new Dictionary<ETipoEquipaje, Dictionary<int,int>>();
        }

        public Pasajero(string nombre, string apellido, long dni,
            short edad, Dictionary<ETipoEquipaje,Dictionary<int, int>> equipaje)
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
        public Dictionary<ETipoEquipaje, Dictionary<int, int>> Equipaje
        {
            get { return equipaje; }
            set { equipaje = value; }
        }
        #endregion

        #region METODOS
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
        
    }
}
