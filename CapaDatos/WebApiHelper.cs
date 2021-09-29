using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Configuration;
using System.Collections.Specialized;
using System.Threading.Tasks;

namespace CapaDatos
{
    public static class WebApiHelper
    {
        static WebClient client;
        static string rutaBase;

        static WebApiHelper()
        {
            client = new WebClient();
            client.Encoding = Encoding.UTF8;
            rutaBase = ConfigurationManager.AppSettings["URL_API"]; // referencia agregada
        }

        public static string Get(string url)
        {
            var uri = rutaBase + url;
            var responseString = client.DownloadString(uri);
            return responseString;
        }

        public static string Post(string url, NameValueCollection parametros)
        {
            string uri = rutaBase + url;

            var response = client.UploadValues(uri, parametros);

            var responseString = Encoding.Default.GetString(response);

            return responseString;
        }
    }
}
