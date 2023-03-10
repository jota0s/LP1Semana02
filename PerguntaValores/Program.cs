using System;



namespace PerguntaValores
{
    class Program
    {
        static void Main(string[] args)
        {   
            //read the input str and convert to float
            Console.WriteLine("enter value of (h)");
            float h =float.Parse(Console.ReadLine());

            //read the input str and convert to float
            Console.WriteLine("enter value of (r)");
            float r =float.Parse(Console.ReadLine());
            
            //create the variable Pi
            //double Pi = 3.1415926;

            //formula to calculate V
            //add Math.PI
            double V = Math.PI*r*r*h;
            Console.WriteLine(V);
            //formula to calculate Sa
            double S = 2*Math.PI*r*(h + r);
            Console.WriteLine(S);

            //add math,pow
            double t = Math.Pow(r,2);
            Console.WriteLine(t);
 




        }
    }
}
