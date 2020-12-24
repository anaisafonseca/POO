using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caPilhaDinamica
{
    class Pilha
    {
        // atributos 
        private NohPilha topo;

        // metodos
        public Pilha()
        {
            topo = null; // não foi inserido elemento
        }

        public bool isEmpty()
        {
            if (topo == null)
                return true;
            else
                return false;
        }

        public void push(int insertItem)
        {
            if (isEmpty())
                topo = new NohPilha(insertItem);
            else
            {
                // NohPilha novoNoh = new NohPilha(insertItem, topo); OU
                NohPilha novoNoh = new NohPilha(insertItem);
                novoNoh.setNext(topo);
                
                topo = novoNoh; // o topo agora aponta para mim -- this
            }
        } // fim do método push



        public int pop()
        {
            if(isEmpty())
            {
                Console.WriteLine("Pilha Vazia");
                return 0;
            }
            else
            {
                int temp = topo.getData();
                topo = topo.getNext();
                return (temp);
            }
            
        }

        public void print()
        {
            if (isEmpty())
                Console.WriteLine("Pilha Vazia");
        else {
                Console.WriteLine("Status atual da Pilha:");
                NohPilha temp = topo;

                while (temp != null)
                {
                    Console.WriteLine("\n" + temp.getData());
                    temp = temp.getNext();
                } // fim do while
             } // fim do else 
        } // fim do método print

        

     } // fim da classe Pilha
}
