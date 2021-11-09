using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentosPrograma.Models
{
    public class TemperaturaMes
    {
        public int Maxima { get; set; }

        public int Minima { get; set; }

        public string Mes { get; set; }

        public int GetMedia()
        {
            return (this.Maxima + this.Minima) / 2;
        }
    }
}
