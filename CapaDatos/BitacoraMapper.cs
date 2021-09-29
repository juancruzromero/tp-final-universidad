﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;
using CapaEntidades;

namespace CapaDatos
{
    public class BitacoraMapper
    {
        public string EnviarLog(Bitacora bitacora)
        {
            NameValueCollection parametros = MappearADiccionario(bitacora);

            string result = WebApiHelper.Post("/Bitacora", parametros);

            return result;
        }

        private NameValueCollection MappearADiccionario(Bitacora bitacora)
        {
            NameValueCollection valores = new NameValueCollection();
            valores["id"] = bitacora.codigoUsuario.ToString();
            valores["descripcion"] = bitacora.descripcion;
            valores["criticidad"] = bitacora.tipoConsulta.ToString();
            return valores;
        }

    }
}
