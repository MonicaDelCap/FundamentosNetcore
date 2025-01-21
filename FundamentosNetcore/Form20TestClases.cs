using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoClases;

namespace FundamentosNetcore
{
    public partial class Form20TestClases : Form
    {
        public Form20TestClases()
        {
            InitializeComponent();
        }

        private void btnPersona_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            persona.Nombre = "Monica";
            persona.Apellidos = "Delgado";
            persona.Edad = 21;
            persona.Genero = TipoGenero.Femenino;
            persona.Nacionalidad = Paises.España;
            persona.Domicilio = new Direccion();
            persona.Domicilio.Calle = "Tomillo";
            persona.Domicilio.Ciudad = "Madrid";
            persona.Domicilio.CodigoPostal = 28450;
            this.lstClases.Items.Add(persona.GetNombreCompleto(true));
            this.lstClases.Items.Add("Edad: " + persona.Edad);
            this.lstClases.Items.Add("Genero: " + persona.Genero + " Nacionalidad: " + persona.Nacionalidad);
            this.lstClases.Items.Add("Direccion: " + persona.Domicilio.Calle + ", " + persona.Domicilio.Ciudad + " " + persona.Domicilio.CodigoPostal);
        }

        private void btnempleado_Click(object sender, EventArgs e)
        {
            Empleado empleado = new Empleado();
            empleado.Nombre = "Monica";
            empleado.Apellidos = "Delgado";
            this.lstClases.Items.Add(empleado.GetNombreCompleto(0));
            this.lstClases.Items.Add("Salario empleado " + empleado.GetSalario());
            this.lstClases.Items.Add("Vacaciones empleado " + empleado.GetDiasVacaciones());




            Director director = new Director();
            director.Nombre = "Dire";
            director.Apellidos = "Director";
            this.lstClases.Items.Add(director.GetNombreCompleto(0));
            this.lstClases.Items.Add("Salario director " + director.GetSalario());
            this.lstClases.Items.Add("Vacaciones director " + director.GetDiasVacaciones());

        }
    }
}
