using System;

namespace PerfectCountdown
{
    public class Program
    {
        private static void Main(string[] args)
        {
           
            Console.Write("Start number: ");
            string a = Console.ReadLine();
            int start = int.Parse(a);
            Console.Write("Step number: ");
            string b = Console.ReadLine();
            int step = int.Parse(b);
            
            
            while (true)
            {

                
                if (step >= start)

                {
                    Console.Write("Star must be higher than Step");
                    break;
                }


                else if (start>1 || step >1  )

                {
                    continue;
                }

                
                else if (start < step)
                {
                    break;
                }          
                
                
            
                
            }


            
            Console.WriteLine($"Out-of-range start or step. try again");
           
        }
    }
}
