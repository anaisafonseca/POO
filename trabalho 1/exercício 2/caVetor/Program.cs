using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caVetor
{
    class Program
    {
        static void Main(string[] args)
        {
            Vetor2D a = new Vetor2D();
            Vetor2D b = new Vetor2D();
            Vetor2D c = new Vetor2D();

            Console.WriteLine("Digite a componente x do vetor B:");
            b.setX(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("Digite a componente y do vetor B:");
            b.setY(Convert.ToDouble(Console.ReadLine()));


            Console.WriteLine("\nProduto escalar dos vetores: " + a.Escalar(a, b));
            Console.WriteLine("Módulo do vetor a: " + a.Modulo(a));
            Console.WriteLine("Módulo do vetor b: " + b.Modulo(b));
            Console.WriteLine("Ângulo entre os dois vetores: " + a.Angulo(a, b));
            c = a.Projecao(a, b);
            Console.WriteLine("O vetor projeção de a e b é: (" + c.getX() + ", " + c.getY() + ")");
            Console.ReadLine();

        }
    }
}
