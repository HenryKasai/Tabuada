using System;

namespace Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            bool terminar = false;
            int número;
            int zero = 0;
            while (!terminar)
            {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Insira um número e veja sua tabuada.");
            bool númerobool = Int32.TryParse(Console.ReadLine(), out número);
            if (!númerobool)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Valor inválido.");
                Console.WriteLine("Aperte uma tecla para inserir outro valor.");
                Console.ReadKey();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Clear();
                while (zero < 11)
                {
                    int resultado = número * zero;
                    Console.WriteLine($"{número} x {zero} = {resultado}");
                    zero = zero + 1;
                }
                terminar = true;
            }
            }
            Console.ResetColor();
            Console.WriteLine("Aperte uma tecla para finalizar o programa.");
            Console.ReadKey();
        }
    }
}
