﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
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
            //Si los archivos no existen, retorna una new list();
            listaAeronaves = Archivos.CargarAeronaves();
            listaViajes = Archivos.CargarViajes();
            listaPasajeros = Archivos.CargarPasajeros();
        }

        #region PROPIEDADES
        public List<Pasajero> Pasajeros { get { return listaPasajeros; } }
        public List<Aeronave> Aeronaves { get { return listaAeronaves; } }
        public List<Viaje> Viajes { get { return listaViajes; } }
        #endregion

        #region METODOS

        
        /// <summary>
        /// Busca si algun pasajero en la lista coincide con el DNI. Deben ser iguales.
        /// El pasajero es retornado con OUT en caso de existir. NO USAR, LO VOY A MOVER
        /// </summary>
        /// <param name="dni">DNI del pasajero que se desee encontrar.</param>
        /// <param name="resultado">Parametro de salida donde se retornara un pasajero si se lo encuentra.</param>
        /// <returns>Retorna true o false, si encontro o no un pasajero coincidente.</returns>
        public bool BuscarPasajero(long dni, out Pasajero resultado) //ELIMINAR
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

        /// <summary>
        /// Busca si alguna aeronave en la lista coincide con la matricula. Deben ser iguales.
        /// La aeronave es retornada con OUT en caso de existir.
        /// </summary>
        /// <param name="matricula">Matricula de la aeronave que se desee encontrar.</param>
        /// <param name="resultado">Parametro de salida donde se retornara una aeronave si se la encuentra.</param>
        /// <returns>Retorna true o false, si encontro o no una aeronave coincidente.</returns>
        public bool BuscarAeronave(string matricula, out Aeronave resultado)
        {
            resultado = new Aeronave();
            bool ret = false;

            foreach (Aeronave a in this.listaAeronaves)
            {
                if (a.Matricula == matricula.ToUpper())
                {
                    ret = true;
                    resultado = a;
                    break;
                }
            }
            return ret;
        }

        /// <summary>
        /// Funcion que suma el IVA (21%) a un valor.
        /// </summary>
        /// <param name="valorInicial">
        /// Valor sin IVA a el cual se lo quiera calcular.
        /// </param>
        /// <returns>Retorna el valor ingresado + IVA(21%)</returns>
        public static float CalcularIVA(float valorInicial)
        {
            float resultado;

            resultado = valorInicial + (valorInicial*0.21f);

            return resultado;
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
        
        
        /// <summary>
        /// (Revisar uso de copy to u otro metodo)/Esta sobrecarga reemplaza la lista original por
        /// una nueva.
        /// </summary>
        /// <param name="aeropuerto">aeropuerto que contiene la lista original</param>
        /// <param name="listaPasajeros">nueva lista a guardar.</param>
        /// <returns></returns>
        public static Aeropuerto operator +(Aeropuerto aeropuerto, List<Pasajero> listaPasajeros)
        {
            //List<Pasajero> nuevaLista = new List<Pasajero>();
            //nuevaLista.AddRange(listaPasajeros);
            //aeropuerto.listaPasajeros = nuevaLista;
            aeropuerto.listaPasajeros = listaPasajeros;

            return aeropuerto;
        }

        public static Aeropuerto operator +(Aeropuerto aeropuerto, Aeronave aeronave)
        {
            aeropuerto.listaAeronaves.Add(aeronave);
            return aeropuerto;
        }
        public static Aeropuerto operator -(Aeropuerto aeropuerto, Aeronave aeronave)
        {
            aeropuerto.listaAeronaves.Remove(aeronave);
            return aeropuerto;
        }
        public static bool operator ==(Aeropuerto aeropuerto,Aeronave aeronave)
        {
            return aeropuerto.listaAeronaves.Contains(aeronave);
        }
        public static bool operator !=(Aeropuerto aeropuerto, Aeronave aeronave)
        {
            return !(aeropuerto == aeronave);
        }

        public static Aeropuerto operator +(Aeropuerto aeropuerto, Viaje viaje)
        {
            aeropuerto.listaViajes.Add(viaje);
            return aeropuerto;
        }
        public static Aeropuerto operator -(Aeropuerto aeropuerto, Viaje viaje)
        {
            aeropuerto.listaViajes.Remove(viaje);
            return aeropuerto;
        }
        public static bool operator ==(Aeropuerto aeropuerto, Viaje viaje)
        {
            return aeropuerto.listaViajes.Contains(viaje);
        }
        public static bool operator !=(Aeropuerto aeropuerto, Viaje viaje)
        {
            return !(aeropuerto == viaje);
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
