using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaDatos;

namespace CapaNegocios
{
    public class UsuarioBBL
    {
        private UsuarioMapper uMapper = new UsuarioMapper();
        private JugadorMapper jMapper = new JugadorMapper();

        //Ingreso registro
        public Usuario GetUsuario(int id)
        {
            Usuario obj = uMapper.TraerUsuarioPorCodigo(id);
            return obj;
        }


    }
}

