using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int id1 = 20;
            int id2 = 19;
            int id3 = 19;
            int id4 = 22;
            int id5 = 20;
            int id6 = 19;

            int me = (id1 + id2 + id3 + id4 + id5 + id6) / 6;
            Console.WriteLine($"A idade média dos alunos da turma TI32 é {me}");
            Console.ReadKey(); 
        }
    }
}
