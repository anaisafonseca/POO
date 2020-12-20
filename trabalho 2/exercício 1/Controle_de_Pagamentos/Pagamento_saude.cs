using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_de_Pagamentos
{
    class Pagamento_saude: Pagamento
    {

        public string estabelecimento;
        public Pagamento_saude(string id, int cod, double preço, string lugar)
        {
            CPF = id;
            codigo = cod;
            valor = preço * 1.12;
            estabelecimento = lugar;
        }

        //getters
        public string get_estabelcimento()
        {
            return estabelecimento;
        }
    }
}
