using System;

namespace Exercicio_tabuada_17_11_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int resultado;

            Console.Write("Digite o número da tabuada desejada: ");
            numero = int.Parse(Console.ReadLine());
            Console.Clear();

            for(int x = 0; x <= 10; x++)
            {
                resultado = numero * x;
                Console.WriteLine($"{x} X {numero} = {resultado}");
            }

            Console.ReadLine();
        }
    }
}
