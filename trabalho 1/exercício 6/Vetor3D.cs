using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caVetor3D
{
    class Vetor3D : Vetor2D
    {
        public double z;


        // construtores
        public Vetor3D() : base()
        {
            z = 0.0;
        }
        public Vetor3D(double z1)
        {
            z = z1;
        }
        public Vetor3D(double x, double y, double z1) : base(x, y)
        {
            z = z1;
        }


        // getters
        public double getZ()
        {
            return z;
        }


        // setters
        public void setZ(double newz)
        {
            z = newz;
        }


        // operações
        public double Modulo3D()
        {
            double modulo3d;
            modulo3d = Math.Sqrt((x * x) + (y * y) + (z * z));
            return modulo3d;
        }
        public Vetor3D Vetorial(Vetor3D b)
        {
            Vetor3D p = new Vetor3D();
            p.x = (y * b.z) - (z * b.y);
            p.y = (z * b.x) - (x * b.z);
            p.z = (x * b.y) - (y * b.x);

            return p;
        }
    }
}
