using System;
using System.Globalization;
namespace Programa
{
    class Program
    {
        static void Main(string[] args)
        {
            {

                CultureInfo CI = CultureInfo.InvariantCulture;


                int x, y, soma;

                x = int.Parse(Console.ReadLine());
                y = int.Parse(Console.ReadLine());

                soma = x + y;

                Console.WriteLine(soma);
            }
        }
    }
}