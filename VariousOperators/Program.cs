using System;

namespace VariousOperators
{
    public class Program
    {
        private static void Main(string[] args)
        {
            //ask for a number and save the input
            Console.Write("Insere um número inteiro-não negativo: ");
            string p = Console.ReadLine();
            int n = sbyte.Parse(p);

                             
            Console.WriteLine(n/2);
            Console.WriteLine(n <<3);
            Console.WriteLine(n <<3);
            Console.WriteLine(n ^6);
            Console.WriteLine(n >10);
            
        }
    }   
}