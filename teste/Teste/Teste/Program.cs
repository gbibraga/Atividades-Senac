using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual operação deseja fazer?");
            Console.WriteLine("1. Adição");
            Console.WriteLine("2. Subitração");
            Console.WriteLine("3. Multiplicação");
            Console.WriteLine("4. Divisão");

           

            int operacao= int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um numero: ");
            int numero1= int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número");
            int numero2= int.Parse(Console.ReadLine());

            switch (operacao)
            {
                case 1:
                    double adicao = numero1 + numero2;
                    Console.WriteLine(adicao);
                    break;

                    case 2:
                    double subtracao = numero1 - numero2;
                    Console.WriteLine(subtracao);
                    break;

                    case 3:
                    double divisao = numero1  / numero2;
                    Console.WriteLine(divisao);
                                        break;

                    case 4:
                    double multiplicacao = numero1 * numero2;
                    Console.WriteLine(multiplicacao);
                                        break;

                    default: Console.WriteLine("Numero inválido, digite outro");
                    break;


            }

            Console.ReadLine();









        }
    }
}
