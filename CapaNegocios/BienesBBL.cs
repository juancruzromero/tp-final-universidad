using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidades;

namespace CapaNegocios
{
    public class BienesBBL
    {
        BienesMapper bienesMapper = new BienesMapper();

        public string AltaBien(Bien bien)
        {
            string resultado = bienesMapper.AgregarBien(bien);

            return resultado;
        }


        public string Baja(string idBien, string idJugador, string idUsuario)
        {
            string resultado = bienesMapper.BorrarBien(idBien, idJugador, idUsuario);

            return resultado;
        }

        public List<Bien> ListarBienesDeJugador(int idJugador)
        {
            List<Bien> resultado = bienesMapper.TraerTodosLosBienesDeUnJugador(idJugador);

            return resultado;
        }
    }
}
