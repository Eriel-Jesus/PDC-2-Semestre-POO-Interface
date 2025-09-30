using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface10
{
    internal class Terreno
    {
        private double baseReta, altura, area;

        public Terreno(double baseReta, double altura)
        {
            this.baseReta = baseReta;
            this.altura = altura;
        }

        public double GetBase()
        {
            return this.baseReta;
        }

        public double GetAltura()
        {
            return this.altura;
        }

        public double GetArea()
        {
            return this.area;
        }

        public void CalcularArea()
        {
            this.area = this.baseReta * this.altura;
        }
    }
}
