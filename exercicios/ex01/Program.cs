// Receber um valor e informar se é par ou impar

using System;

namespace main
{
    class Program
    {
        static float Input(string input)
        {
            Console.Write(input);
            float num = float.Parse(Console.ReadLine());
            return num;
        }

        static void Main(string[] args)
        {
            float num = Input("Digite um numero: ");
            string parOrImpar = "";

            if (num % 2 == 0)
            {
                parOrImpar = "par";
            } 
            else 
            {
                parOrImpar = "impar";
            }

            Console.WriteLine("O "+num+" é "+parOrImpar);
        }
    }
}