using System;

namespace PerguntaValores
{
    class Program
    {
        static void Main(string[] args)
        {   
            
            Console.WriteLine("enter value of (h)");
            float h =float.Parse(Console.ReadLine());

             Console.WriteLine("enter value of (r)");
            float r =float.Parse(Console.ReadLine());
            
            double Pi = 3.1415926;

           double V = Pi*r*r*h;
           Console.WriteLine(V);

           double S = 2*Pi*r*(h + r);
           Console.WriteLine(S);

 




        }
    }
}
