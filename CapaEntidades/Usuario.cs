using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace CapaEntidades
{   
    [DataContract(Name ="User")]
    public class Usuario
    {  
        internal int _codigo;        
        internal string _nombre,_nombreusuario,_email,_password;
        [DataMember(Name = "id")]
        public int Codigo { get { return _codigo; } set { _codigo = value; } }
        [DataMember(Name = "name")]
        public string Nombre { get { return _nombre; }set { _nombre = value; } }
        [DataMember(Name = "username")]
        public string NombreUsuario { get { return _nombreusuario; } set { _nombreusuario = value; } }
        [DataMember(Name = "email")]
        public string Email { get { return _email; } set { _email = value; } }
        [DataMember(Name = "phone")]
        public string Password { get { return _password; } set { _password = value; } }


        //Agregación de la Propiedad Lista de Jugador
        public List<Jugador> Jugadores { get; set; }

        //Constructor
        public Usuario()
        {
            this.Jugadores = new List<Jugador>();
        }

        //Polimorfismo
        public override string ToString()
        {
            return "El usuario " + this.Nombre + " con legajo número " + this.Codigo +
                " tiene ingresado la siguiente cantidad de jugadores en su cartera: ";
        }

    }
}

