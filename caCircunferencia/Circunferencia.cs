using System;
using System.Collections.Generic;
using System.Text;

namespace caCIRCUNFERENCIA
{
    class Circunferencia
    {
        //atributo
        private double radius;

        //métodos
        public Circunferencia()
        {
            radius = 1.0;
        }

        public Circunferencia(double r)
        {
            radius = r;
        }

        double pi = Math.PI;

        public double Area()
        {
            double area;
            area = pi * radius * radius;
            return area;
        }

        public double Perimetro()
        {
            double perimetro;
            perimetro = 2 * pi * radius;
            return perimetro;
        }

        public void setRadius(double new_radius)
        {
            radius = new_radius;
        }

        public double getRadius()
        {
            return radius;
        }
    }
}
