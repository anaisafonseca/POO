using System;

namespace caRETANGULO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("how i love you, i can´t love myself");

            Retangulo r1 = new Retangulo();  //criei um objeto da classe retangulo
            Retangulo r2 = new Retangulo();  //criei outro objeto da classe retangulo
            Retangulo r3 = new Retangulo(5.0, 8.0);
            Retangulo r4 = new Retangulo(10, 5);

            Console.WriteLine("Area do retangulo 1: " + r1.Area());  //1
            Console.WriteLine("Base do retangulo 1: " + r1.getBasis());  //1
            Console.ReadLine();

            r1.setBasis(4.0);
            r1.setHeight(5.0);
            r2.setBasis(5.0);
            r2.setHeight(6.0);

            Console.WriteLine("Area do retangulo 1: " + r1.Area());  //20
            Console.WriteLine("Base do retangulo 1: " + r1.getBasis());  //4
            Console.ReadLine();

            Console.WriteLine("Area do retangulo 2: " + r2.Area());  //30
            Console.WriteLine("Area do retangulo 3: " + r3.Area());  //40
            Console.WriteLine("Area do retangulo 4: " + r4.Area());  //50
            Console.ReadLine();

        }
    }
}
