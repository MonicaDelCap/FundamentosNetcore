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
    public partial class Form17ListDelegados : Form
    {
        //Declaramos un contador
        int contador;
        List<Button> botones;
        public Form17ListDelegados()
        {
            InitializeComponent();
            this.contador = 0;
            this.botones = new List<Button>();
            //this.button1.Click += BotonPulsado;
            //this.button2.Click += BotonPulsado;
           
            //Con la coleccion controls podemos rellenar dinamicamente la coleccion
            foreach(Control miControl in this.Controls)
            {
                if(miControl is Button)
                {
                    this.botones.Add((Button)miControl);
                }
            }


            foreach (Button boton in this.botones)
            {
                boton.Click += BotonPulsado;
            }
        }

        void BotonPulsado(object sender,EventArgs e)
        {
            this.contador += 1;
            this.textBox1.Text = this.contador.ToString();
            //sender es el objeto que realiza la llamada y es un button
            Button miboton = (Button)sender;
            miboton.BackColor = Color.Aqua;
        }
    }
}
