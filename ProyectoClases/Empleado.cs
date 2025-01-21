using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    public class Empleado: Persona

    {
        protected int SalarioMinimo { get; set; }
        public Empleado()
        {
            Debug.WriteLine("Constructor empleado vacio");
            this.SalarioMinimo = 1400;
        }

        public int GetSalario()
        {
            return this.SalarioMinimo;
        }

        public int GetDiasVacaciones()
        {
            Debug.WriteLine("Dias de vacaciones empleado");
            return 22;
        }
        public Empleado(string nombre, string apellido):base(nombre,apellido)
        {
            Debug.WriteLine("Constructor empleado con dos parametros");
            this.Nombre = nombre;
            this.Apellidos = apellido;
        }
    }
}
