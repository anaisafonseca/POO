using System;

namespace caCIRCUNFERENCIA
{
    class Program
    {
        static void Main(string[] args)
        {
            Circunferencia c1 = new Circunferencia();
            Circunferencia c2 = new Circunferencia(3.0);

            Console.WriteLine("Area da circunferencia 1: " + c1.Area());            //3.14...
            Console.WriteLine("Perimetro da circunferencia 1: " + c1.Perimetro());  //6.28...
            Console.WriteLine("Raio da circunferencia 1: " + c1.getRadius());       //1
            Console.ReadLine();

            Console.WriteLine("Area da circunferencia 2: " + c2.Area());            //28.27...
            Console.WriteLine("Perimetro da circunferencia 1: " + c2.Perimetro());  //18.84...
            Console.WriteLine("Raio da circunferencia 2: " + c2.getRadius());       //3
            Console.ReadLine();

            c1.setRadius(5.0);
            c2.setRadius(10.0);

            Console.WriteLine("Area da circunferencia 1: " + c1.Area());            //78.53...
            Console.WriteLine("Perimetro da circunferencia 1: " + c1.Perimetro());  //31.41...
            Console.WriteLine("Raio da circunferencia 1: " + c1.getRadius());       //5
            Console.ReadLine();

            Console.WriteLine("Area da circunferencia 2: " + c2.Area());            //314.15...
            Console.WriteLine("Perimetro da circunferencia 1: " + c2.Perimetro());  //62.83...
            Console.WriteLine("Raio da circunferencia 2: " + c2.getRadius());       //10
            Console.ReadLine();
        }
    }
}
