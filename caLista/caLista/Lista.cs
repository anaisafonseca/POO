using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caLista
{
    class Lista
    {
        NohLista INICIO;
        NohLista FIM;

        public Lista()
        {
            INICIO = null;
            FIM = null;
        }

        public bool estaVazia()
        {
            if (INICIO == null && FIM == null)
                return true;
            else
                return false;
        }

        public  void insereInicio(int  n)
        {
            NohLista newNoh = new NohLista(n);
            if (estaVazia())
            {
                INICIO = newNoh;
                FIM = newNoh;
            }
            else
            {
                INICIO.setPrevio(newNoh);
                newNoh.setNext(INICIO);
                INICIO = newNoh;
            }
        }

        public void insereFim(int n)
        {
            NohLista newNoh = new NohLista(n);
            if (estaVazia())
            {
                INICIO = newNoh;
                FIM = newNoh;
            }
            else
            {
                FIM.setNext(newNoh);
                newNoh.setPrevio(FIM);
                FIM = newNoh;
            }
        }

        public void remove(int n)
        {
            NohLista thisPtr = encontraNoh(n);
            if (thisPtr == INICIO) // remover do início da lista
            {
                INICIO = INICIO.getNext();
                INICIO.setPrevio(null);
            }
            else if (thisPtr == FIM) // remover do fim da lista
            {
                FIM = FIM.getPrevio();
                FIM.setNext(null); 
            }
            else // remove um elemento do meio da lista
            {

            }
        }

        // este método pressupõe que intEncontrado está na Lista
        public NohLista encontraNoh(int intEncontrado)
        {
            NohLista foundNoh = INICIO;
            while (foundNoh != null) 
            {
                if (foundNoh.getData() == intEncontrado)
                    return (foundNoh);
                else
                    foundNoh = foundNoh.getNext();
            }
            return null;
        }

    }
}
