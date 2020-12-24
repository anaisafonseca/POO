using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caFila
{
    class Fila
    {
        //atributos
        private NohFila start;
        private NohFila end;
        
        //construtor default
        public Fila()
        {
            start = null;
            end = null;
        }

        //função para verificar se esta vazia
        bool isEmpty()
        {
            if (start == null)
                return true;
            else
                return false;

        }

        // 0) Verificar se a fila não está vazia
        // 1) Criar o nó
        // 2) Encadear com o novo nó
        // 3) Fazer FIM (start) apontar para novo nó
       
   


        public void insere(int valor)
        {
            NohFila novonoh = new NohFila(valor); // cria um novo NohFila

            if (isEmpty()) // a Fila está vazia -- primeiro nó da Fila
            {
                start = novonoh; // o start aponta para novonoh
                end = novonoh;   // o end aponta para novonoh
            }
            else
            {
                end.setAnterior(novonoh);
                end = novonoh;
            }

        } // fim do método insere( )

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

    } // fim da classe Fila 
}
