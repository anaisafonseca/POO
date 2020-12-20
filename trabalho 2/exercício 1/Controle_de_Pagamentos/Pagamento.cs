using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_de_Pagamentos
{
    class Pagamento
    {
        public string CPF;
        public int codigo;
        public double valor;

        public  Pagamento(string id, int cod, double preço)
        {
            CPF = id;
            codigo = cod;
            valor = preço;
        }

        public Pagamento()
        {

        }

        //getters
        public string get_CPF()
        {
            return CPF;
        }

        public string get_codigo()
        {
            return Convert.ToString(codigo);
        }

        public string get_valor()
        {
            return Convert.ToString(valor);
        }
    }
}
