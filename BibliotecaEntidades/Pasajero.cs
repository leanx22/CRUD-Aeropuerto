using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaEntidades
{
    public class Pasajero
    {
        private string apellido;
        private string nombre;
        private long dni;
        private short edad;
        private Dictionary<string, int> equipaje;

        public Pasajero()
        {
            apellido = "Sin apellido";
            nombre = "Sin nombre";
            dni = 00112233;
            edad = 0;
            equipaje = new Dictionary<string, int>();
        }

        //Hacer las propiedades.
    }
}
