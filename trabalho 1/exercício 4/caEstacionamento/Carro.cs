using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caEstacionamento
{
    class Carro : Tempo
    {
        public string placa, marca;
        public int horaE, minE, segE, horaS, minS, segS, preço;
        Tempo entrada = new Tempo();
        Tempo saida = new Tempo();


        public Carro()
        {
            preço = 0;
        }


        //setters

        public void set_placa(string _placa)
        {
            placa = _placa;
        }

        public void set_marca(string _marca)
        {
            marca = _marca;
        }


        public void set_entrada()
        {
            entrada.askHour();
            horaE = hora;
            minE = min;
            segE = segs;


        }

        public void set_saida()
        {
            saida.askHour();
            horaS = hora;
            minS = min;
            segS = segs;

        }

        public void set_preço()
        {
            preço = saida.diferença(entrada) * 7;
        }

        //Getters

        public string get_placa()
        {
            return (placa);
        }

        public string get_marca()
        {
            return (marca);
        }

        public void get_entrada()
        {
            entrada.showTime();
            //Console.WriteLine("Entrada: " + horaE + ":" + minE + ":" + segE);
        }

        public void get_saida()
        {
            saida.showTime();
            //Console.WriteLine("Saida: " + horaS + ":" + minS + ":" + segS);
        }

        public void get_informações()
        {
            Console.WriteLine("Placa: " + placa);
            Console.WriteLine("Marca: " + marca);
            Console.WriteLine("Entrada: " + entrada.hora + ":" + entrada.min + ":" + entrada.segs);
            Console.WriteLine("Saida: " + saida.hora + ":" + saida.min + ":" + saida.segs);
            Console.WriteLine("Preço: " + preço);
        }

    }
}

