using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma palavra!");
            string contar = Console.ReadLine();
            Console.WriteLine($"A palavra {contar} tem {contar.Length}");
            Console.ReadKey();
            
        }
    }
}
