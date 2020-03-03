using System;

namespace error_handling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            try
            {
                int a = 0;
                int b = 4;
                int c;
                c = b / a;
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("Hello World!");
        }
    }
}
