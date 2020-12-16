using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caPilha
{
    class Pilha
    {
        private NohPilha topo;
        int count = 0;

        public Pilha()
        {
            topo = null;
        }

        public bool isEmpty()
        {
            return (topo == null) ? true : false;
        }

        public void push(int valor)
        {
            topo = new NohPilha(valor, topo);
            count++;
            
        }

        public int pop()
        {
            if (isEmpty())
            {
                throw new Exception();
            }
            int aux = topo.getData();
            topo = topo.getNext();
            count--;
            return aux;

        }

        public string print()
        {
            string resultado = "";
            if (!isEmpty())
            {
                NohPilha aux = topo;
                while (aux != null)
                {
                    resultado += aux.getData() + "\r\n";
                    aux = aux.getNext();
                }
            }
            return resultado;
        }
        public int indexOf(int button)
        {
            
            int resultado = -1;
            int a = 0;
            if (!isEmpty())
            {
                NohPilha aux = topo;
                while (aux != null)
                {
                    if(aux.getData() == button)
                    {
                       resultado = a;

                    }
                    
                    aux = aux.getNext();
                    a++;

                }
            }
            return resultado;

        }
        public int peek()
        {
            return topo.getData();
        }
        
        public int len()
        {
            return count;
        }

        
       
    }
}
