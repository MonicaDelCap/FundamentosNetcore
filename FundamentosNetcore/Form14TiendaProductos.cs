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
    public partial class Form14TiendaProductos : Form
    {
        public Form14TiendaProductos()
        {
            InitializeComponent();
            this.lstTienda.SelectionMode = SelectionMode.MultiExtended;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            string item = this.txtProducto.Text;
            if (this.lstTienda.Items.Contains(item))
            {
                this.lstTienda.ClearSelected();
                int index = this.lstTienda.Items.IndexOf(item);
                this.lstTienda.SetSelected(index, true);
            }
            else
            {
                lstTienda.Items.Add(item);
            }
        }

        private void btnBorrarTodo_Click(object sender, EventArgs e)
        {
            this.lstTienda.Items.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int length = this.lstTienda.SelectedIndices.Count;
            for (int i = length - 1; i >= 0; i--)
            {
                int index = this.lstTienda.SelectedIndices[i];
                this.lstTienda.Items.RemoveAt(index);
            }
        }

        private void btnSeleccion_Click(object sender, EventArgs e)
        {
            int length = this.lstTienda.SelectedIndices.Count;
            for (int i = length - 1; i >= 0; i--)
            {
                string item = this.lstTienda.SelectedItems[i].ToString();
                int index = this.lstTienda.SelectedIndices[i];
                this.lstAlmacen.Items.Add(item);
                this.lstTienda.Items.RemoveAt(index);
            }
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            this.lstAlmacen.Items.AddRange(this.lstTienda.Items);
            this.lstTienda.Items.Clear();
            //int length = this.lstTienda.Items.Count;
            //for(int i = length - 1; i >= 0; i--)
            //{
            //    this.lstAlmacen.Items.Add(this.lstTienda.Items[i]);
            //}
        }

        private void btnSubir_Click(object sender, EventArgs e)
        {
            int index = this.lstAlmacen.SelectedIndex;
            string producto = this.lstAlmacen.SelectedItem.ToString();
            this.lstAlmacen.Items.RemoveAt(index);
            this.lstAlmacen.Items.Insert(index - 1, producto);
            this.lstAlmacen.SelectedIndex = index - 1;
        }

        private void btnBajar_Click(object sender, EventArgs e)
        {
            int index = this.lstAlmacen.SelectedIndex;
            string producto = this.lstAlmacen.SelectedItem.ToString();
            this.lstAlmacen.Items.RemoveAt(index);
            this.lstAlmacen.Items.Insert(index + 1, producto);
            this.lstAlmacen.SelectedIndex = index + 1;
        }
    }
}
