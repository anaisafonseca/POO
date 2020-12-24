using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caHeranca
{
    class Gerente : Empregado // Gerente herda de Empregado
    {
        // atributos
        private String secretaria;

        // métodos
        public Gerente() : base()
        {

        }

        public Gerente(String _nome, String _secao,
                     double _salario, String _secretaria) 
            : base(_nome, _secao, _salario)  // ordem eh importante       
        {
            secretaria = _secretaria;
        }

        public String getSecretaria()
        {
            return (secretaria);
        }

        public void setSecretaria(String _secretaria)
        {
            secretaria = _secretaria;
        }

                
        public override void aumentaSalario(double percentagem) // 'override
        {
            double novaPercentagem = percentagem + 15.0;
            base.aumentaSalario(novaPercentagem);
        }

    } // fim da classe Gerente
}
