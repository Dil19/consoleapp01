using System;

namespace ConsoleApp1HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            checked
            {
                byte num = 255; //largest byte

                num += 1;
                Console.WriteLine(num);
            }
        }
    }
}
