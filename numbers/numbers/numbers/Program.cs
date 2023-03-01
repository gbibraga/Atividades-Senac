using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Numero1 = 9;
            int Numero2 = 10;
            int Numero3 = 21;
            int result = (Numero1 + Numero2) - 6 * Numero3 + (12 * 4) / 3 + 112;
            Console.WriteLine($"O resultado inteiro do quociente da divisão é: {result}");

            int RNumero1 = 9;
            int RNumero2 = 10;
            int RNumero3 = 21;
            int Rresult = (RNumero1 + RNumero2) - 6 * RNumero3 + (12 * 4) / 3 + 112;
            Console.WriteLine($"O resultado inteiro do quociente da divisão é: {Rresult}");

            int Imin = int.MinValue;
            int Imax = int.MaxValue;
            Console.WriteLine($"O intervalo do tipo inteiro está entre: {Imin} {Imax}");

            Console.WriteLine("=== Operação com double ===");
            double DNumero1 = 9;
            double DNumero2 = 10;
            double DNumero3 = 91;
            double Dresult = (DNumero1 + DNumero2) - 6 / DNumero3;
            Console.WriteLine($"Resultado da operação double {Dresult}\n");

            Console.WriteLine("=== Operação com double ===");
            float FNumero1 = 9;
            float FNumero2 = 10;
            float FNumero3 = 91;
            float Fresult = (FNumero1 + FNumero2) - 6 / FNumero3;
            Console.WriteLine($"Resultado da operação float {Fresult}\n");

            Console.WriteLine("=== Operação com double ===");
            decimal TNumero1 = 9;
            decimal TNumero2 = 10;
            decimal TNumero3 = 91;
            decimal Tresult = (TNumero1 + TNumero2) - 6 / TNumero3;
            Console.WriteLine($"Resultado da operação decimal {Tresult}\n");

            Console.WriteLine("=== Operação com double ===");

            float Fmin = float.MinValue;
            float Fmax = float.MaxValue;
            Console.WriteLine($"O intervalo do tipo float está entre {Fmin} e {Fmax}\n");

            double raio = 2.50;
            double area = Math.PI * raio * raio;
            Console.WriteLine(area);

            double a = 4;
            double b = 5;
            double c = a * a * b;
            double r = Math.Sqrt(c);
            //Convert.ToInt16(r);
            Console.WriteLine(r);




            Console.ReadKey();

        }
    }
}
