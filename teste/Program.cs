using System;

namespace teste
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
            string nome = "";
            nome = input("Digite o nome: ");
            Console.WriteLine("o nome é " + nome);
        }

    }

}
