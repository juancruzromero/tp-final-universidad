using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using System.Collections.Specialized;
using System.Runtime.Serialization.Json;
using System.IO;


namespace CapaDatos
{
    public class JugadorMapper
    {
        // trae todos los jugadores que tiene un usuario
        // En mi caso URIhttp://uba-cai.azurewebsites.net/api/Jugador/886586
        public List<Jugador> GetJugadores(int codigo)
        {
            string json2 = WebApiHelper.Get("Jugador/" + codigo.ToString()); // trae un texto en formato json de una web
            List<Jugador> resultado = MapObj(json2);
            return resultado;
        }

        // trae solo un jugador, que coincide con el id.El nro de registro es para validar que el usuario que enviías es el dueño de ese jugador
        public Jugador TraerJugador(int id, int registro)
        {
            List<Jugador> jugadores = GetJugadores(registro);
            Jugador resultado = null;
            foreach (Jugador obj in jugadores)
            {
                if (obj.IdUsuario == registro)
                {
                    resultado = obj;
                }
            }

            return resultado;
        }

        public string EnviarJugador(Jugador jugador)
        {
            NameValueCollection parametros = MappearADiccionario(jugador);

            string result = WebApiHelper.Post("/Jugador", parametros);

            return result;
        }


        public string Delete(string idJugador, string registro)
        {
            // trae un texto en formato json de una web
            string resultado = WebApiHelper.Get("Jugador/Delete?codigo=" + idJugador.ToString() + "&registro=" + registro);
            return resultado;
        }


        private List<Jugador> MapObj(string json)
        {
            MemoryStream stream1 = new MemoryStream(Encoding.UTF8.GetBytes(json));
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(List<Jugador>));
            List<Jugador> lst = (List<Jugador>)ser.ReadObject(stream1);
            return lst;
        }

        private NameValueCollection MappearADiccionario(Jugador bitacora)
        {
            NameValueCollection valores = new NameValueCollection();
            valores["Id"] = bitacora.Id.ToString();
            valores["IdUsuario"] = bitacora.IdUsuario.ToString();
            valores["Nombre"] = bitacora.Nombre.ToString();
            valores["Apellido"] = bitacora.Apellido.ToString();
            valores["Fuerza"] = bitacora.Fuerza.ToString();
            valores["Angulo"] = bitacora.Angulo.ToString();
            return valores;
        }
    }
}
