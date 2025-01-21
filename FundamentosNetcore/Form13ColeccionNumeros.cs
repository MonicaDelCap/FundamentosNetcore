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
    public partial class Form13ColeccionNumeros : Form
    {
        public Form13ColeccionNumeros()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            lstNumeros.Items.Clear();
            Random random = new Random();
            for (int i = 0; i < 11; i++)
            {
                int rnd = random.Next(1, 5);
                this.lstNumeros.Items.Add(rnd);
            }
        }

        private void lblDatos_Click(object sender, EventArgs e)
        {
            int suma = 0;
            int pares = 0;
            int impares = 0;
            //Suma
            foreach(int num in this.lstNumeros.Items)
            {
                suma += num;

                if(num % 2 == 0)
                {
                    pares += num;
                }
                else
                {
                    impares += num; 
                }
                
            }
            this.txtSuma.Text = suma.ToString();
            this.txtPares.Text = pares.ToString();
            this.txtImpares.Text = impares.ToString();
        }
    }
}
