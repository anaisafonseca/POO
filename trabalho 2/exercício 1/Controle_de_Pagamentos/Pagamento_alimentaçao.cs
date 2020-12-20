using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_de_Pagamentos
{
    class Pagamento_alimentaçao: Pagamento

    {
        public string descrição;

        public Pagamento_alimentaçao(string id, int cod, double preço, string descript)
        {
            CPF = id;
            codigo = cod;
            valor = preço * 1.05;
            descrição = descript;
        }

        //getters
        public string get_descrição()
        {
            return descrição;
        }
    }
}
