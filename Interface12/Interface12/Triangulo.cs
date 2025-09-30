using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface12
{
    internal class Triangulo
    {
        private double a, b, c;

        public Triangulo(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public bool FormaTriangulo()
        {
            if ((a + b > c) && (a + c > b) && (b + c > a))
            {
                return true;
            }
            else return false;

        }

        public string Classificar()
        {
            if (a == b && b == c)
            {
                return "Equilátero";
            }
            else if (a == b || a == c || b == c)
            {
                return "Isósceles";
            }
            else
            {
                return "Escaleno";
            }
        }
    }
}

