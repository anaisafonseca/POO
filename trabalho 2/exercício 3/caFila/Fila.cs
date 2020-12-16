using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caFila
{
    class Fila
    {
        private NohFila start;
        private NohFila end;

        public Fila()
        {
            start = null;
            end = null;
        }

        bool isEmpty()
        {
            if (start == null)
                return true;
            else
                return false;

        }

        public void insere(int valor)
        {
            NohFila novonoh = new NohFila(valor);

            if (isEmpty())
            {
                start = novonoh;
                end = novonoh;
            }
            else
            {
                end.setAnterior(novonoh);
                end = novonoh;
            }
        }

        public int retirar()
        {
            if (isEmpty())
            {
                Console.WriteLine("Fila Vazia");
                return 0;
            }

            else
            {
                int aux = start.getData();
                start = start.getAnterior();
                return (aux);
            }
        }

        public void imprime()
        {
            if (isEmpty())
            {
                Console.WriteLine("Fila vazia");
            }
            else
            {
                NohFila aux = start;
                while (aux != null)
                {
                    Console.Write(aux.getData() + " ");
                    aux = aux.getAnterior();
                }
            }
        }
    }
}
