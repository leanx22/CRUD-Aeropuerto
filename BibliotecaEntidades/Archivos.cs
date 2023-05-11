using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BibliotecaEntidades
{
    public static class Archivos
    {
        #region PASAJEROS
        
        /// <summary>
        /// Deserealiza el archivo donde se guarda la lista de pasajeros.
        /// </summary>
        /// <returns>Retorna la lista de pasajeros deserealizada</returns>
        public static List<Pasajero> CargarPasajeros()
        {
            string filename = "PASAJEROS.json";
            string jsonText;
            List<Pasajero> nuevaLista = new List<Pasajero>();
            
            if (File.Exists(filename))
            {
                try
                {
                    using (StreamReader reader = new StreamReader(filename))
                    {
                        jsonText = reader.ReadToEnd();
                        nuevaLista = (List<Pasajero>)JsonSerializer.Deserialize(jsonText, typeof(List<Pasajero>));
                    }
                }
                catch
                {
                    nuevaLista = new List<Pasajero>();
                }
            }
            return nuevaLista;
        }

        /// <summary>
        /// Serializa la lista de pasajeros en formato jSon.
        /// </summary>
        /// <param name="lista">Lista de pasajeros que se quiera guardar</param>
        /// <returns></returns>
        public static bool GuardarPasajeros(List<Pasajero> lista)
        {


            return false;
        }

        #endregion
    }
}
