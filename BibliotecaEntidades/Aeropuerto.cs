using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaEntidades
{
    public class Aeropuerto
    {
        private List<Pasajero> listaPasajeros;
        private List<Viaje> listaViajes;
        private List<Aeronave> listaAeronaves;

        public Aeropuerto()
        {
            listaAeronaves = new List<Aeronave>();
            listaViajes = new List<Viaje>();
            listaPasajeros = new List<Pasajero>();
        }

        #region PROPIEDADES
        public List<Pasajero> Pasajeros { get { return listaPasajeros; } }

        #endregion

        #region METODOS

        public List<Pasajero> BuscarPasajero(long dni, string nombre, string apellido)
        {
            List<Pasajero> resultados = new List<Pasajero>();
            foreach (Pasajero p in this.listaPasajeros)
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

        public bool BuscarPasajero(long dni, out Pasajero resultado)
        {
            resultado = new Pasajero();
            bool ret = false;

            foreach (Pasajero p in this.listaPasajeros)
            {
                if (p.DNI == dni)
                {
                    ret = true;
                    resultado = p;
                    break;
                }
            }
            return ret;
        }

        #endregion

        #region SOBRECARGA_OPERADORES
        public static Aeropuerto operator +(Aeropuerto aeropuerto,Pasajero pasajero)
        {
            aeropuerto.listaPasajeros.Add(pasajero);
            return aeropuerto;
        }

        public static Aeropuerto operator -(Aeropuerto aeropuerto, Pasajero pasajero)
        {
            aeropuerto.listaPasajeros.Remove(pasajero);
            return aeropuerto;
        }

        public static bool operator ==(Aeropuerto aeropuerto, Pasajero pasajero)
        {
            return aeropuerto.listaPasajeros.Contains(pasajero);
        }

        public static bool operator !=(Aeropuerto aeropuerto, Pasajero pasajero)
        {
            return !(aeropuerto == pasajero);
        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        #endregion
    }
}
