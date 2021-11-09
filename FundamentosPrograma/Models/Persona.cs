using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentosPrograma.Models
{
    public enum Paises { España, Francia, Alemania, Argentina}

   
    public class Persona
    {
        public Persona()
        {
            this.Edad = 10;
            this.Nacionalidad = Paises.España;
            Console.WriteLine("Constructor de persona");
        }
        public Persona (String nombre, string apellidos)
        {
            this.Nombre = nombre;
            this.Apellidos = apellidos;
        }
        public void convertirDescripciones()
        {
            for (int i=0; i< this._Descripciones.Length; i++)
            {
                this._Descripciones[i] = this._Descripciones[i].ToUpper();
            }
        }

        public virtual String GetNombreCompleto()
        {
            Console.WriteLine("Get nombre completo persona");
            return this.Nombre + " " + this.Apellidos;
        }

        public string GetNombreCompleto(bool orden)
        {
            if(orden == true)
            {
                return this.Apellidos + " " + this.Nombre;
            }
            else
            {
                return this.GetNombreCompleto();
            }
        }

        private string[] _Descripciones = new string[3];
        public String this[int indice]
        {
            get
            {
                return this._Descripciones[indice];
            }
            set
            {
                this._Descripciones[indice] = value;
            }
        }
        public Paises Nacionalidad { get; set; }
        public String Nombre { get; set; }
        public String Apellidos { get; set; }

        private int _Edad;
        public int Edad
        {
            get
            {
                return this._Edad;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("La edad no puede ser negativa");
                }
                else
                {
                    this._Edad = value;
                }

            }
        }


    }
}
