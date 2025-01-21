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
    public partial class Form18SumarBotones : Form
    {
        List<Button> botones;
        int suma;
        public Form18SumarBotones()
        {
            InitializeComponent();
            this.botones = new List<Button>();
            this.suma = 0;
            //Almacenamos los botones del panel
            foreach(Button boton in this.panel1.Controls)
            {
                boton.Click += SumarNumeros;
                botones.Add(boton);
            }
        }

        private void btnIniciarApp_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            this.suma = 0;
            this.txtSuma.Text = suma.ToString();
            foreach(Button boton in this.botones)
            {
                int ale = random.Next(0, 30);
                boton.Text = ale.ToString();
            }
        }

        void SumarNumeros(object sender,EventArgs e)
        {
            suma += int.Parse(((Button)sender).Text);
            this.txtSuma.Text = suma.ToString();
        }
    }
}
