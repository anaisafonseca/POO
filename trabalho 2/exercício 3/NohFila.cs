using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caFila
{
    class NohFila
    {
        private int data;
        private NohFila anterior;

        public NohFila()
        {
            data = 0;
            anterior = null;
        }

        public NohFila(int valor)
        {
            data = valor;
            anterior = null;
        }

        public NohFila(int valor, NohFila prior)
        {
            data = valor;
            anterior = prior;
        }

        public int getData()
        {
            return data;
        }

        public NohFila getAnterior()
        {
            return anterior;
        }

        public void setData(int valor)
        {
            data = valor;
        }

        public void setAnterior(NohFila prior)
        {
            anterior = prior;
        }
    }
}
