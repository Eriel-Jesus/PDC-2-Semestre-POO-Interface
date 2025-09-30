using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface7
{
    internal class ConversorDolar
    {
        private double cotacao;
        private double qtddol;
        private double valorReais;

        public ConversorDolar(double cotacao, double qtddol)
        {
            this.cotacao = cotacao;
            this.qtddol = qtddol;
        }

        public void SetCotacaoDolar(double cotacao)
        {
            this.cotacao = cotacao;
        }

        public void SetQuantidadeDolares(double quantidade)
        {
            this.qtddol = quantidade;
        }

        public double GetCotacaoDolar()
        {
            return this.cotacao;
        }

        public double GetQuantidadeDolares()
        {
            return this.qtddol;
        }

        public double GetValorReais()
        {
            return this.valorReais;
        }

        public void CalcularReais()
        {
            this.valorReais = this.qtddol * this.cotacao;
        }
    }
}
