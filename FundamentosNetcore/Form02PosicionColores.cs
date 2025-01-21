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
    public partial class Form02PosicionColores : Form
    {
        public Form02PosicionColores()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.btnPosicion.Location = new Point(int.Parse(this.txtPosX.Text), int.Parse(this.txtPosY.Text));
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            int numero1 = int.Parse(this.txtRojo.Text);
            int numero2 = int.Parse(this.txtVerde.Text);
            if (numero1 > 0 && numero1 < 256
                && numero2 > 0 && numero2 < 256)
            {
                this.BackColor = Color.FromArgb(numero1, numero2, int.Parse(this.txtAzul.Text));
            }
            else
            {
                MessageBox.Show("El valor no es correcto", "Titulo", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }
    }
}
