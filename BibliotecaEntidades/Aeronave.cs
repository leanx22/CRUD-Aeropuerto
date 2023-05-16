using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaEntidades
{
    public class Aeronave
    {
        private string matricula;
        private int asientos;
        private int banios;
        private bool internet;
        private bool comida;
        private int capacidadBodega;
        private bool disponible;
        

        public Aeronave()
        {
            this.matricula = "AAAA0000";
            this.asientos = 1;
            this.banios = 1;
            this.internet = false;
            this.comida = false;
            this.capacidadBodega = 0;
            this.disponible = true;
        }

        public Aeronave(string matricula, int asientos, int banios,
            bool internet, bool comida, int bodega,bool disponible)
        {
            this.matricula = matricula;
            this.asientos = asientos;
            this.banios = banios;
            this.internet = internet;
            this.comida = comida;
            this.capacidadBodega = bodega;
            this.disponible = disponible;
        }

        #region METODOS
        
        /// <summary>
        /// Esta funcion valida la cadena pasada por parametros, verificando que
        /// esta tenga 8 caracteres, ademas debe tener, por lo menos, un numero y una letra.
        /// </summary>
        /// <param name="matricula"> Cadena que se quiera validar. </param>
        /// <returns>Retorna true si la cadena es valida para usarse como matricula de una aeronave.</returns>
        public static bool ValidarMatricula(string matricula)
        {
            bool tieneLetras = false;
            bool tieneNumeros = false;
            int caracteres=0;
            foreach (char c in matricula)
            {
                if (!char.IsLetterOrDigit(c)) //En caso de no ser una letra o numero break y todo false.
                {
                    tieneLetras = false;
                    tieneNumeros = false;
                    break; 
                }

                caracteres++; //Sumo cada caracter.
                if (char.IsDigit(c)) //Si el caracter es un numero.
                {
                    tieneNumeros = true;
                }
                else if (char.IsLetter(c))//Si el caracter es una letra.
                {
                    tieneLetras = true;
                }
            }
            //Si tiene letras y numeros, y si caracteres es igual a 8.
            return (tieneLetras && tieneNumeros) && caracteres==8;
        }


        #endregion

        #region PROPIEDADES
        public string Matricula
        {
            get { return matricula; }
            set { matricula = value; } //validar. Alfanumerico 8chars.
        }
        public int Asientos
        {
            get { return asientos; }
            set { asientos = value; } //no puede ser negativo o 0.
        }
        public int Banios
        {
            get { return banios; }
            set { banios = value; }
        }
        public bool Internet
        {
            get { return internet; }
            set { internet = value; }
        }
        public bool Comida
        {
            get { return comida; }
            set { comida = value; }
        }
        public int bodega
        {
            get { return capacidadBodega; }
            set { capacidadBodega = value; } //no puede ser negativo o 0.
        }
        public bool Disponible { get { return this.disponible; } set { this.disponible = value; } }
        #endregion

        #region SOBRECARGA DE OPs
        public static bool operator ==(Aeronave a1, Aeronave a2)
        {
            return a1.matricula == a2.matricula;
        }
        public static bool operator !=(Aeronave a1, Aeronave a2)
        {
            return !(a1 == a2);
        }
        #endregion

        public override bool Equals(object? obj)
        {
            Aeronave aeronave = (Aeronave)obj;
            return aeronave is not null && this == aeronave;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
