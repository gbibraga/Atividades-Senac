using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 3;
            double b = 4;
            double c = (a * a) + (b * b) ;
            double r = Math.Sqrt(c);
            //Convert.ToInt16(r);
            Console.WriteLine($"A hipotenusa {r}");

            Console.ReadKey();
        }
    }
}
