using System;
using System.Collections;
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
    public partial class Form16ArrayList : Form
    {
        public Form16ArrayList()
        {
            InitializeComponent();
            ArrayList coleccion = new ArrayList();
            coleccion.Add(this.button1);
            coleccion.Add(this.button2);
            coleccion.Add(this.button3);
            coleccion.Add(this.textBox1);
            //Necesitamos casting 
            //((Button)coleccion[0]).BackColor = Color.Pink;

            //foreach(Button boton in coleccion)
            //{
            //    boton.BackColor = Color.AntiqueWhite;
            //}

            //Si tengo objetos de clases distintas debemos de abstraernos
            foreach(Control control in coleccion)
            {
                control.BackColor = Color.BlueViolet;
                
                //Textbox contiene un metodo Paste() , para diferenciarlo debemos de preguntar
                if(control is TextBox)
                {
                    ((TextBox)control).Paste();
                }
            }
        }
    }
}
