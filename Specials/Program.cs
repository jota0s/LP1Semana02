using System;

namespace Specials
{
    class Program
    {
        static void Main(string[] args)
        {
          int i = short.MaxValue;
          Console.WriteLine(i);
          Console.WriteLine((short)(i +1));

          float t=float.MaxValue;
          Console.WriteLine(t);
          Console.WriteLine((float)(i +1));

        }
    }
}
