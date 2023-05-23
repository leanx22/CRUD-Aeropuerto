using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BibliotecaEntidades
{
    public static class Archivos
    {
        #region USUARIOS

        /// <summary>
        /// Deserealiza el jSon de usuarios en la lista que se le pase por parametro y la inicializa.
        /// </summary>
        /// <param name="filename">Nombre del archivo a deserealizar.</param>
        /// <param name="lista">Salida de la lista deserealizada.</param>
        /// <returns>Retorna true o false dependiendo del exito de la operacion.</returns>
        public static bool DeserealizarUsuarios(string filename, out List<Usuario> lista)
        {
            JsonSerializerOptions jSonOptions = new JsonSerializerOptions();
            lista = new List<Usuario>();
            string jsonText;
            bool ret = false;

            if (File.Exists(filename))
            {
                try
                {
                    using (StreamReader reader = new StreamReader(filename))
                    {
                        jsonText = reader.ReadToEnd();

                        //Nueva opcion para que pueda deserealizar los strings como enum.
                        jSonOptions.Converters.Add(new JsonStringEnumConverter());
                        lista = (List<Usuario>)JsonSerializer.Deserialize(jsonText, typeof(List<Usuario>), jSonOptions);
                        ret = true;
                    }
                }
                catch
                {
                    ret = false;
                }
            }
            return ret;
        }

        #endregion

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
            bool ret = false;
            string jSon;
            jSon = JsonSerializer.Serialize(lista);
            using (StreamWriter sw = new StreamWriter("PASAJEROS.json"))
            {
                sw.WriteLine(jSon);            
                ret = true;
            }
            return ret;
        }

        #endregion

        #region AERONAVES
        /// <summary>
        /// Deserealiza el archivo donde se guarda la lista de aeronaves.
        /// </summary>
        /// <returns>Retorna la lista de aeronaves deserealizada</returns>
        public static List<Aeronave> CargarAeronaves()
        {
            string filename = "AERONAVES.json";
            string jsonText;
            List<Aeronave> nuevaLista = new List<Aeronave>();

            if (File.Exists(filename))
            {
                try
                {
                    using (StreamReader reader = new StreamReader(filename))
                    {
                        jsonText = reader.ReadToEnd();
                        nuevaLista = (List<Aeronave>)JsonSerializer.Deserialize(jsonText, typeof(List<Aeronave>));
                    }
                }
                catch
                {
                    nuevaLista = new List<Aeronave>();
                }
            }
            return nuevaLista;
        }

        /// <summary>
        /// Serializa la lista de aeronaves en formato jSon.
        /// </summary>
        /// <param name="lista">Lista de aeronaves que se quiera guardar</param>
        /// <returns></returns>
        public static bool GuardarAeronaves(List<Aeronave> lista)
        {
            bool ret = false;
            string jSon;
            jSon = JsonSerializer.Serialize(lista);
            using (StreamWriter sw = new StreamWriter("AERONAVES.json"))
            {
                sw.WriteLine(jSon);
                ret = true;
            }
            return ret;
        }

        #endregion

        #region VIAJES

        /// <summary>
        /// Deserealiza el archivo donde se guarda la lista de viajes.
        /// </summary>
        /// <returns>Retorna la lista de viajes deserealizada</returns>
        public static List<Viaje> CargarViajes()
        {
            string filename = "VIAJES.json";
            string jsonText;
            List<Viaje> nuevaLista = new List<Viaje>();

            if (File.Exists(filename))
            {
                try
                {
                    using (StreamReader reader = new StreamReader(filename))
                    {
                        jsonText = reader.ReadToEnd();
                        nuevaLista = (List<Viaje>)JsonSerializer.Deserialize(jsonText, typeof(List<Viaje>));
                    }
                }
                catch
                {
                    nuevaLista = new List<Viaje>();
                }
            }
            return nuevaLista;
        }

        /// <summary>
        /// Serializa la lista de viajes en formato jSon.
        /// </summary>
        /// <param name="lista">Lista de viajes que se quiera guardar</param>
        /// <returns></returns>
        public static bool GuardarViajes(List<Viaje> lista)
        {
            bool ret = false;
            string jSon;
            jSon = JsonSerializer.Serialize(lista);
            using (StreamWriter sw = new StreamWriter("VIAJES.json"))
            {
                sw.WriteLine(jSon);
                ret = true;
            }
            return ret;
        }

        #endregion
    }
}
