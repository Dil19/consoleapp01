using System;

namespace ConsoleApp1HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //postfix increment
            int a = 1;
            int b = a++;
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);

            //prefix increment
            b = ++a;
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);

        }
    }
}
