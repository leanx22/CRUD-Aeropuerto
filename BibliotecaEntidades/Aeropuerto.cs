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


        #region SOBRECARGA_OPERADORES
        public static bool operator +(Aeropuerto aeropuerto,Pasajero pasajero)
        {
            bool ret = false;
            if (!aeropuerto.listaPasajeros.Contains(pasajero))
            {
                aeropuerto.listaPasajeros.Add(pasajero);
                ret = true;
            }
            return ret;
        }
        public static bool operator +(Aeropuerto aeropuerto, Viaje viaje)
        {
            return true;
        }

        public static bool operator -(Aeropuerto aeropuerto, Pasajero pasajero)
        {
            bool ret=false;
            if (aeropuerto.listaPasajeros.Contains(pasajero))
            {
                aeropuerto.listaPasajeros.Remove(pasajero);
                ret = true;
            }
            return ret;
        }

        #endregion
    }
}
