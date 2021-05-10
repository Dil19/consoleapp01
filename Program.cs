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
            Console.WriteLine(string.Format("a: {0}, b: {1}", a, b));

            //prefix increment
            b = ++a;
            Console.WriteLine(string.Format("a: {0}, b: {1}", a, b));

        }
    }
}
