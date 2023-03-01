using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string musica = "Na minha vida tudo acontece\r\n Mas quanto mais a gente rala, mais a gente cresce\r\n Hoje estou feliz porque eu sonhei com você\r\n E amanhã posso chorar por não poder te ver\r\n Mas o seu sorriso vale mais que um diamante\r\n Se você vier comigo, aí nós vamos adiante\r\n Com a cabeça erguida e mantendo a fé em Deus\r\n O seu dia mais feliz vai ser o mesmo que o meu\r\n A vida me ensinou a nunca desistir\r\n Nem ganhar, nem perder mas procurar evoluir\r\n Podem me tirar tudo que tenho\r\n Só não podem me tirar as coisas boas que eu já fiz pra quem eu amo\r\n E eu sou feliz e canto e o universo é uma canção\r\n E eu vou que vou\r\n História, nossas histórias\r\n Dias de luta, dias de glória";
            Console.WriteLine($"{musica}\n");
            Console.WriteLine(musica.Contains("tudo"));
            Console.WriteLine(musica.Contains("fracasso"));
            Console.WriteLine(musica.Contains("vitória"));
            Console.ReadKey();
        }
    }
    }
