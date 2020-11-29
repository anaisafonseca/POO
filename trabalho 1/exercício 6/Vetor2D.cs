using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caVetor3D
{
    class Vetor2D
    {
        public double x;
        public double y;


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
            return this.x;
        }
        public double getY()
        {
            return this.y;
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
    }
}