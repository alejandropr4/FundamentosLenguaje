using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentosPrograma.Models
{
    public class Director: Empleado
    {
        public override int GetDiasVacaciones()
        {
            int diasempleados = base.GetDiasVacaciones();
            return diasempleados+20;

        }
        public Director()
        {
            this.SalarioMinimo = 1400;
            Console.WriteLine("Constructor Director sin parametros");
        }

        public Director(int salario):base(12)
        {
            Console.WriteLine("Constructor director con parametros");
        }
    }
}
