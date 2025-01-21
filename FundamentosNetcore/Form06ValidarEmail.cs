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
    public partial class Form06ValidarEmail : Form
    {
        public Form06ValidarEmail()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            string email = this.txtEmail.Text;
            int pos1 = email.IndexOf("@");
            int pos2 = email.IndexOf("@", pos1+1);
            int posPunto = email.IndexOf(".");
            string longitudDominio = email.Substring(posPunto + 1);
            if (!email.Contains("@"))
            {
                lblResultado.Text = "Debe de tener al menos un @";
            }
            else if (email.StartsWith("@") || email.EndsWith("@"))
            {
                lblResultado.Text = "No puede contener @ ni al principio ni al final";
            }
            else if( pos2 != -1)
            {
                lblResultado.Text = "No puede contener mas de 1 @ ";
            }
            else if (!email.Contains("."))
            {
                lblResultado.Text = "Debe contener minimo 1 .";

            }
            else if (email[pos1 + 1].ToString() == ".")
            {
                lblResultado.Text = "No puede contener . despues de un @ ";
            }
            else if(longitudDominio.Length < 2 || longitudDominio.Length > 4)
            {
                lblResultado.Text = "El dominio no es correcto";

            }
            else
            {
                lblResultado.Text = "Es correcto el formato";

            }

        }
    }
}
