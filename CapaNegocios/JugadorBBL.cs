using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidades;

namespace CapaNegocios
{
    public class JugadorBBL
    {
        private JugadorMapper jMapper = new JugadorMapper();
        private UsuarioMapper uMapper = new UsuarioMapper();


        //La que usa la que actualiza tabla
        
        public List<Jugador> TraerlistaJugadores(int idusuario)
        {
            List<Jugador> listj = jMapper.GetJugadores(idusuario);
            return listj;
        }
        
        //Agregación INICIO
    public List<Jugador> TraerJugadores(int registro)
    {
        List<Jugador> lista = jMapper.GetJugadores(registro);
        foreach (Jugador j in lista)
        {
            this.AsignarUsuario(j);
        }
        return lista;
    }

    private void AsignarUsuario(Jugador jugador)
    {
        jugador.Usuario = uMapper.TraerUsuarioPorCodigo(jugador.IdUsuario);
    }
        //Agregacion FIN      

        public Jugador GetJugador(int id,int registro)
        {
            Jugador obj = jMapper.TraerJugador(id,registro);
            return obj;
        }

        public List<Jugador> AddList(Jugador jugador)
        {
            List<Jugador> lst = new List<Jugador>();
            lst.Add(jugador);
            return lst;
        }

        public string PostJugador(Jugador jugador)
        {
            string obj = jMapper.EnviarJugador(jugador);
            return obj;
        }

        //Objeto DarAlta Jugador
        public string AltaJugador(Jugador altaJugador)
        {
            string obj = jMapper.EnviarJugador(altaJugador);

            return obj;

        }
        //Objeto DarBaja Jugador
        public string BajaJugador(string idJugador, string registro)
        {
            string obj = jMapper.Delete(idJugador, registro);

            return obj;
        }

    }
}
