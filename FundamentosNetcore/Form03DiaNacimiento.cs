using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FundamentosNetcore
{
    public partial class Form03DiaNacimiento : Form
    {
        public Form03DiaNacimiento()
        {
            InitializeComponent();
        }

        private void btnCalcularDia_Click(object sender, EventArgs e)
        {
            string[] diasSemana = ["Sabado", "Domingo", "Lunes", "Martes","Miercoles","Jueves","Viernes"];
            int dia = int.Parse(txtDia.Text);
            int mes = int.Parse(txtMes.Text);
            int anio = int.Parse(txtAnio.Text);
            if(mes == 1)
            {
                mes = 13;
                anio--;
            }
            if(mes == 2)
            {
                mes = 14;
                anio--;
            }
            int calc1 = ((mes + 1) * 3) / 5;
            int calc2 = anio / 4;
            int calc3 = anio / 100;
            int calc4 = anio / 400;
            int calc5 = dia + (mes * 2) + anio + calc1 + calc2 - calc3 + calc4 + 2;
            int calc6 = calc5 / 7;
            int calc7 = calc5 - (calc6 * 7);
            lblDiaSemana.Text = diasSemana[calc7];
        }
    }
}
