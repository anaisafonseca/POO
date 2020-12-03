using System;
using System.Collections.Generic;
using System.Text;

namespace caRETANGULO
{
    class Retangulo
    {
        //atributos
        private double basis;
        private double height;

        //métodos
        public Retangulo()
        {
            basis = 1.0;
            height = 1.0;
        }

        public Retangulo(double b, double h)
        {
            basis = b;
            height = h;
        }

        public double Area()
        {
            double area;
            area = basis * height;
            return area;
        }

        public void setBasis(double new_basis)  //altera o valor da base
        {
            basis = new_basis;
        }
        public void setHeight(double new_height)  //altera o valor da altura
        {
            height = new_height;
        }

        public double getBasis()  //retorna o valor da base
        {
            return basis;
        }
        public double getHeight()  //retorna o valor da altura
        {
            return height;
        }
    }
}
