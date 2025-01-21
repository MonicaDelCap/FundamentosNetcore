using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ProyectoClases.Helpers;

namespace FundamentosNetcore
{
    public partial class Form21Files : Form
    {
        private string Path { get; set; }
        private HelperFilers helper;

        public Form21Files()
        {
            InitializeComponent();
            this.helper = new HelperFilers();
            //UTILIZAMOS DOBLE CONTRABARRA COMO ESCAPE 
            this.Path = "C:\\carpeta\\file.txt";
            //2) INDICAR QUE EL STRING ES LITERAL CON @
            this.Path = @"C:\carpeta\file.txt";
            this.Path = "file1.txt";
        }

        private void btnNuevoNombre_Click(object sender, EventArgs e)
        {
            this.lstNombres.Items.Add(this.txtNombre.Text);
            this.txtNombre.SelectAll();
            this.txtNombre.Focus();
        }

        public string GetNombreListBox()
        {
            string data = "";
            foreach (string name in this.lstNombres.Items)
            {
                data += name + ",";
            }
            data = data.Trim(',');
            return data;
        }

        private async void btnWrite_Click(object sender, EventArgs e)
        {
            string data = this.GetNombreListBox();
            await HelperFilers.WriteFileAsync(this.Path,data);
            MessageBox.Show("Datos guardados");
        }

        private async void btnRead_Click(object sender, EventArgs e)
        {
            string data = await HelperFilers.ReadFileAsync(this.Path);
            this.RellenarListBox(data);
            this.txtContenido.Text = data;
        }

        public void RellenarListBox(string nombre)
        {
            string[] data = nombre.Split(",");
            this.lstNombres.Items.Clear();
            foreach(string name in data)
            {
                this.lstNombres.Items.Add(name);
            }
        }
    }
}
