using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Aluno
    {
        private string nome;
        private string matricula;


        public Aluno(string _nome, string _matricula)
        {
            nome = _nome;
            matricula = _matricula;
        }
        
        public void Print()
        {
            Console.WriteLine(nome + "\n" + matricula);
        }
        public Aluno()
        {
            nome = "";
            matricula = "";
        }
        public void Set(string _nome, string _matricula)
        {
            nome = _nome;
            matricula = _matricula;
        }
        public string Getnome()
        {
            return(nome);
        }
    }
}
