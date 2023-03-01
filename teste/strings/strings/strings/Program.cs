using System;


namespace strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string PrimeiroNome = "Gabriela";
            string Sobrenome = "Braga";
            Console.WriteLine(PrimeiroNome + Sobrenome);
            Console.WriteLine($"O seu primeiro nome é {PrimeiroNome} e seu sobrenome é {Sobrenome}");
            string ContadorLetras = "Piracamjuba";
            Console.WriteLine($"A palavra {ContadorLetras} tem {ContadorLetras.Length} letras");


            string msg = "    Maravilha   ";
            Console.WriteLine($"[{msg}]");

            string TiraBranco = msg.Trim();
            Console.WriteLine($"[{TiraBranco}]");

            string TiraBrancoI = msg.TrimStart();
            Console.WriteLine($"[{TiraBrancoI}]");

            string TiraBrancoF = msg.TrimEnd();
            Console.WriteLine($"[{TiraBrancoF}]");

            string egg = "Quem veo primeiro, o ovo ou a galinha?\n";
            Console.WriteLine(egg);

            egg = egg.Replace("galinha", "dinopato");
            Console.WriteLine($"Aplicando Replace: {egg}\n");
            Console.WriteLine(egg.ToUpper());
            Console.WriteLine(egg.ToLower());


            Console.ReadLine(); 

        }
        


    }
}
