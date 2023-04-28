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
        private float capacidadBodega;

        public Aeronave()
        {
            matricula = "AAAA0000";
            asientos = 1;
            banios = 1;
            internet = false;
            comida = false;
            capacidadBodega = 0;
        }

        public Aeronave(string matricula, int asientos, int banios,
            bool internet, bool comida, float bodega)
        {
            this.matricula = matricula;
            this.asientos = asientos;
            this.banios = banios;
            this.internet = internet;
            this.comida = comida;
            this.capacidadBodega = bodega;
        }


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
        public float bodega
        {
            get { return capacidadBodega; }
            set { capacidadBodega = value; } //no puede ser negativo o 0.
        }
        #endregion


    }
}
