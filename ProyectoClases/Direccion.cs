using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    public class Direccion
    {
        public string Calle { get; set; }
        public int CodigoPostal { get; set; }
        public string Ciudad {get; set;}


        public Direccion()
        {
            Debug.WriteLine("Constructor direccion sin parametros");
        }

        public Direccion(string calle, string ciudad)
        {
            this.Calle = calle;
            this.Ciudad = ciudad;
            Debug.WriteLine("Constructor Direccion con dos parametros");
        }

        public Direccion(string calle, string ciudad, int codigoPostal)
        {
            this.Calle = calle;
            this.Ciudad = ciudad;
            this.CodigoPostal = codigoPostal;
            Debug.WriteLine("Constructor Direccion con tres parametros");
        }
    }
}
