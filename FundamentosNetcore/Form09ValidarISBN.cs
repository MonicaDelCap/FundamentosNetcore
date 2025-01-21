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
    public partial class Form09ValidarISBN : Form
    {
        public Form09ValidarISBN()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            string isbn = txtISBN.Text.Trim();
            if(isbn.Length == 10)
                { 
                int suma = 0;
                int numeroActual = 0;
                int multiplicador = 1;
                for(int i = 0; i < isbn.Length; i++)
                {
                    numeroActual = int.Parse(isbn[i].ToString());
                    suma += numeroActual * multiplicador;
                    multiplicador++;
                }
                suma = suma % 11;

                if(suma == 0)
                {
                    lblResultado.Text = "El ISBN es correcto";
                }
                else
                {
                    lblResultado.Text = "El ISBN es incorrecto";

                }
            }
            else
            {
                lblResultado.Text = "Cantidad de digitos incorrecta";
            }
        }
    }
}
