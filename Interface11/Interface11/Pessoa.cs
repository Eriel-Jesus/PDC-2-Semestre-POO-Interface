using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface11
{
    internal class Pessoa
    {
        private double peso, altura, relacao;

        public Pessoa(double peso, double altura)
        {
            this.peso = peso;
            this.altura = altura;
        }

        public double GetPeso()
        {
            return this.peso;
        }
        public double GetAltura()
        { 
            return this.altura;
        }
        public double GetRelacao()
        {
            return this.relacao;
        }

        public void CalcularRelacao()
        {
            this.relacao = this.peso / Math.Pow(this.altura, 2);
        }

        public string ClassificarPeso()
        {
            if (relacao < 20)
            {
                return "Abaixo do peso";
            }
            else
            {
                if (relacao >= 20 && relacao < 25)
                {
                    return "Peso ideal";
                }
                else { return "Acima do peso"; }
            }
        }
    }
}
