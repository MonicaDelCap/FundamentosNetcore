using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoClases.Models;
using System.Text.Json;

namespace FundamentosNetcore
{
    public partial class Form25ColeccionMascotasJSON : Form
    {
        ColeccionMascotas mascotasList;
        public Form25ColeccionMascotasJSON()
        {
            InitializeComponent();
            mascotasList = new ColeccionMascotas();
        }

        private void DibujarMascotas()
        {
            this.lstMascotas.Items.Clear();
            foreach (Mascota mascota in this.mascotasList)
            {
                this.lstMascotas.Items.Add(mascota.Nombre);
            }
        }

        private void btnNuevaMascota_Click(object sender, EventArgs e)
        {
            Mascota mascota = new Mascota();
            mascota.Nombre = this.txtNombre.Text;
            mascota.Raza = this.txtRaza.Text;
            mascota.Years = int.Parse(this.txtAnios.Text);

            this.mascotasList.Add(mascota);
            this.DibujarMascotas();

            this.txtNombre.Clear();
            this.txtRaza.Clear();
            this.txtAnios.Clear();
        }

        private async void btnGuardarMascotas_Click(object sender, EventArgs e)
        {
            string fileName = "mascotaslist.json";
            await using FileStream createStream = File.Create(fileName);
            await JsonSerializer.SerializeAsync(createStream, mascotasList);
            this.lstMascotas.Items.Clear();

        }

        private async void btnLeerMascotas_Click(object sender, EventArgs e)
        {
            string fileName = "mascotaslist.json";
            FileStream openStream = File.OpenRead(fileName);
            mascotasList = await JsonSerializer.DeserializeAsync<ColeccionMascotas>(openStream);
            this.DibujarMascotas();
        }
    }
}
