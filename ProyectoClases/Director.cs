using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    public class Director:Empleado
    {

        public Director()
        {
            Debug.WriteLine("Cosntructor director");
            SalarioMinimo += 200;
        }

        public new int GetDiasVacaciones()
        {
            Debug.WriteLine("Dias de vacaciones director");
            int vacacionesEmpleado = base.GetDiasVacaciones();
            return vacacionesEmpleado + 8;
        }
        public int GetDiasVacaciones(int extras)
        {
            Debug.WriteLine("Dias de vacaciones director");
            return this.GetDiasVacaciones() + extras;
        }
    }
}
