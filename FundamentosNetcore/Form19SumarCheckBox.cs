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
    public partial class Form19SumarCheckBox : Form
    {
        List<CheckBox> checkboxes;
        int suma;
        public Form19SumarCheckBox()
        {
            InitializeComponent();
            this.checkboxes = new List<CheckBox>();
            this.suma = 0;
            foreach (CheckBox check in this.panel1.Controls)
            {
                check.Click += sumarBoton;
                this.checkboxes.Add(check);
            }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            foreach(CheckBox check in this.checkboxes)
            {
                check.Text = random.Next(1, 100).ToString();
            }
        }

        void sumarBoton(object sender, EventArgs e)
        {
            CheckBox obj = (CheckBox)sender;
            if (obj.Checked)
            {
                suma += int.Parse(((CheckBox)sender).Text);
                this.txtSuma.Text = this.suma.ToString();
            }
            else
            {
                suma -= int.Parse(((CheckBox)sender).Text);
                this.txtSuma.Text = this.suma.ToString();
            }
            
        }
    }
}
