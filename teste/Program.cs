using System;

namespace teste
{
    class Program
    {
        public string input(string ask) {
            Console.WriteLine(ask);
            string response = Console.ReadLine();
            Return response;
        }
        static void Main(string[] args)
        {
            string nome = "";
            nome = input("Digite o nome: ");
            Console.WriteLine(nome);
        }

    }

}
