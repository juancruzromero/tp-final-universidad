using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace CapaEntidades
{
    [DataContract]
    public class Jugador
    {
        //Atributos
        private int _id; //Es el ID de jugador n+1
        private int _idUsuario; //Es el Registro del Usuario
        private string _apellido, _nombre;
        //fuerza y angulo tiene que tener validaciones
        private double _fuerza, _angulo;

        //Todos por default
        [DataMember]
        public int Id { get { return _id; } set { _id = value; } }
        [DataMember]
        public int IdUsuario { get { return _idUsuario; } set { _idUsuario = value; } }
        [DataMember]
        public string Apellido { get { return _apellido; } set { _apellido = value; } }
        [DataMember]
        public string Nombre {get { return _nombre; } set { _nombre = value; } }
        [DataMember]
        public double Fuerza { get { return _fuerza; }set { _fuerza = value; } }
        [DataMember]
        public double Angulo { get { return _angulo; } set { _angulo = value; } }
        [DataMember]
        public Usuario Usuario { get; set; }

        //----------------------------------Constructor------------------------------
        public Jugador( int idusuairo,string nombre, string apellido,double fuerza, double angulo)
        {
            this.IdUsuario = idusuairo;
            this.Nombre = nombre;
            Apellido = apellido;
            Fuerza = fuerza;
            Angulo = angulo;
        }
        public Jugador()
        {
            this.Usuario = new Usuario();
        }

    }
}
