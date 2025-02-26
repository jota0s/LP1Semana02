using System;

namespace SmootOperator
{
    public class Program
    {
        private static void Main(string[] args)
        {   

            //ask for a number and save the input
            Console.Write("Insere um número inteiro: ");
            string p = Console.ReadLine();
            int n = sbyte.Parse(p);

            //print the input with increment and decrement 
            Console.WriteLine(--n);
            Console.WriteLine(++n);


        }
    }
}
