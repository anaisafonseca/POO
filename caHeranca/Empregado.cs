using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caHeranca
{
    class Empregado
    {
        protected String nome;
        protected String secao;
        protected double salario;

        public Empregado()
        {
        }

        public Empregado(String _nome, String _secao, double _salario)
        {
            nome = _nome;
            secao = _secao;
            salario = _salario;
        }

        public String getNome()
        {
            return nome;
        }

        public void setNome(String _nome)
        {
            this.nome = _nome;
        }

        public String getSecao()
        {
            return secao;
        }

        public void setSecao(String _secao)
        {
            this.secao = _secao;
        }

        public double getSalario()
        {
            return salario;
        }

        public void setSalario(double _salario)
        {
            this.salario = _salario;
        }

        public virtual void aumentaSalario(double percentual) // 'virtual'
        {
            salario *= 1 + percentual / 100;
        }
    }
}
