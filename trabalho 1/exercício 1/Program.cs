using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caAluno
{
    class Program
    {
        static void Main(string[] args)
        {
            int aux = 1;
            DetalhesAlunos al = new DetalhesAlunos();
            Aluno aluno = new Aluno();
            while (aux != 0)
            {
                Console.WriteLine("\nEscolha uma opção do menu :\n");
                Console.WriteLine(" [1] - Cadastrar dados");
                Console.WriteLine(" [2] - Imprimir dados");
                Console.WriteLine(" [q] - Sair");
                string op = Console.ReadLine();
               
                switch (op)
                {
                    case "q":
                        return;
                    case "1":
                        aluno = al.askDetails();
                        break;
                    case "2":
                        al.showDetails(aluno);
                        break;
                    default:
                        Console.Write("Favor selecionar uma das opções mostradas no menu\n");
                        break;                   
                        
                } // fim do switch
            }
        }
    }
}
