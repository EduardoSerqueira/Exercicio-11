using System;

namespace Exercicio_onze
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B;

            Console.WriteLine("Digite um valor: ");
            A = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite um valor: ");
            B = int.Parse(Console.ReadLine());

            if (A % B == 0 || B % A == 0)
            {
                Console.WriteLine("São multiplos");
            }
            else
            {
                Console.WriteLine("Não são multiplos");
            }
            Console.ReadKey();
        }
    }
}
