using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caPolimorfismo
{
    class Automovel : Veiculo
    {
        private int qte_rodas; 

        public Automovel(String _tipo, int _qte_rodas) : base(_tipo) // construtor
        {
            qte_rodas = _qte_rodas;
        }

        public override void mover()
        {
            Console.WriteLine("Acelerando o automovel");
        }

        public override void parar()
        {
            Console.WriteLine("Brecando o automovel");
        }
    }
}
