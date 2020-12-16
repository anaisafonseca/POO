using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caAluno
{
    class DetalhesAlunos
    {
        //Aluno aluno = new Aluno();
        public Aluno askDetails()
        {
            
            Console.WriteLine("Coloque seu primeiro nome:");
            string FirstName = Console.ReadLine();
            Console.WriteLine("Coloque seu último nome:");
            string LastName = Console.ReadLine();
            Console.WriteLine("Coloque seu número de matrícula:");
            string Matricula = Console.ReadLine();
            Console.WriteLine("Coloque seu número de telefone:");
            string Tel = Console.ReadLine();
            return new Aluno(FirstName, LastName, Matricula, Tel);

        }
        public void showDetails(Aluno aluno)
        {
            Console.WriteLine("Seus dados são:" + aluno);
        }

    }

}
