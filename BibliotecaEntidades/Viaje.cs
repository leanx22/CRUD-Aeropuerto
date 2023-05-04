using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaEntidades
{
    public class Viaje
    {
        private bool esInternacional;
        private string partida;
        private string destino;
        //private EInternacional destinoInternacional;
       //private ENacional detinoNacional;
        private string fechaDeVuelo;
        private Aeronave avionAsignado;
        private int asientosPremium;
        private int asientosTurista;
        private float costoPremium;
        private float costoTurista;
        private float duracion;
        private List<Pasajero> listaPasajeros;

        public Viaje()
        {
            this.esInternacional = false;
            this.partida = "No especificada";
            this.destino = ENacional.NA.ToString(); //utilizar .ToString() en el enum al asignar.
            //destinoInternacional = EInternacional.NA;
            //detinoNacional = ENacional.NA;
            this.fechaDeVuelo = DateTime.Now.ToString();
            this.avionAsignado = new Aeronave();
            this.asientosPremium = 0;
            this.asientosTurista = 0;
            this.costoPremium = 0;
            this.costoTurista = 0;
            this.duracion = 0;
            this.listaPasajeros = new List<Pasajero>();
        }

        public Viaje(bool esInternacional, string partida, string destino, string fechaDeVuelo,
            Aeronave avionAsignado, int asientosPremium, int asientosTurista, float costoPremium,
            float costoTurista, float duracion,List<Pasajero> listaPasajeros)
        {
            this.esInternacional = esInternacional;
            this.partida = partida;
            this.destino = destino;
            //destinoInternacional = EInternacional.NA;
            //detinoNacional = ENacional.NA;
            this.fechaDeVuelo = fechaDeVuelo;
            this.avionAsignado = avionAsignado;
            this.asientosPremium = asientosPremium;
            this.asientosTurista = asientosTurista;
            this.costoPremium = costoPremium;
            this.costoTurista = costoTurista;
            this.duracion = duracion;
            this.listaPasajeros = listaPasajeros;
        }

        #region PROPIEDADES
        public bool EsInternacional { get { return esInternacional; }set { esInternacional = value; } }
        public string Partida { get { return partida; } set { partida = value; } }
        public string Destino { get {  return destino; } set {  destino = value; } }
        public string FechaDeVuelo { get {  return fechaDeVuelo; } set {  fechaDeVuelo = value; } }
        public Aeronave AvionAsignado { get { return avionAsignado; } set { avionAsignado = value; } }
        public int AsientosPremium { get { return asientosPremium; } set { asientosPremium = value; } }
        public int AsientosTurista { get {  return asientosTurista; } set { asientosTurista= value; } }
        public float CostoPremium { get { return costoPremium; } set { costoPremium = value; } }
        public float CostoTurista { get { return costoTurista; } set { costoTurista = value; } }
        public float Duracion { get { return duracion; }set { duracion = value; } }
        public List<Pasajero> ListaPasajeros { get { return listaPasajeros; } set { listaPasajeros = value; } }
        #endregion
    }
}
