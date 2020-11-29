using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caVetor3D
{
    class Program
    {
        static void Main(string[] args)
        {
            Vetor3D a = new Vetor3D();
            Vetor3D b = new Vetor3D();
            Vetor3D c = new Vetor3D();

            Console.WriteLine("Digite a componente x do vetor B:");
            b.setX(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("Digite a componente y do vetor B:");
            b.setY(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("Digite a componente z do vetor B:");
            b.setZ(Convert.ToDouble(Console.ReadLine()));

            Console.WriteLine("Modulo do vetor a: " + a.Modulo3D());
            Console.WriteLine("Modulo do vetor b: " + b.Modulo3D());
            c = a.Vetorial(b);
            Console.WriteLine("O produto vetorial de a e b é: (" + c.getX() + ", " + c.getY() + ", " + c.getZ() + ")");
            Console.ReadLine();

        }
    }
}
