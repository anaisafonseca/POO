using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caEstacionamento
{
    class Program
    {
        static void Main(string[] args)
        {

            //criando carro 1
            Carro primeiro = new Carro();
            Console.WriteLine("Digite a placa do carro 1:");
            primeiro.set_placa(Console.ReadLine());
            Console.WriteLine("Digite a marca do carro 1:");
            primeiro.set_marca(Console.ReadLine());
            Console.WriteLine("Entrada do carro 1:");
            primeiro.set_entrada();
            Console.WriteLine("Saída do carro 1:");
            primeiro.set_saida();
            primeiro.set_preço();


            //criando carro 2
            Carro segundo = new Carro();
            Console.WriteLine("Digite a placa do carro 2:");
            segundo.set_placa(Console.ReadLine());
            Console.WriteLine("Digite a marca do carro 2:");
            segundo.set_marca(Console.ReadLine());
            Console.WriteLine("Entrada do carro 2:");
            segundo.set_entrada();
            Console.WriteLine("Saída do carro 2:");
            segundo.set_saida();
            segundo.set_preço();

            //criando carro 3
            Carro terceiro = new Carro();
            Console.WriteLine("Digite a placa do carro 3:");
            terceiro.set_placa(Console.ReadLine());
            Console.WriteLine("Digite a marca do carro 3:");
            terceiro.set_marca(Console.ReadLine());
            Console.WriteLine("Entrada do carro 3:");
            terceiro.set_entrada();
            Console.WriteLine("Saída do carro 3:");
            terceiro.set_saida();
            terceiro.set_preço();

            //criando carro 4
            Carro quarto = new Carro();
            Console.WriteLine("Digite a placa do carro 4:");
            quarto.set_placa(Console.ReadLine());
            Console.WriteLine("Digite a marca do carro 4:");
            quarto.set_marca(Console.ReadLine());
            Console.WriteLine("Entrada do carro 4:");
            quarto.set_entrada();
            Console.WriteLine("Saída do carro 4:");
            quarto.set_saida();
            quarto.set_preço();

            //criando carro 5
            Carro cinco = new Carro();
            Console.WriteLine("Digite a placa do carro 5:");
            cinco.set_placa(Console.ReadLine());
            Console.WriteLine("Digite a marca do carro 5:");
            cinco.set_marca(Console.ReadLine());
            Console.WriteLine("Entrada do carro 5:");
            cinco.set_entrada();
            Console.WriteLine("Saída do carro 5:");
            cinco.set_saida();
            cinco.set_preço();

            //Imprimindo Carro 1
            Console.WriteLine("\nCarro 1");
            primeiro.get_informações();

            //Imprimindo Carro 2
            Console.WriteLine("\nCarro 2");
            segundo.get_informações();

            //Imprimindo Carro 3
            Console.WriteLine("\nCarro 3");
            terceiro.get_informações();

            //Imprimindo Carro 4
            Console.WriteLine("\nCarro 4");
            quarto.get_informações();

            //Imprimindo Carro 5
            Console.WriteLine("\nCarro 5");
            cinco.get_informações();
            Console.ReadLine();

        }
    }
}

