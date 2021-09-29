using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace CapaEntidades
{
    [DataContract]
    public class Bien
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public TipoBienesEnum idTipo { get; set; }
        [DataMember]
        public int idJugador { get; set; }
        [DataMember]
        public string nombre { get; set; }
        [DataMember]
        public decimal precio { get; set; }
        [DataMember]
        public string fecha { get; set; }

        public Bien(TipoBienesEnum idTipo, int idJugador, string nombre, decimal precio, string fecha)
        {
            this.idTipo = idTipo;
            this.idJugador = idJugador;
            this.nombre = nombre;
            this.precio = precio;
            this.fecha = fecha;
        }
    }
    public enum TipoBienesEnum
    {
        Electro = 1, VideoJuegos, Autos, Comida
    }
}
