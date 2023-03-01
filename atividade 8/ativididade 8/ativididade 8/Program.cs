using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ativididade_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int f = 86;
            double c = (f - 32) * 5 / 9;
            Console.WriteLine($"A temperatura é {c}");
            
            Console.ReadKey();
        }
    }
}
