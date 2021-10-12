using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appClassHerenciaCS
{
    class Program
    {
        static void Main(string[] args)
        {
            Punto2D a;
            a = new Punto2D(98, 76);
            Console.WriteLine(a.ToString());

            Punto a2;
            a2 = new Punto(5.99);

            Console.WriteLine(a2.ToString());


            Console.ReadKey();



        }
    }
}
