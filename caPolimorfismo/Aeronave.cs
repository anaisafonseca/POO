﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caPolimorfismo
{
    class Aeronave : Veiculo
    {
        private int qte_turbinas;

        public Aeronave(String _tipo, int _qte_turbinas) : base(_tipo)
        {
            qte_turbinas = _qte_turbinas;
        }

        public override void mover()
        {
            //base.mover();
            Console.WriteLine("Acelerando a aeronave");
        }

        public override void parar()
        {
            Console.WriteLine("Freiando a aeronave");
        }
    }
}
