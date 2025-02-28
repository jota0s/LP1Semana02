using System;
using System.Linq.Expressions;

namespace ChatGPTOne
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string d;

            do

            {   
                Console.WriteLine("Ask a question? ");
                d = Console.ReadLine();

                
                if (d == "wha's your name?")
                
                    Console.WriteLine("my name is Pedro");

                else if (d == "where are you from?")  
                    Console.WriteLine ("I'm from Lisbon");

                else if (d == "how old are you?")
                    Console.WriteLine ("I'm 1700 years old");

                else if (d == "where do you live?")
                    Console.WriteLine("I live in Madeira");




            }

            while (d != "EXIT");    
        }
    }
}
