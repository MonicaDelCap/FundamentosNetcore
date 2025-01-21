using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoClases.Models;

namespace ProyectoClases.Helpers
{
    public class HelperMascotas
    {
        public List<Mascota> Mascotas { get; set; }
        private string Path;

        public HelperMascotas(string path)
        {
            this.Mascotas = new List<Mascota>();
            this.Path = path;
        }

        private string ConvertirMascotasString()
        {
            string data = "";
            foreach(Mascota mascota in this.Mascotas)
            {
                string temp = mascota.Nombre + "," + mascota.Raza;
                data += temp + "@";
            }
            data = data.TrimEnd('@');
            return data;
        }

        private void ConvertirMascotasList(string data)
        {
            this.Mascotas.Clear();
            string[] datosMascotas = data.Split("@");
            foreach(string stringMascota in datosMascotas)
            {
                string[] propiedades = stringMascota.Split(",");
                Mascota mascota = new Mascota();
                mascota.Nombre = propiedades[0];
                mascota.Raza = propiedades[1];
                this.Mascotas.Add(mascota);
            }
        }

        public async Task WriteMascotasAsync()
        {
            string data = this.ConvertirMascotasString();
            await HelperFilers.WriteFileAsync(this.Path, data);
        }

        public async Task ReadMascotasAsync()
        {
            string data = await HelperFilers.ReadFileAsync(this.Path);
            this.ConvertirMascotasList(data);

        }
    }
}
