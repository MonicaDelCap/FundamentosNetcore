using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    public enum TipoGenero { Masculino, Femenino}
    public enum Paises { España, Alemania, RepDominicana}
    
    public class Persona
    {
        public Persona()
        {
            Debug.WriteLine("Constructor Persona vacio");
            this.Domicilio = new Direccion();
        }

        public Persona(string nombre, string apellido)
        {
            Debug.WriteLine("Constructor persona con dos parametros");
            this.Nombre = nombre;
            this.Apellidos = apellido;
        }

        #region PROPIEDADES

        public string _DescripcionThis;
        public string this[int indice]
        {
            get { return this._DescripcionThis; }
            set {
                Random random = new Random();
                int ale = random.Next(1, 20);
                this._DescripcionThis = "Desc: " + ale;
            }
        }

        public Direccion Domicilio { get; set; }
        public Direccion DomicilioVacaciones { get; set; }

        public Paises Nacionalidad { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        //CAMPO PRIVADO PARA LA EDAD
        private int _Edad;
        public int Edad
        {
            get { return this._Edad; }
            set
            {
                //DEBEMOS CONMPROBAR EL VALOR DE LA EDAD
                if (value < 0)
                {
                    //SI EL VALOR ES INCORRECTO
                    //this._Edad = 0;

                    //MEJOR LANZAMOS UNA EXCEPCION
                    throw new Exception("La edad no puede ser negativa");
                }
                else
                {
                    this._Edad = value;
                }
            }
        }

        public TipoGenero _Genero;
        public TipoGenero Genero
        {
            get { return this._Genero; }
            set
            {
                if (value != TipoGenero.Femenino && value != TipoGenero.Masculino)
                {
                    throw new Exception("Valor incorrecto");
                }
                else
                {
                    this._Genero = value;
                }
            }
        }
        #endregion
        #region METODOS

        //METODO PARA DEVOLVER UN NOMBRE COMPLETO

        public string GetNombreCompleto(int orden)
        {
            if(orden == 1)
            {
                return this.Apellidos + " " + this.Nombre;
            }
            else
            {
                return this.Nombre + " " + this.Apellidos;

            }
        }

        public string GetNombreCompleto(bool mayusculas)
        {
            if (mayusculas)
            {
                return (this.Nombre + " " + this.Apellidos).ToUpper();
            }
            else
            {
            return (this.Nombre + " " + this.Apellidos).ToLower();

            }

        }

      

        #endregion



    }

}
