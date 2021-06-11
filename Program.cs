using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroAnterior = 0;
            int numeroAtual = 1;
            int fibonacci = 0;


            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(fibonacci);
                numeroAnterior = numeroAtual;
                numeroAtual = fibonacci;
                fibonacci = numeroAnterior + numeroAtual;
            }

        }
    }
}
