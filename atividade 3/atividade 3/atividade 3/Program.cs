using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite seu sobrenome");
            string sobrenome = Console.ReadLine();
            Console.WriteLine($"Seu nome é {nome} e seu sobrenome é {sobrenome}");

            Console.ReadKey(); 
        }
    }
}
