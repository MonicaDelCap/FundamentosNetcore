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
    public partial class Form10ValidarDNI : Form
    {
        public Form10ValidarDNI()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            string dni = txtDni.Text;
            string letra = dni[dni.Length - 1].ToString();
            int resto = int.Parse(dni.Substring(0,dni.Length - 1)) % 23;
            string[] letras = ["T","R", "W", "A", "G", "M", "Y", "F", "P", "D", "X", "B", "N", "J", "Z",
            "S","Q","V","H","L","C","K","E","T"];

            if (letra.Equals(letras[resto]))
            {
                lblResultado.Text = "Resultado correcto";
            }
            else
            {
                lblResultado.Text = "La letra correcta para este DNI es, " + letras[resto];
            }

        }
    }
}
