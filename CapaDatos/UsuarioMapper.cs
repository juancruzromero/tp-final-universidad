using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;
using CapaEntidades;
using System.IO;

namespace CapaDatos
{
    public class UsuarioMapper
    {
        //Completo URIhttp://uba-cai.azurewebsites.net/api/usuarios/886586
        public Usuario TraerUsuarioPorCodigo(int codigo)
        {
            string json2 = WebApiHelper.Get("usuarios/" + codigo.ToString()); // trae un texto en formato json de una web
            Usuario resultado = MapObj(json2);
            return resultado;
        }

        private Usuario MapObj(string json)
        {
            MemoryStream stream1 = new MemoryStream(Encoding.UTF8.GetBytes(json));
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(Usuario));
            Usuario lst = (Usuario)ser.ReadObject(stream1);
            return lst;
        }
    }
}
