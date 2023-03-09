using System;

namespace ManipulaVar
{
    class Program
    {
        static void Main(string[] args)
        {
           //convert args to a int an print v + 1 
           int v= int.Parse(args[0]);
           v++;
           Console.WriteLine(v);
           
           ////convert args to a int an print x - 1 
           int x= int.Parse(args[0]);
           --x;
           Console.WriteLine(x);

           
           
        }
    }
}
