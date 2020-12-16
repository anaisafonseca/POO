using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caTempo
{
    class Program
    {
        static void Main(string[] args)
        {
            Tempo t1 = new Tempo();
            Tempo t2 = new Tempo();
            t1.askHour(1);
            t2.askHour(2);

            Tempo t3 = t1.soma(t2);
            t1.showTime(1);
            t2.showTime(2);
            t3.showTime(3);
            Console.ReadLine();
            //Tempo t3 = t1.soma(t2);


        }
    }
}
