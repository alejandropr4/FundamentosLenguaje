using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentosPrograma.Models
{

    public class Empleado: Persona
    {
        public virtual int GetDiasVacaciones()
        {
            return 32;
        }
        public override string ToString()
        {
            return this.Apellidos + " " + this.Nombre + ", Salario minimo: " + this.SalarioMinimo;
        }

        public override string GetNombreCompleto()

        {
            Console.WriteLine("Getnombrecompleto empleado");
            return this.Nombre + " " + this.Apellidos + ", Slario: " + this.Salario;
        }
        public Empleado()
        {
            this.SalarioMinimo = 900;
            this.Salario = 900;
            Console.WriteLine("Constructor empleado sin parametros");
        }

        public Empleado(int salario)
        {
            Console.WriteLine("Contructor empleado con paramatros");
        }
        public int Salario { get; set; }
        protected int SalarioMinimo { get; set; }
    }
}
