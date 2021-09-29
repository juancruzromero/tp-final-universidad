using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;
using System.IO;
using CapaEntidades;
using System.Collections.Specialized;

namespace CapaDatos
{
    public class BienesMapper
    {
        public string AgregarBien(Bien bien)
        {
            NameValueCollection parametros = MappearADiccionario(bien);
            string result = WebApiHelper.Post("/Bienes", parametros);
            return result;
        }

        public string BorrarBien(string idBien, string idJugador, string idUsuario)
        {
            string resultado = WebApiHelper.Get("Bienes/Delete?id=" + idBien + "&idJugador=" + idJugador + "&idUsuario=" + idUsuario);
            return resultado;
        }

        public List<Bien> TraerTodosLosBienesDeUnJugador(int codigoJugador)
        {
            string json = WebApiHelper.Get("Bienes/" + codigoJugador.ToString()); // trae un texto en formato json de una web
            List<Bien> resultado = MapObjetos(json);
            return resultado;
        }

        //Recibe
        private List<Bien> MapObjetos(string json)
        {
            MemoryStream stream1 = new MemoryStream(Encoding.UTF8.GetBytes(json));
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(List<Bien>));
            List<Bien> lst = (List<Bien>)ser.ReadObject(stream1);
            return lst;
        }

        //Envia
        private NameValueCollection MappearADiccionario(Bien bien)
        {
            NameValueCollection valores = new NameValueCollection();

            int idInt = Convert.ToInt32(bien.idTipo);
            valores["idTipo"] = (idInt).ToString();
            valores["idJugador"] = bien.idJugador.ToString();
            valores["nombre"] = bien.nombre;
            valores["precio"] = bien.precio.ToString();
            valores["fecha"] = bien.fecha.ToString();
            return valores;
        }
        
    }
    
}
