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
        //LISTA DE PASAJEROS!

        public Viaje()
        {
            esInternacional = false;
            partida = "No especificada";
            destino = ENacional.NA.ToString(); //utilizar .ToString() en el enum al asignar.
            //destinoInternacional = EInternacional.NA;
            //detinoNacional = ENacional.NA;
            fechaDeVuelo = DateTime.Now.ToString();
            avionAsignado = new Aeronave();
            asientosPremium = 0;
            asientosTurista = 0;
            costoPremium = 0;
            costoTurista = 0;
            duracion = 0;
        }

        //Hacer las propiedades
    }
}
