using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caFila
{
    class Program
    {
        static void Main(string[] args)
        {
            // inserir um inteiro na fila
            // remover um inteiro da fila
            // inserir um inteiro após um outro escolhido
            // imprimir a fila
            // sair

            Fila fila = new Fila();

            TextReader leitor = System.Console.In;
            TextWriter escritor = System.Console.Out;
            int aux = 1;
            while (aux != 0)
            {
                Console.WriteLine("Escolha uma opção do menu:");
                Console.WriteLine(" [1] - Inserir um inteiro na fila");
                Console.WriteLine(" [2] - Remover um inteiro da fila");
                Console.WriteLine(" [3] - Inserir um inteiro após um outro a ser escolhido");
                Console.WriteLine(" [4] - Imprimir a fila");
                Console.WriteLine(" [5] - Sair");

                string op = leitor.ReadLine();

                switch (op)
                {
                    case "1":
                        Console.Write("Digite um inteiro a ser inserido: ");
                        int valor = Convert.ToInt32(leitor.ReadLine());
                        fila.insere(valor);
                        Console.Clear();
                        break;

                    case "2":
                        Console.Write("O elemento " + fila.retirar() + "foi removido");
                        Console.Clear();
                        break;

                    case "3":
                        Console.Write("Digite um inteiro a ser inserido após outro: ");
                        int valor1 = Convert.ToInt32(leitor.ReadLine());
                        Console.Write("Escolha o inteiro após o qual o anterior será inserido: ");
                        int valor2 = Convert.ToInt32(leitor.ReadLine());
                        fila.insere(valor2);
                        fila.insere(valor1);
                        Console.Clear();
                        break;

                    case "4":
                        Console.Write("Fila:\n");
                        fila.imprime();
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case "5":
                        aux = 0;
                        Console.Clear();
                        break;
                    default:
                        Console.Write("Favor selecionar uma das opções mostradas no menu.\n");
                        break;
                }
            }
        }
    }
}
