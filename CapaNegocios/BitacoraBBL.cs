using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaDatos;

namespace CapaNegocios
{
    public class BitacoraBBL
    {
        private BitacoraMapper mapper = new BitacoraMapper();

        public string GetJugador(Bitacora bitacora)
        {
            string obj = mapper.EnviarLog(bitacora);
            return obj;
        }

        public Bitacora Post(int codUsuario, string descripcion, TipoConsultaEnum consulta)
        {
            Bitacora log = new Bitacora(codUsuario, descripcion, consulta);

            return log;

        }
    }
}
