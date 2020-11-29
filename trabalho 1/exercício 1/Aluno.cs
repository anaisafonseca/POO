using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caAluno
{
    class Aluno
    {

        public Aluno()
        {
            FirstName = " ";
            LastName = " ";
            Matricula = " ";
            Tel = " ";

        }
        public Aluno(string firstName, string lastName, string numMatricula,
            string telephone)
        {
            FirstName = firstName;
            LastName = lastName;
            Matricula = numMatricula;
            Tel = telephone;
        }
        
        public string FirstName;
        public string LastName;
        public string Matricula;
        public string Tel;

        public void SetFirstName(string _name)
        {
            FirstName = _name;
        }

        public void SetLastName(string _name)
        {
            LastName = _name;
        }
        public void SetMatricula(string _mat)
        {
            Matricula = _mat;
        }
        public void SetTel(string _tel)
        {
            Tel = _tel;
        }
        public string GetFirstName()
        {
            return FirstName;
        }
        public string GetLastName()
        {
            return LastName;
        }
        public string GetMatricula()
        {
            return Matricula;
        }
        public string GetTel()
        {
            return Tel;
        }

        public override string ToString()
        {
            return "\n\nNome:" + FirstName + "  Sobrenome:" + LastName + "\nMatricula:" 
                + Matricula + "\nTelefone: " + Tel; 
        }

    }
}
