using System;
using System.Globalization;

namespace teste
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite numeros de 0 a 9");
            int x = int.Parse(Console.ReadLine()!);
            int soma = 0;

       
            while (x != 0 ) {
                soma = soma + x;
                x = int.Parse(Console.ReadLine()!);
            }   
            Console.WriteLine("o valor de todo os numeros digitados é: " + soma);
            Console.ReadLine();
        }
    }
}
