using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Numero1 = 144;
            int Numero2 = 256;
            int Numero3 = 169;
            int Numero4 = 121;
            int Numero5 = 361;
            double num1 = Math.Sqrt(Numero1);
            double num2 = Math.Sqrt(Numero2);
            double num3 = Math.Sqrt(Numero3);
            double num4 = Math.Sqrt(Numero4);
            double num5 = Math.Sqrt(Numero5);


            Console.WriteLine($"A raiz quadrada de 144 é {num1}");
            Console.WriteLine($"A raiz quadrada de 256 é {num2}");
            Console.WriteLine($"A raiz quadrade de 169 é {num3}");
            Console.WriteLine($"A raiz quadrada de 121 é {num4}");
            Console.WriteLine($"A raiz quadrada de 361 é {num5}");

            Console.ReadKey();

        }
    }
}
