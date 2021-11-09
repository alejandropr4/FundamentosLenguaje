using FundamentosPrograma.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentosPrograma.Helpers
{
    public class HelperMeses
    {
        public List<TemperaturaMes> Meses { get; set; }

        public HelperMeses()
        {
            this.Meses = new List<TemperaturaMes>();
            Random random = new Random();
            for (int i=1; i<=12; i++)
            {
                TemperaturaMes mes = new TemperaturaMes();
                mes.Mes = "Mes " + i;
                mes.Maxima = random.Next(20, 50);
                mes.Minima = random.Next(-10, 20);
                this.Meses.Add(mes);
            }
        }

        public int GetMaximaAnual()
        {
            int maxima = 0;
            foreach (TemperaturaMes mes in this.Meses)
            {
                maxima = Math.Max(maxima, mes.Maxima);
            }
            return maxima;
        }
        public int GetMinimaAnual()
        {
            int minima = 30;
            foreach (TemperaturaMes mes in this.Meses)
            {
                minima = Math.Min(minima, mes.Minima);
            }
            return minima;
        }

        public int GetMediaAnual()
        {
            int media = 0;
            foreach(TemperaturaMes mes in this.Meses)
            {
                media += mes.GetMedia();
            }
            return media / this.Meses.Count;
        }
    }
}
