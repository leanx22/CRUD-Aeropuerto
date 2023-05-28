using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaEntidades
{
    public class Equipaje
    {
        private int cantidad;
        private float peso;

        public int Cantidad { get { return this.cantidad; } set { this.cantidad = value; } }
        public float Peso { get { return this.peso;} set { this.peso = value;} }

        public Equipaje()
        {
            cantidad = 0;
            peso = 0;
        }

        public Equipaje(int cantidad, float peso)
        {
            this.cantidad = cantidad;
            this.peso = peso;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(">Cantidad: "+this.cantidad);
            sb.AppendLine(">Peso: "+this.peso);
            return sb.ToString();
        }

    }
}
