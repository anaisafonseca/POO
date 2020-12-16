using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caEstacionamento
{
    class Tempo
    {

        public Tempo()
        {
            hora = 0;
            min = 0;
            segs = 0;
        }
        public Tempo(int _hora, int _min, int _segs)
        {
            hora = _hora;
            min = _min;
            segs = _segs;

        }

        public int hora, min, segs;
        // Hora
        public int getHora()
        {
            return hora;
        }
        public void setHora(int _hora)
        {
            hora = _hora;
        }
        //Min
        public int getMin()
        {
            return min;
        }

        public void setMin(int _min)
        {
            min = _min;
        }
        //Segs
        public int getSegs()
        {
            return segs;
        }

        public void setSeg(int _segs)
        {
            segs = _segs;
        }


        public void askHour()
        {

            do
            {
                Console.WriteLine("Insira a hora corretamente: ");
                hora = Convert.ToInt32(Console.ReadLine());
            } while (hora < 0 || hora > 23);

            do
            {
                Console.WriteLine("Insira os minutos corretamente: ");
                min = Convert.ToInt32(Console.ReadLine());
            } while (min < 0 || min > 59);

            do
            {
                Console.WriteLine("Insira os segundos corretamente: ");
                segs = Convert.ToInt32(Console.ReadLine());
            } while (segs < 0 || segs > 59);
        }

        public void showTime()
        {
            Console.WriteLine(hora + ":" + min + ":" + segs);
        }
        public Tempo soma(Tempo t)
        {
            int _hora, _min, _segs;
            _hora = hora + t.getHora();
            _min = min + t.getMin();
            _segs = segs + t.getSegs();

            if (_segs > 59)
            {
                _segs -= 60;
                _min++;
            }
            if (_min > 59)
            {
                _min -= 60;
                _hora++;
            }
            if (_hora > 23)
            {
                _hora -= 24;
            }
            return new Tempo(_hora, _min, _segs);
        }

        public int diferença(Tempo t)
        {
            int _hora, _min, _segs;
            _hora = hora - t.getHora();
            _min = min - t.getMin();
            _segs = segs - t.getSegs();

            if (_segs < 0)
            {
                _segs += 10;
                _min--;
            }
            if (_min < 0)
            {
                _min += 10;
                _hora--;
            }

            return (_hora);

        }
    }
}
