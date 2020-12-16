using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Matérias
    {
        private string[] materias;
        private Aluno objaluno;

        public Matérias(string[] _materias, Aluno _objaluno)
        {
            materias = _materias;
            objaluno = _objaluno;
        }

        
        public Matérias()
        {
            materias[0] = "0";
            objaluno = null;
        }
        public void Set(string[] _materias, Aluno _objaluno) 
        {
            materias = _materias;
            objaluno = _objaluno;
        }
        
        public string Getaluno()
        {
            return (objaluno.Getnome());
        }
        public string[] Getmateria()
        {
            return (materias);
        }
    }
}

