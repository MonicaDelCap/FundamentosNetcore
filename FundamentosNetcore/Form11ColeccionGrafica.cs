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
    public partial class Form11ColeccionGrafica : Form
    {
        public Form11ColeccionGrafica()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            this.lstElementos.Items.Add(this.txtNuevoElemento.Text);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Elimina pero el primer elemento que encuentra no el seleccionado
            //this.lstElementos.Items.Remove(this.lstElementos.SelectedItem);
            this.lstElementos.Items.RemoveAt(lstElementos.SelectedIndex);
        }

        private void btnBorrarTodo_Click(object sender, EventArgs e)
        {
            this.lstElementos.Items.Clear();
        }

        private void lstElementos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.lstElementos.SelectedIndex != -1)
            {
                this.lblIndexSeleccionado.Text = this.lstElementos.SelectedIndex.ToString();
                this.lblItemSeleccionado.Text = this.lstElementos.SelectedItem.ToString();
            }
        }
    }
}
