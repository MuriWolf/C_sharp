using System;

namespace main
{
    class Program
    {
        static string input(string ask) {
            Console.Write(ask);
            string response = Console.ReadLine();
            return response;
        }
        static void Main(string[] args)
        {
            string nome = input("Digite seu nome: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Seu nome é {0}", nome);
        }
    }
}