using System;
using System.Collections;
using System.Diagnostics;

namespace Cilindro
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("inserir a altura do cilindro: ");
            string altura = Console.ReadLine();
            float a = float.Parse(altura);

            Console.WriteLine("inserir o raio do cilindro: ");
            string raio = Console.ReadLine();
            float r = float.Parse(raio);

            double volume = Math.PI * Math.Pow(r,2) *a;
            Console.WriteLine(volume);

            double area = 2 * Math.PI * r *(r + a);
            Console.WriteLine(area);

        }
    }
}
