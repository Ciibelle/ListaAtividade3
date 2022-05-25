using System;

namespace Atividade3
{
    class Program
    {
        static void Main(string[] args)
        {
            int valorVendido = 500000;
            int porcentagem = 5;
            int resultado = 0;

            resultado = (valorVendido * porcentagem)/100;
            Console.WriteLine($"Os 5% de 500000 é: {resultado}");
        }
    }
}
