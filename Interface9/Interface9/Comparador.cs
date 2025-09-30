using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface9
{
    internal class Comparador
    {
        private double valor1, valor2, maior;
        public Comparador(double valor1, double valor2)
        {
            this.valor1 = valor1;
            this.valor2 = valor2;
        }

        public bool SaoIguais()
        {
            if (this.valor1 == this.valor2)
            {
                return true;
            }
            else { return false; }
        }

        public double DeterminarMaior()
        {
            if (this.valor1 > this.valor2)
            {
                this.maior = this.valor1;
                return this.maior;
            }
            else
            {
                this.maior = this.valor2;
                return this.maior;
            }
        }
    }
}
