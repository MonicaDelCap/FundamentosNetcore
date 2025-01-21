using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FundamentosNetcore
{
    public partial class Form08StringBuilder : Form
    {
        public Form08StringBuilder()
        {
            InitializeComponent();
        }

        private void btnInvertir_Click(object sender, EventArgs e)
        {
            Stopwatch krono = new Stopwatch();
            string cadena = this.txtTexto.Text;
            int logitud = cadena.Length;
            krono.Start();
            for (int i = 0; i < logitud; i++)
            {
                char caracter = cadena[logitud - 1];
                cadena = cadena.Remove(logitud - 1, 1);
                cadena = cadena.Insert(i, caracter.ToString());
            }
            krono.Stop();
            lblTiempo.Text = krono.Elapsed.Seconds / 100 + " " + krono.Elapsed.Milliseconds;
            txtTexto.Text = cadena;
        }

        private void btnInvertirStringBuilder_Click(object sender, EventArgs e)
        {
            Stopwatch krono = new Stopwatch();
            StringBuilder stringCadena = new StringBuilder();
            stringCadena.Append(this.txtTexto.Text);
            int longitud = stringCadena.Length;
            krono.Start();
            for (int i = 0; i < longitud; i++)
            {
                char caracter = stringCadena[longitud - 1];
                stringCadena = stringCadena.Remove(longitud - 1, 1);
                stringCadena = stringCadena.Insert(i, caracter);
            }
            krono.Stop();
            lblTiempo.Text = krono.Elapsed.Seconds / 100 + " " + krono.Elapsed.Milliseconds;
            txtTexto.Text = stringCadena.ToString();
        }
    }
}
