using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaEntidades
{
    public class Viaje//(o vuelo)
    {
        private string partida;
        private string destino;
        private EEstadoDeVuelo estado;
        private bool esInternacional;                
        private DateTime fechaDeVuelo;
        private string avionAsignado;
        private int asientosPremium;
        private int asientosTurista;
        private float costoPremium;
        private float costoTurista;
        private float duracion;
        private List<Pasajero> listaPasajeros;        
        
        private static Random rand;

        static Viaje()
        {
            rand = new Random();
        }

        public Viaje()
        {
            this.esInternacional = false;
            this.partida = "No especificada";
            this.destino = ENacional.SantaRosa.ToString(); //utilizar .ToString() en el enum al asignar.
            this.fechaDeVuelo = DateTime.Today;
            this.avionAsignado = "AAAA0000";
            this.asientosPremium = 0;
            this.asientosTurista = 0;
            this.costoPremium = 0;
            this.costoTurista = 0;
            this.duracion = 0;
            this.listaPasajeros = new List<Pasajero>();
            this.estado = EEstadoDeVuelo.Pendiente;
        }

        public Viaje(bool esInternacional, string partida, string destino, DateTime fechaDeVuelo,
            string avionAsignado, int asientosPremium, int asientosTurista, float costoPremium,
            float costoTurista, float duracion,List<Pasajero> listaPasajeros,EEstadoDeVuelo estado)
        {
            this.esInternacional = esInternacional;
            this.partida = partida;
            this.destino = destino;
            this.fechaDeVuelo = fechaDeVuelo;
            this.avionAsignado = avionAsignado;
            this.asientosPremium = asientosPremium;
            this.asientosTurista = asientosTurista;
            this.costoPremium = costoPremium;
            this.costoTurista = costoTurista;
            this.duracion = duracion;
            this.listaPasajeros = listaPasajeros;
            this.estado = estado;
        }

        #region PROPIEDADES
        public bool EsInternacional { get { return esInternacional; }set { esInternacional = value; } }
        public string Partida { get { return partida; } set { partida = value; } }
        public string Destino { get {  return destino; } set {  destino = value; } }
        public DateTime FechaDeVuelo { get {  return fechaDeVuelo; } set {  fechaDeVuelo = value; } }
        public string AvionAsignado { get { return avionAsignado; } set { avionAsignado = value; } }
        public int AsientosPremium { get { return asientosPremium; } set { asientosPremium = value; } }
        public int AsientosTurista { get {  return asientosTurista; } set { asientosTurista= value; } }
        public float CostoPremium { get { return costoPremium; } set { costoPremium = value; } }
        public float CostoTurista { get { return costoTurista; } set { costoTurista = value; } }
        public float Duracion { get { return duracion; }set { duracion = value; } }
        public List<Pasajero> ListaPasajeros { get { return listaPasajeros; } set { listaPasajeros = value; } }
        public EEstadoDeVuelo Estado { get { return estado; } set{ estado = value; } }
        #endregion

        #region METODOS
        /// <summary>
        /// Esta funcion genera una duracion aleatoria para un viaje.
        /// Internacionales: 8hs a 12hs.
        /// Nacionales: 2hs a 4hs.
        /// </summary>
        /// <param name="esInternacional">
        /// Si el vuelo es internacional o no
        /// </param>
        /// <returns>Retorna un entero aleatorio que representa la duracion del viaje.</returns>
        public static int GenerarDuracion(bool esInternacional)
        {
            int horas;
            if (esInternacional)
            {
                horas=rand.Next(8, 13);//13 ya que no lo incluye.
            }
            else
            {
                horas=rand.Next(2, 5);//5 ya que no lo incluye.
            }
            return horas;
        }
        
        /// <summary>
        /// Esta funcion calcula la cantidad de asientos premium y turista 
        /// de una aeronave (20% de sus asientos)
        /// </summary>
        /// <param name="aeronave">
        /// Aeronave de la cual se quieran calcular sus asientos.
        /// </param>
        /// <param name="asientosPremium">
        /// Variable de salida de la cantidad de asientos premium.
        /// </param>
        /// <param name="asientosTurista">
        /// Variable de salida de la cantidad de asientos turista o regulares.
        /// </param>
        public static void ObtenerAsientos(Aeronave aeronave, out int asientosPremium,
            out int asientosTurista)
        {
            int premiums;
            int turistas;

            premiums = (int)(aeronave.Asientos * 0.2);
            turistas = aeronave.Asientos - premiums;
                
            asientosPremium = premiums;
            asientosTurista = turistas;
        }

        /// <summary>
        /// Esta funcion calcula los precios BASE del viaje, dependiendo si en o no internacional
        /// a la vez que toma en cuanta la duracion del vuelo.
        /// </summary>
        /// <param name="esInternacional">
        /// Si el vuelo es internacional.
        /// </param>
        /// <param name="horas">
        /// Horas de vuelo.
        /// </param>
        /// <param name="precioTurista">
        /// Variable de salida del precio Turista.
        /// </param>
        /// <param name="precioPremium">
        /// Variable de salida del precio premium.
        /// </param>
        public static void ObtenerPrecios(bool esInternacional, int horas, out float precioTurista, out float precioPremium)
        {
            float precioT;
            float precioP;

            if (esInternacional)
            {
                precioT = horas * 100;
                precioP = precioT + precioT * 0.35f;
            }
            else
            {
                precioT = horas * 50;
                precioP = precioT + precioT * 0.35f;
            }
            precioTurista = precioT;
            precioPremium = precioP;
        }
        #endregion

        #region SOBRECARGA DE OPs
        public static bool operator ==(Viaje v1, Viaje v2)
        {
            return (v1.destino == v2.destino)&&(v1.fechaDeVuelo.Date==v2.fechaDeVuelo.Date)&&
                (v1.avionAsignado==v2.avionAsignado);
        }
        public static bool operator !=(Viaje v1, Viaje v2)
        {
            return !(v1 == v2);
        }

        /// <summary>
        /// Sobrecarga que agrega al pasajero a la lista de pasajeros del viaje.
        /// </summary>
        /// <param name="v1">Viaje</param>
        /// <param name="p1">Pasajero que se quiere agregar</param>
        /// <returns>Retorna un nuevo viaje con el pasajero agregado en su lista.</returns>
        public static Viaje operator +(Viaje v1, Pasajero p1)
        {
            v1.ListaPasajeros.Add(p1);
            return v1;
        }

        public static Viaje operator -(Viaje v1, Pasajero p1)
        {
            v1.ListaPasajeros.Remove(p1);
            return v1;
        }

        public static bool operator ==(Viaje v1, Pasajero p1)
        {           
            return v1.ListaPasajeros.Contains(p1);
        }

        public static bool operator !=(Viaje v1, Pasajero p1)
        {
            return !v1.ListaPasajeros.Contains(p1);
        }
        #endregion

        public override bool Equals(object? obj)
        {
            Viaje viaje = (Viaje)obj;
            return viaje is not null && this == viaje;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }
}
