using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caVetor
{
    class Vetor2D
    {
        private double x;
        private double y;


        // construtores
        public Vetor2D()
        {
            x = 0.0;
            y = 0.0;
        }
        public Vetor2D(double x1, double y1)
        {
            x = x1;
            y = y1;
        }


        // getters
        public double getX()
        {
            return x;
        }
        public double getY()
        {
            return y;
        }


        // setters
        public void setX(double newx)
        {
            x = newx;
        }
        public void setY(double newy)
        {
            y = newy;
        }


        // operações
        public double Escalar(Vetor2D a, Vetor2D b)
        {
            double escalar;
            escalar = ((a.x * b.x) + (a.y * b.y));
            return escalar;
        }
        public double Modulo(Vetor2D a)
        {
            double modulo;
            modulo = Math.Sqrt((a.x * a.x) + (a.y * a.y));
            return modulo;
        }
        public double Angulo(Vetor2D a, Vetor2D b)
        {
            double angulo;
            angulo = ((Escalar(a, b)) / (Modulo(a) * Modulo(b)));
            double result = Math.Acos(angulo);
            return result;
            //return angulo;
        }
        public Vetor2D Projecao(Vetor2D a, Vetor2D b)
        {
            double projecao;
            projecao = ((Escalar(a, b)) / (Modulo(a) * Modulo(a)));
            double x1 = projecao * a.x;
            double x2 = projecao * a.y;
            Vetor2D vetorproj = new Vetor2D(x1, x2);
            return vetorproj;
        }
    }
}
