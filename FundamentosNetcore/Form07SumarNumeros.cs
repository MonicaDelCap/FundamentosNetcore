﻿using System;
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
    public partial class Form07SumarNumeros : Form
    {
        public Form07SumarNumeros()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            string texto = this.txtNumero.Text;
            int suma = 0;
            int valorActual = 0;
            for(int i = 0; i < texto.Length; i ++)
            {
                char caracter = texto[i];
                //valorActual = caracter - '0' ;
                valorActual = Convert.ToInt32(caracter.ToString());
                //valorActual = int.Parse(caracter.ToString());
                suma += valorActual;
                this.lblResultado.Text = suma.ToString();
            }
        }
    }
}
